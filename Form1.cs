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

namespace Singing_animals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        System.Media.SoundPlayer player = new System.Media.SoundPlayer(); 
        Random r = new Random();

        Animal[] a = new Animal[2];
        

        private void Form1_Load(object sender, EventArgs e)
        {
            Image pandaimg = Image.FromFile(@"C:\Users\Pc\source\repos\Singing animals\Singing animals\panda.jpg");
            Image monkeyimg = Image.FromFile(@"C:\Users\Pc\source\repos\Singing animals\Singing animals\monkey.png");
            Width = 1000;
            Height = 1000;
            
            a[0] = new Panda(100, 5, pandaimg);
            a[1] = new Monkey(400, 5, monkeyimg);
            timer.Start();
            player.SoundLocation = @"C:\Users\Pc\source\repos\Singing animals\Singing animals\bin\Debug\muzika.wav";
           

        }
       

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < 2; i++) a[i].Crtaj(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            a[0].Igraj(r.Next(10, 20),timer);
            a[1].Igraj(r.Next(10, 40),timer);


            Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.Play();
        }
    }
}
