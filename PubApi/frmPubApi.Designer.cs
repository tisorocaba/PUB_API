namespace PubApi
{
    partial class frmPubApi
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edtNumero = new System.Windows.Forms.TextBox();
            this.edtAno = new System.Windows.Forms.TextBox();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.edtChave = new System.Windows.Forms.TextBox();
            this.edtUsuario = new System.Windows.Forms.TextBox();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnModalidade = new System.Windows.Forms.Button();
            this.btnItens = new System.Windows.Forms.Button();
            this.edtUrl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Retorno";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(525, 69);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 16;
            this.btnConsultar.Text = "Publicação";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Número";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ano";
            // 
            // edtNumero
            // 
            this.edtNumero.Location = new System.Drawing.Point(64, 45);
            this.edtNumero.Name = "edtNumero";
            this.edtNumero.Size = new System.Drawing.Size(100, 20);
            this.edtNumero.TabIndex = 11;
            // 
            // edtAno
            // 
            this.edtAno.Location = new System.Drawing.Point(64, 19);
            this.edtAno.Name = "edtAno";
            this.edtAno.Size = new System.Drawing.Size(100, 20);
            this.edtAno.TabIndex = 10;
            // 
            // dgvDados
            // 
            this.dgvDados.BackgroundColor = System.Drawing.Color.White;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(15, 147);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.Size = new System.Drawing.Size(585, 238);
            this.dgvDados.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Chave";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Usuário";
            // 
            // edtChave
            // 
            this.edtChave.Location = new System.Drawing.Point(64, 97);
            this.edtChave.Name = "edtChave";
            this.edtChave.Size = new System.Drawing.Size(100, 20);
            this.edtChave.TabIndex = 22;
            // 
            // edtUsuario
            // 
            this.edtUsuario.Location = new System.Drawing.Point(64, 71);
            this.edtUsuario.Name = "edtUsuario";
            this.edtUsuario.Size = new System.Drawing.Size(100, 20);
            this.edtUsuario.TabIndex = 21;
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(426, 95);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(75, 23);
            this.btnStatus.TabIndex = 25;
            this.btnStatus.Text = "Status";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnModalidade
            // 
            this.btnModalidade.Location = new System.Drawing.Point(525, 95);
            this.btnModalidade.Name = "btnModalidade";
            this.btnModalidade.Size = new System.Drawing.Size(75, 23);
            this.btnModalidade.TabIndex = 26;
            this.btnModalidade.Text = "Modalidade";
            this.btnModalidade.UseVisualStyleBackColor = true;
            this.btnModalidade.Click += new System.EventHandler(this.btnModalidade_Click);
            // 
            // btnItens
            // 
            this.btnItens.Location = new System.Drawing.Point(426, 69);
            this.btnItens.Name = "btnItens";
            this.btnItens.Size = new System.Drawing.Size(75, 23);
            this.btnItens.TabIndex = 27;
            this.btnItens.Text = "Itens";
            this.btnItens.UseVisualStyleBackColor = true;
            this.btnItens.Click += new System.EventHandler(this.btnItens_Click);
            // 
            // edtUrl
            // 
            this.edtUrl.Location = new System.Drawing.Point(221, 19);
            this.edtUrl.Name = "edtUrl";
            this.edtUrl.Size = new System.Drawing.Size(337, 20);
            this.edtUrl.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Url";
            // 
            // frmPubApi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 397);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edtUrl);
            this.Controls.Add(this.btnItens);
            this.Controls.Add(this.btnModalidade);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.edtChave);
            this.Controls.Add(this.edtUsuario);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edtNumero);
            this.Controls.Add(this.edtAno);
            this.Name = "frmPubApi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pub";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtNumero;
        private System.Windows.Forms.TextBox edtAno;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox edtChave;
        private System.Windows.Forms.TextBox edtUsuario;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnModalidade;
        private System.Windows.Forms.Button btnItens;
        private System.Windows.Forms.TextBox edtUrl;
        private System.Windows.Forms.Label label3;
    }
}