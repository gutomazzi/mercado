namespace mercado
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidepanel = new System.Windows.Forms.Panel();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnprodutos = new System.Windows.Forms.Button();
            this.btncaixa = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.caixa_Control1 = new mercado.Caixa_Control();
            this.produtos_Control1 = new mercado.Produtos_Control();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.sidepanel);
            this.panel1.Controls.Add(this.btnsair);
            this.panel1.Controls.Add(this.btnprodutos);
            this.panel1.Controls.Add(this.btncaixa);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(77, 529);
            this.panel1.TabIndex = 0;
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.sidepanel.Location = new System.Drawing.Point(9, 22);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(10, 36);
            this.sidepanel.TabIndex = 1;
            // 
            // btnsair
            // 
            this.btnsair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsair.Image = global::mercado.Properties.Resources.sair;
            this.btnsair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsair.Location = new System.Drawing.Point(21, 129);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(53, 36);
            this.btnsair.TabIndex = 2;
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btnprodutos
            // 
            this.btnprodutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprodutos.Image = global::mercado.Properties.Resources.lista_de_controle;
            this.btnprodutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnprodutos.Location = new System.Drawing.Point(21, 76);
            this.btnprodutos.Name = "btnprodutos";
            this.btnprodutos.Size = new System.Drawing.Size(53, 36);
            this.btnprodutos.TabIndex = 1;
            this.btnprodutos.UseVisualStyleBackColor = true;
            this.btnprodutos.Click += new System.EventHandler(this.btnprodutos_Click);
            // 
            // btncaixa
            // 
            this.btncaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncaixa.Image = global::mercado.Properties.Resources.caixa_registradora__4_;
            this.btncaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncaixa.Location = new System.Drawing.Point(21, 22);
            this.btncaixa.Name = "btncaixa";
            this.btncaixa.Size = new System.Drawing.Size(53, 36);
            this.btncaixa.TabIndex = 0;
            this.btncaixa.UseVisualStyleBackColor = true;
            this.btncaixa.Click += new System.EventHandler(this.btncaixa_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1057, 18);
            this.panel3.TabIndex = 1;
            // 
            // caixa_Control1
            // 
            this.caixa_Control1.Location = new System.Drawing.Point(80, 17);
            this.caixa_Control1.Name = "caixa_Control1";
            this.caixa_Control1.Size = new System.Drawing.Size(963, 463);
            this.caixa_Control1.TabIndex = 3;
            this.caixa_Control1.Load += new System.EventHandler(this.caixa_Control1_Load);
            // 
            // produtos_Control1
            // 
            this.produtos_Control1.Location = new System.Drawing.Point(80, 17);
            this.produtos_Control1.Name = "produtos_Control1";
            this.produtos_Control1.Size = new System.Drawing.Size(963, 463);
            this.produtos_Control1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 492);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.caixa_Control1);
            this.Controls.Add(this.produtos_Control1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btncaixa;
        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnprodutos;
        private System.Windows.Forms.Panel panel3;
        private Produtos_Control produtos_Control1;
        private Caixa_Control caixa_Control1;
    }
}

