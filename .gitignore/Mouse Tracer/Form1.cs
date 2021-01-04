using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace MouseTracer
{
    public partial class frmMain : Form
    {
        private Graphics _Graphic;
        private Bitmap _Image;

        public frmMain()
        {
            InitializeComponent();
            timer1.Start();

            _Image = new Bitmap(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            _Graphic = Graphics.FromImage(_Image);
            _Graphic.FillRectangle(Brushes.White, 0, 0, _Image.Width, _Image.Height);

            pictureBox1.Image = _Image;

            MouseHook.Start();
            MouseHook.LeftClick += MouseHook_LeftClick;
            MouseHook.ReightClick += MouseHook_ReightClick;
            MouseHook.MouseWheel += MouseHook_MouseWheel;
        }

        private void btnSavePicture_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Images|*.jpg";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.Image.Save(sfd.FileName, ImageFormat.Jpeg);
            }
        }

        private void MouseHook_LeftClick(object sender, EventArgs e)
        {
            _Graphic.DrawEllipse(new Pen(Color.Red, 4), new Rectangle(MousePosition.X, MousePosition.Y, 4, 4));
        }

        private void MouseHook_MouseWheel(object sender, EventArgs e)
        {
            _Graphic.DrawEllipse(new Pen(Color.Blue, 4), new Rectangle(MousePosition.X, MousePosition.Y, 4, 4));
        }

        private void MouseHook_ReightClick(object sender, EventArgs e)
        {
            _Graphic.DrawEllipse(new Pen(Color.Green, 4), new Rectangle(MousePosition.X, MousePosition.Y, 4, 4));
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Type s = MouseButtons.GetUnderlyingType(MouseButtons.GetType());

            if (MouseButtons.HasFlag(MouseButtons.None))
            {
                _Graphic.DrawEllipse(new Pen(Color.Black, 1), new Rectangle(MousePosition.X, MousePosition.Y, 1, 1));
            }

            pictureBox1.Image = _Image;
            pictureBox1.Update();
        }
    }
}
