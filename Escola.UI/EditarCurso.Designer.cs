namespace Escola.UI
{
    partial class EditarCurso
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnfechar = new System.Windows.Forms.Button();
            this.gpB1 = new System.Windows.Forms.GroupBox();
            this.txtCarga_Horaria = new System.Windows.Forms.TextBox();
            this.lblCarga_Horaria = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtNome_Curso = new System.Windows.Forms.TextBox();
            this.lblNome_Curso = new System.Windows.Forms.Label();
            this.gpB1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.White;
            this.txtId.ForeColor = System.Drawing.Color.Black;
            this.txtId.Location = new System.Drawing.Point(19, 88);
            this.txtId.MaxLength = 50;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(112, 20);
            this.txtId.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Digite o ID do Curso:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(149, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Edição do Curso";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(153, 83);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 25);
            this.btnPesquisar.TabIndex = 7;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnfechar
            // 
            this.btnfechar.BackColor = System.Drawing.Color.DarkRed;
            this.btnfechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnfechar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnfechar.ForeColor = System.Drawing.Color.White;
            this.btnfechar.Location = new System.Drawing.Point(358, 11);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(100, 25);
            this.btnfechar.TabIndex = 6;
            this.btnfechar.Text = "Fechar";
            this.btnfechar.UseVisualStyleBackColor = false;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // gpB1
            // 
            this.gpB1.Controls.Add(this.txtCarga_Horaria);
            this.gpB1.Controls.Add(this.lblCarga_Horaria);
            this.gpB1.Controls.Add(this.btnConfirmar);
            this.gpB1.Controls.Add(this.btnEditar);
            this.gpB1.Controls.Add(this.btnExcluir);
            this.gpB1.Controls.Add(this.txtNome_Curso);
            this.gpB1.Controls.Add(this.lblNome_Curso);
            this.gpB1.Location = new System.Drawing.Point(12, 126);
            this.gpB1.Name = "gpB1";
            this.gpB1.Size = new System.Drawing.Size(446, 262);
            this.gpB1.TabIndex = 65;
            this.gpB1.TabStop = false;
            // 
            // txtCarga_Horaria
            // 
            this.txtCarga_Horaria.BackColor = System.Drawing.Color.White;
            this.txtCarga_Horaria.ForeColor = System.Drawing.Color.Black;
            this.txtCarga_Horaria.Location = new System.Drawing.Point(107, 133);
            this.txtCarga_Horaria.MaxLength = 50;
            this.txtCarga_Horaria.Name = "txtCarga_Horaria";
            this.txtCarga_Horaria.Size = new System.Drawing.Size(227, 20);
            this.txtCarga_Horaria.TabIndex = 61;
            // 
            // lblCarga_Horaria
            // 
            this.lblCarga_Horaria.AutoSize = true;
            this.lblCarga_Horaria.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCarga_Horaria.ForeColor = System.Drawing.Color.White;
            this.lblCarga_Horaria.Location = new System.Drawing.Point(104, 114);
            this.lblCarga_Horaria.Name = "lblCarga_Horaria";
            this.lblCarga_Horaria.Size = new System.Drawing.Size(80, 15);
            this.lblCarga_Horaria.TabIndex = 58;
            this.lblCarga_Horaria.Text = "Carga Horaria";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(296, 218);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(100, 25);
            this.btnConfirmar.TabIndex = 12;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(173, 218);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 25);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluir.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(46, 218);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 25);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtNome_Curso
            // 
            this.txtNome_Curso.BackColor = System.Drawing.Color.White;
            this.txtNome_Curso.ForeColor = System.Drawing.Color.Black;
            this.txtNome_Curso.Location = new System.Drawing.Point(107, 69);
            this.txtNome_Curso.MaxLength = 50;
            this.txtNome_Curso.Name = "txtNome_Curso";
            this.txtNome_Curso.Size = new System.Drawing.Size(227, 20);
            this.txtNome_Curso.TabIndex = 2;
            // 
            // lblNome_Curso
            // 
            this.lblNome_Curso.AutoSize = true;
            this.lblNome_Curso.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNome_Curso.ForeColor = System.Drawing.Color.White;
            this.lblNome_Curso.Location = new System.Drawing.Point(105, 50);
            this.lblNome_Curso.Name = "lblNome_Curso";
            this.lblNome_Curso.Size = new System.Drawing.Size(96, 15);
            this.lblNome_Curso.TabIndex = 50;
            this.lblNome_Curso.Text = "Nome do Curso:";
            // 
            // EditarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(470, 400);
            this.Controls.Add(this.gpB1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnfechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarCurso";
            this.Load += new System.EventHandler(this.EditarCurso_Load);
            this.gpB1.ResumeLayout(false);
            this.gpB1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.GroupBox gpB1;
        private System.Windows.Forms.TextBox txtCarga_Horaria;
        private System.Windows.Forms.Label lblCarga_Horaria;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtNome_Curso;
        private System.Windows.Forms.Label lblNome_Curso;
    }
}