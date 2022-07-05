using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Proekt
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            customizeDesign();
            axWindowsMediaPlayer1.Visible = false;
            trackVolume.Value = 20;



        }

        public string[] paths, files;
        private const int cGrip = 16;      // Grip size
        private const int cCaption = 32;   // Caption bar height;
        public double songCurrentSec;
        public double songCurrentMin;
        public double songTotalSec;

        protected override void OnPaint(PaintEventArgs e)
        {
            Brush bruh = new SolidBrush(Color.FromArgb(80, 80, 80));
            Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
            rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);
            e.Graphics.FillRectangle(bruh, rc);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;  // HTCAPTION
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }



        private void customizeDesign()
        {
            panelSubMenu.Visible = false;
            panel5.Visible = false;
            panel3.Visible = false;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.ControlBox = false;
            this.Text = "";
            Pause.Visible = false;

        }


        private void hideSubMenu()
        {
            if (panelSubMenu.Visible = true)
                panelSubMenu.Visible = false;
            if (panel5.Visible = true)
                panel5.Visible = false;
            if (panel3.Visible = true)
                panel3.Visible = false;
        }

        private void showSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubMenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private Form activeForm = null;



        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenu);
        }



        private void button10_Click(object sender, EventArgs e)
        {
            showSubMenu(panel5);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void playlistSubMenu_Click(object sender, EventArgs e)
        {
            showSubMenu(panel5);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            showSubMenu(panel5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            showSubMenu(panel5);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            showSubMenu(panel5);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            showSubMenu(panel3);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            showSubMenu(panel3);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            showSubMenu(panel3);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            showSubMenu(panel3);
        }

        private void toolsSubMenu_Click(object sender, EventArgs e)
        {
            showSubMenu(panel3);
        }

        private void playlistButton_Click(object sender, EventArgs e)
        {
            showSubMenu(panel3);
        }

        private void toolsSubMenu_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panel5);
        }

        private void About_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new Form2());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.FileNames;
                paths = ofd.FileNames;
                for (int x = 0; x < files.Length; x++)
                {
                    track_list.Items.Add(files[x]);
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

            UpgradeFullscreen();

        }
        private System.Drawing.Size oldsize = new System.Drawing.Size(300, 300);
        private System.Drawing.Point oldlocation = new System.Drawing.Point(0, 0);
        private System.Windows.Forms.FormWindowState oldstate = System.Windows.Forms.FormWindowState.Normal;
        private System.Windows.Forms.FormBorderStyle oldstyle = System.Windows.Forms.FormBorderStyle.Sizable;
        private bool fullscreen = false;

        private void UpgradeFullscreen()
        {
            if (!fullscreen)
            {
                oldsize = this.Size;
                oldstate = this.WindowState;
                oldstyle = this.FormBorderStyle;
                oldlocation = this.Location;
                this.WindowState = System.Windows.Forms.FormWindowState.Normal;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Bounds = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
                fullscreen = true;
            }
            else
            {
                this.Location = oldlocation;
                this.WindowState = oldstate;
                this.FormBorderStyle = oldstyle;
                this.Size = oldsize;
                fullscreen = false;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
           this.WindowState = FormWindowState.Minimized;
        }

        private void track_list_SelectedIndexChanged(object sender, EventArgs e, AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1)
        {
            axWindowsMediaPlayer1.URL = paths[track_list.SelectedIndex];
            axWindowsMediaPlayer1.Ctlcontrols.play();
            try
            {
                var file = TagLib.File.Create(paths[track_list.SelectedIndex]);
                var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                pictureArt.Image = Image.FromStream(new MemoryStream(bin));
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void track_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = paths[track_list.SelectedIndex];
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void Play_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
            Play.Hide();
            Pause.Show();
        }
        private void Pause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            Pause.Hide();
            Play.Show();
        }

        private void Pause_Click_1(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            Pause.Hide();
            Play.Show();
        }

        private void skipForward_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.next();
            track_list.SelectedIndex = track_list.SelectedIndex + 1;
        }

        private void skipBack_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.previous();
            track_list.SelectedIndex = track_list.SelectedIndex - 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {

                Play.Visible = false;
                Pause.Visible = true;
                songProgress.Maximum = (int)axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration;
                songProgress.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
                Math.Round(songCurrentSec, 1);

                try
                {

                    songCurrentSec = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentPosition);
                    //songCurrentSec.Round
                    songCurrentMin = songCurrentSec % 60;
                    songCurrent.Text = $"{Math.Round(songCurrentSec / 60)} : {songCurrentMin % 60}";
                }
                catch (Exception)
                {

                    throw;
                }
            }

        }

        private void songProgress_MouseDown(object sender, MouseEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = axWindowsMediaPlayer1.currentMedia.duration * e.X / songProgress.Width;
        }

        private void clearPlaylist_Click(object sender, EventArgs e)
        {
            track_list.Items.Clear();

        }

        private void trackVolume_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = trackVolume.Value;
            volumeLabel.Text = (trackVolume.Value * 2).ToString() + "%";

        }

    }
}
