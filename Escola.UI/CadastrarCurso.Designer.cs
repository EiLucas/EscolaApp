namespace Escola.UI
{
    partial class CadastrarCurso
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
            this.lblNome_Curso = new System.Windows.Forms.Label();
            this.lblCarga_Horaria = new System.Windows.Forms.Label();
            this.txtNome_Curso = new System.Windows.Forms.TextBox();
            this.txtCarga_Horaria = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Maroon;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(364, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(84, 27);
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
            this.btnCadastrar.Location = new System.Drawing.Point(61, 363);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(93, 27);
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
            this.btnCancelar.Location = new System.Drawing.Point(315, 363);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 27);
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
            this.label1.Location = new System.Drawing.Point(55, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cadastramento de Cursos";
            // 
            // lblNome_Curso
            // 
            this.lblNome_Curso.AutoSize = true;
            this.lblNome_Curso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome_Curso.ForeColor = System.Drawing.Color.White;
            this.lblNome_Curso.Location = new System.Drawing.Point(126, 165);
            this.lblNome_Curso.Name = "lblNome_Curso";
            this.lblNome_Curso.Size = new System.Drawing.Size(115, 16);
            this.lblNome_Curso.TabIndex = 4;
            this.lblNome_Curso.Text = "Nome do Curso";
            // 
            // lblCarga_Horaria
            // 
            this.lblCarga_Horaria.AutoSize = true;
            this.lblCarga_Horaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarga_Horaria.ForeColor = System.Drawing.Color.White;
            this.lblCarga_Horaria.Location = new System.Drawing.Point(126, 241);
            this.lblCarga_Horaria.Name = "lblCarga_Horaria";
            this.lblCarga_Horaria.Size = new System.Drawing.Size(106, 16);
            this.lblCarga_Horaria.TabIndex = 6;
            this.lblCarga_Horaria.Text = "Carga Horaria";
            // 
            // txtNome_Curso
            // 
            this.txtNome_Curso.BackColor = System.Drawing.Color.White;
            this.txtNome_Curso.ForeColor = System.Drawing.Color.Black;
            this.txtNome_Curso.Location = new System.Drawing.Point(129, 184);
            this.txtNome_Curso.Name = "txtNome_Curso";
            this.txtNome_Curso.Size = new System.Drawing.Size(200, 20);
            this.txtNome_Curso.TabIndex = 9;
            // 
            // txtCarga_Horaria
            // 
            this.txtCarga_Horaria.BackColor = System.Drawing.Color.White;
            this.txtCarga_Horaria.ForeColor = System.Drawing.Color.Black;
            this.txtCarga_Horaria.Location = new System.Drawing.Point(129, 260);
            this.txtCarga_Horaria.Name = "txtCarga_Horaria";
            this.txtCarga_Horaria.Size = new System.Drawing.Size(200, 20);
            this.txtCarga_Horaria.TabIndex = 11;
            // 
            // CadastrarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(460, 450);
            this.Controls.Add(this.txtCarga_Horaria);
            this.Controls.Add(this.txtNome_Curso);
            this.Controls.Add(this.lblCarga_Horaria);
            this.Controls.Add(this.lblNome_Curso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnFechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastrarCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar_Curso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNome_Curso;
        private System.Windows.Forms.Label lblCarga_Horaria;
        private System.Windows.Forms.TextBox txtNome_Curso;
        private System.Windows.Forms.TextBox txtCarga_Horaria;
    }
}