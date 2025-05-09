using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_Agenda_2025.Formularios;

namespace Projeto_Agenda_2025
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmCadPessoas_Load(object sender, EventArgs e)
        {

        }

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadPessoas objCadPessoas = new frmCadPessoas();
            objCadPessoas.MdiParent = this;
            objCadPessoas.Show();
        }

        private void pessoasfiltroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaPessoas objConPessoas = new frmConsultaPessoas();
            objConPessoas.MdiParent = this;
            objConPessoas.Show();
        }
    }
}
