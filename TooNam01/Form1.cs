using System.Windows.Forms;

namespace TooNam01
{
    public partial class Form1 : Form
    {
        TaoBood taobood;

        public Form1()
        {
            InitializeComponent();
            taobood = new TaoBood();
        }

        private void BlackCofBut_Click(object sender, EventArgs e)
        {
            bool canMake = taobood.BlackCoffee();
            if (canMake)
            {
                OutRaw.Image = Properties.Resources.OutBlackCof;
            }
            else
            {
                OutRaw.Image = Properties.Resources.SoldOut;
            }
        }

        private void MochaBut_Click(object sender, EventArgs e)
        {
            bool canMake = taobood.Mocha();
            if (canMake)
            {
                OutRaw.Image = Properties.Resources.OutMocha;
            }
            else
            {
                OutRaw.Image = Properties.Resources.SoldOut;
            }
        }

        private void LatteBut_Click(object sender, EventArgs e)
        {
            bool canMake = taobood.Latte();
            if (canMake)
            {
                OutRaw.Image = Properties.Resources.OutLatte;
            }
            else
            {
                OutRaw.Image = Properties.Resources.SoldOut;
            }
        }

        private void ChocoBut_Click(object sender, EventArgs e)
        {
            bool canMake = taobood.Chocolate();
            if (canMake)
            {
                OutRaw.Image = Properties.Resources.OutChoco;
            }
            else
            {
                OutRaw.Image = Properties.Resources.SoldOut;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int RS = taobood.ReStack();
        }
    }
}