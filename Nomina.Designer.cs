﻿namespace PracticaLogin
{
    partial class Nomina
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
            lvNomina = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            columnHeader16 = new ColumnHeader();
            label1 = new Label();
            txtSalario = new TextBox();
            txtHorasEx = new TextBox();
            groupBox1 = new GroupBox();
            btnActHoras = new Button();
            rdNoHE = new RadioButton();
            rdSiHE = new RadioButton();
            groupBox2 = new GroupBox();
            button1 = new Button();
            rdNoAntg = new RadioButton();
            rdSiAntg = new RadioButton();
            txtAntiguedad = new TextBox();
            label2 = new Label();
            groupBox3 = new GroupBox();
            btnActCuo = new Button();
            rdNoCuo = new RadioButton();
            rdSiCuo = new RadioButton();
            txtCuota = new TextBox();
            btnIngresar = new Button();
            btnAgregar = new Button();
            btnActAntSal = new Button();
            rdAntSalNo = new RadioButton();
            rdAntSalSi = new RadioButton();
            txtAntSal = new TextBox();
            groupBox4 = new GroupBox();
            label3 = new Label();
            txtNombre1 = new TextBox();
            button2 = new Button();
            btnVer = new Button();
            groupBox5 = new GroupBox();
            cmbFecha = new ComboBox();
            btnActivar = new Button();
            btnActualizarFecha = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // lvNomina
            // 
            lvNomina.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12, columnHeader13, columnHeader14, columnHeader15, columnHeader16 });
            lvNomina.FullRowSelect = true;
            lvNomina.GridLines = true;
            lvNomina.Location = new Point(5, 71);
            lvNomina.Name = "lvNomina";
            lvNomina.Size = new Size(1516, 334);
            lvNomina.TabIndex = 0;
            lvNomina.UseCompatibleStateImageBehavior = false;
            lvNomina.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nombre";
            columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Salario Basico";
            columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Horas Extras";
            columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Antigüedad";
            columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Salario Bruto";
            columnHeader5.Width = 90;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "INSS Laboral";
            columnHeader6.Width = 90;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "IR";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Cuota Sindical";
            columnHeader8.Width = 90;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Anticipo de Salario";
            columnHeader9.Width = 130;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Total de Deducciones";
            columnHeader10.Width = 130;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Salario Neto";
            columnHeader11.Width = 100;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "INATEC";
            columnHeader12.Width = 90;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "INSS Patronal";
            columnHeader13.Width = 100;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Vacaciones";
            columnHeader14.Width = 90;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "Aguinaldo";
            columnHeader15.Width = 90;
            // 
            // columnHeader16
            // 
            columnHeader16.Text = "Indemnización";
            columnHeader16.Width = 100;
            // 
            // label1
            // 
            label1.Font = new Font("Sitka Small", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(107, 9);
            label1.Name = "label1";
            label1.Size = new Size(1408, 53);
            label1.TabIndex = 1;
            label1.Text = "Nómina Laboral";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(235, 427);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(193, 23);
            txtSalario.TabIndex = 2;
            txtSalario.KeyPress += txtSalario_KeyPress;
            // 
            // txtHorasEx
            // 
            txtHorasEx.Location = new Point(6, 22);
            txtHorasEx.Name = "txtHorasEx";
            txtHorasEx.Size = new Size(100, 24);
            txtHorasEx.TabIndex = 3;
            txtHorasEx.KeyPress += txtHorasEx_KeyPress;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnActHoras);
            groupBox1.Controls.Add(rdNoHE);
            groupBox1.Controls.Add(rdSiHE);
            groupBox1.Controls.Add(txtHorasEx);
            groupBox1.Font = new Font("Sitka Small", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(5, 501);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Horas Extras";
            // 
            // btnActHoras
            // 
            btnActHoras.Cursor = Cursors.Hand;
            btnActHoras.Location = new Point(64, 61);
            btnActHoras.Name = "btnActHoras";
            btnActHoras.Size = new Size(97, 29);
            btnActHoras.TabIndex = 13;
            btnActHoras.Text = "Actualizar";
            btnActHoras.UseVisualStyleBackColor = true;
            btnActHoras.Click += btnActHoras_Click;
            // 
            // rdNoHE
            // 
            rdNoHE.AutoSize = true;
            rdNoHE.Location = new Point(6, 71);
            rdNoHE.Name = "rdNoHE";
            rdNoHE.Size = new Size(46, 23);
            rdNoHE.TabIndex = 12;
            rdNoHE.TabStop = true;
            rdNoHE.Text = "No";
            rdNoHE.UseVisualStyleBackColor = true;
            // 
            // rdSiHE
            // 
            rdSiHE.AutoSize = true;
            rdSiHE.Location = new Point(6, 52);
            rdSiHE.Name = "rdSiHE";
            rdSiHE.Size = new Size(40, 23);
            rdSiHE.TabIndex = 11;
            rdSiHE.TabStop = true;
            rdSiHE.Text = "Si";
            rdSiHE.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(rdNoAntg);
            groupBox2.Controls.Add(rdSiAntg);
            groupBox2.Controls.Add(txtAntiguedad);
            groupBox2.Font = new Font("Sitka Small", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(235, 501);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Antigüedad";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(63, 61);
            button1.Name = "button1";
            button1.Size = new Size(91, 31);
            button1.TabIndex = 16;
            button1.Text = "Actualizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // rdNoAntg
            // 
            rdNoAntg.AutoSize = true;
            rdNoAntg.Location = new Point(5, 73);
            rdNoAntg.Name = "rdNoAntg";
            rdNoAntg.Size = new Size(46, 23);
            rdNoAntg.TabIndex = 15;
            rdNoAntg.TabStop = true;
            rdNoAntg.Text = "No";
            rdNoAntg.UseVisualStyleBackColor = true;
            // 
            // rdSiAntg
            // 
            rdSiAntg.AutoSize = true;
            rdSiAntg.Location = new Point(5, 54);
            rdSiAntg.Name = "rdSiAntg";
            rdSiAntg.Size = new Size(40, 23);
            rdSiAntg.TabIndex = 14;
            rdSiAntg.TabStop = true;
            rdSiAntg.Text = "Si";
            rdSiAntg.UseVisualStyleBackColor = true;
            // 
            // txtAntiguedad
            // 
            txtAntiguedad.Location = new Point(6, 22);
            txtAntiguedad.Name = "txtAntiguedad";
            txtAntiguedad.Size = new Size(100, 24);
            txtAntiguedad.TabIndex = 3;
            txtAntiguedad.KeyPress += txtAntiguedad_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(235, 408);
            label2.Name = "label2";
            label2.Size = new Size(105, 19);
            label2.TabIndex = 7;
            label2.Text = "Salario Básico";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnActCuo);
            groupBox3.Controls.Add(rdNoCuo);
            groupBox3.Controls.Add(rdSiCuo);
            groupBox3.Controls.Add(txtCuota);
            groupBox3.Font = new Font("Sitka Small", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(456, 506);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 100);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Cuota Sindical";
            // 
            // btnActCuo
            // 
            btnActCuo.Cursor = Cursors.Hand;
            btnActCuo.Location = new Point(62, 66);
            btnActCuo.Name = "btnActCuo";
            btnActCuo.Size = new Size(90, 28);
            btnActCuo.TabIndex = 16;
            btnActCuo.Text = "Actualizar";
            btnActCuo.UseVisualStyleBackColor = true;
            btnActCuo.Click += btnActCuo_Click;
            // 
            // rdNoCuo
            // 
            rdNoCuo.AutoSize = true;
            rdNoCuo.Location = new Point(4, 75);
            rdNoCuo.Name = "rdNoCuo";
            rdNoCuo.Size = new Size(46, 23);
            rdNoCuo.TabIndex = 15;
            rdNoCuo.TabStop = true;
            rdNoCuo.Text = "No";
            rdNoCuo.UseVisualStyleBackColor = true;
            // 
            // rdSiCuo
            // 
            rdSiCuo.AutoSize = true;
            rdSiCuo.Location = new Point(4, 56);
            rdSiCuo.Name = "rdSiCuo";
            rdSiCuo.Size = new Size(40, 23);
            rdSiCuo.TabIndex = 14;
            rdSiCuo.TabStop = true;
            rdSiCuo.Text = "Si";
            rdSiCuo.UseVisualStyleBackColor = true;
            // 
            // txtCuota
            // 
            txtCuota.Location = new Point(6, 22);
            txtCuota.Name = "txtCuota";
            txtCuota.Size = new Size(100, 24);
            txtCuota.TabIndex = 3;
            txtCuota.KeyPress += txtCuota_KeyPress;
            // 
            // btnIngresar
            // 
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.Font = new Font("Sitka Small", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresar.Location = new Point(813, 405);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(150, 78);
            btnIngresar.TabIndex = 9;
            btnIngresar.Text = "Ingresar Empleado en la Nómina";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.Font = new Font("Sitka Small", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.Location = new Point(687, 408);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(106, 75);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar Empleado";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActAntSal
            // 
            btnActAntSal.Cursor = Cursors.Hand;
            btnActAntSal.Location = new Point(62, 66);
            btnActAntSal.Name = "btnActAntSal";
            btnActAntSal.Size = new Size(86, 28);
            btnActAntSal.TabIndex = 16;
            btnActAntSal.Text = "Actualizar";
            btnActAntSal.UseVisualStyleBackColor = true;
            btnActAntSal.Click += btnActAntSal_Click;
            // 
            // rdAntSalNo
            // 
            rdAntSalNo.AutoSize = true;
            rdAntSalNo.Location = new Point(4, 75);
            rdAntSalNo.Name = "rdAntSalNo";
            rdAntSalNo.Size = new Size(46, 23);
            rdAntSalNo.TabIndex = 15;
            rdAntSalNo.TabStop = true;
            rdAntSalNo.Text = "No";
            rdAntSalNo.UseVisualStyleBackColor = true;
            // 
            // rdAntSalSi
            // 
            rdAntSalSi.AutoSize = true;
            rdAntSalSi.Location = new Point(4, 56);
            rdAntSalSi.Name = "rdAntSalSi";
            rdAntSalSi.Size = new Size(40, 23);
            rdAntSalSi.TabIndex = 14;
            rdAntSalSi.TabStop = true;
            rdAntSalSi.Text = "Si";
            rdAntSalSi.UseVisualStyleBackColor = true;
            // 
            // txtAntSal
            // 
            txtAntSal.Location = new Point(6, 22);
            txtAntSal.Name = "txtAntSal";
            txtAntSal.Size = new Size(100, 24);
            txtAntSal.TabIndex = 3;
            txtAntSal.KeyPress += txtAntSal_KeyPress;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnActAntSal);
            groupBox4.Controls.Add(rdAntSalNo);
            groupBox4.Controls.Add(rdAntSalSi);
            groupBox4.Controls.Add(txtAntSal);
            groupBox4.Font = new Font("Sitka Small", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.Location = new Point(687, 506);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(200, 100);
            groupBox4.TabIndex = 11;
            groupBox4.TabStop = false;
            groupBox4.Text = "Anticipo de Salario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 408);
            label3.Name = "label3";
            label3.Size = new Size(154, 19);
            label3.TabIndex = 13;
            label3.Text = "Nombre del Empleado";
            // 
            // txtNombre1
            // 
            txtNombre1.Location = new Point(12, 427);
            txtNombre1.Name = "txtNombre1";
            txtNombre1.Size = new Size(193, 23);
            txtNombre1.TabIndex = 12;
            // 
            // button2
            // 
            button2.Location = new Point(1514, 536);
            button2.Name = "button2";
            button2.Size = new Size(103, 57);
            button2.TabIndex = 14;
            button2.Text = "Volver a Principal";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnVer
            // 
            btnVer.Cursor = Cursors.Hand;
            btnVer.Font = new Font("Sitka Small", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnVer.Location = new Point(924, 528);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(112, 67);
            btnVer.TabIndex = 15;
            btnVer.Text = "Ver Archivo";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(cmbFecha);
            groupBox5.Controls.Add(btnActivar);
            groupBox5.Controls.Add(btnActualizarFecha);
            groupBox5.Font = new Font("Sitka Small", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox5.Location = new Point(441, 405);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(220, 100);
            groupBox5.TabIndex = 17;
            groupBox5.TabStop = false;
            groupBox5.Text = "Tipo de Fecha de Nómina";
            // 
            // cmbFecha
            // 
            cmbFecha.Cursor = Cursors.Hand;
            cmbFecha.FormattingEnabled = true;
            cmbFecha.Items.AddRange(new object[] { "Anual", "Mensual" });
            cmbFecha.Location = new Point(9, 28);
            cmbFecha.Name = "cmbFecha";
            cmbFecha.Size = new Size(191, 27);
            cmbFecha.TabIndex = 19;
            cmbFecha.Text = "-Tipo Fecha-";
            // 
            // btnActivar
            // 
            btnActivar.Cursor = Cursors.Hand;
            btnActivar.Location = new Point(117, 64);
            btnActivar.Name = "btnActivar";
            btnActivar.Size = new Size(83, 30);
            btnActivar.TabIndex = 18;
            btnActivar.Text = "Cambiar";
            btnActivar.UseVisualStyleBackColor = true;
            btnActivar.Click += btnActivar_Click;
            // 
            // btnActualizarFecha
            // 
            btnActualizarFecha.Cursor = Cursors.Hand;
            btnActualizarFecha.Location = new Point(15, 64);
            btnActualizarFecha.Name = "btnActualizarFecha";
            btnActualizarFecha.Size = new Size(93, 30);
            btnActualizarFecha.TabIndex = 17;
            btnActualizarFecha.Text = "Actualizar";
            btnActualizarFecha.UseVisualStyleBackColor = true;
            btnActualizarFecha.Click += btnActualizarFecha_Click;
            // 
            // Nomina
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 618);
            Controls.Add(groupBox5);
            Controls.Add(btnVer);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(txtNombre1);
            Controls.Add(groupBox4);
            Controls.Add(btnAgregar);
            Controls.Add(btnIngresar);
            Controls.Add(groupBox3);
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtSalario);
            Controls.Add(label1);
            Controls.Add(lvNomina);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Nomina";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nomina";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvNomina;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader16;
        private Label label1;
        private TextBox txtSalario;
        private TextBox txtHorasEx;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtAntiguedad;
        private Label label2;
        private GroupBox groupBox3;
        private TextBox txtCuota;
        private Button btnIngresar;
        private Button btnAgregar;
        private RadioButton rdSiHE;
        private RadioButton rdNoHE;
        private Button btnActHoras;
        private Button button1;
        private RadioButton rdNoAntg;
        private RadioButton rdSiAntg;
        private Button btnActCuo;
        private RadioButton rdNoCuo;
        private RadioButton rdSiCuo;
        private Button btnActAntSal;
        private RadioButton rdAntSalNo;
        private RadioButton rdAntSalSi;
        private TextBox txtAntSal;
        private GroupBox groupBox4;
        private Label label3;
        private TextBox txtNombre1;
        private Button button2;
        private Button btnVer;
        private GroupBox groupBox5;
        private Button btnActualizarFecha;
        private Button btnActivar;
        private ComboBox cmbFecha;
    }
}