﻿namespace ffccSimulacion.ABMCoche
{
    partial class frmABMCoche
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.btnCocheNuevoLimpiar = new System.Windows.Forms.Button();
            this.btnCocheNuevoAceptar = new System.Windows.Forms.Button();
            this.btnCocheNuevoCancelar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCrear = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxTipoConsumo = new System.Windows.Forms.ComboBox();
            this.rndEsLocomotoraNo = new System.Windows.Forms.RadioButton();
            this.txtConsumoParado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtConsumoMov = new System.Windows.Forms.TextBox();
            this.rndEsLocomotoraSi = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMaxReal = new System.Windows.Forms.TextBox();
            this.txtMaxLegal = new System.Windows.Forms.TextBox();
            this.txtCantidadAsientos = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabModificar = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbxCochesModificar = new System.Windows.Forms.ListBox();
            this.tabEliminar = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.btnBorrarCoche = new System.Windows.Forms.Button();
            this.lbxCochesBorrar = new System.Windows.Forms.ListBox();
            this.pnlCoche = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabCrear.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabModificar.SuspendLayout();
            this.tabEliminar.SuspendLayout();
            this.pnlCoche.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modelo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(520, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(381, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 151);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Locomotora";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Electrico",
            "Diesel"});
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Electrico",
            "Disel"});
            this.comboBox1.Location = new System.Drawing.Point(139, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(47, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(39, 17);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "No";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(139, 117);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 20);
            this.textBox3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tipo Consumo";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(139, 81);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 1;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(34, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Si";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Consumo Parado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Consumo en Movimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cantidad de Asientos";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(520, 300);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(200, 20);
            this.textBox4.TabIndex = 1;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(520, 347);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(200, 20);
            this.textBox5.TabIndex = 1;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(520, 393);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(200, 20);
            this.textBox6.TabIndex = 1;
            // 
            // btnCocheNuevoLimpiar
            // 
            this.btnCocheNuevoLimpiar.Location = new System.Drawing.Point(15, 545);
            this.btnCocheNuevoLimpiar.Name = "btnCocheNuevoLimpiar";
            this.btnCocheNuevoLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnCocheNuevoLimpiar.TabIndex = 3;
            this.btnCocheNuevoLimpiar.Text = "Limpiar";
            this.btnCocheNuevoLimpiar.UseVisualStyleBackColor = true;
            this.btnCocheNuevoLimpiar.Click += new System.EventHandler(this.btnCocheNuevoLimpiar_Click);
            // 
            // btnCocheNuevoAceptar
            // 
            this.btnCocheNuevoAceptar.Location = new System.Drawing.Point(633, 545);
            this.btnCocheNuevoAceptar.Name = "btnCocheNuevoAceptar";
            this.btnCocheNuevoAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnCocheNuevoAceptar.TabIndex = 4;
            this.btnCocheNuevoAceptar.Text = "Aceptar";
            this.btnCocheNuevoAceptar.UseVisualStyleBackColor = true;
            this.btnCocheNuevoAceptar.Click += new System.EventHandler(this.btnCocheNuevoAceptar_Click);
            // 
            // btnCocheNuevoCancelar
            // 
            this.btnCocheNuevoCancelar.Location = new System.Drawing.Point(720, 545);
            this.btnCocheNuevoCancelar.Name = "btnCocheNuevoCancelar";
            this.btnCocheNuevoCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCocheNuevoCancelar.TabIndex = 5;
            this.btnCocheNuevoCancelar.Text = "Cancelar";
            this.btnCocheNuevoCancelar.UseVisualStyleBackColor = true;
            this.btnCocheNuevoCancelar.Click += new System.EventHandler(this.btnCocheNuevoCancelar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCrear);
            this.tabControl1.Controls.Add(this.tabModificar);
            this.tabControl1.Controls.Add(this.tabEliminar);
            this.tabControl1.Location = new System.Drawing.Point(15, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(780, 523);
            this.tabControl1.TabIndex = 6;
            // 
            // tabCrear
            // 
            this.tabCrear.Controls.Add(this.groupBox2);
            this.tabCrear.Controls.Add(this.txtMaxReal);
            this.tabCrear.Controls.Add(this.txtMaxLegal);
            this.tabCrear.Controls.Add(this.txtCantidadAsientos);
            this.tabCrear.Controls.Add(this.txtModelo);
            this.tabCrear.Controls.Add(this.label11);
            this.tabCrear.Controls.Add(this.label12);
            this.tabCrear.Controls.Add(this.label13);
            this.tabCrear.Controls.Add(this.label14);
            this.tabCrear.Location = new System.Drawing.Point(4, 22);
            this.tabCrear.Name = "tabCrear";
            this.tabCrear.Padding = new System.Windows.Forms.Padding(3);
            this.tabCrear.Size = new System.Drawing.Size(772, 497);
            this.tabCrear.TabIndex = 0;
            this.tabCrear.Text = "Crear";
            this.tabCrear.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxTipoConsumo);
            this.groupBox2.Controls.Add(this.rndEsLocomotoraNo);
            this.groupBox2.Controls.Add(this.txtConsumoParado);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtConsumoMov);
            this.groupBox2.Controls.Add(this.rndEsLocomotoraSi);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(197, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 151);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Locomotora";
            // 
            // cbxTipoConsumo
            // 
            this.cbxTipoConsumo.AutoCompleteCustomSource.AddRange(new string[] {
            "Electrico",
            "Diesel"});
            this.cbxTipoConsumo.FormattingEnabled = true;
            this.cbxTipoConsumo.Items.AddRange(new object[] {
            "Electrico",
            "Disel"});
            this.cbxTipoConsumo.Location = new System.Drawing.Point(139, 44);
            this.cbxTipoConsumo.Name = "cbxTipoConsumo";
            this.cbxTipoConsumo.Size = new System.Drawing.Size(233, 21);
            this.cbxTipoConsumo.TabIndex = 2;
            // 
            // rndEsLocomotoraNo
            // 
            this.rndEsLocomotoraNo.AutoSize = true;
            this.rndEsLocomotoraNo.Location = new System.Drawing.Point(47, 19);
            this.rndEsLocomotoraNo.Name = "rndEsLocomotoraNo";
            this.rndEsLocomotoraNo.Size = new System.Drawing.Size(39, 17);
            this.rndEsLocomotoraNo.TabIndex = 0;
            this.rndEsLocomotoraNo.TabStop = true;
            this.rndEsLocomotoraNo.Text = "No";
            this.rndEsLocomotoraNo.UseVisualStyleBackColor = true;
            // 
            // txtConsumoParado
            // 
            this.txtConsumoParado.Location = new System.Drawing.Point(139, 117);
            this.txtConsumoParado.Name = "txtConsumoParado";
            this.txtConsumoParado.Size = new System.Drawing.Size(233, 20);
            this.txtConsumoParado.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tipo Consumo";
            // 
            // txtConsumoMov
            // 
            this.txtConsumoMov.Location = new System.Drawing.Point(139, 81);
            this.txtConsumoMov.Name = "txtConsumoMov";
            this.txtConsumoMov.Size = new System.Drawing.Size(233, 20);
            this.txtConsumoMov.TabIndex = 1;
            // 
            // rndEsLocomotoraSi
            // 
            this.rndEsLocomotoraSi.AutoSize = true;
            this.rndEsLocomotoraSi.Location = new System.Drawing.Point(7, 20);
            this.rndEsLocomotoraSi.Name = "rndEsLocomotoraSi";
            this.rndEsLocomotoraSi.Size = new System.Drawing.Size(34, 17);
            this.rndEsLocomotoraSi.TabIndex = 0;
            this.rndEsLocomotoraSi.TabStop = true;
            this.rndEsLocomotoraSi.Text = "Si";
            this.rndEsLocomotoraSi.UseVisualStyleBackColor = true;
            this.rndEsLocomotoraSi.CheckedChanged += new System.EventHandler(this.rndEsLocomotoraSi_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Consumo Parado";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Consumo en Movimiento";
            // 
            // txtMaxReal
            // 
            this.txtMaxReal.Location = new System.Drawing.Point(336, 401);
            this.txtMaxReal.Name = "txtMaxReal";
            this.txtMaxReal.Size = new System.Drawing.Size(233, 20);
            this.txtMaxReal.TabIndex = 7;
            // 
            // txtMaxLegal
            // 
            this.txtMaxLegal.Location = new System.Drawing.Point(336, 363);
            this.txtMaxLegal.Name = "txtMaxLegal";
            this.txtMaxLegal.Size = new System.Drawing.Size(233, 20);
            this.txtMaxLegal.TabIndex = 8;
            // 
            // txtCantidadAsientos
            // 
            this.txtCantidadAsientos.Location = new System.Drawing.Point(336, 323);
            this.txtCantidadAsientos.Name = "txtCantidadAsientos";
            this.txtCantidadAsientos.Size = new System.Drawing.Size(233, 20);
            this.txtCantidadAsientos.TabIndex = 9;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(336, 60);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(233, 20);
            this.txtModelo.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(194, 404);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Capacidad Maxima Real";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(194, 366);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Capacidad Máxima Legal";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(194, 330);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Cantidad de Asientos";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(198, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Modelo";
            // 
            // tabModificar
            // 
            this.tabModificar.Controls.Add(this.label16);
            this.tabModificar.Controls.Add(this.label6);
            this.tabModificar.Controls.Add(this.label7);
            this.tabModificar.Controls.Add(this.lbxCochesModificar);
            this.tabModificar.Controls.Add(this.textBox1);
            this.tabModificar.Controls.Add(this.label1);
            this.tabModificar.Controls.Add(this.label5);
            this.tabModificar.Controls.Add(this.groupBox1);
            this.tabModificar.Controls.Add(this.textBox6);
            this.tabModificar.Controls.Add(this.textBox4);
            this.tabModificar.Controls.Add(this.textBox5);
            this.tabModificar.Location = new System.Drawing.Point(4, 22);
            this.tabModificar.Name = "tabModificar";
            this.tabModificar.Padding = new System.Windows.Forms.Padding(3);
            this.tabModificar.Size = new System.Drawing.Size(772, 497);
            this.tabModificar.TabIndex = 1;
            this.tabModificar.Text = "Modificar";
            this.tabModificar.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Coches Existentes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(378, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Capacidad Maxima Real";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(378, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Capacidad Máxima Legal";
            // 
            // lbxCochesModificar
            // 
            this.lbxCochesModificar.FormattingEnabled = true;
            this.lbxCochesModificar.Location = new System.Drawing.Point(15, 39);
            this.lbxCochesModificar.Name = "lbxCochesModificar";
            this.lbxCochesModificar.Size = new System.Drawing.Size(336, 446);
            this.lbxCochesModificar.TabIndex = 3;
            // 
            // tabEliminar
            // 
            this.tabEliminar.Controls.Add(this.label15);
            this.tabEliminar.Controls.Add(this.btnBorrarCoche);
            this.tabEliminar.Controls.Add(this.lbxCochesBorrar);
            this.tabEliminar.Location = new System.Drawing.Point(4, 22);
            this.tabEliminar.Name = "tabEliminar";
            this.tabEliminar.Padding = new System.Windows.Forms.Padding(3);
            this.tabEliminar.Size = new System.Drawing.Size(772, 497);
            this.tabEliminar.TabIndex = 2;
            this.tabEliminar.Text = "Eliminar";
            this.tabEliminar.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(182, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "Coches Existentes";
            // 
            // btnBorrarCoche
            // 
            this.btnBorrarCoche.Location = new System.Drawing.Point(524, 30);
            this.btnBorrarCoche.Name = "btnBorrarCoche";
            this.btnBorrarCoche.Size = new System.Drawing.Size(81, 23);
            this.btnBorrarCoche.TabIndex = 6;
            this.btnBorrarCoche.Text = "Borrar Coche";
            this.btnBorrarCoche.UseVisualStyleBackColor = true;
            this.btnBorrarCoche.Click += new System.EventHandler(this.btnBorrarCoche_Click);
            // 
            // lbxCochesBorrar
            // 
            this.lbxCochesBorrar.FormattingEnabled = true;
            this.lbxCochesBorrar.Location = new System.Drawing.Point(182, 30);
            this.lbxCochesBorrar.Name = "lbxCochesBorrar";
            this.lbxCochesBorrar.Size = new System.Drawing.Size(336, 446);
            this.lbxCochesBorrar.TabIndex = 5;
            // 
            // pnlCoche
            // 
            this.pnlCoche.Controls.Add(this.tabControl1);
            this.pnlCoche.Controls.Add(this.btnCocheNuevoLimpiar);
            this.pnlCoche.Controls.Add(this.btnCocheNuevoCancelar);
            this.pnlCoche.Controls.Add(this.btnCocheNuevoAceptar);
            this.pnlCoche.Location = new System.Drawing.Point(29, 29);
            this.pnlCoche.Name = "pnlCoche";
            this.pnlCoche.Size = new System.Drawing.Size(811, 583);
            this.pnlCoche.TabIndex = 7;
            // 
            // frmABMCoche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 626);
            this.Controls.Add(this.pnlCoche);
            this.Name = "frmABMCoche";
            this.Text = "Coche";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabCrear.ResumeLayout(false);
            this.tabCrear.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabModificar.ResumeLayout(false);
            this.tabModificar.PerformLayout();
            this.tabEliminar.ResumeLayout(false);
            this.tabEliminar.PerformLayout();
            this.pnlCoche.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button btnCocheNuevoLimpiar;
        private System.Windows.Forms.Button btnCocheNuevoAceptar;
        private System.Windows.Forms.Button btnCocheNuevoCancelar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCrear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxTipoConsumo;
        private System.Windows.Forms.RadioButton rndEsLocomotoraNo;
        private System.Windows.Forms.TextBox txtConsumoParado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtConsumoMov;
        private System.Windows.Forms.RadioButton rndEsLocomotoraSi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMaxReal;
        private System.Windows.Forms.TextBox txtMaxLegal;
        private System.Windows.Forms.TextBox txtCantidadAsientos;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage tabModificar;
        private System.Windows.Forms.ListBox lbxCochesModificar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage tabEliminar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnBorrarCoche;
        private System.Windows.Forms.ListBox lbxCochesBorrar;
        public System.Windows.Forms.Panel pnlCoche;
    }
}