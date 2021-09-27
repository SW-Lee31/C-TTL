using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManager0827
{
    class DoubleBufferPanel : Panel
    {
        public DoubleBufferPanel()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint, true);
            UpdateStyles();
        }
    }
}
