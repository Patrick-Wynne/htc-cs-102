using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceIntro
{
    class Cow : Animal
    {

        public string Color;

        public void Moo()
        {
            MessageBox.Show("Moo");
        }

        public Cow() { }

        public Cow(int height, string name, string color)
        {
            Height = height;
            Name = name;
            Color = color;
        }
        
    }
}
