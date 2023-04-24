using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_19
{
    public partial class Form1 : Form
    {

        private ListViewGroup carnes = new ListViewGroup("Carnes", HorizontalAlignment.Left);
        private ListViewGroup frutas = new ListViewGroup("Frutas", HorizontalAlignment.Left);



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListViewGroup frutas = new ListViewGroup("Frutas", HorizontalAlignment.Left);
            ListViewGroup carnes = new ListViewGroup("Carnes", HorizontalAlignment.Left);

            LV_Alimentos.Items.Add(new ListViewItem("Fresa", frutas)); 
            LV_Alimentos.Items.Add(new ListViewItem("Pasas", frutas));
            LV_Alimentos.Items.Add(new ListViewItem("Uva", frutas));
            LV_Alimentos.Items.Add(new ListViewItem("Maago", frutas));
            LV_Alimentos.Items.Add(new ListViewItem("Ceresa", frutas));

            ListViewItem miElemento = new ListViewItem("Pollo", carnes);
            LV_Alimentos.Items.Add(new ListViewItem("Res", carnes));
            LV_Alimentos.Items.Add(new ListViewItem("Pescado", carnes));
            LV_Alimentos.Items.Add(new ListViewItem("Cerdo", carnes));

            LV_Alimentos.Groups.Add(frutas);
            LV_Alimentos.Groups.Add(carnes);







        }

        private void BT_Agregar_Click(object sender, EventArgs e)
        {
            if (RB_Frutas.Checked == true)
            {

                LV_Alimentos.Items.Add(new ListViewItem(TX_Elmento.Text, frutas));

            }

            if (RB_Carnes.Checked == true)
            {

                LV_Alimentos.Items.Add(new ListViewItem(TX_Elmento.Text, carnes));

            }
        }

        private void LV_Alimentos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
