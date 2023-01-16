using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CGS_DLL;

namespace CGS_Windows
{
    public partial class Login : Form
    {
        //Gallery myGallery = new Gallery();
        int counter = 0;

        public Login()
        {
            InitializeComponent();
        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(@"C:\Users\bob2a\Desktop\COLLEGE LASALLE\3. FALL 2022\MULTI-TIER APPLICATIONS DEVELOPMENT C#\CGS_Windows\CGS_Windows\Login.txt"))
            {
                while (sr.Peek() >= 0)
                {
                    string str;
                    string[] strArray;
                    str = sr.ReadLine();

                    strArray = str.Split(',');
                    strArray.Append(str);   
                    if (strArray[0] != txt_userName.Text || strArray[1] != txt_Password.Text)
                    {
                        counter++;
                        MessageBox.Show("Wrong username and/or password");
                    }
                    else
                    {
                        mainForm mainForm = new mainForm();
                        mainForm.ShowDialog();
                    }
                    if(counter == 3)
                    {
                        Application.Exit();
                    }
                }
            }
            


            //if (txt_userName.Text != "CGS")
            //{
            //    counter++;
            //    MessageBox.Show("Wrong password");                
            //}
            //else
            //{
            //    if (txt_Password.Text != "admin")
            //    {
            //        counter++;
            //        MessageBox.Show("Wrong password");                   
            //    }
            //    else
            //    {   
            //        //mainForm mainForm = new mainForm();
            //        //mainForm.ShowDialog();
            //        mainForm mainform = new mainForm();
            //        mainform.Visible = true;
            //        mainform.Activate();                   
            //    }                
            //}    
            //if (counter == 3)
            //{
            //    Application.Exit();
            //}
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_userName_TextChanged(object sender, EventArgs e)
        {
            this.Focus();   
        }
    }
}
