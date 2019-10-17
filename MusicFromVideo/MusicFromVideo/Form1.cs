using System;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using NReco.VideoConverter;

namespace MusicFromVideo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "MP4 files(*.mp4)|*.mp4|(*.mpg)|*.mpg|(*.mpeg)|*.mpeg|(*.amv)|*.amv|(*.mov)|*.mov";
            saveFileDialog1.Filter = "Music files(*.mp3)|*.mp3|(*.3gp)|*.3gp|(*.aa)|*.aa|(*.aac)|*.aac|(*.aax)|*.aax|(*.act)|*.act|(*.aiff)|*.aiff|(*.alac)|*.alac|(*.amr)|*.amr|(*.ape)|*.ape|(*.au)|*.au|(*.awb)|*.awb|(*.dct)|*.dct|(*.dss)|*.dss|(*.flac)|*.flac|(*.gsm)|*.gsm|(*.m4a)|*.m4a|(*.m4b)|*.m4b|(*.m4p)|*.m4p|(*.mpc)|*.mpc|(*.nsf)|*.nsf|(*.ogg)|*.ogg|(*.oga)|*.oga|(*.mog)|*.mog|(*.opus)|*.opus|(*.ra)|*.ra|(*.rm)|*.rm|(*.raw)|*.raw|(*.sln)|*.sln|(*.tta)|*.tta|(*.voc)|*.voc|(*.vox)|*.vox|(*.wav)|*.wav|(*.wma)|*.wma|(*.wv)|*.wv|(*.webm)|*.webm|(*.8svx)|*.8svx";
        }

        private void openMP4_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK & !string.IsNullOrWhiteSpace(openFileDialog1.FileName))
                mp4FilePath.Text = openFileDialog1.FileName;
        }

        private void saveMP3_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK & !string.IsNullOrWhiteSpace(saveFileDialog1.FileName))
                mp3FilePath.Text = saveFileDialog1.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread myThread = new Thread(new ThreadStart(ConvertMP4File));
            myThread.Start();
            button1.Enabled = false;
        }

        public void ConvertMP4File()
        {
            var ffMpeg = new NReco.VideoConverter.FFMpegConverter();
            string[] extention = Path.GetExtension(mp3FilePath.Text).Split('.');
            ffMpeg.ConvertMedia(mp4FilePath.Text, mp3FilePath.Text, extention[1]);
            MessageBox.Show("Well done!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mp4FilePath_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(mp3FilePath.Text))
                if (!string.IsNullOrEmpty(mp4FilePath.Text))
                    button1.Enabled = true;
        }

        private void mp3FilePath_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(mp4FilePath.Text))
                if (!string.IsNullOrEmpty(mp3FilePath.Text))
                    button1.Enabled = true;
        }
    }
}
