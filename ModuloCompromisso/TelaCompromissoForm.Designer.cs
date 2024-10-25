namespace eAgenda.Pessoal.WinFormsApp.ModuloCompromisso
{
    partial class TelaCompromissoForm
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

        private void InitializeComponent()
        {
            label1 = new Label();
            txtId = new TextBox();
            txtAssunto = new TextBox();
            label2 = new Label();
            txtTermino = new Label();
            btnCancelar = new Button();
            btnGravar = new Button();
            dateData = new DateTimePicker();
            timeInicio = new DateTimePicker();
            timeTermino = new DateTimePicker();
            label4 = new Label();
            txtData = new Label();
            txtInicio = new Label();
            boxContatos = new ComboBox();
            groupBox1 = new GroupBox();
            txtLocal = new TextBox();
            txtLink = new TextBox();
            rdbPresencial = new RadioButton();
            rdbRemoto = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(137, 12);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(172, 9);
            txtId.Name = "txtId";
            txtId.Size = new Size(28, 23);
            txtId.TabIndex = 1;
            // 
            // txtAssunto
            // 
            txtAssunto.Location = new Point(71, 47);
            txtAssunto.Name = "txtAssunto";
            txtAssunto.Size = new Size(257, 23);
            txtAssunto.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 2;
            label2.Text = "Assunto";
            // 
            // txtTermino
            // 
            txtTermino.AutoSize = true;
            txtTermino.Location = new Point(174, 126);
            txtTermino.Name = "txtTermino";
            txtTermino.Size = new Size(50, 15);
            txtTermino.TabIndex = 10;
            txtTermino.Text = "Termino";
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(262, 372);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(102, 32);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(154, 372);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(102, 32);
            btnGravar.TabIndex = 7;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // dateData
            // 
            dateData.CustomFormat = "dd/MM/yyyy";
            dateData.Format = DateTimePickerFormat.Short;
            dateData.Location = new Point(71, 84);
            dateData.Name = "dateData";
            dateData.Size = new Size(100, 23);
            dateData.TabIndex = 2;
            // 
            // timeInicio
            // 
            timeInicio.CustomFormat = "HH:mm";
            timeInicio.Format = DateTimePickerFormat.Custom;
            timeInicio.Location = new Point(71, 120);
            timeInicio.Name = "timeInicio";
            timeInicio.ShowUpDown = true;
            timeInicio.Size = new Size(83, 23);
            timeInicio.TabIndex = 3;
            // 
            // timeTermino
            // 
            timeTermino.CustomFormat = "HH:mm";
            timeTermino.Format = DateTimePickerFormat.Custom;
            timeTermino.Location = new Point(240, 120);
            timeTermino.Name = "timeTermino";
            timeTermino.ShowUpDown = true;
            timeTermino.Size = new Size(88, 23);
            timeTermino.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 175);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 14;
            label4.Text = "Contato";
            // 
            // txtData
            // 
            txtData.AutoSize = true;
            txtData.Location = new Point(23, 90);
            txtData.Name = "txtData";
            txtData.Size = new Size(31, 15);
            txtData.TabIndex = 15;
            txtData.Text = "Data";
            // 
            // txtInicio
            // 
            txtInicio.AutoSize = true;
            txtInicio.Location = new Point(18, 126);
            txtInicio.Name = "txtInicio";
            txtInicio.Size = new Size(36, 15);
            txtInicio.TabIndex = 16;
            txtInicio.Text = "Inicio";
            // 
            // boxContatos
            // 
            boxContatos.DropDownStyle = ComboBoxStyle.DropDownList;
            boxContatos.FormattingEnabled = true;
            boxContatos.Location = new Point(127, 172);
            boxContatos.Name = "boxContatos";
            boxContatos.Size = new Size(121, 23);
            boxContatos.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtLocal);
            groupBox1.Controls.Add(txtLink);
            groupBox1.Controls.Add(rdbPresencial);
            groupBox1.Controls.Add(rdbRemoto);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(18, 229);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(346, 102);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Localização";
            // 
            // txtLocal
            // 
            txtLocal.Enabled = false;
            txtLocal.Location = new Point(120, 69);
            txtLocal.Name = "txtLocal";
            txtLocal.Size = new Size(213, 27);
            txtLocal.TabIndex = 2;
            // 
            // txtLink
            // 
            txtLink.Location = new Point(120, 36);
            txtLink.Name = "txtLink";
            txtLink.Size = new Size(213, 27);
            txtLink.TabIndex = 1;
            // 
            // rdbPresencial
            // 
            rdbPresencial.AutoSize = true;
            rdbPresencial.Font = new Font("Segoe UI", 9F);
            rdbPresencial.Location = new Point(18, 70);
            rdbPresencial.Name = "rdbPresencial";
            rdbPresencial.Size = new Size(81, 19);
            rdbPresencial.TabIndex = 0;
            rdbPresencial.TabStop = true;
            rdbPresencial.Text = "Presencial:";
            rdbPresencial.UseVisualStyleBackColor = true;
            rdbPresencial.CheckedChanged += rdbPresencial_CheckedChanged;
            // 
            // rdbRemoto
            // 
            rdbRemoto.AutoSize = true;
            rdbRemoto.Checked = true;
            rdbRemoto.Font = new Font("Segoe UI", 9F);
            rdbRemoto.Location = new Point(15, 37);
            rdbRemoto.Name = "rdbRemoto";
            rdbRemoto.Size = new Size(70, 19);
            rdbRemoto.TabIndex = 0;
            rdbRemoto.TabStop = true;
            rdbRemoto.Text = "Remoto:";
            rdbRemoto.UseVisualStyleBackColor = true;
            rdbRemoto.CheckedChanged += rdbRemoto_CheckedChanged;
            // 
            // TelaCompromissoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 416);
            Controls.Add(groupBox1);
            Controls.Add(boxContatos);
            Controls.Add(txtInicio);
            Controls.Add(txtData);
            Controls.Add(label4);
            Controls.Add(timeTermino);
            Controls.Add(timeInicio);
            Controls.Add(dateData);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Controls.Add(txtTermino);
            Controls.Add(txtAssunto);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "TelaCompromissoForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "addContatoForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private TextBox txtId;
        private TextBox txtAssunto;
        private Label label2;
        private TextBox txtTelefone;
        private Label label4;
        private TextBox txtCargo;
        private Label label5;
        private TextBox txtEmpresa;
        private Label txtTermino;
        private Button btnCancelar;
        private Button btnGravar;
        private DateTimePicker dateData;
        private DateTimePicker timeInicio;
        private DateTimePicker timeTermino;
        private Label txtData;
        private Label txtInicio;
        private ComboBox boxContatos;
        private GroupBox groupBox1;
        private TextBox txtLocal;
        private TextBox txtLink;
        private RadioButton rdbPresencial;
        private RadioButton rdbRemoto;
    }
}
