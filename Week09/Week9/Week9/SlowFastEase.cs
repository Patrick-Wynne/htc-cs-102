using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace Week9
{
    class SlowFastEase : IEasingFunction
    {
        public double Ease(double normalizedTime)
        {
            if(normalizedTime < 0.75)
            {
                return normalizedTime / 5;
            } else
            {
                return 3.4 * normalizedTime - 2.4;
            }
        }
    }
}
