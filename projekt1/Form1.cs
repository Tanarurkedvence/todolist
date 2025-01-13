using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace projekt1
{
    public partial class Form1 : Form
    {
        Logic logic = new Logic();
        public Form1()
        {
            InitializeComponent();
        }

        private void gomb_Click(object sender, EventArgs e)
        {
            if (input.Text != "")
            {
                logic.addEntry(input.Text, content);
                input.Text = "";
            }



        }
    }
}
