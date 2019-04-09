using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISD.Week2
{
    class Password
    {
        public char RandomSymbol()
        {
            char[] Symbols = "abcdefghijklmnopqrstuvwxyz1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();//I wanted to make random inckuding ASCII but I just found this
            Random rand = new Random();//object of type Random for use method Next()
            int num = rand.Next(0, Symbols.Length - 1);//taking of random symbol
            return Symbols[num];
        }
    }

    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
