using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManager0811.Util
{
    class CommonUtil
    {
        public static void serRowColor(ListView lst, Color bcolor1, Color bcolor2)
        {
            foreach (ListViewItem item in lst.Items)
            {
                if ((item.Index % 2) == 0)
                {
                    item.BackColor = bcolor1;
                }
                else
                {
                    item.BackColor = bcolor2;
                }
            }
        }

        static void bodydraw(object sender, DrawListViewItemEventArgs args)
        {
            args.DrawDefault = true;
        }

        static void headerdraw(object sender, DrawListViewColumnHeaderEventArgs arg, Color backcolor, Color forecolor)
        {
            using(SolidBrush backbrush = new SolidBrush(backcolor))
            {
                arg.Graphics.FillRectangle(backbrush, arg.Bounds);
            }

            using(SolidBrush forebrush = new SolidBrush(forecolor))
            {
                arg.Graphics.DrawString(arg.Header.Text, arg.Font, forebrush, arg.Bounds);
            }
        }

        public static void colorListHeader(ListView lst, Color backcolor, Color forecolor)
        {
            lst.OwnerDraw = true;
            lst.DrawColumnHeader += new DrawListViewColumnHeaderEventHandler
                (
                    (sender, e) => headerdraw(sender, e, backcolor, forecolor)
                );
            lst.DrawItem += new DrawListViewItemEventHandler(bodydraw);
        }
    }
}
