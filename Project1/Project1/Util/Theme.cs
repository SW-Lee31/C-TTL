using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Util
{
    class Theme
    {
        public static void initTheme(MaterialForm form)
        {
            var skin = MaterialSkinManager.Instance;
            skin.AddFormToManage(form);
            skin.ColorScheme = new ColorScheme(
                Primary.DeepPurple50,
                Primary.DeepOrange100,
                Primary.DeepOrange100,
                Accent.Teal100,
                TextShade.WHITE);
        }
    }
}
