using System;
using System.Drawing;
using System.Windows.Forms;

namespace Delegates2
{
    public partial class Form1 : Form
    {
        private EventHandler TransparencyEventHandler;
        private EventHandler BackgroundColorEventHandler;
        private EventHandler HelloWorldEventHandler;

        public Form1()
        {
            InitializeComponent();
            
            TransparencyEventHandler = btnTransparency_Click;
            BackgroundColorEventHandler = btnBackgroundColor_Click;
            HelloWorldEventHandler = btnHelloWorld_Click;
        }

        private void btnTransparency_Click(object sender, EventArgs e)
        {
            ActiveForm.Opacity = ActiveForm.Opacity == 1.0 ? 0.5 : 1.0;
        }

        private void btnBackgroundColor_Click(object sender, EventArgs e)
        {
            ActiveForm.BackColor = ActiveForm.BackColor == Color.Azure ? Color.Aqua : Color.Azure;
        }

        private void btnHelloWorld_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Home!");
        }

        private void btnSetOfActions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Я супермегакнопка,\nі цього мене не позбавиш!");
        }

        private void checkBoxTransparency_Click(object sender, EventArgs e)
        {
            if (checkBoxTransparency.Checked)
            {
                btnSetOfActions.Click += TransparencyEventHandler;
            }
            else
            {
                btnSetOfActions.Click -= TransparencyEventHandler;
            }
        }

        private void checkBoxBackgroundColor_Click(object sender, EventArgs e)
        {
            if (checkBoxBackgroundColor.Checked)
            {
                btnSetOfActions.Click += BackgroundColorEventHandler;
            }
            else
            {
                btnSetOfActions.Click -= BackgroundColorEventHandler;
            }
        }

        private void checkBoxHelloWorld_Click(object sender, EventArgs e)
        {
            if (checkBoxHelloWorld.Checked)
            {
                btnSetOfActions.Click += HelloWorldEventHandler;
            }
            else
            {
                btnSetOfActions.Click -= HelloWorldEventHandler;
            }
        }
    }
}