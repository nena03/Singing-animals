using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Singing_animals
{
     abstract class Animal
    {
        protected int x, y;
        protected Image img;

        protected Animal(int x, int y, Image img)
        {
            this.x = x;
            this.y = y;
            this.img = img;
        }

        
        public abstract void Crtaj(Graphics g);
        public abstract void Igraj(int brzina, System.Windows.Forms.Timer timer);

        public abstract void Start();

        
    }
}
