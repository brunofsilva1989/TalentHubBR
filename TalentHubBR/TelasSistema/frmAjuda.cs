using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TalentHubBR.UI.TelasSistema
{
    public partial class frmAjuda : Form
    {
        public frmAjuda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Manual do Usuário");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Atalhos uteis do sistema");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Versão 1.0.0");
        }
    }
}
