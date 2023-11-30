
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDeCompras
{
    public partial class Form1 : Form
    {
        private int idSelecionado;

        public Form1()
        {
            InitializeComponent();
            Classe.ListaDeCompras listaDeCompras = new Classe.ListaDeCompras();

            // Atribuir a tabela (resultado do SELECT) no DGV:
            dgvLista.DataSource = listaDeCompras.ListarTudo();

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ativar os grbs:
            grbEditar.Enabled = true;
            grbInserir.Enabled = true;

            // obter a linha clicada:
            int linhaSelecionada = dgvLista.CurrentCell.RowIndex;
            var linha = dgvLista.Rows[linhaSelecionada];

             cmbEdiPrio.Text = linha.Cells[2].Value.ToString();
            txbEdiNome.Text = linha.Cells[1].Value.ToString();
            txbEdiQuantidade.Text =  linha.Cells[3].Value.ToString();

            // Salvar o id do selecionado na variavel global:
            idSelecionado = (int)linha.Cells[0].Value;
            // Juntar o ID e o nome para exibir no apagar:
            btnRemover.Text = linha.Cells[0].Value.ToString() + " - " +
                linha.Cells[1].Value.ToString();

            // Salvar o id do selecionado na variavel global:
            idSelecionado = (int)linha.Cells[0].Value;

        }

        private void grbEditar_Enter(object sender, EventArgs e)
        {
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Classe.ListaDeCompras lcd = new Classe.ListaDeCompras();
            var r = MessageBox.Show("Tem certeza que de seja remover?", "Atenção",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                lcd.Id = idSelecionado;
                //Apagar:
                if (lcd.Apagar() == true)
                {
                    MessageBox.Show("produto removido!", "Sucesso",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Atualizar o dgb:
                    dgvLista.DataSource = lcd.ListarTudo();
                    //limpar os campos de edição:
                    txbEdiNome.Clear();
                    txbEdiQuantidade.Clear();
                    btnRemover.Text = "Selecione o produto para apagar";
                    //Desabilidar os grbs:
                    grbEditar.Enabled = false;
                    btnInserir.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Erro!", "Falhou",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Classe.ListaDeCompras listaDeCompras = new Classe.ListaDeCompras();
            //Obter os valores dos txbs:
            listaDeCompras.Id = idSelecionado;
            listaDeCompras.Nome_item = txbEdiNome.Text;
            listaDeCompras.Quantidade = int.Parse(txbEdiQuantidade.Text);
            listaDeCompras.Prioridade = cmbEdiPrio.Text;


            //Editar:
            if (listaDeCompras.Editar() == true)
            {
                MessageBox.Show("Usuario modiifcado!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvLista.DataSource = listaDeCompras.ListarTudo();
            }
            else
            {
                MessageBox.Show("falha ao modiifcar!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            {
                // Instanciar o usuário:
                Classe.ListaDeCompras listaDeCompras = new Classe.ListaDeCompras();
                // Obter os valores dos campos:
                listaDeCompras.Nome_item = txbNome.Text;
                listaDeCompras.Quantidade = int.Parse(txbQuantidade.Text); ;
                listaDeCompras.Prioridade = (cmbPrioridade.Text);

                if (listaDeCompras.Inserir() == true)
                {
                    MessageBox.Show("Produto cadastrado com sucesso!");
                    // Limpar os campos:
                    txbNome.Clear();
                    txbQuantidade.Clear();

                    // Atualizar o dgv:
                    dgvLista.DataSource = listaDeCompras.ListarTudo();
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar o produto!");
                }
            }
    }

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

