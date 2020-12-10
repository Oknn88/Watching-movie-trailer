using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmFragmanIzleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightSkyBlue;
        }

        private void griToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void yeşilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGreen;
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu uygulama Okan Erciyas tarafından geliştirilmiştir", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void madMaxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=hEJnMQG9ev8&ab_channel=WarnerBros.Pictures");
            label1.Text = "Mad Max Trailer";
        }

        private void hızlıVeÖfkeli4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=PMfQk9gG0Ag&ab_channel=Fragman%C4%B0%C3%A7in");
            label1.Text = "Hızlı ve Öfkeli 4 trailer";
        }

        private void loganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=Div0iP65aZo&ab_channel=20thCenturyStudios");
            label1.Text = "Logan Trailer";
        }

        private void silBaştanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=yhs-CfJq4g4&ab_channel=SeslendirmeKadrolar%C4%B1");
            label1.Text = "Sil Baştan Trailer";
        }

        private void aileArasındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=N-hyXVxNNjM&ab_channel=Be%C5%9Fikta%C5%9FK%C3%BClt%C3%BCrMerkezi%28BKM%29");
            label1.Text = "Aile Arasında Trailer";
        }

        private void yıldızlarArasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=1LHj8TL71do&ab_channel=BiletivaBilet");
            label1.Text = "Yıldızlar Arası Trailer";
        }

        private void başlangıçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=8hP9D6kZseM&ab_channel=BoxOfficeSmashers");
            label1.Text = "Başlangıç Trailer";
        }
    }
}
