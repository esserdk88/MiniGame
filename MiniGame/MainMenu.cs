using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGame
{
    public partial class MainMenu : Form
    {
        Form1 form1;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btn_GridGame_Click(object sender, EventArgs e)
        {
            
            // Check if the child form is already open
            if (form1 == null || form1.IsDisposed)
            {
                // Create a new instance of the child form
                form1 = new Form1();

                // Set the TopLevel property to false
                form1.TopLevel = false;

                // Set the form's parent to the panel
                panel_Center.Controls.Add(form1);

                // Show the form
                form1.Show();
            }
        }
    }
}
