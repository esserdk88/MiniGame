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
    public partial class Form1 : Form
    {
        List<Button> _buttonList;
        Color _onColor;
        Color _offColor;
        public Form1()
        {
            InitializeComponent();
            InitializeButtonList();
            InitializeColors();
        }

        private void InitializeColors()
        {
            _onColor = Color.Red; 
            _offColor = Color.Blue;

            foreach (Button button in _buttonList)
            {
                button.BackColor = _offColor;
            }
            
        }

        private void InitializeButtonList()
        {
            _buttonList = new List<Button>
            {
                button1,
                button2,
                button3,
                button4,
                button5,
                button6,
                button7,
                button8,
                button9
            };
        }

        private List<Button> getAdjacentButtons(Button root)
        {
            List<Button> outputList = new List<Button>();

            switch (root.Name)
            {
                case "button1":
                    outputList = new List<Button> { button2, button4 };
                    break;
                case "button2":
                    outputList = new List<Button> { button1, button3, button5 };
                    break;
                case "button3":
                    outputList = new List<Button> { button2, button6 };
                    break;
                case "button4":
                    outputList = new List<Button> { button1, button5, button7 };
                    break;
                case "button5":
                    outputList = new List<Button> { button2, button4, button6, button8 };
                    break;
                case "button6":
                    outputList = new List<Button> { button3, button5, button9 };
                    break;
                case "button7":
                    outputList = new List<Button> { button4, button8 };
                    break;
                case "button8":
                    outputList = new List<Button> { button7, button5, button9 };
                    break;
                case "button9":
                    outputList = new List<Button> { button8, button6 };
                    break;

            }
            return outputList;
        }

        private void flipButtonColor(Button button)
        {
            if(button.BackColor == _onColor)
            {
                button.BackColor = _offColor;
            }
            else
            {
                button.BackColor = _onColor;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            //Find all button affected
            List<Button> buttons = new List<Button>();
            buttons.Add(button);
            buttons.AddRange(getAdjacentButtons(button));

            //Change color on button clicked and adjacent buttons
            foreach (Button b in buttons)
            {
                flipButtonColor(b);
            }

            //Victorycheck
            bool victoryCheck = true;
            foreach (Button b in _buttonList)
            {
                if(b.BackColor == _offColor)
                {
                    victoryCheck = false;
                }
            }
            if (victoryCheck)
            {
                MessageBox.Show("You have won the game!");
            }

        }
    }
}
