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
        GridGameForm gridGameForm;
        YatzyRollerForm yatzyRollerForm;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btn_GridGame_Click(object sender, EventArgs e)
        {
            
            // Check if the child form is already open
            if (gridGameForm == null || gridGameForm.IsDisposed)
            {
                // Create a new instance of the child form
                gridGameForm = new GridGameForm();

                // Set the TopLevel property to false
                gridGameForm.TopLevel = false;

                // Set the form's parent to the panel
                panel_Center.Controls.Add(gridGameForm);

                // Show the form
                gridGameForm.Show();
            }
        }

        private void btn_YatzyRoller_Click(object sender, EventArgs e)
        {
            // Check if the child form is already open
            if (yatzyRollerForm == null || yatzyRollerForm.IsDisposed)
            {
                // Create a new instance of the child form
                yatzyRollerForm = new YatzyRollerForm();

                // Set the TopLevel property to false
                yatzyRollerForm.TopLevel = false;

                // Set the form's parent to the panel
                panel_Center.Controls.Add(yatzyRollerForm);

                // Show the form
                yatzyRollerForm.Show();
            }
        }
    }
}
