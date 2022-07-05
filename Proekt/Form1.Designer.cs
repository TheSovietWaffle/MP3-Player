namespace Proekt
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.About = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.toolsSubMenu = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.clearPlaylist = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.playlistButton = new System.Windows.Forms.Button();
            this.panelSubMenu = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.mediaSubMenu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.track_list = new System.Windows.Forms.ListBox();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.pictureArt = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.trackVolume = new System.Windows.Forms.TrackBar();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Pause = new System.Windows.Forms.PictureBox();
            this.songLenght = new System.Windows.Forms.Label();
            this.songCurrent = new System.Windows.Forms.Label();
            this.skipForward = new System.Windows.Forms.PictureBox();
            this.skipBack = new System.Windows.Forms.PictureBox();
            this.Play = new System.Windows.Forms.PictureBox();
            this.songProgress = new System.Windows.Forms.ProgressBar();
            this.panelPlayer = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.button13 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelSubMenu.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureArt)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skipForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skipBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.About);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.toolsSubMenu);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.playlistButton);
            this.panel1.Controls.Add(this.panelSubMenu);
            this.panel1.Controls.Add(this.mediaSubMenu);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 885);
            this.panel1.TabIndex = 0;
            // 
            // About
            // 
            this.About.Dock = System.Windows.Forms.DockStyle.Top;
            this.About.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.About.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.About.Location = new System.Drawing.Point(0, 700);
            this.About.Name = "About";
            this.About.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.About.Size = new System.Drawing.Size(200, 40);
            this.About.TabIndex = 8;
            this.About.Text = "About";
            this.About.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button12);
            this.panel5.Controls.Add(this.button11);
            this.panel5.Controls.Add(this.button10);
            this.panel5.Controls.Add(this.button9);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 540);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 160);
            this.panel5.TabIndex = 7;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.DarkGray;
            this.button12.Dock = System.Windows.Forms.DockStyle.Top;
            this.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(0, 120);
            this.button12.Name = "button12";
            this.button12.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button12.Size = new System.Drawing.Size(200, 40);
            this.button12.TabIndex = 4;
            this.button12.Text = "button12";
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.DarkGray;
            this.button11.Dock = System.Windows.Forms.DockStyle.Top;
            this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(0, 80);
            this.button11.Name = "button11";
            this.button11.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button11.Size = new System.Drawing.Size(200, 40);
            this.button11.TabIndex = 3;
            this.button11.Text = "button11";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.DarkGray;
            this.button10.Dock = System.Windows.Forms.DockStyle.Top;
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(0, 40);
            this.button10.Name = "button10";
            this.button10.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button10.Size = new System.Drawing.Size(200, 40);
            this.button10.TabIndex = 2;
            this.button10.Text = "button10";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.DarkGray;
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(0, 0);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button9.Size = new System.Drawing.Size(200, 40);
            this.button9.TabIndex = 1;
            this.button9.Text = "button9";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // toolsSubMenu
            // 
            this.toolsSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolsSubMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.toolsSubMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.toolsSubMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toolsSubMenu.Location = new System.Drawing.Point(0, 500);
            this.toolsSubMenu.Name = "toolsSubMenu";
            this.toolsSubMenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.toolsSubMenu.Size = new System.Drawing.Size(200, 40);
            this.toolsSubMenu.TabIndex = 6;
            this.toolsSubMenu.Text = "Tools";
            this.toolsSubMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolsSubMenu.UseVisualStyleBackColor = true;
            this.toolsSubMenu.Click += new System.EventHandler(this.toolsSubMenu_Click_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.clearPlaylist);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 340);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 160);
            this.panel3.TabIndex = 4;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DarkGray;
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(0, 120);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button8.Size = new System.Drawing.Size(200, 40);
            this.button8.TabIndex = 4;
            this.button8.Text = "Delete Playlist";
            this.button8.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DarkGray;
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(0, 80);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(200, 40);
            this.button7.TabIndex = 3;
            this.button7.Text = "Save Playlist";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // clearPlaylist
            // 
            this.clearPlaylist.BackColor = System.Drawing.Color.DarkGray;
            this.clearPlaylist.Dock = System.Windows.Forms.DockStyle.Top;
            this.clearPlaylist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.clearPlaylist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.clearPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearPlaylist.Location = new System.Drawing.Point(0, 40);
            this.clearPlaylist.Name = "clearPlaylist";
            this.clearPlaylist.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.clearPlaylist.Size = new System.Drawing.Size(200, 40);
            this.clearPlaylist.TabIndex = 2;
            this.clearPlaylist.Text = "Clear Playlist";
            this.clearPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearPlaylist.UseVisualStyleBackColor = false;
            this.clearPlaylist.Click += new System.EventHandler(this.clearPlaylist_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(200, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Song";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // playlistButton
            // 
            this.playlistButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.playlistButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.playlistButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.playlistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playlistButton.Location = new System.Drawing.Point(0, 300);
            this.playlistButton.Name = "playlistButton";
            this.playlistButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.playlistButton.Size = new System.Drawing.Size(200, 40);
            this.playlistButton.TabIndex = 3;
            this.playlistButton.Text = "Playlist";
            this.playlistButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.playlistButton.UseVisualStyleBackColor = true;
            this.playlistButton.Click += new System.EventHandler(this.playlistButton_Click);
            // 
            // panelSubMenu
            // 
            this.panelSubMenu.AutoScroll = true;
            this.panelSubMenu.BackColor = System.Drawing.Color.DarkGray;
            this.panelSubMenu.Controls.Add(this.button5);
            this.panelSubMenu.Controls.Add(this.button4);
            this.panelSubMenu.Controls.Add(this.button3);
            this.panelSubMenu.Controls.Add(this.button2);
            this.panelSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenu.Location = new System.Drawing.Point(0, 140);
            this.panelSubMenu.Name = "panelSubMenu";
            this.panelSubMenu.Size = new System.Drawing.Size(200, 160);
            this.panelSubMenu.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(0, 120);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(200, 40);
            this.button5.TabIndex = 3;
            this.button5.Text = "button5";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(0, 80);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(200, 40);
            this.button4.TabIndex = 2;
            this.button4.Text = "button4";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(0, 40);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(200, 40);
            this.button3.TabIndex = 1;
            this.button3.Text = "button3";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(200, 40);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mediaSubMenu
            // 
            this.mediaSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.mediaSubMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.mediaSubMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.mediaSubMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mediaSubMenu.Location = new System.Drawing.Point(0, 100);
            this.mediaSubMenu.Name = "mediaSubMenu";
            this.mediaSubMenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.mediaSubMenu.Size = new System.Drawing.Size(200, 40);
            this.mediaSubMenu.TabIndex = 1;
            this.mediaSubMenu.Text = "Media";
            this.mediaSubMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mediaSubMenu.UseVisualStyleBackColor = true;
            this.mediaSubMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 0;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChildForm.AutoScroll = true;
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panelChildForm.Controls.Add(this.track_list);
            this.panelChildForm.Controls.Add(this.button15);
            this.panelChildForm.Controls.Add(this.button14);
            this.panelChildForm.Controls.Add(this.pictureArt);
            this.panelChildForm.Location = new System.Drawing.Point(200, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(994, 713);
            this.panelChildForm.TabIndex = 3;
            
            // 
            // track_list
            // 
            this.track_list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.track_list.BackColor = System.Drawing.Color.DarkGray;
            this.track_list.FormattingEnabled = true;
            this.track_list.ItemHeight = 16;
            this.track_list.Location = new System.Drawing.Point(783, 136);
            this.track_list.Name = "track_list";
            this.track_list.Size = new System.Drawing.Size(208, 484);
            this.track_list.TabIndex = 8;
            this.track_list.SelectedIndexChanged += new System.EventHandler(this.track_list_SelectedIndexChanged);
            // 
            // button15
            // 
            this.button15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Location = new System.Drawing.Point(844, 0);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 7;
            this.button15.Text = "一";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button14
            // 
            this.button14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Location = new System.Drawing.Point(916, 0);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 6;
            this.button14.Text = "何";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // pictureArt
            // 
            this.pictureArt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureArt.Image = ((System.Drawing.Image)(resources.GetObject("pictureArt.Image")));
            this.pictureArt.Location = new System.Drawing.Point(125, 108);
            this.pictureArt.Name = "pictureArt";
            this.pictureArt.Size = new System.Drawing.Size(512, 512);
            this.pictureArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureArt.TabIndex = 0;
            this.pictureArt.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel6.Controls.Add(this.volumeLabel);
            this.panel6.Controls.Add(this.trackVolume);
            this.panel6.Controls.Add(this.panel4);
            this.panel6.Controls.Add(this.songProgress);
            this.panel6.Controls.Add(this.panelPlayer);
            this.panel6.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(200, 731);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1053, 154);
            this.panel6.TabIndex = 4;
            
            // 
            // volumeLabel
            // 
            this.volumeLabel.AutoSize = true;
            this.volumeLabel.Location = new System.Drawing.Point(966, 101);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(36, 17);
            this.volumeLabel.TabIndex = 9;
            this.volumeLabel.Text = "40%";
            // 
            // trackVolume
            // 
            this.trackVolume.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trackVolume.LargeChange = 1;
            this.trackVolume.Location = new System.Drawing.Point(921, 55);
            this.trackVolume.Maximum = 50;
            this.trackVolume.MaximumSize = new System.Drawing.Size(129, 45);
            this.trackVolume.MinimumSize = new System.Drawing.Size(129, 45);
            this.trackVolume.Name = "trackVolume";
            this.trackVolume.Size = new System.Drawing.Size(129, 45);
            this.trackVolume.TabIndex = 3;
            this.trackVolume.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackVolume.Scroll += new System.EventHandler(this.trackVolume_Scroll);
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel4.Controls.Add(this.Pause);
            this.panel4.Controls.Add(this.songLenght);
            this.panel4.Controls.Add(this.songCurrent);
            this.panel4.Controls.Add(this.skipForward);
            this.panel4.Controls.Add(this.skipBack);
            this.panel4.Controls.Add(this.Play);
            this.panel4.Location = new System.Drawing.Point(119, 34);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 84);
            this.panel4.TabIndex = 7;
            // 
            // Pause
            // 
            this.Pause.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Pause.Image = global::Proekt.Properties.Resources.Pause;
            this.Pause.Location = new System.Drawing.Point(377, 21);
            this.Pause.MaximumSize = new System.Drawing.Size(60, 60);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(60, 60);
            this.Pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pause.TabIndex = 10;
            this.Pause.TabStop = false;
            this.Pause.Click += new System.EventHandler(this.Pause_Click_1);
            // 
            // songLenght
            // 
            this.songLenght.AutoSize = true;
            this.songLenght.Location = new System.Drawing.Point(751, 64);
            this.songLenght.Name = "songLenght";
            this.songLenght.Size = new System.Drawing.Size(44, 17);
            this.songLenght.TabIndex = 9;
            this.songLenght.Text = "00:00";
            // 
            // songCurrent
            // 
            this.songCurrent.AutoSize = true;
            this.songCurrent.Location = new System.Drawing.Point(3, 64);
            this.songCurrent.Name = "songCurrent";
            this.songCurrent.Size = new System.Drawing.Size(44, 17);
            this.songCurrent.TabIndex = 8;
            this.songCurrent.Text = "00:00";
            
            // 
            // skipForward
            // 
            this.skipForward.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.skipForward.Image = global::Proekt.Properties.Resources.SkipForward;
            this.skipForward.Location = new System.Drawing.Point(443, 36);
            this.skipForward.Name = "skipForward";
            this.skipForward.Size = new System.Drawing.Size(45, 45);
            this.skipForward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.skipForward.TabIndex = 2;
            this.skipForward.TabStop = false;
            this.skipForward.Click += new System.EventHandler(this.skipForward_Click);
            // 
            // skipBack
            // 
            this.skipBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.skipBack.Image = global::Proekt.Properties.Resources.SkipBack;
            this.skipBack.Location = new System.Drawing.Point(326, 36);
            this.skipBack.Name = "skipBack";
            this.skipBack.Size = new System.Drawing.Size(45, 45);
            this.skipBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.skipBack.TabIndex = 1;
            this.skipBack.TabStop = false;
            this.skipBack.Click += new System.EventHandler(this.skipBack_Click);
            // 
            // Play
            // 
            this.Play.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Play.Image = global::Proekt.Properties.Resources.Play;
            this.Play.Location = new System.Drawing.Point(377, 21);
            this.Play.MaximumSize = new System.Drawing.Size(60, 60);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(60, 60);
            this.Play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Play.TabIndex = 0;
            this.Play.TabStop = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // songProgress
            // 
            this.songProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.songProgress.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.songProgress.Location = new System.Drawing.Point(119, 132);
            this.songProgress.Name = "songProgress";
            this.songProgress.Size = new System.Drawing.Size(800, 10);
            this.songProgress.TabIndex = 6;
            this.songProgress.MouseDown += new System.Windows.Forms.MouseEventHandler(this.songProgress_MouseDown);
            // 
            // panelPlayer
            // 
            this.panelPlayer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelPlayer.AutoScroll = true;
            this.panelPlayer.AutoSize = true;
            this.panelPlayer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelPlayer.Location = new System.Drawing.Point(93, 154);
            this.panelPlayer.Name = "panelPlayer";
            this.panelPlayer.Size = new System.Drawing.Size(0, 0);
            this.panelPlayer.TabIndex = 5;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(195, 5);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 8;
            
            // 
            // button13
            // 
            this.button13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Location = new System.Drawing.Point(1178, 0);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 5;
            this.button13.Text = "X";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1253, 885);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(970, 722);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelSubMenu.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureArt)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skipForward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skipBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelSubMenu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button mediaSubMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button toolsSubMenu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button clearPlaylist;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button playlistButton;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panelPlayer;
        private System.Windows.Forms.PictureBox pictureArt;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.ProgressBar songProgress;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox skipBack;
        private System.Windows.Forms.PictureBox Play;
        private System.Windows.Forms.PictureBox skipForward;
        private System.Windows.Forms.TrackBar trackVolume;
        private System.Windows.Forms.Label songLenght;
        private System.Windows.Forms.Label songCurrent;
        public AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ListBox track_list;
        private System.Windows.Forms.PictureBox Pause;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label volumeLabel;
    }
}

