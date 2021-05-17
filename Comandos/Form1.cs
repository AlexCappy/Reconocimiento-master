using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using Comandos.Properties;
using System.Threading.Tasks;

namespace Comandos
{
    public partial class Form1 : Form
    {
        private SpeechRecognitionEngine escucha = new SpeechRecognitionEngine();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                escucha.SetInputToDefaultAudioDevice();
                escucha.LoadGrammar(new DictationGrammar());
                escucha.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(lector);
                escucha.RecognizeAsync(RecognizeMode.Multiple);

            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("No se puede abrir mas de una vez");
            }
        }

        public async void lector(object sender, SpeechRecognizedEventArgs e)
        {
            foreach (RecognizedWordUnit palabra in e.Result.Words)
            {
                label2.Text = palabra.Text;

                if (palabra.Text == "arriba")
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X - 10, pictureBox1.Location.Y);
                    pictureBox1.Image = Resources.pikachu3;
                    await Task.Delay(500);
                    pictureBox1.Image = Resources.pikachu4;
                    pictureBox1.Location = new Point(pictureBox1.Location.X - 10, pictureBox1.Location.Y);
                    await Task.Delay(500);
                }
                else if (palabra.Text == "abajo")
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X + 10, pictureBox1.Location.Y);
                    pictureBox1.Image = Resources.pikachu3;
                    await Task.Delay(500);
                    pictureBox1.Image = Resources.pikachu4;
                    pictureBox1.Location = new Point(pictureBox1.Location.X + 10, pictureBox1.Location.Y);
                    await Task.Delay(500);
                   
                }
                else if (palabra.Text == "izquierda")
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y-10);
                    pictureBox1.Image = Resources.pikachu3;
                    await Task.Delay(500);
                    pictureBox1.Image = Resources.pikachu4;
                    pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y-10);
                    await Task.Delay(500);
                }         
                else if (palabra.Text == "derecha")
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 10);
                    pictureBox1.Image = Resources.pikachu3;
                    await Task.Delay(500);
                    pictureBox1.Image = Resources.pikachu4;
                    pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 10);
                    await Task.Delay(500);
                }
                else if (palabra.Text == "salta")
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 60);
                    pictureBox1.Image = Resources.pikachu3;
                    await Task.Delay(500);
                    
                    pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 60);
                    
                }
                else if (palabra.Text == "sentado")
                {
                    
                    pictureBox1.Image = Resources.pikachu1;
                   
                }
            }
        }

        private async void button1_Click_1(object sender, EventArgs e)
        {

            



        }

        private  void button2_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
