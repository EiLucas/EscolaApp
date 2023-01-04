namespace Escola.UI
{
    partial class CadastrarDiciplina
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
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Nome_Disciplina = new System.Windows.Forms.Label();
            this.lblHorario_Disciplina = new System.Windows.Forms.Label();
            this.txtDisciplina = new System.Windows.Forms.TextBox();
            this.txtHorario_Disciplina = new System.Windows.Forms.TextBox();
            this.txtHorario_Termino = new System.Windows.Forms.TextBox();
            this.lblHorario_Termino = new System.Windows.Forms.Label();
            this.txtCod_Periodo = new System.Windows.Forms.TextBox();
            this.lblCod_Aluno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Maroon;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(396, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(86, 33);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(53, 335);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(89, 33);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(353, 335);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 33);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cadastramento de Disciplina";
            // 
            // lbl_Nome_Disciplina
            // 
            this.lbl_Nome_Disciplina.AutoSize = true;
            this.lbl_Nome_Disciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nome_Disciplina.ForeColor = System.Drawing.Color.White;
            this.lbl_Nome_Disciplina.Location = new System.Drawing.Point(50, 156);
            this.lbl_Nome_Disciplina.Name = "lbl_Nome_Disciplina";
            this.lbl_Nome_Disciplina.Size = new System.Drawing.Size(144, 16);
            this.lbl_Nome_Disciplina.TabIndex = 4;
            this.lbl_Nome_Disciplina.Text = "Nome da Disciplina";
            // 
            // lblHorario_Disciplina
            // 
            this.lblHorario_Disciplina.AutoSize = true;
            this.lblHorario_Disciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario_Disciplina.ForeColor = System.Drawing.Color.White;
            this.lblHorario_Disciplina.Location = new System.Drawing.Point(50, 226);
            this.lblHorario_Disciplina.Name = "lblHorario_Disciplina";
            this.lblHorario_Disciplina.Size = new System.Drawing.Size(123, 16);
            this.lblHorario_Disciplina.TabIndex = 5;
            this.lblHorario_Disciplina.Text = "Horário de início";
            // 
            // txtDisciplina
            // 
            this.txtDisciplina.BackColor = System.Drawing.Color.White;
            this.txtDisciplina.ForeColor = System.Drawing.Color.Black;
            this.txtDisciplina.Location = new System.Drawing.Point(53, 175);
            this.txtDisciplina.Name = "txtDisciplina";
            this.txtDisciplina.Size = new System.Drawing.Size(180, 20);
            this.txtDisciplina.TabIndex = 8;
            // 
            // txtHorario_Disciplina
            // 
            this.txtHorario_Disciplina.BackColor = System.Drawing.Color.White;
            this.txtHorario_Disciplina.ForeColor = System.Drawing.Color.Black;
            this.txtHorario_Disciplina.Location = new System.Drawing.Point(53, 245);
            this.txtHorario_Disciplina.Name = "txtHorario_Disciplina";
            this.txtHorario_Disciplina.Size = new System.Drawing.Size(180, 20);
            this.txtHorario_Disciplina.TabIndex = 9;
            // 
            // txtHorario_Termino
            // 
            this.txtHorario_Termino.BackColor = System.Drawing.Color.White;
            this.txtHorario_Termino.ForeColor = System.Drawing.Color.Black;
            this.txtHorario_Termino.Location = new System.Drawing.Point(258, 175);
            this.txtHorario_Termino.Name = "txtHorario_Termino";
            this.txtHorario_Termino.Size = new System.Drawing.Size(177, 20);
            this.txtHorario_Termino.TabIndex = 11;
            // 
            // lblHorario_Termino
            // 
            this.lblHorario_Termino.AutoSize = true;
            this.lblHorario_Termino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario_Termino.ForeColor = System.Drawing.Color.White;
            this.lblHorario_Termino.Location = new System.Drawing.Point(256, 156);
            this.lblHorario_Termino.Name = "lblHorario_Termino";
            this.lblHorario_Termino.Size = new System.Drawing.Size(137, 16);
            this.lblHorario_Termino.TabIndex = 10;
            this.lblHorario_Termino.Text = "Horário de término";
            // 
            // txtCod_Periodo
            // 
            this.txtCod_Periodo.BackColor = System.Drawing.Color.White;
            this.txtCod_Periodo.ForeColor = System.Drawing.Color.Black;
            this.txtCod_Periodo.Location = new System.Drawing.Point(258, 245);
            this.txtCod_Periodo.Name = "txtCod_Periodo";
            this.txtCod_Periodo.Size = new System.Drawing.Size(177, 20);
            this.txtCod_Periodo.TabIndex = 13;
            // 
            // lblCod_Aluno
            // 
            this.lblCod_Aluno.AutoSize = true;
            this.lblCod_Aluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod_Aluno.ForeColor = System.Drawing.Color.White;
            this.lblCod_Aluno.Location = new System.Drawing.Point(255, 226);
            this.lblCod_Aluno.Name = "lblCod_Aluno";
            this.lblCod_Aluno.Size = new System.Drawing.Size(138, 16);
            this.lblCod_Aluno.TabIndex = 12;
            this.lblCod_Aluno.Text = "Código do período";
            // 
            // CadastrarDiciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(494, 408);
            this.Controls.Add(this.txtCod_Periodo);
            this.Controls.Add(this.lblCod_Aluno);
            this.Controls.Add(this.txtHorario_Termino);
            this.Controls.Add(this.lblHorario_Termino);
            this.Controls.Add(this.txtHorario_Disciplina);
            this.Controls.Add(this.txtDisciplina);
            this.Controls.Add(this.lblHorario_Disciplina);
            this.Controls.Add(this.lbl_Nome_Disciplina);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnFechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastrarDiciplina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar_Diciplina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Nome_Disciplina;
        private System.Windows.Forms.Label lblHorario_Disciplina;
        private System.Windows.Forms.TextBox txtDisciplina;
        private System.Windows.Forms.TextBox txtHorario_Disciplina;
        private System.Windows.Forms.TextBox txtHorario_Termino;
        private System.Windows.Forms.Label lblHorario_Termino;
        private System.Windows.Forms.TextBox txtCod_Periodo;
        private System.Windows.Forms.Label lblCod_Aluno;
    }
}