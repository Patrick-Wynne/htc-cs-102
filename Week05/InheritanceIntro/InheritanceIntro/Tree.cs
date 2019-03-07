using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceIntro
{
    public class Tree : Organism
    {

        public int Height;

        public void Grow()
        {
            MessageBox.Show("+1 height");
            Height++;
        }

        public Tree() { }

        public Tree(string dna, int height)
        {
            Dna = dna;
            Height = height;
        }

    }
}
