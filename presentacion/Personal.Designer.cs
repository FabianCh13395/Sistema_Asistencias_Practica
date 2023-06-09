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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.dtListadoPersonal = new System.Windows.Forms.DataGridView();
            this.pnPaginado = new System.Windows.Forms.Panel();
            this.btnPagSiguiente = new System.Windows.Forms.Button();
            this.btnPrimeraPag = new System.Windows.Forms.Button();
            this.btnUltimaPag = new System.Windows.Forms.Button();
            this.btnPagAnterior = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNPagina = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPagTotal = new System.Windows.Forms.Label();
            this.pnRegistros = new System.Windows.Forms.Panel();
            this.dtListadoCargos = new System.Windows.Forms.DataGridView();
            this.pnCargos = new System.Windows.Forms.Panel();
            this.txtSueldoI = new System.Windows.Forms.TextBox();
            this.txtCargoI = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnBtnGuardarPersonal = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGuardarPersonal = new System.Windows.Forms.Button();
            this.btnGuardarCambiosPersonal = new System.Windows.Forms.Button();
            this.btnAgregarCargo = new System.Windows.Forms.Button();
            this.cbPaises = new System.Windows.Forms.ComboBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lblTextoSueldo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.EditarC = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnGuardarEditadoC = new System.Windows.Forms.Button();
            this.btnCancelarCargo = new System.Windows.Forms.Button();
            this.btnGuardarCargo = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtListadoPersonal)).BeginInit();
            this.pnPaginado.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.pnRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtListadoCargos)).BeginInit();
            this.pnCargos.SuspendLayout();
            this.pnBtnGuardarPersonal.SuspendLayout();
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
            // dtListadoPersonal
            // 
            this.dtListadoPersonal.AllowUserToAddRows = false;
            this.dtListadoPersonal.AllowUserToDeleteRows = false;
            this.dtListadoPersonal.AllowUserToResizeRows = false;
            this.dtListadoPersonal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.dtListadoPersonal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtListadoPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListadoPersonal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtListadoPersonal.Location = new System.Drawing.Point(0, 78);
            this.dtListadoPersonal.Name = "dtListadoPersonal";
            this.dtListadoPersonal.RowHeadersWidth = 51;
            this.dtListadoPersonal.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.dtListadoPersonal.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dtListadoPersonal.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtListadoPersonal.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtListadoPersonal.RowTemplate.Height = 24;
            this.dtListadoPersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtListadoPersonal.Size = new System.Drawing.Size(1383, 564);
            this.dtListadoPersonal.TabIndex = 1;
            // 
            // pnPaginado
            // 
            this.pnPaginado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.pnPaginado.Controls.Add(this.btnPagSiguiente);
            this.pnPaginado.Controls.Add(this.btnPrimeraPag);
            this.pnPaginado.Controls.Add(this.btnUltimaPag);
            this.pnPaginado.Controls.Add(this.btnPagAnterior);
            this.pnPaginado.Controls.Add(this.flowLayoutPanel3);
            this.pnPaginado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnPaginado.Location = new System.Drawing.Point(0, 642);
            this.pnPaginado.Name = "pnPaginado";
            this.pnPaginado.Size = new System.Drawing.Size(1383, 100);
            this.pnPaginado.TabIndex = 2;
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
            this.btnPrimeraPag.Size = new System.Drawing.Size(229, 63);
            this.btnPrimeraPag.TabIndex = 4;
            this.btnPrimeraPag.Text = "Primera Página";
            this.btnPrimeraPag.UseVisualStyleBackColor = false;
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
            this.flowLayoutPanel3.Size = new System.Drawing.Size(259, 32);
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
            this.label6.Size = new System.Drawing.Size(43, 26);
            this.label6.TabIndex = 2;
            this.label6.Text = "de";
            // 
            // lblPagTotal
            // 
            this.lblPagTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblPagTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblPagTotal.Location = new System.Drawing.Point(179, 0);
            this.lblPagTotal.Name = "lblPagTotal";
            this.lblPagTotal.Size = new System.Drawing.Size(27, 26);
            this.lblPagTotal.TabIndex = 3;
            this.lblPagTotal.Text = "0";
            // 
            // pnRegistros
            // 
            this.pnRegistros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.pnRegistros.Controls.Add(this.dtListadoCargos);
            this.pnRegistros.Controls.Add(this.pnCargos);
            this.pnRegistros.Controls.Add(this.btnRegresar);
            this.pnRegistros.Controls.Add(this.pnBtnGuardarPersonal);
            this.pnRegistros.Controls.Add(this.btnAgregarCargo);
            this.pnRegistros.Controls.Add(this.cbPaises);
            this.pnRegistros.Controls.Add(this.txtSueldo);
            this.pnRegistros.Controls.Add(this.txtCargo);
            this.pnRegistros.Controls.Add(this.txtCedula);
            this.pnRegistros.Controls.Add(this.txtNombres);
            this.pnRegistros.Controls.Add(this.lblTextoSueldo);
            this.pnRegistros.Controls.Add(this.label3);
            this.pnRegistros.Controls.Add(this.label2);
            this.pnRegistros.Controls.Add(this.label1);
            this.pnRegistros.Controls.Add(this.label);
            this.pnRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.pnRegistros.Location = new System.Drawing.Point(35, 106);
            this.pnRegistros.Name = "pnRegistros";
            this.pnRegistros.Size = new System.Drawing.Size(1308, 442);
            this.pnRegistros.TabIndex = 3;
            this.pnRegistros.Visible = false;
            // 
            // dtListadoCargos
            // 
            this.dtListadoCargos.AllowUserToAddRows = false;
            this.dtListadoCargos.AllowUserToDeleteRows = false;
            this.dtListadoCargos.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(163)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtListadoCargos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtListadoCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListadoCargos.ColumnHeadersVisible = false;
            this.dtListadoCargos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EditarC});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(163)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtListadoCargos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtListadoCargos.Location = new System.Drawing.Point(627, 366);
            this.dtListadoCargos.Name = "dtListadoCargos";
            this.dtListadoCargos.ReadOnly = true;
            this.dtListadoCargos.RowHeadersVisible = false;
            this.dtListadoCargos.RowHeadersWidth = 51;
            this.dtListadoCargos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.dtListadoCargos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtListadoCargos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dtListadoCargos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.dtListadoCargos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtListadoCargos.RowTemplate.Height = 30;
            this.dtListadoCargos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtListadoCargos.Size = new System.Drawing.Size(275, 60);
            this.dtListadoCargos.TabIndex = 15;
            this.dtListadoCargos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtListadoCargos_CellClick);
            // 
            // pnCargos
            // 
            this.pnCargos.Controls.Add(this.btnGuardarEditadoC);
            this.pnCargos.Controls.Add(this.btnCancelarCargo);
            this.pnCargos.Controls.Add(this.btnGuardarCargo);
            this.pnCargos.Controls.Add(this.txtSueldoI);
            this.pnCargos.Controls.Add(this.txtCargoI);
            this.pnCargos.Controls.Add(this.label7);
            this.pnCargos.Controls.Add(this.label8);
            this.pnCargos.Location = new System.Drawing.Point(821, 57);
            this.pnCargos.Name = "pnCargos";
            this.pnCargos.Size = new System.Drawing.Size(464, 303);
            this.pnCargos.TabIndex = 14;
            // 
            // txtSueldoI
            // 
            this.txtSueldoI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtSueldoI.Location = new System.Drawing.Point(232, 139);
            this.txtSueldoI.Multiline = true;
            this.txtSueldoI.Name = "txtSueldoI";
            this.txtSueldoI.Size = new System.Drawing.Size(103, 31);
            this.txtSueldoI.TabIndex = 13;
            this.txtSueldoI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSueldoI_KeyPress);
            // 
            // txtCargoI
            // 
            this.txtCargoI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtCargoI.Location = new System.Drawing.Point(232, 100);
            this.txtCargoI.Multiline = true;
            this.txtCargoI.Name = "txtCargoI";
            this.txtCargoI.Size = new System.Drawing.Size(105, 25);
            this.txtCargoI.TabIndex = 12;
            this.txtCargoI.Text = "-------";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(67, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Sueldo por hora:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(152, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "Cargo:";
            // 
            // pnBtnGuardarPersonal
            // 
            this.pnBtnGuardarPersonal.Controls.Add(this.btnGuardarPersonal);
            this.pnBtnGuardarPersonal.Controls.Add(this.btnGuardarCambiosPersonal);
            this.pnBtnGuardarPersonal.Location = new System.Drawing.Point(247, 292);
            this.pnBtnGuardarPersonal.Name = "pnBtnGuardarPersonal";
            this.pnBtnGuardarPersonal.Size = new System.Drawing.Size(369, 51);
            this.pnBtnGuardarPersonal.TabIndex = 12;
            // 
            // btnGuardarPersonal
            // 
            this.btnGuardarPersonal.FlatAppearance.BorderSize = 2;
            this.btnGuardarPersonal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGuardarPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGuardarPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnGuardarPersonal.ForeColor = System.Drawing.Color.White;
            this.btnGuardarPersonal.Location = new System.Drawing.Point(3, 3);
            this.btnGuardarPersonal.Name = "btnGuardarPersonal";
            this.btnGuardarPersonal.Size = new System.Drawing.Size(163, 37);
            this.btnGuardarPersonal.TabIndex = 0;
            this.btnGuardarPersonal.Text = "Guardar";
            this.btnGuardarPersonal.UseVisualStyleBackColor = true;
            this.btnGuardarPersonal.Click += new System.EventHandler(this.btnGuardarPersonal_Click);
            // 
            // btnGuardarCambiosPersonal
            // 
            this.btnGuardarCambiosPersonal.FlatAppearance.BorderSize = 2;
            this.btnGuardarCambiosPersonal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGuardarCambiosPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGuardarCambiosPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCambiosPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnGuardarCambiosPersonal.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCambiosPersonal.Location = new System.Drawing.Point(172, 3);
            this.btnGuardarCambiosPersonal.Name = "btnGuardarCambiosPersonal";
            this.btnGuardarCambiosPersonal.Size = new System.Drawing.Size(178, 37);
            this.btnGuardarCambiosPersonal.TabIndex = 1;
            this.btnGuardarCambiosPersonal.Text = "Guardar*";
            this.btnGuardarCambiosPersonal.UseVisualStyleBackColor = true;
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
            this.btnAgregarCargo.Click += new System.EventHandler(this.btnAgregarCargo_Click);
            // 
            // cbPaises
            // 
            this.cbPaises.FormattingEnabled = true;
            this.cbPaises.Items.AddRange(new object[] {
            "México",
            "Guatemala",
            "Belice",
            "El Salvador",
            "Honduras",
            "Nicaragua",
            "Costa Rica",
            "Panamá",
            "Cuba",
            "República Dominicana",
            "Puerto Rico ",
            "Haití",
            "Jamaica",
            "Bahamas",
            "Dominica",
            "Colombia",
            "Venezuela",
            "Ecuador",
            "Perú",
            "Brasil",
            "Bolivia",
            "Paraguay",
            "Chile",
            "Argentina",
            "Uruguay"});
            this.cbPaises.Location = new System.Drawing.Point(248, 133);
            this.cbPaises.Name = "cbPaises";
            this.cbPaises.Size = new System.Drawing.Size(121, 33);
            this.cbPaises.TabIndex = 10;
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
            this.txtSueldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSueldo_KeyPress);
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
            this.txtCargo.TextChanged += new System.EventHandler(this.txtCargo_TextChanged);
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
            // lblTextoSueldo
            // 
            this.lblTextoSueldo.AutoSize = true;
            this.lblTextoSueldo.ForeColor = System.Drawing.Color.White;
            this.lblTextoSueldo.Location = new System.Drawing.Point(84, 216);
            this.lblTextoSueldo.Name = "lblTextoSueldo";
            this.lblTextoSueldo.Size = new System.Drawing.Size(157, 25);
            this.lblTextoSueldo.TabIndex = 4;
            this.lblTextoSueldo.Text = "Sueldo por hora:";
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
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Asistencias.Properties.Resources.editar;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // EditarC
            // 
            this.EditarC.HeaderText = "";
            this.EditarC.Image = global::Asistencias.Properties.Resources.editar;
            this.EditarC.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.EditarC.MinimumWidth = 6;
            this.EditarC.Name = "EditarC";
            this.EditarC.ReadOnly = true;
            this.EditarC.Width = 125;
            // 
            // btnGuardarEditadoC
            // 
            this.btnGuardarEditadoC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.btnGuardarEditadoC.BackgroundImage = global::Asistencias.Properties.Resources.check_comprobado;
            this.btnGuardarEditadoC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardarEditadoC.FlatAppearance.BorderSize = 0;
            this.btnGuardarEditadoC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarEditadoC.Location = new System.Drawing.Point(213, 198);
            this.btnGuardarEditadoC.Name = "btnGuardarEditadoC";
            this.btnGuardarEditadoC.Size = new System.Drawing.Size(50, 45);
            this.btnGuardarEditadoC.TabIndex = 16;
            this.btnGuardarEditadoC.UseVisualStyleBackColor = false;
            this.btnGuardarEditadoC.Visible = false;
            this.btnGuardarEditadoC.Click += new System.EventHandler(this.btnGuardarEditadoC_Click);
            // 
            // btnCancelarCargo
            // 
            this.btnCancelarCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.btnCancelarCargo.BackgroundImage = global::Asistencias.Properties.Resources.cerrar;
            this.btnCancelarCargo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelarCargo.FlatAppearance.BorderSize = 0;
            this.btnCancelarCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCargo.Location = new System.Drawing.Point(287, 198);
            this.btnCancelarCargo.Name = "btnCancelarCargo";
            this.btnCancelarCargo.Size = new System.Drawing.Size(50, 45);
            this.btnCancelarCargo.TabIndex = 15;
            this.btnCancelarCargo.UseVisualStyleBackColor = false;
            this.btnCancelarCargo.Click += new System.EventHandler(this.btnCancelarCargo_Click);
            // 
            // btnGuardarCargo
            // 
            this.btnGuardarCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.btnGuardarCargo.BackgroundImage = global::Asistencias.Properties.Resources.salvar;
            this.btnGuardarCargo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardarCargo.FlatAppearance.BorderSize = 0;
            this.btnGuardarCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCargo.Location = new System.Drawing.Point(157, 198);
            this.btnGuardarCargo.Name = "btnGuardarCargo";
            this.btnGuardarCargo.Size = new System.Drawing.Size(50, 45);
            this.btnGuardarCargo.TabIndex = 14;
            this.btnGuardarCargo.UseVisualStyleBackColor = false;
            this.btnGuardarCargo.Click += new System.EventHandler(this.btnGuardarCargo_Click);
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
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
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
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
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
            // Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnRegistros);
            this.Controls.Add(this.dtListadoPersonal);
            this.Controls.Add(this.pnPaginado);
            this.Controls.Add(this.panel1);
            this.Name = "Personal";
            this.Size = new System.Drawing.Size(1383, 742);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtListadoPersonal)).EndInit();
            this.pnPaginado.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.pnRegistros.ResumeLayout(false);
            this.pnRegistros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtListadoCargos)).EndInit();
            this.pnCargos.ResumeLayout(false);
            this.pnCargos.PerformLayout();
            this.pnBtnGuardarPersonal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtListadoPersonal;
        private System.Windows.Forms.Panel pnPaginado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.Panel pnRegistros;
        private System.Windows.Forms.Label lblTextoSueldo;
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
        private System.Windows.Forms.FlowLayoutPanel pnBtnGuardarPersonal;
        private System.Windows.Forms.Button btnGuardarPersonal;
        private System.Windows.Forms.Button btnAgregarCargo;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnGuardarCambiosPersonal;
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
        private System.Windows.Forms.Panel pnCargos;
        private System.Windows.Forms.Button btnGuardarCargo;
        private System.Windows.Forms.TextBox txtSueldoI;
        private System.Windows.Forms.TextBox txtCargoI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancelarCargo;
        private System.Windows.Forms.DataGridView dtListadoCargos;
        private System.Windows.Forms.DataGridViewImageColumn EditarC;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button btnGuardarEditadoC;
    }
}
