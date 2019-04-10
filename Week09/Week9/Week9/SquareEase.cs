using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace Week9
{
    class SquareEase : IEasingFunction
    {
        public double Ease(double normalizedTime)
        {
            return normalizedTime * 2;
        }
    }
}
