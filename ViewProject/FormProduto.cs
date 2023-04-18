using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControllerProject;
using ModelProject;

namespace ViewProject
{
    public partial class FormProduto : Form
    {
        private ProdutoController controller;
        public FormProduto(ProdutoController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void btnGravarProduto_Click(object sender, EventArgs e)
        {
            var produto = new Produto()
            {
                Id = (txtIDProduto.Text == string.Empty ? Guid.NewGuid() : new Guid(txtIDProduto.Text)),
                Nome = txtNomeProduto.Text,
                PrecoDeCusto = double.Parse(txtCustoProduto.Text),
                Estoque = double.Parse(txtQuantidadeProduto.Text)
                
            };

            produto = (txtIDProduto.Text == string.Empty ?
                this.controller.Insert(produto) :
                this.controller.Update(produto));
            dgvProdutos.DataSource = null;
            dgvProdutos.DataSource = this.controller.GetAll();
            ClearControls();

        }

        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            ClearControls();

        }

        private void dgvProdutos_SelectionChanged(object sender, EventArgs e)
        {
            dgvProdutos.ClearSelection();
            txtIDProduto.Text = dgvProdutos.CurrentRow.Cells[0].Value.ToString();
            txtNomeProduto.Text = dgvProdutos.CurrentRow.Cells[1].Value.ToString();
            txtCustoProduto.Text = dgvProdutos.CurrentRow.Cells[2].Value.ToString();
            txtQuantidadeProduto.Text = dgvProdutos.CurrentRow.Cells[3].Value.ToString();

        }

        private void ClearControls()
        {
            dgvProdutos.ClearSelection();
            txtIDProduto.Text = string.Empty;
            txtNomeProduto.Text = string.Empty;
            txtCustoProduto.Text = string.Empty;
            txtQuantidadeProduto.Text = string.Empty;
            txtNomeProduto.Focus();
        }

        private void btnRemoverProduto_Click(object sender, EventArgs e)
        {
            if (txtIDProduto.Text == string.Empty)
                MessageBox.Show(
                    "Selecione o PRODUTO a ser removido " +
                    "do GRID");
            else
            {
                this.controller.Remove(
                    new Produto()
                    {
                        Id = new Guid(txtIDProduto.Text)
                    });

                dgvProdutos.DataSource = null;
                dgvProdutos.DataSource =
                    this.controller.GetAll();
                ClearControls();
            }
        }

    }
    
}
