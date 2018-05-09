using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eindopdracht_Gevorderd_Programmeren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int counter = 0; int tag = 1;


            for (counter = 0; counter < 4; counter++)
            {
                


                for (int i = 0; i < 4; i++)
                {
                    Button b = new Button()
                    {
                        Size = new Size(100, 80),
                        Location = new Point(101 * counter, 82 * i),
                        Tag = tag.ToString(),


                    };


                    tag++;
                    keyholder.Controls.Add(b);
                }
            }


        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                // now you know the button that was clicked
                switch ((int)button.Tag)
                {
                    case 0:
                        // First Button Clicked
                        break;
                    case 1:
                        // Second Button Clicked
                        break;
                        // ...
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
