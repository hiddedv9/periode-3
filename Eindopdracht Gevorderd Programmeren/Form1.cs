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
        MyListStack myliststack = new MyListStack();
        ArrayStack arraystack = new ArrayStack();
        ListStack liststack = new ListStack();
        private string mode = "ListStack";
        public Form1()
        {
            InitializeComponent();
            int counter = 0;
            int tag = 1;
           

            for (counter = 0; counter < 4; counter++)
            {



                for (int i = 0; i < 4; i++)
                {
                    string text = "";
                    switch (tag)
                    {
                        case 1:
                            text = "1";
                            break;
                        case 2:
                            text = "4";
                            break;
                        case 3:
                            text = "7";
                            break;
                        case 4:
                            text = "ArrayStack";
                            break;
                        case 5:
                            text = "2";
                            break;
                        case 6:
                            text = "5";
                            break;
                        case 7:
                            text = "8";
                            break;
                        case 8:
                            text = "ListStack";
                            break;
                        case 9:
                            text = "3";
                            break;
                        case 10:
                            text = "6";
                            break;
                        case 11:
                            text = "9";
                            break;
                        case 12:
                            text = "MyListStack";
                            break;
                        case 13:
                            text = "+";
                            break;
                        case 14:
                            text = "-";
                            break;
                        case 15:
                            text = "/";
                            break;
                        case 16:
                            text = "x";
                            break;

                    }

                    Button b = new Button()
                    {
                        
                        Size = new Size(100, 80),
                        Location = new Point(101 * counter, 82 * i),
                        Tag = tag.ToString(),
                        Text = text,
                        
                        
                        
                        


                    };
                    b.Click += new EventHandler(ButtonClick);
                    tag++;
                    keyholder.Controls.Add(b);

                }



            }
        }




        private void ButtonClick(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                // now you know the button that was clicked
                switch (Convert.ToInt32(button.Tag))
                {
                    case 1:
                        berekeningbox.Text += "1";
                        break;
                    case 2:
                        berekeningbox.Text +=  "4";
                        break;
                    case 3:
                        berekeningbox.Text += "7";
                        break;
                    case 4:
                        mode = "ArrayStack";
                        stacklabel.Text = mode;
                        break;
                    case 5:
                        berekeningbox.Text += "2";
                        break;
                    case 6:
                        berekeningbox.Text += "5";
                        break;
                    case 7:
                        berekeningbox.Text += "8";
                        break;
                    case 8:
                        mode = "ListStack";
                        stacklabel.Text = mode;
                        break;
                    case 9:
                        berekeningbox.Text += "3";
                        break;
                    case 10:
                        berekeningbox.Text += "6";
                        break;
                    case 11:
                        berekeningbox.Text += "9";
                        break;
                    case 12:
                        mode = "MyListStack";
                        stacklabel.Text = mode;
                        break;
                    case 13:
                        berekeningbox.Text += "+";
                        break;
                    case 14:
                        berekeningbox.Text += "-";
                        break;
                    case 15:
                        berekeningbox.Text += "/";
                        break;
                    case 16:
                        berekeningbox.Text += "x";
                        break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stacklabel.Text = mode;
        }
    }
}

