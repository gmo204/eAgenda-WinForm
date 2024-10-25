namespace eAgenda.Pessoal.WinFormsApp.ModuloContato
{
    partial class TelaContatoForm
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
            label1 = new Label();
            txtId = new TextBox();
            txtNome = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtTelefone = new TextBox();
            label4 = new Label();
            txtCargo = new TextBox();
            label5 = new Label();
            txtEmpresa = new TextBox();
            label6 = new Label();
            btnCancelar = new Button();
            btnGravar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 28);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(88, 25);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(88, 81);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(305, 23);
            txtNome.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 84);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(88, 122);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(305, 23);
            txtEmail.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 125);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(88, 161);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(305, 23);
            txtTelefone.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 164);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 6;
            label4.Text = "Telefone";
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(88, 195);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(119, 23);
            txtCargo.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 198);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 8;
            label5.Text = "Cargo";
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(271, 195);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(122, 23);
            txtEmpresa.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(213, 198);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 10;
            label6.Text = "Empresa";
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(291, 250);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(102, 32);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(172, 250);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(102, 32);
            btnGravar.TabIndex = 6;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // addContatoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 294);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Controls.Add(txtEmpresa);
            Controls.Add(label6);
            Controls.Add(txtCargo);
            Controls.Add(label5);
            Controls.Add(txtTelefone);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "addContatoForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "addContatoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtTelefone;
        private Label label4;
        private TextBox txtCargo;
        private Label label5;
        private TextBox txtEmpresa;
        private Label label6;
        private Button btnCancelar;
        private Button btnGravar;
    }
}