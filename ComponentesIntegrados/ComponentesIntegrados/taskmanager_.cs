using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libreria;

namespace ComponentesIntegrados
{
    public partial class taskmanager_ : Form
    {
        public taskmanager_()
        {
            InitializeComponent();

        }

        Process[] proc;
        void GetAllProcess()
        {
            proc = Process.GetProcesses();
            lbitems.Items.Clear();
            foreach (Process p in proc)
            {
                lbitems.Items.Add(p.ProcessName);
            }
        }

        private void taskmanager__Load(object sender, EventArgs e)
        {
            GetAllProcess();
        }

        private void btnfinalizarTarea_Click(object sender, EventArgs e)
        {
            try
            {
                proc[lbitems.SelectedIndex].Kill();
                GetAllProcess();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Principal form1 = new Principal();
            form1.Show();
            this.Hide();
        }
    }
    
}
