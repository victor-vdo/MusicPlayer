using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WMPLib;

namespace MusicPlayer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        bool playState = true;
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        List<string> pathFiles = new List<string>();
     

        private void btnHome_MouseHover(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(104,104,104);
        }

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.Black;
        }

        private void btnSearch_MouseHover(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.FromArgb(104, 104, 104);
        }

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.Black;
        }

        private void btnLibrary_MouseHover(object sender, EventArgs e)
        {
            btnLibrary.BackColor = Color.FromArgb(104, 104, 104);
        }

        private void btnLibrary_MouseLeave(object sender, EventArgs e)
        {
            btnLibrary.BackColor = Color.Black;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
           try
            {
                if (playState)
                {
                    player.controls.play();
                    btnPlay.Text = "=";
                    playState = false;
                }

                else
                {
                    player.controls.pause();
                    btnPlay.Text = ">";
                    playState = true;
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($" Erro: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($" Erro: {ex.Message}");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            ofd1.Multiselect = true;
            ofd1.Title = "Select a Audio File";
            ofd1.InitialDirectory = @"C:\Users\victor\Desktop\";
            ofd1.Filter = "Audio Files (*.MP3;*.WAV;*.M4A,*.FLAC,*.WMA,*.AAC)|*.MP3;*.WAV;*.M4A,*.FLAC,*.WMA,*.AAC|" + "All files (*.*)|*.*";
            ofd1.CheckFileExists = true;
            ofd1.CheckPathExists = true;
            ofd1.FilterIndex = 2;
            ofd1.RestoreDirectory = true;
            ofd1.ReadOnlyChecked = true;
            ofd1.ShowReadOnly = true;

            DialogResult dr = ofd1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                pathFiles.AddRange(ofd1.FileNames);
                DataTable dt = new DataTable();
                dt.Columns.Add("Músicas", typeof(string));
                var values = ofd1.SafeFileNames.Select( x => new {Value = x }).ToList();

                IWMPMedia currMedia = player.currentMedia;
                IWMPPlaylist playlist = player.playlistCollection.newPlaylist("MusicPlayer");
                var playListName = playlist.name;

                foreach(var val in values.Select((x, i) => new { Index = i, Value = x }))
                {
                    var fileUrl = pathFiles.Where(p => p.Contains(val.Value.Value)).FirstOrDefault();
                    currMedia = player.newMedia(fileUrl);
                    playlist.appendItem(currMedia);
                    dt.Rows.Add(val.Value.Value);
                }
                player.currentPlaylist = playlist;  
                dgvNext.DataSource = dt;
                btnPlay.Text = "=";
                playState = false;

            }
        }

        private void dgvNext_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (playState)
                {
                    if(player.isOnline)
                        player.controls.stop();
                    btnPlay.Text = "=";
                    playState = false;
                    var fileName = dgvNext[e.ColumnIndex, e.RowIndex].Value.ToString();
                    var url = pathFiles.Where(f => f.Contains(fileName)).FirstOrDefault();
                    PlayFile(url);
                }

                else
                {
                    player.controls.stop();
                    btnPlay.Text = ">";
                    playState = true;
                }
            
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($" Erro: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($" Erro: {ex.Message}");
            }
        }

        private void PlayFile(String url)
        {
            player.PlayStateChange += Player_PlayStateChange;
            player.URL = url;
            player.controls.play();
        }

        private void Player_PlayStateChange(int NewState)
        {
            if ((WMPPlayState)NewState == WMPPlayState.wmppsStopped)
            {
                //Actions on stop
                player.controls.stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.controls.next();
            if (dgvNext.SelectedCells.Count > 0)
            {
                int id = dgvNext.SelectedCells[0].RowIndex;
                id++;
                dgvNext.ClearSelection();
                dgvNext.Rows[id].Selected = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.controls.previous();
            if (dgvNext.SelectedCells.Count > 0)
            {
                int id = dgvNext.SelectedCells[0].RowIndex;
                id--;
                dgvNext.ClearSelection();
                dgvNext.Rows[id].Selected = true;
            }
        }
    }
}
