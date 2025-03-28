namespace PollosLaColina
{
    partial class FormConfig
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.Cb_Colina = new System.Windows.Forms.CheckBox();
            this.Cb_Fuentes = new System.Windows.Forms.CheckBox();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "CONFIGURACIONES";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(-15, -15);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(-15, -15);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Cb_Colina
            // 
            this.Cb_Colina.AutoSize = true;
            this.Cb_Colina.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_Colina.Location = new System.Drawing.Point(42, 127);
            this.Cb_Colina.Name = "Cb_Colina";
            this.Cb_Colina.Size = new System.Drawing.Size(146, 25);
            this.Cb_Colina.TabIndex = 6;
            this.Cb_Colina.Text = "Pollos La Colina";
            this.Cb_Colina.UseVisualStyleBackColor = true;
            this.Cb_Colina.CheckedChanged += new System.EventHandler(this.Cb_Colina_CheckedChanged);
            // 
            // Cb_Fuentes
            // 
            this.Cb_Fuentes.AutoSize = true;
            this.Cb_Fuentes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_Fuentes.Location = new System.Drawing.Point(42, 158);
            this.Cb_Fuentes.Name = "Cb_Fuentes";
            this.Cb_Fuentes.Size = new System.Drawing.Size(191, 25);
            this.Cb_Fuentes.TabIndex = 7;
            this.Cb_Fuentes.Text = "Restaurante Fuentes";
            this.Cb_Fuentes.UseVisualStyleBackColor = true;
            this.Cb_Fuentes.CheckedChanged += new System.EventHandler(this.Cb_Fuentes_CheckedChanged);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Save.Location = new System.Drawing.Point(42, 256);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(191, 46);
            this.Btn_Save.TabIndex = 8;
            this.Btn_Save.Text = "Guardar Cambios";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1166, 617);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Cb_Fuentes);
            this.Controls.Add(this.Cb_Colina);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConfig";
            this.Text = "config";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox Cb_Colina;
        private System.Windows.Forms.CheckBox Cb_Fuentes;
        private System.Windows.Forms.Button Btn_Save;
    }
}