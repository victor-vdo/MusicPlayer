
namespace MusicPlayer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnLibrary = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnConfiguration = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvNext = new System.Windows.Forms.DataGridView();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.flpCenter = new System.Windows.Forms.FlowLayoutPanel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNext)).BeginInit();
            this.pnlCenter.SuspendLayout();
            this.flpCenter.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Black;
            this.pnlMenu.Controls.Add(this.btnLibrary);
            this.pnlMenu.Controls.Add(this.btnSearch);
            this.pnlMenu.Controls.Add(this.btnHome);
            this.pnlMenu.Controls.Add(this.btnConfiguration);
            this.pnlMenu.Controls.Add(this.label1);
            this.pnlMenu.Controls.Add(this.dgvNext);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(233, 564);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnLibrary
            // 
            this.btnLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibrary.ForeColor = System.Drawing.Color.White;
            this.btnLibrary.Location = new System.Drawing.Point(12, 123);
            this.btnLibrary.Name = "btnLibrary";
            this.btnLibrary.Size = new System.Drawing.Size(140, 30);
            this.btnLibrary.TabIndex = 11;
            this.btnLibrary.Text = "Your Library";
            this.btnLibrary.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(12, 87);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(140, 30);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(12, 51);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(140, 30);
            this.btnHome.TabIndex = 9;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // btnConfiguration
            // 
            this.btnConfiguration.FlatAppearance.BorderSize = 0;
            this.btnConfiguration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguration.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfiguration.ForeColor = System.Drawing.Color.White;
            this.btnConfiguration.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfiguration.Location = new System.Drawing.Point(12, 12);
            this.btnConfiguration.Name = "btnConfiguration";
            this.btnConfiguration.Size = new System.Drawing.Size(49, 33);
            this.btnConfiguration.TabIndex = 3;
            this.btnConfiguration.Text = "...";
            this.btnConfiguration.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnConfiguration.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnConfiguration.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Next songs:";
            // 
            // dgvNext
            // 
            this.dgvNext.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNext.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvNext.Location = new System.Drawing.Point(12, 228);
            this.dgvNext.Name = "dgvNext";
            this.dgvNext.RowTemplate.Height = 25;
            this.dgvNext.Size = new System.Drawing.Size(215, 324);
            this.dgvNext.TabIndex = 5;
            this.dgvNext.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNext_CellContentClick);
            this.dgvNext.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNext_CellContentDoubleClick);
            // 
            // pnlCenter
            // 
            this.pnlCenter.AutoScroll = true;
            this.pnlCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.pnlCenter.Controls.Add(this.flpCenter);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(233, 0);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(674, 522);
            this.pnlCenter.TabIndex = 1;
            // 
            // flpCenter
            // 
            this.flpCenter.AutoScroll = true;
            this.flpCenter.Controls.Add(this.panel19);
            this.flpCenter.Controls.Add(this.flowLayoutPanel2);
            this.flpCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpCenter.Location = new System.Drawing.Point(0, 0);
            this.flpCenter.Name = "flpCenter";
            this.flpCenter.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.flpCenter.Size = new System.Drawing.Size(674, 522);
            this.flpCenter.TabIndex = 0;
            // 
            // panel19
            // 
            this.panel19.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel19.BackColor = System.Drawing.Color.Red;
            this.panel19.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel19.Location = new System.Drawing.Point(23, 3);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(617, 300);
            this.panel19.TabIndex = 21;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.panel14);
            this.flowLayoutPanel2.Controls.Add(this.panel15);
            this.flowLayoutPanel2.Controls.Add(this.panel16);
            this.flowLayoutPanel2.Controls.Add(this.panel17);
            this.flowLayoutPanel2.Controls.Add(this.panel18);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(23, 309);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(617, 201);
            this.flowLayoutPanel2.TabIndex = 24;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
            this.panel14.Location = new System.Drawing.Point(3, 38);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(150, 160);
            this.panel14.TabIndex = 12;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
            this.panel15.Location = new System.Drawing.Point(159, 38);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(150, 160);
            this.panel15.TabIndex = 13;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
            this.panel16.Location = new System.Drawing.Point(315, 38);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(150, 160);
            this.panel16.TabIndex = 14;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
            this.panel17.Location = new System.Drawing.Point(471, 38);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(150, 160);
            this.panel17.TabIndex = 15;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
            this.panel18.Location = new System.Drawing.Point(627, 38);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(150, 160);
            this.panel18.TabIndex = 16;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Controls.Add(this.panel7);
            this.flowLayoutPanel1.Controls.Add(this.panel8);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(783, -3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(617, 201);
            this.flowLayoutPanel1.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
            this.panel2.Location = new System.Drawing.Point(3, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 160);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
            this.panel3.Location = new System.Drawing.Point(159, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 160);
            this.panel3.TabIndex = 13;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
            this.panel6.Location = new System.Drawing.Point(315, 38);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(150, 160);
            this.panel6.TabIndex = 14;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
            this.panel7.Location = new System.Drawing.Point(471, 38);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(150, 160);
            this.panel7.TabIndex = 15;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
            this.panel8.Location = new System.Drawing.Point(627, 38);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(150, 160);
            this.panel8.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
            this.panel1.Location = new System.Drawing.Point(149, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 160);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
            this.panel4.Location = new System.Drawing.Point(295, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(140, 160);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
            this.panel5.Location = new System.Drawing.Point(441, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(140, 160);
            this.panel5.TabIndex = 3;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.button2);
            this.pnlBottom.Controls.Add(this.button1);
            this.pnlBottom.Controls.Add(this.btnPlay);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(233, 522);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(674, 42);
            this.pnlBottom.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(241, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "<<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.AutoSize = true;
            this.btnPlay.Location = new System.Drawing.Point(296, 7);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(49, 25);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = ">";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(907, 564);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlMenu);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Music Player";
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNext)).EndInit();
            this.pnlCenter.ResumeLayout(false);
            this.flpCenter.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.FlowLayoutPanel flpCenter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridView gvN;
        private System.Windows.Forms.DataGridView e;
        private System.Windows.Forms.Button btnLibrary;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnConfiguration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvNext;
    }
}

