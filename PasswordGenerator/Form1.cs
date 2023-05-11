using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
//using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetRoundedShape(lenght, 20);
            SetRoundedShape(privateSymbol, 20);
            SetRoundedShape(buttonCopy, 20);
            SetRoundedShape(buttonRefresh, 20);
            privateSymbol.Text = "~!@#$%^&*+-/.,\\{}[]();:?";
            lenght.Text = "16";
            hystory.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public static void SetRoundedShape(Control control, int radius)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddLine(radius, 0, control.Width - radius, 0);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddLine(control.Width, radius, control.Width, control.Height - radius);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddLine(control.Width - radius, control.Height, radius, control.Height);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            path.AddLine(0, control.Height - radius, 0, radius);
            path.AddArc(0, 0, radius, radius, 180, 90);
            control.Region = new Region(path);
        }
        public void History()
        {
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanel.AutoSize = true;

            string filePath = "passwords.txt";
            int lineCount = 0;
            if (!File.Exists(filePath))
            {
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    sw.WriteLine("AA7`=1p`k$\".Qo>K");
                }
            }
            using (StreamReader sr = new StreamReader(filePath))
            {
                while (sr.ReadLine() != null)
                {
                    lineCount++;
                }
            }
            string[] lines = File.ReadAllLines("passwords.txt");
            for (int i = 0; i < lineCount; i++)
            {
                Panel panel = new Panel();
                panel.BackColor = Color.Transparent;
                panel.Size = new Size(551, 50);
                flowLayoutPanel.Controls.Add(panel);

                Label label2 = new Label();
                label2.Text = lines[i];
                label2.Location = new Point(5, 10);
                label2.AutoSize = true;
                label2.ForeColor = Color.White;
                label2.Font = new Font("Segoe UI Variable Display Semib", 14);
                panel.Controls.Add(label2);

                foreach (Control control in flowLayoutPanel.Controls)
                {
                    control.Margin = new Padding(1, 1, 1, 1);
                }

                ListOfHistory.Controls.Add(flowLayoutPanel);
            }
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            hystory.Visible = true;
            History();
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            Setting.Visible = true;
            hystory.Visible = false;
            
        }
        public string GeneratePassword()
        {
            string chars = "";
            if(checkBox09.Checked == true) chars = "0123456789";
            if (checkBoxAZ.Checked == true) chars = chars + "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (checkBoxsmallAZ.Checked == true) chars = chars + "abcdefghijklmnopqrstuvwxyz";
            if (checkBoxPrivateSymbol.Checked == true) chars = chars + privateSymbol.Text;
            var random = new Random();
            var password = new string(
                Enumerable.Repeat(chars, int.Parse(lenght.Text))
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            int count = 0;
            int checking = 0;
            if (checkBox09.Checked == true) count++;
            if (checkBoxAZ.Checked == true) count++;
            if (checkBoxPrivateSymbol.Checked == true) count++;
            if (checkBoxsmallAZ.Checked == true) count++;
            
            if (int.Parse(lenght.Text) <= 11)
            {
                reliability.Text = "слабый";
                reliability.ForeColor = Color.Red;
                checking++;
            }
            if(checking == 0 && int.Parse(lenght.Text) == 12)
            {
                if (int.Parse(lenght.Text) == 12 && count < 4 && checking == 0)
                {
                    reliability.Text = "слабый";
                    reliability.ForeColor = Color.Red;
                    checking++;
                }
                else
                {
                    reliability.Text = "средний";
                    reliability.ForeColor = Color.Yellow;
                    checking++;
                }
            }
            

            if(checking == 0 && int.Parse(lenght.Text) == 13)
            {
                if (checking == 0 && int.Parse(lenght.Text) == 13 && count >= 4)
                {
                    reliability.Text = "средний";
                    reliability.ForeColor = Color.Yellow;
                    checking++;
                }
                else
                {
                    reliability.Text = "слабый";
                    reliability.ForeColor = Color.Red;
                    checking++;
                }
            }

            if(checking == 0 && int.Parse(lenght.Text) == 14)
            {
                if (checking == 0 && int.Parse(lenght.Text) == 14 && count >= 3)
                {
                    reliability.Text = "средний";
                    reliability.ForeColor = Color.Yellow;
                    checking++;
                }
                else
                {
                    reliability.Text = "слабый";
                    reliability.ForeColor = Color.Red;
                    checking++;
                }
            }
            
            if(checking == 0 && int.Parse(lenght.Text) == 15) 
            {
                if (int.Parse(lenght.Text) == 15 && count >= 2)
                {
                    reliability.Text = "средний";
                    reliability.ForeColor = Color.Yellow;
                    checking++;
                }
                else
                {
                    reliability.Text = "слабый";
                    reliability.ForeColor = Color.Red;
                    checking++;
                }
            }
            

            if (count == 4 && int.Parse(lenght.Text) == 16)
            {
                reliability.Text = "надежный";
                reliability.ForeColor = Color.Green;
                checking++;
            }
            return password;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            if(int.Parse(lenght.Text) <= 16 && int.Parse(lenght.Text) >= 4)
            {
                if(checkBox09.Checked == false && checkBoxAZ.Checked == false && checkBoxsmallAZ.Checked == false && checkBoxPrivateSymbol.Checked == false) 
                {
                    MessageBox.Show("Выберите хоть одну опцию");
                } else
                {     
                    string pass = GeneratePassword();
                    string[] passwords = File.ReadAllLines("rockyou.txt");
                    if (passwords.Contains(pass))
                    {
                        MessageBox.Show("Этот пароль очень не безопасен, сгенерируйте еще раз");
                    } else
                    {
                        Password.Text = pass;
                    }
                }
            } else
            {
                MessageBox.Show("Длина пароля не соответсвует допустимым значениям");
            }
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Password.Text);
            string path = "passwords.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(Password.Text);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(Password.Text);
                }
            }
        }

        private void checkBoxAZ_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ClearHistory_Click(object sender, EventArgs e)
        {
            File.WriteAllText("passwords.txt", string.Empty);
            ListOfHistory.Controls.Clear();
            History();
        }
    }
}
