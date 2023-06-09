using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plod_i_Zelenchuk
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Display display = new Display();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PlodIZelenchuk());
        }
    }
}
