using System;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace SerializableYugi
{
    public class Fuente
    {
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr fuente, uint cbfont, IntPtr pdv, [In] ref uint pcFonts);
        static FontFamily ff;
        static FontFamily ff2;
        static FontFamily ff3;
        public static void CargarFuente()
        {
            byte[] arrayfuente = Properties.Resources.StoneSerifSemibold;
            byte[] arrayfuente2 = Properties.Resources.Yu_Gi_Oh__Matrix_Regular_Small_Caps_2;
            byte[] arrayfuente3 = Properties.Resources.Yu_Gi_Oh__Matrix_Book;
            int datalenght = Properties.Resources.StoneSerifSemibold.Length;
            int datalenght2 = Properties.Resources.Yu_Gi_Oh__Matrix_Regular_Small_Caps_2.Length;
            int datalenght3 = Properties.Resources.Yu_Gi_Oh__Matrix_Book.Length;
            IntPtr pointer = Marshal.AllocCoTaskMem(datalenght);
            IntPtr pointer2 = Marshal.AllocCoTaskMem(datalenght2);
            IntPtr pointer3 = Marshal.AllocCoTaskMem(datalenght3);
            Marshal.Copy(arrayfuente, 0, pointer, datalenght);
            Marshal.Copy(arrayfuente2, 0, pointer2, datalenght2);
            Marshal.Copy(arrayfuente3, 0, pointer3, datalenght3);
            uint cFonts = 0;
            AddFontMemResourceEx(pointer, (uint)arrayfuente.Length, IntPtr.Zero, ref cFonts);
            AddFontMemResourceEx(pointer2, (uint)arrayfuente2.Length, IntPtr.Zero, ref cFonts);
            AddFontMemResourceEx(pointer3, (uint)arrayfuente3.Length, IntPtr.Zero, ref cFonts);
            PrivateFontCollection privateFontCollection = new PrivateFontCollection();
            privateFontCollection.AddMemoryFont(pointer, datalenght);
            privateFontCollection.AddMemoryFont(pointer2, datalenght2);
            privateFontCollection.AddMemoryFont(pointer3, datalenght3);
            Marshal.FreeCoTaskMem(pointer);
            Marshal.FreeCoTaskMem(pointer2);
            Marshal.FreeCoTaskMem(pointer3);
            ff = privateFontCollection.Families[0];
            ff2= privateFontCollection.Families[1];
            ff3= privateFontCollection.Families[2];
        }//CARGAR FUENTE 1
        public static void LocalizarFuente(System.Windows.Forms.Control c, float tamanho)
        {
            c.Font = new Font(ff, tamanho, FontStyle.Regular);
        }
        public static void LocalizarFuenteNombre(System.Windows.Forms.Control c, float tamanho)
        {
            c.Font = new Font(ff2, tamanho, FontStyle.Regular);
        }
        public static void LocalizarFuenteDesc(System.Windows.Forms.Control c, float tamanho)
        {
            c.Font = new Font(ff2, tamanho, FontStyle.Regular);
        }
    }//CLASS
}
