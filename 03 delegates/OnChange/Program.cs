﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OnChange
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var form = new Form1();

            form.Person = new Person { Name = "Hans Muster" };

            form.Person.NameChanged += delegate (Person p)
            {
                MessageBox.Show(String.Format("Name has been changed to '{0}'", p.Name), "ShowChange");
            };

            Application.Run(form);
        }
    }
}
