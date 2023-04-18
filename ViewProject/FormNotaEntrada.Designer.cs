
namespace ViewProject
{
    partial class FormNotaEntrada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRemoverProdutoComprado = new System.Windows.Forms.Button();
            this.btnCancelarProdutoComprado = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btnGravarProdutoComprado = new System.Windows.Forms.Button();
            this.btnNovoProdutoComprado = new System.Windows.Forms.Button();
            this.txtIDProdutoComprado = new System.Windows.Forms.TextBox();
            this.txtCustoProdutoComprado = new System.Windows.Forms.TextBox();
            this.cboxProdutoComprado = new System.Windows.Forms.ComboBox();
            this.txtQuantidadeProdutoComprado = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvNotasEntrada = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRemoverNota = new System.Windows.Forms.Button();
            this.btnCancelarNota = new System.Windows.Forms.Button();
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnGravarNota = new System.Windows.Forms.Button();
            this.btnNovoNota = new System.Windows.Forms.Button();
            this.txtIDNotaEntrada = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.cboxFornecedor = new System.Windows.Forms.ComboBox();
            this.dtpEmissao = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotasEntrada)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvProdutos);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.dgvNotasEntrada);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(7, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 442);
            this.panel1.TabIndex = 0;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(407, 247);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(381, 172);
            this.dgvProdutos.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel4);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(405, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(383, 235);
            this.panel4.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.label10, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.txtIDProdutoComprado, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtCustoProdutoComprado, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.cboxProdutoComprado, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.txtQuantidadeProdutoComprado, 1, 3);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(5, 49);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 6;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.16981F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.83019F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(378, 186);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.btnRemoverProdutoComprado, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnCancelarProdutoComprado, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(192, 125);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(183, 57);
            this.tableLayoutPanel5.TabIndex = 11;
            // 
            // btnRemoverProdutoComprado
            // 
            this.btnRemoverProdutoComprado.Enabled = false;
            this.btnRemoverProdutoComprado.Location = new System.Drawing.Point(94, 3);
            this.btnRemoverProdutoComprado.Name = "btnRemoverProdutoComprado";
            this.btnRemoverProdutoComprado.Size = new System.Drawing.Size(75, 23);
            this.btnRemoverProdutoComprado.TabIndex = 1;
            this.btnRemoverProdutoComprado.Text = "Remover";
            this.btnRemoverProdutoComprado.UseVisualStyleBackColor = true;
            this.btnRemoverProdutoComprado.Click += new System.EventHandler(this.btnRemoverProdutoComprado_Click);
            // 
            // btnCancelarProdutoComprado
            // 
            this.btnCancelarProdutoComprado.Enabled = false;
            this.btnCancelarProdutoComprado.Location = new System.Drawing.Point(3, 3);
            this.btnCancelarProdutoComprado.Name = "btnCancelarProdutoComprado";
            this.btnCancelarProdutoComprado.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarProdutoComprado.TabIndex = 0;
            this.btnCancelarProdutoComprado.Text = "Cancelar";
            this.btnCancelarProdutoComprado.UseVisualStyleBackColor = true;
            this.btnCancelarProdutoComprado.Click += new System.EventHandler(this.btnCancelarProdutoComprado_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Id:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Produto:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Custo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Quantidade:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 8);
            this.label10.TabIndex = 4;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.btnGravarProdutoComprado, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnNovoProdutoComprado, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 125);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(183, 58);
            this.tableLayoutPanel6.TabIndex = 5;
            // 
            // btnGravarProdutoComprado
            // 
            this.btnGravarProdutoComprado.Enabled = false;
            this.btnGravarProdutoComprado.Location = new System.Drawing.Point(94, 3);
            this.btnGravarProdutoComprado.Name = "btnGravarProdutoComprado";
            this.btnGravarProdutoComprado.Size = new System.Drawing.Size(75, 23);
            this.btnGravarProdutoComprado.TabIndex = 1;
            this.btnGravarProdutoComprado.Text = "Gravar";
            this.btnGravarProdutoComprado.UseVisualStyleBackColor = true;
            this.btnGravarProdutoComprado.Click += new System.EventHandler(this.btnGravarProdutoComprado_Click);
            // 
            // btnNovoProdutoComprado
            // 
            this.btnNovoProdutoComprado.Location = new System.Drawing.Point(3, 3);
            this.btnNovoProdutoComprado.Name = "btnNovoProdutoComprado";
            this.btnNovoProdutoComprado.Size = new System.Drawing.Size(75, 23);
            this.btnNovoProdutoComprado.TabIndex = 0;
            this.btnNovoProdutoComprado.Text = "Novo";
            this.btnNovoProdutoComprado.UseVisualStyleBackColor = true;
            this.btnNovoProdutoComprado.Click += new System.EventHandler(this.btnNovoProdutoComprado_Click);
            // 
            // txtIDProdutoComprado
            // 
            this.txtIDProdutoComprado.Enabled = false;
            this.txtIDProdutoComprado.Location = new System.Drawing.Point(192, 3);
            this.txtIDProdutoComprado.Name = "txtIDProdutoComprado";
            this.txtIDProdutoComprado.Size = new System.Drawing.Size(179, 20);
            this.txtIDProdutoComprado.TabIndex = 6;
            // 
            // txtCustoProdutoComprado
            // 
            this.txtCustoProdutoComprado.Enabled = false;
            this.txtCustoProdutoComprado.Location = new System.Drawing.Point(192, 58);
            this.txtCustoProdutoComprado.Name = "txtCustoProdutoComprado";
            this.txtCustoProdutoComprado.Size = new System.Drawing.Size(129, 20);
            this.txtCustoProdutoComprado.TabIndex = 7;
            // 
            // cboxProdutoComprado
            // 
            this.cboxProdutoComprado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxProdutoComprado.Enabled = false;
            this.cboxProdutoComprado.FormattingEnabled = true;
            this.cboxProdutoComprado.Items.AddRange(new object[] {
            "Lápis",
            "Caneta",
            "Caderno",
            "Régua",
            "Corretivo",
            "Estojo",
            "Borracha"});
            this.cboxProdutoComprado.Location = new System.Drawing.Point(192, 29);
            this.cboxProdutoComprado.Name = "cboxProdutoComprado";
            this.cboxProdutoComprado.Size = new System.Drawing.Size(176, 21);
            this.cboxProdutoComprado.TabIndex = 8;
            // 
            // txtQuantidadeProdutoComprado
            // 
            this.txtQuantidadeProdutoComprado.Enabled = false;
            this.txtQuantidadeProdutoComprado.Location = new System.Drawing.Point(192, 87);
            this.txtQuantidadeProdutoComprado.Name = "txtQuantidadeProdutoComprado";
            this.txtQuantidadeProdutoComprado.Size = new System.Drawing.Size(129, 20);
            this.txtQuantidadeProdutoComprado.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label12);
            this.panel5.Location = new System.Drawing.Point(5, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(376, 42);
            this.panel5.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(9, 1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(359, 41);
            this.label12.TabIndex = 1;
            this.label12.Text = "Produtos comprados";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvNotasEntrada
            // 
            this.dgvNotasEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotasEntrada.Location = new System.Drawing.Point(6, 246);
            this.dgvNotasEntrada.Name = "dgvNotasEntrada";
            this.dgvNotasEntrada.Size = new System.Drawing.Size(381, 172);
            this.dgvNotasEntrada.TabIndex = 1;
            this.dgvNotasEntrada.SelectionChanged += new System.EventHandler(this.dgvNotasEntrada_SelectionChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 235);
            this.panel2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.dtpEntrada, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtIDNotaEntrada, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNumero, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cboxFornecedor, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpEmissao, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 49);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.16981F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.83019F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(378, 186);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnRemoverNota, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnCancelarNota, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(192, 144);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(183, 39);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // btnRemoverNota
            // 
            this.btnRemoverNota.Location = new System.Drawing.Point(94, 3);
            this.btnRemoverNota.Name = "btnRemoverNota";
            this.btnRemoverNota.Size = new System.Drawing.Size(75, 23);
            this.btnRemoverNota.TabIndex = 1;
            this.btnRemoverNota.Text = "Remover";
            this.btnRemoverNota.UseVisualStyleBackColor = true;
            this.btnRemoverNota.Click += new System.EventHandler(this.btnRemoverNota_Click);
            // 
            // btnCancelarNota
            // 
            this.btnCancelarNota.Location = new System.Drawing.Point(3, 3);
            this.btnCancelarNota.Name = "btnCancelarNota";
            this.btnCancelarNota.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarNota.TabIndex = 0;
            this.btnCancelarNota.Text = "Cancelar";
            this.btnCancelarNota.UseVisualStyleBackColor = true;
            this.btnCancelarNota.Click += new System.EventHandler(this.btnCancelarNota_Click);
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntrada.Location = new System.Drawing.Point(192, 117);
            this.dtpEntrada.Name = "dtpEntrada";
            this.dtpEntrada.Size = new System.Drawing.Size(162, 20);
            this.dtpEntrada.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fornecedor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Emissão:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Entrada:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnGravarNota, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnNovoNota, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 144);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(176, 39);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // btnGravarNota
            // 
            this.btnGravarNota.Location = new System.Drawing.Point(91, 3);
            this.btnGravarNota.Name = "btnGravarNota";
            this.btnGravarNota.Size = new System.Drawing.Size(75, 23);
            this.btnGravarNota.TabIndex = 1;
            this.btnGravarNota.Text = "Gravar";
            this.btnGravarNota.UseVisualStyleBackColor = true;
            this.btnGravarNota.Click += new System.EventHandler(this.btnGravarNota_Click);
            // 
            // btnNovoNota
            // 
            this.btnNovoNota.Location = new System.Drawing.Point(3, 3);
            this.btnNovoNota.Name = "btnNovoNota";
            this.btnNovoNota.Size = new System.Drawing.Size(75, 23);
            this.btnNovoNota.TabIndex = 0;
            this.btnNovoNota.Text = "Novo";
            this.btnNovoNota.UseVisualStyleBackColor = true;
            this.btnNovoNota.Click += new System.EventHandler(this.btnNovoNota_Click);
            // 
            // txtIDNotaEntrada
            // 
            this.txtIDNotaEntrada.Location = new System.Drawing.Point(192, 3);
            this.txtIDNotaEntrada.Name = "txtIDNotaEntrada";
            this.txtIDNotaEntrada.Size = new System.Drawing.Size(179, 20);
            this.txtIDNotaEntrada.TabIndex = 6;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(192, 58);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(176, 20);
            this.txtNumero.TabIndex = 7;
            // 
            // cboxFornecedor
            // 
            this.cboxFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxFornecedor.FormattingEnabled = true;
            this.cboxFornecedor.Items.AddRange(new object[] {
            "Fornecedor A",
            "Fornecedor B",
            "Fornecedor C",
            "Fornecedor D",
            "Fornecedor E"});
            this.cboxFornecedor.Location = new System.Drawing.Point(192, 29);
            this.cboxFornecedor.Name = "cboxFornecedor";
            this.cboxFornecedor.Size = new System.Drawing.Size(176, 21);
            this.cboxFornecedor.TabIndex = 8;
            // 
            // dtpEmissao
            // 
            this.dtpEmissao.AccessibleDescription = "";
            this.dtpEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEmissao.Location = new System.Drawing.Point(192, 87);
            this.dtpEmissao.Name = "dtpEmissao";
            this.dtpEmissao.Size = new System.Drawing.Size(162, 20);
            this.dtpEmissao.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(5, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(376, 42);
            this.panel3.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(359, 41);
            this.label11.TabIndex = 0;
            this.label11.Text = "Corpo da Nota";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormNotaEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormNotaEntrada";
            this.Text = "FormNotaEntrada";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotasEntrada)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvNotasEntrada;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btnRemoverProdutoComprado;
        private System.Windows.Forms.Button btnCancelarProdutoComprado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button btnGravarProdutoComprado;
        private System.Windows.Forms.Button btnNovoProdutoComprado;
        private System.Windows.Forms.TextBox txtIDProdutoComprado;
        private System.Windows.Forms.TextBox txtCustoProdutoComprado;
        private System.Windows.Forms.ComboBox cboxProdutoComprado;
        private System.Windows.Forms.TextBox txtQuantidadeProdutoComprado;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnRemoverNota;
        private System.Windows.Forms.Button btnCancelarNota;
        private System.Windows.Forms.DateTimePicker dtpEntrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnGravarNota;
        private System.Windows.Forms.Button btnNovoNota;
        private System.Windows.Forms.TextBox txtIDNotaEntrada;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.ComboBox cboxFornecedor;
        private System.Windows.Forms.DateTimePicker dtpEmissao;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}