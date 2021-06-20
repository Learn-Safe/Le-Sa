using System;
using System.IO;
using System.Security.AccessControl;
using System.Windows.Forms;
namespace Le_Sa.test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string User = System.Environment.UserDomainName + "\\" + System.Environment.UserName;


        private string folder = @"C:\Users\" + System.Environment.UserName + @"\Desktop\SQLiteCrypt";

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public static string password;
        private void button1_Click_1(object sender, EventArgs e)
        {
            string filepath = @"C:\Users\" + System.Environment.UserName+ @"\Desktop\SQLiteCrypt\testing1.txt";
            richTextBox1.Text = Encryptor.Encrypt(richTextBox1.Text);
            string x = "saskjiasjfbhalksuhfrliwusrliuayse5";
            File.WriteAllText(filepath, x);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

            richTextBox1.Text = Encryptor.Decrypted(richTextBox1.Text);
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        public void SetAccessD()
        {
            DirectoryInfo myDirectoryInfo = new DirectoryInfo(folder);
            richTextBox1.Text = myDirectoryInfo.ToString();
            DirectorySecurity myDirectorySecurity = myDirectoryInfo.GetAccessControl();
            textBox2.Text = myDirectorySecurity.ToString();
            textBox1.Text = User.ToString();
            myDirectorySecurity.AddAccessRule(new FileSystemAccessRule(User, FileSystemRights.Delete, AccessControlType.Deny));
            myDirectoryInfo.SetAccessControl(myDirectorySecurity);
        }

        public void SetAccessA()
        {
            DirectoryInfo myDirectoryInfo = new DirectoryInfo(folder);
            richTextBox1.Text = myDirectoryInfo.ToString();
            DirectorySecurity myDirectorySecurity = myDirectoryInfo.GetAccessControl();
            textBox2.Text = myDirectorySecurity.ToString();
            textBox1.Text = User.ToString();
            myDirectorySecurity.RemoveAccessRule(new FileSystemAccessRule(User, FileSystemRights.Delete, AccessControlType.Deny));
            myDirectoryInfo.SetAccessControl(myDirectorySecurity);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetAccessD();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           SetAccessA();
        }
    }
}
