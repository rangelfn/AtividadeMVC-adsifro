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
    public partial class FormNotaEntrada : Form
    {
        private NotaEntradaController controller;
        private FornecedorCotroller fornecedorController;
        private ProdutoController produtoController;

        private NotaEntrada notaAtual;

        public FormNotaEntrada(
            NotaEntradaController controller,
            FornecedorCotroller
            fornecedorController,
            ProdutoController produtoController)
        {
            InitializeComponent();
            this.controller = controller;
            this.fornecedorController =
            fornecedorController;
            this.produtoController = produtoController;
            InicializaComboBoxs();
        }

        private void InicializaComboBoxs()
        {
            cboxFornecedor.Items.Clear();
            cboxProdutoComprado.Items.Clear();
            foreach (Fornecedor fornecedor in
            this.fornecedorController.GetAll())
            {
                cboxFornecedor.Items.Add(fornecedor);
            }
            foreach (Produto produto in
            this.produtoController.GetAll())
            {
                cboxProdutoComprado.Items.Add(produto);
            }
        }

        private void btnNovoNota_Click(object sender, EventArgs e)
        {
            ClearControlsNota();


        }

        private void ClearControlsNota()
        {
            dgvNotasEntrada.ClearSelection();
            dgvProdutos.ClearSelection();
            txtIDNotaEntrada.Text = string.Empty;
            cboxFornecedor.SelectedIndex = -1;
            txtNumero.Text = string.Empty;
            dtpEmissao.Value = DateTime.Now;
            dtpEntrada.Value = DateTime.Now;
            cboxFornecedor.Focus();
        }

        private void ClearControlsProduto()
        {
            dgvProdutos.ClearSelection();
            dgvNotasEntrada.ClearSelection();
            txtIDProdutoComprado.Text = string.Empty;
            cboxProdutoComprado.SelectedIndex = -1;
            txtCustoProdutoComprado.Text = string.Empty;
            txtQuantidadeProdutoComprado.Text = string.Empty;

            cboxProdutoComprado.Focus();
        }

        private void btnGravarNota_Click(object sender, EventArgs e)
        {
            var notaEntrada = new NotaEntrada()
            {
                Id = (txtIDNotaEntrada.Text == string.Empty ? Guid.NewGuid() : new Guid(txtIDNotaEntrada.Text)),
                DataEmissao = dtpEmissao.Value,
                DataEntrada = dtpEntrada.Value,
                FornecedorNota = (Fornecedor)cboxFornecedor.
                SelectedItem,
                Numero = txtNumero.Text
            };
            notaEntrada =
                (txtIDNotaEntrada.Text == string.Empty ? this.controller.
                Insert(notaEntrada) : this.controller.
                Update( notaEntrada));
            dgvNotasEntrada.DataSource = null;
            dgvNotasEntrada.DataSource = this.controller.
            GetAll();
            ClearControlsNota();

        }

        private void btnCancelarNota_Click(object sender, EventArgs e)
        {
            ClearControlsNota();

        }

        private void btnRemoverNota_Click(object sender, EventArgs e)
        {
            if (txtIDNotaEntrada.Text == string.Empty)
            {
                MessageBox.Show(
                "Selecione a NOTA a ser removida no GRID");
            }
            else
            {
                this.controller.Remove(
                new NotaEntrada()
                {
                    Id = new Guid(txtIDNotaEntrada.Text)
                }
                );
                dgvNotasEntrada.DataSource = null;
                dgvNotasEntrada.DataSource =
                this.controller.GetAll();
                ClearControlsNota();
            }

        }

        private void dgvNotasEntrada_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                this.notaAtual = this.controller.
                GetNotaEntradaById((Guid)dgvNotasEntrada.
                CurrentRow.Cells[0].Value);
                txtIDNotaEntrada.Text = notaAtual.Id.
                ToString();
                txtNumero.Text = notaAtual.Numero;
                cboxFornecedor.SelectedItem = notaAtual.
                FornecedorNota;
                dtpEmissao.Value = notaAtual.DataEmissao;
                dtpEntrada.Value = notaAtual.DataEntrada;
                UpdateProdutosGrid();
            }
            catch (Exception exception)
            {
                this.notaAtual = new NotaEntrada();
            }

        }
        private void UpdateProdutosGrid()
        {
            dgvProdutos.DataSource = null;
            if (this.notaAtual.Produtos.Count > 0)
            {
                dgvProdutos.DataSource = this.notaAtual.Produtos;
            }
        }

        private void btnNovoProdutoComprado_Click(object sender, EventArgs e)
        {
            ClearControlsProduto();
            if (txtIDNotaEntrada.Text == string.Empty)
            {
                MessageBox.Show("Selecione a NOTA, que terá " +
                "inserção de produtos, no GRID");
            }
            else
            {
                ChangeStatusOfControls(true);
            }

        }
        //método responsável pela habilitação e desabilitação de controles referentes aos produtos da nota
        private void ChangeStatusOfControls(bool newStatus)
        {
            cboxProdutoComprado.Enabled = newStatus;
            txtCustoProdutoComprado.Enabled = newStatus;
            txtQuantidadeProdutoComprado.Enabled = newStatus;
            btnNovoProdutoComprado.Enabled = !newStatus;
            btnGravarProdutoComprado.Enabled = newStatus;
            btnCancelarProdutoComprado.Enabled = newStatus;
            btnRemoverProdutoComprado.Enabled = newStatus;
        }

        private void btnGravarProdutoComprado_Click(object sender, EventArgs e)
        {
            var produtoNota = new ProdutoNotaEntrada()
            {
                Id = (txtIDProdutoComprado.Text == string.Empty ? Guid.NewGuid() : new Guid(txtIDProdutoComprado.Text)),
                PrecoCustoCompra = Convert.ToDouble(txtCustoProdutoComprado.Text),
                ProdutoNota = (Produto)cboxProdutoComprado.SelectedItem,
                QuantidadeComprada = Convert.ToDouble(txtQuantidadeProdutoComprado.Text)
            };
           
                this.notaAtual.RegistrarProduto(produtoNota);
                this.notaAtual = this.controller.Update(
                this.notaAtual);
                ChangeStatusOfControls(false);
                UpdateProdutosGrid();
                ClearControlsProduto();


        }

        private void btnCancelarProdutoComprado_Click(object sender, EventArgs e)
        {
            ClearControlsProduto();
            ChangeStatusOfControls(false);

        }

        private void btnRemoverProdutoComprado_Click(object sender, EventArgs e)
        {
            this.notaAtual.RemoverProduto(new ProdutoNotaEntrada(){
                Id = new Guid(txtIDProdutoComprado.Text)
            });

            this.controller.Update(this.notaAtual);
            UpdateProdutosGrid();
            ClearControlsProduto();
            ChangeStatusOfControls(false);

        }
    }
}
