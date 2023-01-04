namespace Escola.UI
{
    partial class EditarProfessor
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
            this.gpB1 = new System.Windows.Forms.GroupBox();
            this.txtNome_Professor = new System.Windows.Forms.TextBox();
            this.txtCod_Disciplina = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblCod_Disciplina = new System.Windows.Forms.Label();
            this.lblNome_Professor = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnfechar = new System.Windows.Forms.Button();
            this.gpB1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpB1
            // 
            this.gpB1.Controls.Add(this.txtNome_Professor);
            this.gpB1.Controls.Add(this.txtCod_Disciplina);
            this.gpB1.Controls.Add(this.btnConfirmar);
            this.gpB1.Controls.Add(this.btnEditar);
            this.gpB1.Controls.Add(this.btnExcluir);
            this.gpB1.Controls.Add(this.lblCod_Disciplina);
            this.gpB1.Controls.Add(this.lblNome_Professor);
            this.gpB1.Location = new System.Drawing.Point(12, 114);
            this.gpB1.Name = "gpB1";
            this.gpB1.Size = new System.Drawing.Size(448, 272);
            this.gpB1.TabIndex = 71;
            this.gpB1.TabStop = false;
            // 
            // txtNome_Professor
            // 
            this.txtNome_Professor.BackColor = System.Drawing.Color.White;
            this.txtNome_Professor.ForeColor = System.Drawing.Color.Black;
            this.txtNome_Professor.Location = new System.Drawing.Point(114, 81);
            this.txtNome_Professor.MaxLength = 50;
            this.txtNome_Professor.Name = "txtNome_Professor";
            this.txtNome_Professor.Size = new System.Drawing.Size(227, 20);
            this.txtNome_Professor.TabIndex = 63;
            // 
            // txtCod_Disciplina
            // 
            this.txtCod_Disciplina.BackColor = System.Drawing.Color.White;
            this.txtCod_Disciplina.ForeColor = System.Drawing.Color.Black;
            this.txtCod_Disciplina.Location = new System.Drawing.Point(114, 135);
            this.txtCod_Disciplina.MaxLength = 50;
            this.txtCod_Disciplina.Name = "txtCod_Disciplina";
            this.txtCod_Disciplina.Size = new System.Drawing.Size(227, 20);
            this.txtCod_Disciplina.TabIndex = 62;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConfirmar.Location = new System.Drawing.Point(296, 219);
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
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditar.Location = new System.Drawing.Point(176, 219);
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
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExcluir.Location = new System.Drawing.Point(48, 219);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 25);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblCod_Disciplina
            // 
            this.lblCod_Disciplina.AutoSize = true;
            this.lblCod_Disciplina.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCod_Disciplina.ForeColor = System.Drawing.Color.White;
            this.lblCod_Disciplina.Location = new System.Drawing.Point(111, 116);
            this.lblCod_Disciplina.Name = "lblCod_Disciplina";
            this.lblCod_Disciplina.Size = new System.Drawing.Size(120, 15);
            this.lblCod_Disciplina.TabIndex = 49;
            this.lblCod_Disciplina.Text = "Código da Disciplina :";
            // 
            // lblNome_Professor
            // 
            this.lblNome_Professor.AutoSize = true;
            this.lblNome_Professor.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNome_Professor.ForeColor = System.Drawing.Color.White;
            this.lblNome_Professor.Location = new System.Drawing.Point(111, 62);
            this.lblNome_Professor.Name = "lblNome_Professor";
            this.lblNome_Professor.Size = new System.Drawing.Size(117, 15);
            this.lblNome_Professor.TabIndex = 50;
            this.lblNome_Professor.Text = "Nome do Professor:";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.White;
            this.txtId.ForeColor = System.Drawing.Color.Black;
            this.txtId.Location = new System.Drawing.Point(19, 88);
            this.txtId.MaxLength = 50;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(141, 20);
            this.txtId.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "Digite o ID do Professor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(133, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 24);
            this.label1.TabIndex = 68;
            this.label1.Text = "Edição do Professor";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPesquisar.Location = new System.Drawing.Point(169, 83);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 25);
            this.btnPesquisar.TabIndex = 67;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnfechar
            // 
            this.btnfechar.BackColor = System.Drawing.Color.Maroon;
            this.btnfechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnfechar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnfechar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnfechar.Location = new System.Drawing.Point(360, 12);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(100, 25);
            this.btnfechar.TabIndex = 66;
            this.btnfechar.Text = "Fechar";
            this.btnfechar.UseVisualStyleBackColor = false;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // EditarProfessor
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
            this.Name = "EditarProfessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarProfessor";
            this.Load += new System.EventHandler(this.EditarProfessor_Load);
            this.gpB1.ResumeLayout(false);
            this.gpB1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpB1;
        private System.Windows.Forms.TextBox txtCod_Disciplina;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblCod_Disciplina;
        private System.Windows.Forms.Label lblNome_Professor;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.TextBox txtNome_Professor;
    }
}