using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModuloAutenticacao.Classes;


namespace ModuloAutenticacao.Desktop
{
    public partial class TelaNivel : Form
    {
        public TelaNivel()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
           
        }

        private void txtCadastrar_Click(object sender, EventArgs e)
        {
            NivelDAO nivel = new NivelDAO();
            MessageBox.Show(nivel.Inserir(txtNome.Text));
            CarregarResponsabilidades();

        }

        private void dgvNivel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
        private void CarregarResponsabilidades()
        {
            NivelDAO nivelPesquisa = new NivelDAO();

            dgvNivel.DataSource = nivelPesquisa.Pesquisar();
        }

    }
}

