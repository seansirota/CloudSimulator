using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CloudSimulator
{
    //Contains Program class and main method.
    static class Program
    {
        public static MainForm mainForm = new MainForm();

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(mainForm);
            mainForm.CBXView.SelectedIndex = 0;
        }
    }
}