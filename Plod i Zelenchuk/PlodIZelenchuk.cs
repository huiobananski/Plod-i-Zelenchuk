using Plod_i_Zelenchuk.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plod_i_Zelenchuk
{
    public partial class PlodIZelenchuk : Form
    {
        public PlodIZelenchuk()
        {
            InitializeComponent();
        }

        private void PlodIZelenchuk_Load(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            _VeganDbContext.VegaAdd(vegan);   
        }
    }
}
