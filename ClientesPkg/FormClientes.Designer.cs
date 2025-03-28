namespace PollosLaColina
{
    partial class FormClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientes));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.txt_IDCliente = new System.Windows.Forms.TextBox();
            this.txt_PhoneCliente = new System.Windows.Forms.TextBox();
            this.txt_EmailCliente = new System.Windows.Forms.TextBox();
            this.txt_NCliente = new System.Windows.Forms.TextBox();
            this.lbl_IDCliente = new System.Windows.Forms.Label();
            this.lbl_EmailCliente = new System.Windows.Forms.Label();
            this.lbl_PhoneCliente = new System.Windows.Forms.Label();
            this.lbl_NCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(738, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "CLIENTES";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Peru;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(334, 354);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(150, 35);
            this.btn_delete.TabIndex = 34;
            this.btn_delete.Text = "Borrar";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackColor = System.Drawing.Color.Peru;
            this.btn_actualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_actualizar.FlatAppearance.BorderSize = 0;
            this.btn_actualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar.Location = new System.Drawing.Point(505, 415);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(125, 35);
            this.btn_actualizar.TabIndex = 33;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = false;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.Location = new System.Drawing.Point(505, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(575, 315);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.Peru;
            this.btn_agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar.FlatAppearance.BorderSize = 0;
            this.btn_agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_agregar.Location = new System.Drawing.Point(130, 354);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(150, 35);
            this.btn_agregar.TabIndex = 31;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // txt_IDCliente
            // 
            this.txt_IDCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txt_IDCliente.Location = new System.Drawing.Point(334, 143);
            this.txt_IDCliente.Name = "txt_IDCliente";
            this.txt_IDCliente.Size = new System.Drawing.Size(150, 26);
            this.txt_IDCliente.TabIndex = 30;
            this.txt_IDCliente.TextChanged += new System.EventHandler(this.txt_IDCliente_TextChanged);
            // 
            // txt_PhoneCliente
            // 
            this.txt_PhoneCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txt_PhoneCliente.Location = new System.Drawing.Point(334, 235);
            this.txt_PhoneCliente.Name = "txt_PhoneCliente";
            this.txt_PhoneCliente.Size = new System.Drawing.Size(150, 26);
            this.txt_PhoneCliente.TabIndex = 29;
            // 
            // txt_EmailCliente
            // 
            this.txt_EmailCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txt_EmailCliente.Location = new System.Drawing.Point(334, 281);
            this.txt_EmailCliente.Name = "txt_EmailCliente";
            this.txt_EmailCliente.Size = new System.Drawing.Size(150, 26);
            this.txt_EmailCliente.TabIndex = 28;
            this.txt_EmailCliente.TextChanged += new System.EventHandler(this.txt_EmailCliente_TextChanged);
            // 
            // txt_NCliente
            // 
            this.txt_NCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txt_NCliente.Location = new System.Drawing.Point(334, 189);
            this.txt_NCliente.Name = "txt_NCliente";
            this.txt_NCliente.Size = new System.Drawing.Size(150, 26);
            this.txt_NCliente.TabIndex = 27;
            this.txt_NCliente.TextChanged += new System.EventHandler(this.txt_NCliente_TextChanged);
            // 
            // lbl_IDCliente
            // 
            this.lbl_IDCliente.AutoSize = true;
            this.lbl_IDCliente.BackColor = System.Drawing.Color.Transparent;
            this.lbl_IDCliente.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lbl_IDCliente.ForeColor = System.Drawing.Color.Black;
            this.lbl_IDCliente.Location = new System.Drawing.Point(130, 147);
            this.lbl_IDCliente.Name = "lbl_IDCliente";
            this.lbl_IDCliente.Size = new System.Drawing.Size(202, 22);
            this.lbl_IDCliente.TabIndex = 26;
            this.lbl_IDCliente.Text = "Cédula de identidad";
            this.lbl_IDCliente.Click += new System.EventHandler(this.lbl_IDCliente_Click);
            // 
            // lbl_EmailCliente
            // 
            this.lbl_EmailCliente.AutoSize = true;
            this.lbl_EmailCliente.BackColor = System.Drawing.Color.Transparent;
            this.lbl_EmailCliente.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lbl_EmailCliente.Location = new System.Drawing.Point(130, 282);
            this.lbl_EmailCliente.Name = "lbl_EmailCliente";
            this.lbl_EmailCliente.Size = new System.Drawing.Size(179, 22);
            this.lbl_EmailCliente.TabIndex = 25;
            this.lbl_EmailCliente.Text = "Correo Electrónico";
            // 
            // lbl_PhoneCliente
            // 
            this.lbl_PhoneCliente.AutoSize = true;
            this.lbl_PhoneCliente.BackColor = System.Drawing.Color.Transparent;
            this.lbl_PhoneCliente.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lbl_PhoneCliente.Location = new System.Drawing.Point(130, 237);
            this.lbl_PhoneCliente.Name = "lbl_PhoneCliente";
            this.lbl_PhoneCliente.Size = new System.Drawing.Size(153, 22);
            this.lbl_PhoneCliente.TabIndex = 24;
            this.lbl_PhoneCliente.Text = "Telefono cliente";
            // 
            // lbl_NCliente
            // 
            this.lbl_NCliente.AutoSize = true;
            this.lbl_NCliente.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NCliente.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lbl_NCliente.Location = new System.Drawing.Point(130, 192);
            this.lbl_NCliente.Name = "lbl_NCliente";
            this.lbl_NCliente.Size = new System.Drawing.Size(150, 22);
            this.lbl_NCliente.TabIndex = 23;
            this.lbl_NCliente.Text = "Nombre cliente";
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1166, 617);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.txt_IDCliente);
            this.Controls.Add(this.txt_PhoneCliente);
            this.Controls.Add(this.txt_EmailCliente);
            this.Controls.Add(this.txt_NCliente);
            this.Controls.Add(this.lbl_IDCliente);
            this.Controls.Add(this.lbl_EmailCliente);
            this.Controls.Add(this.lbl_PhoneCliente);
            this.Controls.Add(this.lbl_NCliente);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormClientes";
            this.Text = "clientes";
            this.Load += new System.EventHandler(this.clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label lbl_IDCliente;
        private System.Windows.Forms.Label lbl_EmailCliente;
        private System.Windows.Forms.Label lbl_PhoneCliente;
        private System.Windows.Forms.Label lbl_NCliente;
        public System.Windows.Forms.TextBox txt_IDCliente;
        public System.Windows.Forms.TextBox txt_NCliente;
        public System.Windows.Forms.TextBox txt_PhoneCliente;
        public System.Windows.Forms.TextBox txt_EmailCliente;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}