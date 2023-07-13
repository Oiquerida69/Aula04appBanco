namespace Aula04AppBanco
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Depositar = new System.Windows.Forms.Button();
            this.btn_Sacar = new System.Windows.Forms.Button();
            this.lbl_funcao = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ValorDigitado = new System.Windows.Forms.TextBox();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.Btn_Extrato = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_Valor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(56, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wendell\'s Bank";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seu Saldo atual é :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(202)))), ((int)(((byte)(205)))));
            this.panel1.Controls.Add(this.btn_Salvar);
            this.panel1.Controls.Add(this.txt_ValorDigitado);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbl_funcao);
            this.panel1.Controls.Add(this.btn_Sacar);
            this.panel1.Controls.Add(this.btn_Depositar);
            this.panel1.Location = new System.Drawing.Point(60, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 219);
            this.panel1.TabIndex = 3;
            // 
            // btn_Depositar
            // 
            this.btn_Depositar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Depositar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Depositar.Location = new System.Drawing.Point(26, 24);
            this.btn_Depositar.Name = "btn_Depositar";
            this.btn_Depositar.Size = new System.Drawing.Size(103, 49);
            this.btn_Depositar.TabIndex = 0;
            this.btn_Depositar.Text = "Depositar";
            this.btn_Depositar.UseVisualStyleBackColor = false;
            this.btn_Depositar.Click += new System.EventHandler(this.btn_Depositar_Click);
            // 
            // btn_Sacar
            // 
            this.btn_Sacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sacar.Location = new System.Drawing.Point(135, 24);
            this.btn_Sacar.Name = "btn_Sacar";
            this.btn_Sacar.Size = new System.Drawing.Size(101, 49);
            this.btn_Sacar.TabIndex = 1;
            this.btn_Sacar.Text = "Sacar";
            this.btn_Sacar.UseVisualStyleBackColor = true;
            this.btn_Sacar.Click += new System.EventHandler(this.btn_Sacar_Click);
            // 
            // lbl_funcao
            // 
            this.lbl_funcao.AutoSize = true;
            this.lbl_funcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_funcao.Location = new System.Drawing.Point(34, 76);
            this.lbl_funcao.Name = "lbl_funcao";
            this.lbl_funcao.Size = new System.Drawing.Size(79, 17);
            this.lbl_funcao.TabIndex = 2;
            this.lbl_funcao.Text = "DEPÓSITO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Informe o valor";
            // 
            // txt_ValorDigitado
            // 
            this.txt_ValorDigitado.Location = new System.Drawing.Point(41, 117);
            this.txt_ValorDigitado.Name = "txt_ValorDigitado";
            this.txt_ValorDigitado.Size = new System.Drawing.Size(195, 20);
            this.txt_ValorDigitado.TabIndex = 4;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(41, 143);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(195, 23);
            this.btn_Salvar.TabIndex = 5;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // Btn_Extrato
            // 
            this.Btn_Extrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Extrato.Location = new System.Drawing.Point(341, 123);
            this.Btn_Extrato.Name = "Btn_Extrato";
            this.Btn_Extrato.Size = new System.Drawing.Size(75, 23);
            this.Btn_Extrato.TabIndex = 4;
            this.Btn_Extrato.Text = "Ver Extrato";
            this.Btn_Extrato.UseVisualStyleBackColor = true;
            this.Btn_Extrato.Click += new System.EventHandler(this.Btn_Extrato_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Operações Disponiveis";
            // 
            // lbl_Valor
            // 
            this.lbl_Valor.AutoSize = true;
            this.lbl_Valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Valor.Location = new System.Drawing.Point(83, 152);
            this.lbl_Valor.Name = "lbl_Valor";
            this.lbl_Valor.Size = new System.Drawing.Size(15, 16);
            this.lbl_Valor.TabIndex = 6;
            this.lbl_Valor.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "R$";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_Valor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Btn_Extrato);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.TextBox txt_ValorDigitado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_funcao;
        private System.Windows.Forms.Button btn_Sacar;
        private System.Windows.Forms.Button btn_Depositar;
        private System.Windows.Forms.Button Btn_Extrato;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_Valor;
        private System.Windows.Forms.Label label3;
    }
}

