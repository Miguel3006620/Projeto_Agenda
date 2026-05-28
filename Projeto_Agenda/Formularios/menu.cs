using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Agenda.Formularios
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultar formcad = new Consultar();
            formcad.MdiParent = this;
            formcad.Show();
        }


        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadPessoas formcad = new FormCadPessoas();
            formcad.MdiParent = this;
            formcad.Show();
        }

        private void relatoriosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Relatorios formcad = new Relatorios();
            formcad.MdiParent = this;
            formcad.Show();
        }
    }
}
