using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faq_DLL
{
    public class GlobalVariableFaq
    {
        private static Color gPrincipalColor = Color.FromArgb(13, 34, 61);

        public static Color principalColor
        {
            get { return gPrincipalColor; }
            set { gPrincipalColor = value; }
        }

        private static Color gSecondaryColor = Color.FromArgb(22, 54, 95);

        public static Color SecondaryColor
        {
            get { return gSecondaryColor; }
            set { gSecondaryColor = value; }
        }

        private static Color gtertiaryColor = Color.FromArgb(45, 45, 60);

        public static Color tertiaryColor
        {
            get { return gtertiaryColor; }
            set { gtertiaryColor = value; }
        }

        private static Color gFontColor = Color.FromArgb(255, 255, 255);

        public static Color fontColor
        {
            get { return gFontColor; }
            set { gFontColor = value; }
        }

        private static string gFontStyle = "Microsoft Sans Serif";

        public static string fontStyle
        {
            get { return gFontStyle; }
            set { gFontStyle = value; }
        }

        public static Boolean glightTheme = false;

        public static Boolean lightTheme
        {
            get { return glightTheme; }
            set { glightTheme = value; }
        }
    }
}
