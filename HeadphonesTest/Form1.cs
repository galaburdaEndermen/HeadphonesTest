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

        private void button1_Click(object sender, EventArgs e)
        {
            //SystemSounds.Question.Play();

            //SoundPlayer simpleSound = new SoundPlayer(@"Sounds\6.wav");
            //simpleSound.Play();

            Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("HeadphonesTest.Sounds.6.wav");
            FileStream fileStream = new FileStream("sound.wav", FileMode.OpenOrCreate);
            for (int i = 0; i < stream.Length; i++)
                fileStream.WriteByte((byte)stream.ReadByte());
            fileStream.Close();
        }
    }
}
