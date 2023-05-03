using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Controls;
using System.Windows.Forms;

namespace SerializableYugi
{
    public class Fuente
    {
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr fuente, uint cbfont, IntPtr pdv,[In] ref uint pcFonts);
        static FontFamily ff;
        static Font fuentecita;
        public static void CargarFuente()
        {
            byte[] arrayfuente = Properties.Resources.StoneSerifSemibold;
            int datalenght = Properties.Resources.StoneSerifSemibold.Length;
            IntPtr pointer = Marshal.AllocCoTaskMem( datalenght );
            Marshal.Copy(arrayfuente,0,pointer, datalenght);
            uint cFonts = 0;
            AddFontMemResourceEx(pointer, (uint)arrayfuente.Length, IntPtr.Zero, ref cFonts);
            PrivateFontCollection privateFontCollection = new PrivateFontCollection();
            privateFontCollection.AddMemoryFont(pointer, datalenght);
            Marshal.FreeCoTaskMem(pointer);
            ff = privateFontCollection.Families[0];
            fuentecita = new Font(ff, 15f, FontStyle.Regular);
        }
        public static void LocalizarFuente(System.Windows.Forms.Control c, float tamanho) {
            c.Font = new Font(ff, tamanho, FontStyle.Regular);
        }

        public static Font DevolverFuentecita() {
            return DevolverFuentecita();
        }
    }//CLASS
}
