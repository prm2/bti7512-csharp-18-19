using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OnChange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Person Person { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            TBName.Text = Person.Name;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Person.Name = TBName.Text;
        }

    }
}
