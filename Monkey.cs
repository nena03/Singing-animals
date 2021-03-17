using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Singing_animals
{
    class Monkey: Animal
    {
        public Monkey(int x, int y, Image img) : base(x, y, img)
        { }
        public override void Crtaj(Graphics g)
        {
            g.DrawImage(img, x, y);
        }
      

        public override void Igraj(int brzina, System.Windows.Forms.Timer timer)
        {
            if (y >= 600)
            {
                Start();
                

                

                
            }
            else
                y += brzina;
        }

        public override void Start()
        {  
            x = 400; y = 10;
            img = Image.FromFile("monkey.png");
        }
    }
}
