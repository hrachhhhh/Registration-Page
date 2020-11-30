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

namespace WindowsFormsApp6
{
    public partial class signIn : Form
    {
        public signIn()
        {
            InitializeComponent();
        }

        private void signIn_button_click(object sender, EventArgs e)
        {
            string path = @"C:\Users\hunan\OneDrive\Desktop\ArmathProj\";
            string fileName = name_signIn_box.Text + "_" + lastName_signIn_box.Text + ".txt";
            FileInfo newFile = new FileInfo(path + fileName);
            if (name_signIn_box.Text == "" || lastName_signIn_box.Text == "" || password_signIn_box.Text == "")
            {
                MessageBox.Show("Invalid Input!!!!");
                this.Close();
                return;
            }
            if (!newFile.Exists)
            {
                MessageBox.Show("The user is not found!!!");
                this.Close();
                return;
            }
            string name;
            string lastName;
            string password;
            using(StreamReader sr=new StreamReader(path+fileName))
            {
                name = sr.ReadLine();
                lastName = sr.ReadLine();
                password = sr.ReadLine();
            }
            if(name==name_signIn_box.Text&&lastName==lastName_signIn_box.Text&&password==password_signIn_box.Text)
            {
                MessageBox.Show("Welcome " + name);
                this.Close();
            }
            else
            {
                MessageBox.Show("User is not found!!!");
                this.Close();
            }
        }
    }
}
