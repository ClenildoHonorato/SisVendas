namespace SisVendas
{
    partial class frm_Produtos
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
            this.Descrição = new System.Windows.Forms.Label();
            this.txtDescricaoProdutos = new System.Windows.Forms.TextBox();
            this.txtValorProdutos = new System.Windows.Forms.TextBox();
            this.Valor = new System.Windows.Forms.Label();
            this.Categoria = new System.Windows.Forms.Label();
            this.cbCategoriaProdutos = new System.Windows.Forms.ComboBox();
            this.btnNovoProdutos = new System.Windows.Forms.Button();
            this.btnCadastrarProdutos = new System.Windows.Forms.Button();
            this.btnExcluirProdutos = new System.Windows.Forms.Button();
            this.btnCancelarProdutos = new System.Windows.Forms.Button();
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // Descrição
            // 
            this.Descrição.AutoSize = true;
            this.Descrição.Location = new System.Drawing.Point(3, 18);
            this.Descrição.Name = "Descrição";
            this.Descrição.Size = new System.Drawing.Size(55, 13);
            this.Descrição.TabIndex = 0;
            this.Descrição.Text = "Descrição";
            // 
            // txtDescricaoProdutos
            // 
            this.txtDescricaoProdutos.Location = new System.Drawing.Point(59, 12);
            this.txtDescricaoProdutos.Name = "txtDescricaoProdutos";
            this.txtDescricaoProdutos.Size = new System.Drawing.Size(116, 20);
            this.txtDescricaoProdutos.TabIndex = 1;
            // 
            // txtValorProdutos
            // 
            this.txtValorProdutos.Location = new System.Drawing.Point(233, 10);
            this.txtValorProdutos.Name = "txtValorProdutos";
            this.txtValorProdutos.Size = new System.Drawing.Size(116, 20);
            this.txtValorProdutos.TabIndex = 3;
            // 
            // Valor
            // 
            this.Valor.AutoSize = true;
            this.Valor.Location = new System.Drawing.Point(200, 17);
            this.Valor.Name = "Valor";
            this.Valor.Size = new System.Drawing.Size(31, 13);
            this.Valor.TabIndex = 2;
            this.Valor.Text = "Valor";
            // 
            // Categoria
            // 
            this.Categoria.AutoSize = true;
            this.Categoria.Location = new System.Drawing.Point(370, 19);
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(52, 13);
            this.Categoria.TabIndex = 4;
            this.Categoria.Text = "Categoria";
            // 
            // cbCategoriaProdutos
            // 
            this.cbCategoriaProdutos.FormattingEnabled = true;
            this.cbCategoriaProdutos.Location = new System.Drawing.Point(425, 10);
            this.cbCategoriaProdutos.Name = "cbCategoriaProdutos";
            this.cbCategoriaProdutos.Size = new System.Drawing.Size(121, 21);
            this.cbCategoriaProdutos.TabIndex = 5;
            // 
            // btnNovoProdutos
            // 
            this.btnNovoProdutos.Location = new System.Drawing.Point(92, 64);
            this.btnNovoProdutos.Name = "btnNovoProdutos";
            this.btnNovoProdutos.Size = new System.Drawing.Size(75, 23);
            this.btnNovoProdutos.TabIndex = 6;
            this.btnNovoProdutos.Text = "Novo";
            this.btnNovoProdutos.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarProdutos
            // 
            this.btnCadastrarProdutos.Location = new System.Drawing.Point(184, 64);
            this.btnCadastrarProdutos.Name = "btnCadastrarProdutos";
            this.btnCadastrarProdutos.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarProdutos.TabIndex = 7;
            this.btnCadastrarProdutos.Text = "Cadastrar";
            this.btnCadastrarProdutos.UseVisualStyleBackColor = true;
            // 
            // btnExcluirProdutos
            // 
            this.btnExcluirProdutos.Location = new System.Drawing.Point(274, 64);
            this.btnExcluirProdutos.Name = "btnExcluirProdutos";
            this.btnExcluirProdutos.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirProdutos.TabIndex = 8;
            this.btnExcluirProdutos.Text = "Excluir";
            this.btnExcluirProdutos.UseVisualStyleBackColor = true;
            // 
            // btnCancelarProdutos
            // 
            this.btnCancelarProdutos.Location = new System.Drawing.Point(369, 64);
            this.btnCancelarProdutos.Name = "btnCancelarProdutos";
            this.btnCancelarProdutos.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarProdutos.TabIndex = 9;
            this.btnCancelarProdutos.Text = "Cancelar";
            this.btnCancelarProdutos.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProdutos
            // 
            this.dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutos.Location = new System.Drawing.Point(19, 99);
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.Size = new System.Drawing.Size(527, 150);
            this.dataGridViewProdutos.TabIndex = 10;
            // 
            // frm_Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(564, 266);
            this.Controls.Add(this.dataGridViewProdutos);
            this.Controls.Add(this.btnCancelarProdutos);
            this.Controls.Add(this.btnExcluirProdutos);
            this.Controls.Add(this.btnCadastrarProdutos);
            this.Controls.Add(this.btnNovoProdutos);
            this.Controls.Add(this.cbCategoriaProdutos);
            this.Controls.Add(this.Categoria);
            this.Controls.Add(this.txtValorProdutos);
            this.Controls.Add(this.Valor);
            this.Controls.Add(this.txtDescricaoProdutos);
            this.Controls.Add(this.Descrição);
            this.Name = "frm_Produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Descrição;
        private System.Windows.Forms.TextBox txtDescricaoProdutos;
        private System.Windows.Forms.TextBox txtValorProdutos;
        private System.Windows.Forms.Label Valor;
        private System.Windows.Forms.Label Categoria;
        private System.Windows.Forms.ComboBox cbCategoriaProdutos;
        private System.Windows.Forms.Button btnNovoProdutos;
        private System.Windows.Forms.Button btnCadastrarProdutos;
        private System.Windows.Forms.Button btnExcluirProdutos;
        private System.Windows.Forms.Button btnCancelarProdutos;
        private System.Windows.Forms.DataGridView dataGridViewProdutos;
    }
}