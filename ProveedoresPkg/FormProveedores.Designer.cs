namespace PollosLaColina
{
    partial class FormProveedores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProveedores));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.txt_IDProveedor = new System.Windows.Forms.TextBox();
            this.txt_PhoneProveedor = new System.Windows.Forms.TextBox();
            this.txt_EmailProveedor = new System.Windows.Forms.TextBox();
            this.txt_NProveedor = new System.Windows.Forms.TextBox();
            this.lbl_DNIProveedor = new System.Windows.Forms.Label();
            this.lbl_emailProveedor = new System.Windows.Forms.Label();
            this.lbl_PhoneProveedor = new System.Windows.Forms.Label();
            this.lbl_NProveedor = new System.Windows.Forms.Label();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(743, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "PROVEEDORES";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.Location = new System.Drawing.Point(515, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(575, 315);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.Peru;
            this.btn_agregar.FlatAppearance.BorderSize = 0;
            this.btn_agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_agregar.Location = new System.Drawing.Point(128, 352);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(150, 35);
            this.btn_agregar.TabIndex = 18;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click_1);
            // 
            // txt_IDProveedor
            // 
            this.txt_IDProveedor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IDProveedor.Location = new System.Drawing.Point(341, 149);
            this.txt_IDProveedor.Name = "txt_IDProveedor";
            this.txt_IDProveedor.Size = new System.Drawing.Size(150, 26);
            this.txt_IDProveedor.TabIndex = 17;
            this.txt_IDProveedor.TextChanged += new System.EventHandler(this.txt_IDProveedor_TextChanged);
            // 
            // txt_PhoneProveedor
            // 
            this.txt_PhoneProveedor.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txt_PhoneProveedor.Location = new System.Drawing.Point(341, 237);
            this.txt_PhoneProveedor.Name = "txt_PhoneProveedor";
            this.txt_PhoneProveedor.Size = new System.Drawing.Size(150, 26);
            this.txt_PhoneProveedor.TabIndex = 16;
            this.txt_PhoneProveedor.TextChanged += new System.EventHandler(this.txt_PhoneProveedor_TextChanged);
            // 
            // txt_EmailProveedor
            // 
            this.txt_EmailProveedor.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txt_EmailProveedor.Location = new System.Drawing.Point(341, 281);
            this.txt_EmailProveedor.Name = "txt_EmailProveedor";
            this.txt_EmailProveedor.Size = new System.Drawing.Size(150, 26);
            this.txt_EmailProveedor.TabIndex = 15;
            this.txt_EmailProveedor.TextChanged += new System.EventHandler(this.txt_EmailProveedor_TextChanged);
            // 
            // txt_NProveedor
            // 
            this.txt_NProveedor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NProveedor.Location = new System.Drawing.Point(341, 193);
            this.txt_NProveedor.Name = "txt_NProveedor";
            this.txt_NProveedor.Size = new System.Drawing.Size(150, 26);
            this.txt_NProveedor.TabIndex = 14;
            this.txt_NProveedor.TextChanged += new System.EventHandler(this.txt_NProveedor_TextChanged);
            // 
            // lbl_DNIProveedor
            // 
            this.lbl_DNIProveedor.AutoSize = true;
            this.lbl_DNIProveedor.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DNIProveedor.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DNIProveedor.Location = new System.Drawing.Point(128, 149);
            this.lbl_DNIProveedor.Name = "lbl_DNIProveedor";
            this.lbl_DNIProveedor.Size = new System.Drawing.Size(80, 22);
            this.lbl_DNIProveedor.TabIndex = 13;
            this.lbl_DNIProveedor.Text = "DNI/CIF";
            this.lbl_DNIProveedor.Click += new System.EventHandler(this.lbl_DNIProveedor_Click);
            // 
            // lbl_emailProveedor
            // 
            this.lbl_emailProveedor.AutoSize = true;
            this.lbl_emailProveedor.BackColor = System.Drawing.Color.Transparent;
            this.lbl_emailProveedor.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lbl_emailProveedor.Location = new System.Drawing.Point(128, 284);
            this.lbl_emailProveedor.Name = "lbl_emailProveedor";
            this.lbl_emailProveedor.Size = new System.Drawing.Size(179, 22);
            this.lbl_emailProveedor.TabIndex = 12;
            this.lbl_emailProveedor.Text = "Correo Electrónico";
            this.lbl_emailProveedor.Click += new System.EventHandler(this.lbl_emailProveedor_Click);
            // 
            // lbl_PhoneProveedor
            // 
            this.lbl_PhoneProveedor.AutoSize = true;
            this.lbl_PhoneProveedor.BackColor = System.Drawing.Color.Transparent;
            this.lbl_PhoneProveedor.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lbl_PhoneProveedor.Location = new System.Drawing.Point(128, 239);
            this.lbl_PhoneProveedor.Name = "lbl_PhoneProveedor";
            this.lbl_PhoneProveedor.Size = new System.Drawing.Size(191, 22);
            this.lbl_PhoneProveedor.TabIndex = 11;
            this.lbl_PhoneProveedor.Text = "Telefono proveedor";
            this.lbl_PhoneProveedor.Click += new System.EventHandler(this.lbl_PhoneProveedor_Click);
            // 
            // lbl_NProveedor
            // 
            this.lbl_NProveedor.AutoSize = true;
            this.lbl_NProveedor.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NProveedor.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lbl_NProveedor.Location = new System.Drawing.Point(128, 194);
            this.lbl_NProveedor.Name = "lbl_NProveedor";
            this.lbl_NProveedor.Size = new System.Drawing.Size(188, 22);
            this.lbl_NProveedor.TabIndex = 10;
            this.lbl_NProveedor.Text = "Nombre proveedor";
            this.lbl_NProveedor.Click += new System.EventHandler(this.lbl_NProveedor_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackColor = System.Drawing.Color.Peru;
            this.btn_actualizar.FlatAppearance.BorderSize = 0;
            this.btn_actualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_actualizar.Location = new System.Drawing.Point(515, 419);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(125, 35);
            this.btn_actualizar.TabIndex = 20;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = false;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Peru;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_delete.Location = new System.Drawing.Point(341, 352);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(150, 35);
            this.btn_delete.TabIndex = 21;
            this.btn_delete.Text = "Borrar";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // FormProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1166, 617);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.txt_IDProveedor);
            this.Controls.Add(this.txt_PhoneProveedor);
            this.Controls.Add(this.txt_EmailProveedor);
            this.Controls.Add(this.txt_NProveedor);
            this.Controls.Add(this.lbl_DNIProveedor);
            this.Controls.Add(this.lbl_emailProveedor);
            this.Controls.Add(this.lbl_PhoneProveedor);
            this.Controls.Add(this.lbl_NProveedor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProveedores";
            this.Text = "proveedores";
            this.Load += new System.EventHandler(this.proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.TextBox txt_IDProveedor;
        private System.Windows.Forms.TextBox txt_PhoneProveedor;
        private System.Windows.Forms.TextBox txt_EmailProveedor;
        private System.Windows.Forms.TextBox txt_NProveedor;
        private System.Windows.Forms.Label lbl_DNIProveedor;
        private System.Windows.Forms.Label lbl_emailProveedor;
        private System.Windows.Forms.Label lbl_PhoneProveedor;
        private System.Windows.Forms.Label lbl_NProveedor;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_delete;
    }
}