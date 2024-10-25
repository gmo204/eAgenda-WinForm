namespace eAgenda.Pessoal.WinFormsApp.ModuloTarefa
{
    partial class TelaTarefaForm
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
            lblPrioridade = new Label();
            lblTitulo = new Label();
            lblDataCriacao = new Label();
            lblDataConclusao = new Label();
            btnOK = new Button();
            button2 = new Button();
            txtTitulo = new TextBox();
            dateCriacao = new DateTimePicker();
            dateConclusao = new DateTimePicker();
            cmbPrioridade = new ComboBox();
            lblId = new Label();
            txtId = new TextBox();
            SuspendLayout();
            // 
            // lblPrioridade
            // 
            lblPrioridade.AutoSize = true;
            lblPrioridade.Location = new Point(200, 36);
            lblPrioridade.Name = "lblPrioridade";
            lblPrioridade.Size = new Size(64, 15);
            lblPrioridade.TabIndex = 0;
            lblPrioridade.Text = "Prioridade:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(30, 90);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(40, 15);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Titulo:";
            // 
            // lblDataCriacao
            // 
            lblDataCriacao.AutoSize = true;
            lblDataCriacao.Location = new Point(30, 137);
            lblDataCriacao.Name = "lblDataCriacao";
            lblDataCriacao.Size = new Size(77, 15);
            lblDataCriacao.TabIndex = 2;
            lblDataCriacao.Text = "Data Criação:";
            // 
            // lblDataConclusao
            // 
            lblDataConclusao.AutoSize = true;
            lblDataConclusao.Location = new Point(223, 137);
            lblDataConclusao.Name = "lblDataConclusao";
            lblDataConclusao.Size = new Size(93, 15);
            lblDataConclusao.TabIndex = 3;
            lblDataConclusao.Text = "Data Conclusão:";
            // 
            // btnOK
            // 
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new Point(232, 220);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(84, 30);
            btnOK.TabIndex = 5;
            btnOK.Text = "Ok";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += button1_Click;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(329, 220);
            button2.Name = "button2";
            button2.Size = new Size(84, 30);
            button2.TabIndex = 4;
            button2.Text = "Cancelar\r\n";
            button2.UseVisualStyleBackColor = true;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(74, 87);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(337, 23);
            txtTitulo.TabIndex = 0;
            // 
            // dateCriacao
            // 
            dateCriacao.CustomFormat = "dd/MM/yyyy";
            dateCriacao.Format = DateTimePickerFormat.Custom;
            dateCriacao.Location = new Point(113, 131);
            dateCriacao.MinDate = new DateTime(2024, 6, 10, 19, 28, 8, 0);
            dateCriacao.Name = "dateCriacao";
            dateCriacao.Size = new Size(88, 23);
            dateCriacao.TabIndex = 2;
            dateCriacao.Value = new DateTime(2024, 6, 10, 19, 28, 8, 0);
            // 
            // dateConclusao
            // 
            dateConclusao.CustomFormat = "dd/MM/yyyy";
            dateConclusao.Format = DateTimePickerFormat.Custom;
            dateConclusao.Location = new Point(322, 131);
            dateConclusao.Name = "dateConclusao";
            dateConclusao.Size = new Size(94, 23);
            dateConclusao.TabIndex = 3;
            // 
            // cmbPrioridade
            // 
            cmbPrioridade.FormattingEnabled = true;
            cmbPrioridade.Location = new Point(270, 33);
            cmbPrioridade.Name = "cmbPrioridade";
            cmbPrioridade.Size = new Size(142, 23);
            cmbPrioridade.TabIndex = 1;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(74, 36);
            lblId.Name = "lblId";
            lblId.Size = new Size(20, 15);
            lblId.TabIndex = 10;
            lblId.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(100, 33);
            txtId.Name = "txtId";
            txtId.Size = new Size(49, 23);
            txtId.TabIndex = 11;
            // 
            // TelaTarefaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 273);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(cmbPrioridade);
            Controls.Add(dateConclusao);
            Controls.Add(dateCriacao);
            Controls.Add(txtTitulo);
            Controls.Add(button2);
            Controls.Add(btnOK);
            Controls.Add(lblDataConclusao);
            Controls.Add(lblDataCriacao);
            Controls.Add(lblTitulo);
            Controls.Add(lblPrioridade);
            Name = "TelaTarefaForm";
            Text = "TelaTarefaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrioridade;
        private Label lblTitulo;
        private Label lblDataCriacao;
        private Label lblDataConclusao;
        private Button btnOK;
        private Button button2;
        private TextBox txtTitulo;
        private DateTimePicker dateCriacao;
        private DateTimePicker dateConclusao;
        private ComboBox cmbPrioridade;
        private Label lblId;
        private TextBox txtId;
    }
}