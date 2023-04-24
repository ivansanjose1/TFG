using System.Drawing.Text;

namespace SerializableYugi
{
    public class Fuente
    {
        static PrivateFontCollection pfc = new PrivateFontCollection();
        public static FontCollection FuenteYugi()
        {
            pfc.AddFontFile(System.AppDomain.CurrentDomain.BaseDirectory + "\\ygofont.ttf");
            return pfc;
        }
    }
}
