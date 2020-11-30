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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Resgistration_button_click(object sender, EventArgs e)
        {
            string path = @"C:\Users\hunan\OneDrive\Desktop\ArmathProj\";
            string fileName = name_text_box.Text+"_"+lastName_text_box.Text+".txt";
            FileInfo newFile = new FileInfo(path+fileName);
            if(name_text_box.Text=="" || lastName_text_box.Text==""||password_text_box.Text=="")
            {
                MessageBox.Show("Invalid Input!!!!");
                this.Close();
                return;
            }
            if(newFile.Exists)
            {
                MessageBox.Show("The user is Exists!!!");
                this.Close();
                return;
            }
            using(FileStream fs=new FileStream(path+fileName,FileMode.Create))
            { }
            using(StreamWriter sw=new StreamWriter(path+fileName))
            {
                sw.WriteLine(name_text_box.Text);
                sw.WriteLine(lastName_text_box.Text);
                sw.WriteLine(password_text_box.Text);
            }

            signIn log = new signIn();
            this.Hide();
            log.ShowDialog();
            this.Close();


        }
    }
}
