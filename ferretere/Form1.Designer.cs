namespace ferretere
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataProductos = new System.Windows.Forms.DataGridView();
            this.butAgregar = new System.Windows.Forms.Button();
            this.butModificar = new System.Windows.Forms.Button();
            this.butEliminar = new System.Windows.Forms.Button();
            this.pictureProductos = new System.Windows.Forms.PictureBox();
            this.textFiltr = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(340, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "STOCK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Filtro:";
            // 
            // dataProductos
            // 
            this.dataProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataProductos.Location = new System.Drawing.Point(27, 92);
            this.dataProductos.MultiSelect = false;
            this.dataProductos.Name = "dataProductos";
            this.dataProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataProductos.Size = new System.Drawing.Size(517, 236);
            this.dataProductos.TabIndex = 3;
            this.dataProductos.SelectionChanged += new System.EventHandler(this.dataProductos_SelectionChanged);
            // 
            // butAgregar
            // 
            this.butAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.butAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butAgregar.Location = new System.Drawing.Point(129, 334);
            this.butAgregar.Name = "butAgregar";
            this.butAgregar.Size = new System.Drawing.Size(83, 31);
            this.butAgregar.TabIndex = 4;
            this.butAgregar.Text = "Agregar";
            this.butAgregar.UseVisualStyleBackColor = true;
            this.butAgregar.Click += new System.EventHandler(this.butAgregar_Click);
            // 
            // butModificar
            // 
            this.butModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.butModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butModificar.Location = new System.Drawing.Point(229, 334);
            this.butModificar.Name = "butModificar";
            this.butModificar.Size = new System.Drawing.Size(83, 31);
            this.butModificar.TabIndex = 5;
            this.butModificar.Text = "Modificar";
            this.butModificar.UseVisualStyleBackColor = true;
            this.butModificar.Click += new System.EventHandler(this.butModificar_Click);
            // 
            // butEliminar
            // 
            this.butEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.butEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butEliminar.Location = new System.Drawing.Point(333, 334);
            this.butEliminar.Name = "butEliminar";
            this.butEliminar.Size = new System.Drawing.Size(83, 31);
            this.butEliminar.TabIndex = 6;
            this.butEliminar.Text = "Eliminar";
            this.butEliminar.UseVisualStyleBackColor = true;
            this.butEliminar.Click += new System.EventHandler(this.butEliminar_Click);
            // 
            // pictureProductos
            // 
            this.pictureProductos.Location = new System.Drawing.Point(579, 124);
            this.pictureProductos.Name = "pictureProductos";
            this.pictureProductos.Size = new System.Drawing.Size(209, 173);
            this.pictureProductos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureProductos.TabIndex = 7;
            this.pictureProductos.TabStop = false;
            // 
            // textFiltr
            // 
            this.textFiltr.Location = new System.Drawing.Point(68, 66);
            this.textFiltr.Name = "textFiltr";
            this.textFiltr.Size = new System.Drawing.Size(272, 20);
            this.textFiltr.TabIndex = 9;
            this.textFiltr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textFiltr_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ferretere.Properties.Resources.asssasa;
            this.ClientSize = new System.Drawing.Size(800, 377);
            this.Controls.Add(this.textFiltr);
            this.Controls.Add(this.pictureProductos);
            this.Controls.Add(this.butEliminar);
            this.Controls.Add(this.butModificar);
            this.Controls.Add(this.butAgregar);
            this.Controls.Add(this.dataProductos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 416);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 416);
            this.Name = "Form1";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataProductos;
        private System.Windows.Forms.Button butAgregar;
        private System.Windows.Forms.Button butModificar;
        private System.Windows.Forms.Button butEliminar;
        private System.Windows.Forms.PictureBox pictureProductos;
        private System.Windows.Forms.TextBox textFiltr;
    }
}

