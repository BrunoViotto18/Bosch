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

            Form2 form2 = new Form2(form1.Index, sqlcon);
            Form3 form3 = new Form3(form1.Index, sqlcon);
            if (form1.Cadastrado)
            {
                Application.Run(new Form2(form1.Index,sqlcon));
            }
            else
            {
                Application.Run(new Form3(form1.Index, sqlcon));
            }

            if (!form2.success && !form3.success)
            {
                return;
            }

            Form6 form6 = new Form6(form1.Index, sqlcon);
            Application.Run(form6);
        }
    }
}
