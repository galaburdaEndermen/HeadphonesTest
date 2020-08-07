using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
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

            SoundPlayer simpleSound = new SoundPlayer(@"pack://application:,,,/Sounds\6.wav");
            simpleSound.Play();
        }
    }
}
