namespace PracticaFinalAdoNetV2
{
    partial class FormPracticaFinalV2
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
            cmbDepartamentos = new ComboBox();
            label2 = new Label();
            txtDeptNum = new TextBox();
            label3 = new Label();
            txtDeptNom = new TextBox();
            txtDeptLoc = new TextBox();
            label4 = new Label();
            btnCrearDepartamento = new Button();
            label5 = new Label();
            lstEmpleados = new ListBox();
            label6 = new Label();
            txtEmpApellido = new TextBox();
            label7 = new Label();
            txtEmpOficio = new TextBox();
            label8 = new Label();
            txtEmpSalario = new TextBox();
            btnUpdateEmpleado = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 29);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 0;
            label1.Text = "Departamentos";
            // 
            // cmbDepartamentos
            // 
            cmbDepartamentos.FormattingEnabled = true;
            cmbDepartamentos.Location = new Point(30, 52);
            cmbDepartamentos.Name = "cmbDepartamentos";
            cmbDepartamentos.Size = new Size(151, 28);
            cmbDepartamentos.TabIndex = 1;
            cmbDepartamentos.SelectedIndexChanged += cmbDepartamentos_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 126);
            label2.Name = "label2";
            label2.Size = new Size(164, 20);
            label2.TabIndex = 2;
            label2.Text = "Departamento Numero";
            // 
            // txtDeptNum
            // 
            txtDeptNum.Location = new Point(30, 149);
            txtDeptNum.Name = "txtDeptNum";
            txtDeptNum.Size = new Size(125, 27);
            txtDeptNum.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 204);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 4;
            label3.Text = "Dept_Nombre";
            // 
            // txtDeptNom
            // 
            txtDeptNom.Location = new Point(30, 227);
            txtDeptNom.Name = "txtDeptNom";
            txtDeptNom.Size = new Size(125, 27);
            txtDeptNom.TabIndex = 5;
            // 
            // txtDeptLoc
            // 
            txtDeptLoc.Location = new Point(30, 307);
            txtDeptLoc.Name = "txtDeptLoc";
            txtDeptLoc.Size = new Size(125, 27);
            txtDeptLoc.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 284);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 7;
            label4.Text = "Localidad";
            // 
            // btnCrearDepartamento
            // 
            btnCrearDepartamento.Location = new Point(30, 371);
            btnCrearDepartamento.Name = "btnCrearDepartamento";
            btnCrearDepartamento.Size = new Size(125, 57);
            btnCrearDepartamento.TabIndex = 8;
            btnCrearDepartamento.Text = "Crear departamento";
            btnCrearDepartamento.UseVisualStyleBackColor = true;
            btnCrearDepartamento.Click += btnCrearDepartamento_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(286, 60);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 9;
            label5.Text = "Empleados";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(286, 94);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(218, 324);
            lstEmpleados.TabIndex = 10;
            lstEmpleados.SelectedIndexChanged += lstEmpleados_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(603, 122);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 11;
            label6.Text = "Apellido";
            // 
            // txtEmpApellido
            // 
            txtEmpApellido.Location = new Point(603, 149);
            txtEmpApellido.Name = "txtEmpApellido";
            txtEmpApellido.Size = new Size(125, 27);
            txtEmpApellido.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(603, 204);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 13;
            label7.Text = "Oficio";
            // 
            // txtEmpOficio
            // 
            txtEmpOficio.Location = new Point(603, 227);
            txtEmpOficio.Name = "txtEmpOficio";
            txtEmpOficio.Size = new Size(125, 27);
            txtEmpOficio.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(603, 284);
            label8.Name = "label8";
            label8.Size = new Size(55, 20);
            label8.TabIndex = 15;
            label8.Text = "Salario";
            // 
            // txtEmpSalario
            // 
            txtEmpSalario.Location = new Point(603, 307);
            txtEmpSalario.Name = "txtEmpSalario";
            txtEmpSalario.Size = new Size(125, 27);
            txtEmpSalario.TabIndex = 16;
            // 
            // btnUpdateEmpleado
            // 
            btnUpdateEmpleado.Location = new Point(603, 354);
            btnUpdateEmpleado.Name = "btnUpdateEmpleado";
            btnUpdateEmpleado.Size = new Size(125, 64);
            btnUpdateEmpleado.TabIndex = 17;
            btnUpdateEmpleado.Text = "Modificar Empelado";
            btnUpdateEmpleado.UseVisualStyleBackColor = true;
            btnUpdateEmpleado.Click += btnUpdateEmpleado_Click;
            // 
            // FormPracticaFinalV2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdateEmpleado);
            Controls.Add(txtEmpSalario);
            Controls.Add(label8);
            Controls.Add(txtEmpOficio);
            Controls.Add(label7);
            Controls.Add(txtEmpApellido);
            Controls.Add(label6);
            Controls.Add(lstEmpleados);
            Controls.Add(label5);
            Controls.Add(btnCrearDepartamento);
            Controls.Add(label4);
            Controls.Add(txtDeptLoc);
            Controls.Add(txtDeptNom);
            Controls.Add(label3);
            Controls.Add(txtDeptNum);
            Controls.Add(label2);
            Controls.Add(cmbDepartamentos);
            Controls.Add(label1);
            Name = "FormPracticaFinalV2";
            Text = "FormPracticaFinalV2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbDepartamentos;
        private Label label2;
        private TextBox txtDeptNum;
        private Label label3;
        private TextBox txtDeptNom;
        private TextBox txtDeptLoc;
        private Label label4;
        private Button btnCrearDepartamento;
        private Label label5;
        private ListBox lstEmpleados;
        private Label label6;
        private TextBox txtEmpApellido;
        private Label label7;
        private TextBox txtEmpOficio;
        private Label label8;
        private TextBox txtEmpSalario;
        private Button btnUpdateEmpleado;
    }
}