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
    public partial class YatzyRollerForm : Form
    {
        private List<Button> _buttonList;
        private List<PictureBox> _pictureBoxList;
        private Dictionary<Button, PictureBox> _pictureBoxDictionary;
        private Color _unholdColor;
        private Color _holdColor;
        private int _rollsLeft;

        public YatzyRollerForm()
        {
            InitializeComponent();
            InitializeColors();
            InitializePictureBoxDictionary();
            InitializeOther();
            //InitializeButtons();
            //InitializePictureBoxes();
        }

        private void InitializeOther()
        {
            _rollsLeft = 3;
        }

        private void InitializePictureBoxDictionary()
        {
            _pictureBoxDictionary = new Dictionary<Button, PictureBox>
            {
                { btn_Hold1, pictureBox1 },
                { btn_Hold2, pictureBox2 },
                { btn_Hold3, pictureBox3 },
                { btn_Hold4, pictureBox4 },
                { btn_Hold5, pictureBox5 },
            };
            foreach (KeyValuePair<Button, PictureBox> element in _pictureBoxDictionary)
            {
                element.Key.Enabled = false;
                element.Key.BackColor = _unholdColor;
                element.Value.Image = MiniGame.Properties.Resources._1;
            }
        }

        //private void InitializePictureBoxes()
        //{
        //    _pictureBoxList = new List<PictureBox>
        //    {
        //        pictureBox1,
        //        pictureBox2, 
        //        pictureBox3, 
        //        pictureBox4,
        //        pictureBox5
        //    };
        //    pictureBox1.Image = MiniGame.Properties.Resources._1;
        //    pictureBox2.Image = MiniGame.Properties.Resources._2;
        //    pictureBox3.Image = MiniGame.Properties.Resources._3;
        //    pictureBox4.Image = MiniGame.Properties.Resources._4;
        //    pictureBox5.Image = MiniGame.Properties.Resources._5;
        //}

        //private void InitializeButtons()
        //{
        //    _buttonList = new List<Button>
        //    {
        //        btn_Hold1,
        //        btn_Hold2,
        //        btn_Hold3,
        //        btn_Hold4,
        //        btn_Hold5
        //    };
        //    foreach (Button button in _buttonList)
        //    {
        //        button.Enabled = false;
        //        button.BackColor = _unholdColor;
        //    }

        //}

        private void InitializeColors()
        {
            _unholdColor = Color.White;
            _holdColor = Color.Red;
        }

        private void btn_Hold_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            flipButtonColor(button);
        }

        private void flipButtonColor(Button button)
        {
            if (button.BackColor == _holdColor)
            {
                button.BackColor = _unholdColor;
            }
            else
            {
                button.BackColor = _holdColor;
            }
        }

        private void btn_Roll_Click(object sender, EventArgs e)
        {
            List<PictureBox> affectedPictures = new List<PictureBox>();
            Random rnd = new Random();

            //fill list
            foreach (KeyValuePair<Button,PictureBox> element in _pictureBoxDictionary)
            {
                if(element.Key.BackColor == _unholdColor)
                {
                    affectedPictures.Add(element.Value);
                }
            }

            foreach (PictureBox pictureBox in affectedPictures)
            {
                int rolledNumber = rnd.Next(1,7);

                switch (rolledNumber)
                {
                    case 1:
                        pictureBox.Image = MiniGame.Properties.Resources._1;
                        break; 
                    case 2:
                        pictureBox.Image = MiniGame.Properties.Resources._2;
                        break;
                    case 3:
                        pictureBox.Image = MiniGame.Properties.Resources._3;
                        break;
                    case 4:
                        pictureBox.Image = MiniGame.Properties.Resources._4;
                        break;
                    case 5:
                        pictureBox.Image = MiniGame.Properties.Resources._5;
                        break;
                    case 6:
                        pictureBox.Image = MiniGame.Properties.Resources._6;
                        break;

                }
            }

            _rollsLeft--;
            lbl_RollsLeft.Text = $"Rolls Left: {_rollsLeft}";

            if(_rollsLeft == 0)
            {
                btn_Roll.Enabled = false;
            }
            else if (_rollsLeft == 2)
            {
                foreach (KeyValuePair<Button, PictureBox> element in _pictureBoxDictionary)
                {
                    element.Key.Enabled = true;
                }
            }

        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            InitializeOther();
            InitializePictureBoxDictionary();
            _rollsLeft = 3;
            lbl_RollsLeft.Text = $"Rolls Left: {_rollsLeft}";
            btn_Roll.Enabled = true;
        }
    }
}
