﻿namespace Allqovet
{
    partial class frmComprobantes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelfecha = new System.Windows.Forms.Panel();
            this.dtphasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpdesde = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbocriterio = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelfecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 251);
            this.dataGridView1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(49)))), ((int)(((byte)(96)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::Allqovet.Properties.Resources._6579037_and_computers_hardware_print_printer_icon;
            this.button3.Location = new System.Drawing.Point(165, 382);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 36);
            this.button3.TabIndex = 38;
            this.button3.Text = "Imprimir";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(49)))), ((int)(((byte)(96)))));
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::Allqovet.Properties.Resources.salir;
            this.button4.Location = new System.Drawing.Point(278, 382);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 36);
            this.button4.TabIndex = 37;
            this.button4.Text = "Salir";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(49)))), ((int)(((byte)(96)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::Allqovet.Properties.Resources.nuevo;
            this.button2.Location = new System.Drawing.Point(12, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 36);
            this.button2.TabIndex = 36;
            this.button2.Text = "Registrar nuevo";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelfecha);
            this.groupBox1.Controls.Add(this.cbocriterio);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtbuscar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 59);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Comprobante";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panelfecha
            // 
            this.panelfecha.Controls.Add(this.dtphasta);
            this.panelfecha.Controls.Add(this.label2);
            this.panelfecha.Controls.Add(this.dtpdesde);
            this.panelfecha.Controls.Add(this.label4);
            this.panelfecha.Location = new System.Drawing.Point(227, 17);
            this.panelfecha.Name = "panelfecha";
            this.panelfecha.Size = new System.Drawing.Size(405, 28);
            this.panelfecha.TabIndex = 36;
            this.panelfecha.Visible = false;
            // 
            // dtphasta
            // 
            this.dtphasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtphasta.Location = new System.Drawing.Point(225, 3);
            this.dtphasta.Name = "dtphasta";
            this.dtphasta.Size = new System.Drawing.Size(103, 22);
            this.dtphasta.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(177, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "Hasta";
            // 
            // dtpdesde
            // 
            this.dtpdesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdesde.Location = new System.Drawing.Point(69, 3);
            this.dtpdesde.Name = "dtpdesde";
            this.dtpdesde.Size = new System.Drawing.Size(103, 22);
            this.dtpdesde.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "Desde";
            // 
            // cbocriterio
            // 
            this.cbocriterio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbocriterio.FormattingEnabled = true;
            this.cbocriterio.Items.AddRange(new object[] {
            "APELLIDOS",
            "DNI",
            "FECHAS"});
            this.cbocriterio.Location = new System.Drawing.Point(100, 19);
            this.cbocriterio.Name = "cbocriterio";
            this.cbocriterio.Size = new System.Drawing.Size(121, 25);
            this.cbocriterio.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(49)))), ((int)(((byte)(96)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Allqovet.Properties.Resources.buscar;
            this.button1.Location = new System.Drawing.Point(667, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Buscar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(227, 21);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(434, 22);
            this.txtbuscar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar por";
            // 
            // frmComprobantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(128)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(796, 430);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmComprobantes";
            this.Text = "frmComprobantes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelfecha.ResumeLayout(false);
            this.panelfecha.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panelfecha;
        private System.Windows.Forms.DateTimePicker dtphasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpdesde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbocriterio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label1;
    }
}