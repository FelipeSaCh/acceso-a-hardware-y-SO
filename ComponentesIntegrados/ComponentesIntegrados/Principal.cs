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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnAnalizar_Click(object sender, EventArgs e)
        {
            //Numero de Serie del discoduro

            string serialnumber="";
           lblSerialNumber.Text = Componentes.SerialNumber(serialnumber);

            //Numero de Discos 
            rtxtNumeroDiscos.Text = Componentes.Diskunits();

            //Numero de procesadores
            lblprocesadores.Text = Componentes.NumberProcessors();

            //Memoria Ram disponible
            lblRam.Text = Componentes.Ram();

            //NIT
            rtxtNit.Text = Componentes.NIT();

            //mACaDDRESS
            lblMacAddress.Text = Componentes.MacAddress().ToString();

            //Patches
            rtxtPatches.Text = Componentes.Patches();
            
        }

        private void btnRegedit_Click(object sender, EventArgs e)
        {
            Regedit regedit = new Regedit();
            regedit.Show();
            this.Hide();
        }

        private void btnTaskManager_Click(object sender, EventArgs e)
        {
            taskmanager_ taskmanager = new taskmanager_();
            taskmanager.Show();
            this.Hide();
        }
    }
}
