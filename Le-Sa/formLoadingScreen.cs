using Le_Sa.Account;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Le_Sa
{
    public partial class formLoadingScreen : Form
    {
        public formLoadingScreen()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private readonly string db = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sathsara\source\repos\sathsarabandaraj\Le-Sa\Le-Sa\Data\user.mdf;Integrated Security = True; Timeout=30";

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            pnlLoadingFront.Width += 8;
            if (pnlLoadingFront.Width >= 925)
            {
                timerLoading.Stop();
                formDesktop dahsboard = new formDesktop();
                dahsboard.Show();
                this.Hide();
            }
        }
    }
}
