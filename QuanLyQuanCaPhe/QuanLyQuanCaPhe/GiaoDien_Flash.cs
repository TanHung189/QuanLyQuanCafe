using System;
using System.Windows.Forms;

namespace QuanLyQuanCaPhe
{
    public partial class GiaoDien_Flash : Form
    {
        public GiaoDien_Flash()
        {
            InitializeComponent();
        }

        private void GiaoDien_Flash_Load(object sender, EventArgs e)
        {
            timer1.Interval = 3000; // Mở form trong 3 giây
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();
        }
    }
}
