using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HookanShop
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PRODUCTS pr = new PRODUCTS();
            pr.NAMEP = Convert.ToString(TBN.Text);
            pr.PRICEP = Convert.ToString(TBP.Text);
            pr.GROUPPROD = Convert.ToString(TBG.Text);
            pr.COUNTP = Convert.ToString(TBC.Text);
            Program.HookanShop.PRODUCTS.Add(pr);
            Program.HookanShop.SaveChanges();

            MessageBox.Show("Товар успешно сохранен!", "ОК!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
