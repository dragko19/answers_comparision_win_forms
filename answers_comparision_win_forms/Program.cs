using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace answers_comparision_win_forms
{
    class Program
    {
        public static Comparision Student = new Comparision();
        public static Comparision Teacher = new Comparision();
        public static Messenger Output_message = new Messenger();
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }        
    }
}
