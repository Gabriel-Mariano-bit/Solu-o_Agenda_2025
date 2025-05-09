using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Agenda_2025.Formularios
{
    public partial class frmConsultaPessoas : Form
    {
        public frmConsultaPessoas()
        {
            InitializeComponent();
        }

        private void frmConsultaPessoas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet_Agenda.Pessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoaTableAdapter.Fill(this.dataSet_Agenda.Pessoa);

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            //string vFiltro, vTexto, vProcurar;

            pessoaBindingSource.Filter = "Nome like '%" + txtPesquisa.Text + "%'";

            //pessoaBindingSource.Filter = vFiltro;
        }

        
    }
}
