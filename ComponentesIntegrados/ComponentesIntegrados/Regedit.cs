using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libreria;

namespace ComponentesIntegrados
{
    public partial class Regedit : Form
    {
        public Regedit()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Componentes.CreateKey(txtpath.Text,txtKeyName.Text,txtKeyValue.Text);
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            txtKeyValue.Text = Componentes.ReadKey(txtpath.Text, txtKeyName.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Componentes.DeleteKey(txtpath.Text, txtKeyName.Text);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            Componentes.SetKey(txtpath.Text, txtKeyName.Text, txtKeyValue.Text);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Principal form1 = new Principal();
            form1.Show();
            this.Hide();
        }
    }
}
