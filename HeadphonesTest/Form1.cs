using System;
using System.IO;
using System.Media;
using System.Reflection;
using System.Windows.Forms;

namespace HeadphonesTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Stream stream;

        private void button1_Click(object sender, EventArgs e)
        {

            SoundPlayer simpleSound = new SoundPlayer(stream);
            simpleSound.Play();
            stream.Position = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("HeadphonesTest.Sounds.6.wav");
            if (stream == null)
            {
                MessageBox.Show("Error!");
            }
        }
    }
}
