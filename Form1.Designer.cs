namespace AltaRecetas
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTotalIngredientes = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dgvReceta = new System.Windows.Forms.DataGridView();
            this.detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingrediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtCheff = new System.Windows.Forms.TextBox();
            this.lblCheff = new System.Windows.Forms.Label();
            this.lblProximaReceta = new System.Windows.Forms.Label();
            this.cboTipoReceta = new System.Windows.Forms.ComboBox();
            this.cboIngredientes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalIngredientes
            // 
            this.lblTotalIngredientes.AutoSize = true;
            this.lblTotalIngredientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalIngredientes.Location = new System.Drawing.Point(478, 385);
            this.lblTotalIngredientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalIngredientes.Name = "lblTotalIngredientes";
            this.lblTotalIngredientes.Size = new System.Drawing.Size(148, 18);
            this.lblTotalIngredientes.TabIndex = 35;
            this.lblTotalIngredientes.Text = "Total de ingredientes:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(173, 54);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(412, 22);
            this.txtNombre.TabIndex = 22;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(106, 57);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 34;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(67, 129);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(98, 16);
            this.lblTipo.TabIndex = 33;
            this.lblTipo.Text = "Tipo de receta:";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(465, 177);
            this.nudCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(96, 22);
            this.nudCantidad.TabIndex = 28;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(415, 432);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(310, 432);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 28);
            this.btnAceptar.TabIndex = 31;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dgvReceta
            // 
            this.dgvReceta.AllowUserToAddRows = false;
            this.dgvReceta.AllowUserToDeleteRows = false;
            this.dgvReceta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detalle,
            this.ingrediente,
            this.Cantidad,
            this.acciones});
            this.dgvReceta.Location = new System.Drawing.Point(81, 209);
            this.dgvReceta.Margin = new System.Windows.Forms.Padding(4);
            this.dgvReceta.Name = "dgvReceta";
            this.dgvReceta.ReadOnly = true;
            this.dgvReceta.RowHeadersWidth = 51;
            this.dgvReceta.Size = new System.Drawing.Size(628, 172);
            this.dgvReceta.TabIndex = 30;
            // 
            // detalle
            // 
            this.detalle.HeaderText = "Column1";
            this.detalle.MinimumWidth = 6;
            this.detalle.Name = "detalle";
            this.detalle.ReadOnly = true;
            this.detalle.Visible = false;
            this.detalle.Width = 125;
            // 
            // ingrediente
            // 
            this.ingrediente.HeaderText = "Ingrediente";
            this.ingrediente.MinimumWidth = 6;
            this.ingrediente.Name = "ingrediente";
            this.ingrediente.ReadOnly = true;
            this.ingrediente.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 125;
            // 
            // acciones
            // 
            this.acciones.HeaderText = "Acciones";
            this.acciones.MinimumWidth = 6;
            this.acciones.Name = "acciones";
            this.acciones.ReadOnly = true;
            this.acciones.Text = "Quitar";
            this.acciones.UseColumnTextForButtonValue = true;
            this.acciones.Width = 125;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(590, 173);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(119, 28);
            this.btnAgregar.TabIndex = 29;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtCheff
            // 
            this.txtCheff.Location = new System.Drawing.Point(173, 93);
            this.txtCheff.Margin = new System.Windows.Forms.Padding(4);
            this.txtCheff.Name = "txtCheff";
            this.txtCheff.Size = new System.Drawing.Size(264, 22);
            this.txtCheff.TabIndex = 24;
            // 
            // lblCheff
            // 
            this.lblCheff.AutoSize = true;
            this.lblCheff.Location = new System.Drawing.Point(125, 96);
            this.lblCheff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheff.Name = "lblCheff";
            this.lblCheff.Size = new System.Drawing.Size(40, 16);
            this.lblCheff.TabIndex = 27;
            this.lblCheff.Text = "Cheff:";
            // 
            // lblProximaReceta
            // 
            this.lblProximaReceta.AutoSize = true;
            this.lblProximaReceta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProximaReceta.Location = new System.Drawing.Point(315, 9);
            this.lblProximaReceta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProximaReceta.Name = "lblProximaReceta";
            this.lblProximaReceta.Size = new System.Drawing.Size(122, 25);
            this.lblProximaReceta.TabIndex = 23;
            this.lblProximaReceta.Text = "Receta #: 1";
            // 
            // cboTipoReceta
            // 
            this.cboTipoReceta.FormattingEnabled = true;
            this.cboTipoReceta.Location = new System.Drawing.Point(173, 126);
            this.cboTipoReceta.Name = "cboTipoReceta";
            this.cboTipoReceta.Size = new System.Drawing.Size(264, 24);
            this.cboTipoReceta.TabIndex = 36;
            // 
            // cboIngredientes
            // 
            this.cboIngredientes.FormattingEnabled = true;
            this.cboIngredientes.Location = new System.Drawing.Point(81, 178);
            this.cboIngredientes.Name = "cboIngredientes";
            this.cboIngredientes.Size = new System.Drawing.Size(356, 24);
            this.cboIngredientes.TabIndex = 37;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 480);
            this.Controls.Add(this.cboIngredientes);
            this.Controls.Add(this.cboTipoReceta);
            this.Controls.Add(this.lblTotalIngredientes);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvReceta);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtCheff);
            this.Controls.Add(this.lblCheff);
            this.Controls.Add(this.lblProximaReceta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalIngredientes;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dgvReceta;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingrediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewButtonColumn acciones;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtCheff;
        private System.Windows.Forms.Label lblCheff;
        private System.Windows.Forms.Label lblProximaReceta;
        private System.Windows.Forms.ComboBox cboTipoReceta;
        private System.Windows.Forms.ComboBox cboIngredientes;
    }
}

