using Plod_i_Zelenchuk.Controllers;
using Plod_i_Zelenchuk.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Plod_i_Zelenchuk
{
    public partial class PlodIZelenchuk : Form
    {
        VeganLogic veganlogic = new VeganLogic();
        VeganTypesLogic vegantypeslogic = new VeganTypesLogic();
        public PlodIZelenchuk()
        {
            InitializeComponent();
        }

        private void PlodIZelenchuk_Load(object sender, EventArgs e)
        {
            List<Vegan>vegans = veganlogic.GetAll();
            cmb_name.DisplayMember = "Name";
            cmb_price.ValueMember= "Price";
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            
        }
    }
}
