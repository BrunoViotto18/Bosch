using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldSkills
{
   
    class Program
    {
        private static SqlConnection sqlcon = new SqlConnection(@"Data Source = JVLPC0524; Initial Catalog = ModuloDesktop; Integrated Security = True");
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //for win auth
            // @"Data Source=(MachineName)\(InstanceName);Initial Catalog=(DBname);Integrated Security=True;"

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form1 = new Form1(sqlcon);
            Application.Run(form1);

            if (!form1.Success)
            {
                return;
            }

            if (form1.Cadastrado)
            {
                Application.Run(new Form2(form1.Index));
            }
            else
            {
                Application.Run(new Form3(form1.Index, sqlcon));
            }

            //Close Connection with the server
        }
    }
}
