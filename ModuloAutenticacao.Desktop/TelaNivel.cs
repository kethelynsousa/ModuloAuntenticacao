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
using System.Data.SqlClient;


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
            CarregarResponsabilidades();

        }

        private void txtCadastrar_Click(object sender, EventArgs e)
        {
            NivelDAO nivel = new NivelDAO();
            MessageBox.Show(nivel.Inserir(txtNomeK.Text));
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void txtPesquisar_Click_1(object sender, EventArgs e)
        {
            NivelDAO nivelPesquisa = new NivelDAO();

            dgvNivel.DataSource = nivelPesquisa.PesquisarPorNome(txtNomeK.Text);
        }

            public static bool VerificarUsuario(int nome)
            {
            using (SqlConnection conn = new SqlConnection(@"Server = Lab206_21; Database = ProjetoEstoquev; Uid = sa; Pwd = teste*123;")
                
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "select * from Nivel where nome = @Nome";
                    command.Connection = conn;
                    command.Parameters.AddWithValue("@Nome", nome);

                    conn.Open();

                    return Convert.ToBoolean(command.ExecuteScalar());

                }
                if (VerificarUsuario(1) == true)
                        {
                            MessageBox.Show(" Usuario existe.");
                        }
                        else
                        {
                            MessageBox.Show(" Usuario Nao existe.");
                        }
                    }







                }
            }
    
