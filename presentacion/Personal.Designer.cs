namespace Asistencias.presentacion
{
    partial class Personal
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.cbPaises = new System.Windows.Forms.ComboBox();
            this.btnAgregarCargo = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnGuardarTodos = new System.Windows.Forms.Button();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.btnPagSiguiente = new System.Windows.Forms.Button();
            this.btnPagAnterior = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNPagina = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPagTotal = new System.Windows.Forms.Label();
            this.btnUltimaPag = new System.Windows.Forms.Button();
            this.btnPrimeraPag = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGuardarCargo = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancelarCargo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.btnMostrarTodos);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtBuscador);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1383, 78);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1383, 564);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.panel2.Controls.Add(this.btnPagSiguiente);
            this.panel2.Controls.Add(this.btnPrimeraPag);
            this.panel2.Controls.Add(this.btnUltimaPag);
            this.panel2.Controls.Add(this.btnPagAnterior);
            this.panel2.Controls.Add(this.flowLayoutPanel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 642);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1383, 100);
            this.panel2.TabIndex = 2;
            // 
            // txtBuscador
            // 
            this.txtBuscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtBuscador.Location = new System.Drawing.Point(76, 26);
            this.txtBuscador.Multiline = true;
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(410, 34);
            this.txtBuscador.TabIndex = 0;
            this.txtBuscador.Text = "Ingrese un nombre.....";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.btnRegresar);
            this.panel3.Controls.Add(this.flowLayoutPanel1);
            this.panel3.Controls.Add(this.btnAgregarCargo);
            this.panel3.Controls.Add(this.cbPaises);
            this.panel3.Controls.Add(this.txtSueldo);
            this.panel3.Controls.Add(this.txtCargo);
            this.panel3.Controls.Add(this.txtCedula);
            this.panel3.Controls.Add(this.txtNombres);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.panel3.Location = new System.Drawing.Point(35, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1308, 442);
            this.panel3.TabIndex = 3;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(44, 57);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(197, 25);
            this.label.TabIndex = 0;
            this.label.Text = "Nombres y Apellidos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(160, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cédula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(185, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "País:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(169, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cargo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(84, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sueldo por hora:";
            // 
            // txtNombres
            // 
            this.txtNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtNombres.Location = new System.Drawing.Point(247, 57);
            this.txtNombres.Multiline = true;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(410, 25);
            this.txtNombres.TabIndex = 5;
            this.txtNombres.Text = "Ingrese sus nombres..\r\n\'\r\n";
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtCedula.Location = new System.Drawing.Point(247, 95);
            this.txtCedula.Multiline = true;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(251, 25);
            this.txtCedula.TabIndex = 6;
            this.txtCedula.Text = ".................";
            // 
            // txtCargo
            // 
            this.txtCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtCargo.Location = new System.Drawing.Point(247, 177);
            this.txtCargo.Multiline = true;
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(193, 25);
            this.txtCargo.TabIndex = 8;
            this.txtCargo.Text = "-------";
            // 
            // txtSueldo
            // 
            this.txtSueldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtSueldo.Location = new System.Drawing.Point(247, 217);
            this.txtSueldo.Multiline = true;
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(71, 25);
            this.txtSueldo.TabIndex = 9;
            this.txtSueldo.Text = "$0";
            // 
            // cbPaises
            // 
            this.cbPaises.FormattingEnabled = true;
            this.cbPaises.Location = new System.Drawing.Point(248, 133);
            this.cbPaises.Name = "cbPaises";
            this.cbPaises.Size = new System.Drawing.Size(121, 33);
            this.cbPaises.TabIndex = 10;
            // 
            // btnAgregarCargo
            // 
            this.btnAgregarCargo.FlatAppearance.BorderSize = 5;
            this.btnAgregarCargo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregarCargo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAgregarCargo.Location = new System.Drawing.Point(457, 176);
            this.btnAgregarCargo.Name = "btnAgregarCargo";
            this.btnAgregarCargo.Size = new System.Drawing.Size(24, 26);
            this.btnAgregarCargo.TabIndex = 11;
            this.btnAgregarCargo.Text = "+";
            this.btnAgregarCargo.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnGuardar);
            this.flowLayoutPanel1.Controls.Add(this.btnGuardarTodos);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(49, 289);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(282, 51);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderSize = 2;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(3, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(105, 37);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnGuardarTodos
            // 
            this.btnGuardarTodos.FlatAppearance.BorderSize = 2;
            this.btnGuardarTodos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGuardarTodos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGuardarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnGuardarTodos.ForeColor = System.Drawing.Color.White;
            this.btnGuardarTodos.Location = new System.Drawing.Point(114, 3);
            this.btnGuardarTodos.Name = "btnGuardarTodos";
            this.btnGuardarTodos.Size = new System.Drawing.Size(116, 37);
            this.btnGuardarTodos.TabIndex = 1;
            this.btnGuardarTodos.Text = "Guardar*";
            this.btnGuardarTodos.UseVisualStyleBackColor = true;
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.FlatAppearance.BorderSize = 2;
            this.btnMostrarTodos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMostrarTodos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMostrarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnMostrarTodos.ForeColor = System.Drawing.Color.White;
            this.btnMostrarTodos.Location = new System.Drawing.Point(573, 23);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(181, 37);
            this.btnMostrarTodos.TabIndex = 3;
            this.btnMostrarTodos.Text = "Mostrar todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            // 
            // btnPagSiguiente
            // 
            this.btnPagSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(221)))), ((int)(((byte)(228)))));
            this.btnPagSiguiente.FlatAppearance.BorderSize = 2;
            this.btnPagSiguiente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPagSiguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPagSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnPagSiguiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.btnPagSiguiente.Location = new System.Drawing.Point(3, 20);
            this.btnPagSiguiente.Name = "btnPagSiguiente";
            this.btnPagSiguiente.Size = new System.Drawing.Size(215, 60);
            this.btnPagSiguiente.TabIndex = 1;
            this.btnPagSiguiente.Text = "Pagina Siguiente";
            this.btnPagSiguiente.UseVisualStyleBackColor = false;
            // 
            // btnPagAnterior
            // 
            this.btnPagAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(221)))), ((int)(((byte)(228)))));
            this.btnPagAnterior.FlatAppearance.BorderSize = 2;
            this.btnPagAnterior.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPagAnterior.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPagAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnPagAnterior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.btnPagAnterior.Location = new System.Drawing.Point(225, 20);
            this.btnPagAnterior.Name = "btnPagAnterior";
            this.btnPagAnterior.Size = new System.Drawing.Size(224, 60);
            this.btnPagAnterior.TabIndex = 2;
            this.btnPagAnterior.Text = "PaginaAnterior";
            this.btnPagAnterior.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label5);
            this.flowLayoutPanel3.Controls.Add(this.lblNPagina);
            this.flowLayoutPanel3.Controls.Add(this.label6);
            this.flowLayoutPanel3.Controls.Add(this.lblPagTotal);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(478, 34);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(230, 32);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(163)))), ((int)(((byte)(164)))));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Pagina";
            // 
            // lblNPagina
            // 
            this.lblNPagina.BackColor = System.Drawing.Color.Transparent;
            this.lblNPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblNPagina.Location = new System.Drawing.Point(97, 0);
            this.lblNPagina.Name = "lblNPagina";
            this.lblNPagina.Size = new System.Drawing.Size(27, 26);
            this.lblNPagina.TabIndex = 1;
            this.lblNPagina.Text = "0";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(163)))), ((int)(((byte)(164)))));
            this.label6.Location = new System.Drawing.Point(130, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 26);
            this.label6.TabIndex = 2;
            this.label6.Text = "de";
            // 
            // lblPagTotal
            // 
            this.lblPagTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblPagTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblPagTotal.Location = new System.Drawing.Point(170, 0);
            this.lblPagTotal.Name = "lblPagTotal";
            this.lblPagTotal.Size = new System.Drawing.Size(27, 26);
            this.lblPagTotal.TabIndex = 3;
            this.lblPagTotal.Text = "0";
            // 
            // btnUltimaPag
            // 
            this.btnUltimaPag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnUltimaPag.FlatAppearance.BorderSize = 2;
            this.btnUltimaPag.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUltimaPag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUltimaPag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUltimaPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnUltimaPag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.btnUltimaPag.Location = new System.Drawing.Point(758, 19);
            this.btnUltimaPag.Name = "btnUltimaPag";
            this.btnUltimaPag.Size = new System.Drawing.Size(178, 63);
            this.btnUltimaPag.TabIndex = 3;
            this.btnUltimaPag.Text = "Última Página";
            this.btnUltimaPag.UseVisualStyleBackColor = false;
            // 
            // btnPrimeraPag
            // 
            this.btnPrimeraPag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnPrimeraPag.FlatAppearance.BorderSize = 2;
            this.btnPrimeraPag.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPrimeraPag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPrimeraPag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimeraPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnPrimeraPag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.btnPrimeraPag.Location = new System.Drawing.Point(962, 19);
            this.btnPrimeraPag.Name = "btnPrimeraPag";
            this.btnPrimeraPag.Size = new System.Drawing.Size(178, 63);
            this.btnPrimeraPag.TabIndex = 4;
            this.btnPrimeraPag.Text = "Primera Página";
            this.btnPrimeraPag.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnCancelarCargo);
            this.panel4.Controls.Add(this.btnGuardarCargo);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.textBox2);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(723, 57);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(430, 303);
            this.panel4.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.textBox1.Location = new System.Drawing.Point(157, 140);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(71, 25);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "$0";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.textBox2.Location = new System.Drawing.Point(157, 100);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(105, 25);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "-------";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(-6, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Sueldo por hora:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(79, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "Cargo:";
            // 
            // btnGuardarCargo
            // 
            this.btnGuardarCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.btnGuardarCargo.BackgroundImage = global::Asistencias.Properties.Resources.salvar;
            this.btnGuardarCargo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardarCargo.FlatAppearance.BorderSize = 0;
            this.btnGuardarCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCargo.Location = new System.Drawing.Point(116, 198);
            this.btnGuardarCargo.Name = "btnGuardarCargo";
            this.btnGuardarCargo.Size = new System.Drawing.Size(50, 45);
            this.btnGuardarCargo.TabIndex = 14;
            this.btnGuardarCargo.UseVisualStyleBackColor = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.btnRegresar.BackgroundImage = global::Asistencias.Properties.Resources.cerrar;
            this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Location = new System.Drawing.Point(669, 4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(50, 45);
            this.btnRegresar.TabIndex = 13;
            this.btnRegresar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.btnAgregar.BackgroundImage = global::Asistencias.Properties.Resources.boton_agregar;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.Location = new System.Drawing.Point(1304, 0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(79, 78);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Asistencias.Properties.Resources.lupa;
            this.pictureBox1.Location = new System.Drawing.Point(492, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancelarCargo
            // 
            this.btnCancelarCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.btnCancelarCargo.BackgroundImage = global::Asistencias.Properties.Resources.cerrar;
            this.btnCancelarCargo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelarCargo.FlatAppearance.BorderSize = 0;
            this.btnCancelarCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCargo.Location = new System.Drawing.Point(196, 198);
            this.btnCancelarCargo.Name = "btnCancelarCargo";
            this.btnCancelarCargo.Size = new System.Drawing.Size(50, 45);
            this.btnCancelarCargo.TabIndex = 15;
            this.btnCancelarCargo.UseVisualStyleBackColor = false;
            // 
            // Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Personal";
            this.Size = new System.Drawing.Size(1383, 742);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cbPaises;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAgregarCargo;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnGuardarTodos;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Button btnPagSiguiente;
        private System.Windows.Forms.Button btnPagAnterior;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPrimeraPag;
        private System.Windows.Forms.Button btnUltimaPag;
        private System.Windows.Forms.Label lblNPagina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPagTotal;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnGuardarCargo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancelarCargo;
    }
}
