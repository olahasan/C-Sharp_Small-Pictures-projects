using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 1;
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton button = (RadioButton)sender;

            switch (button.Tag.ToString())
            {
                case "BOY":
                    {
                        pictureBox1.Image = Resources.Two__Big_Boys_;

                        lblTitle.Text = button.Tag.ToString();
                        break;
                    }
                case "GIRL":
                    {
                        pictureBox1.Image = Resources.girls;

                        lblTitle.Text = button.Tag.ToString();
                        break;
                    }
                case "BOOK":
                    {
                        pictureBox1.Image = Resources.books;

                        lblTitle.Text = button.Tag.ToString();
                        break;
                    }
                case "PEN":
                    {
                        pictureBox1.Image = Resources.pen;

                        lblTitle.Text = button.Tag.ToString();
                        break;
                    }


            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int comboBox = comboBox1.SelectedIndex;

            switch (comboBox)
            {
                case 0:
                    {
                        pictureBox1.Image = Resources.books;
                        lblTitle.Text = "BOOK";
                        break;
                    }
                case 1:
                    {
                        pictureBox1.Image = Resources.Two__Big_Boys_;
                        lblTitle.Text = "BOY";
                        break;
                    }
                case 2:
                    {
                        pictureBox1.Image = Resources.girls;
                        lblTitle.Text = "Girl";
                        break;
                    }
                case 3:
                    {
                        pictureBox1.Image = Resources.pen;
                        lblTitle.Text = "PEN";
                        break;
                    }
                
            }

        }

    }
}
