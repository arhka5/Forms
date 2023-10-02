namespace G16_medicamentos
{
    partial class FrmDatos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            dgvDatos = new DataGridView();
            tsmMenu = new ToolStrip();
            tslAyuda = new ToolStripLabel();
            tslSalir = new ToolStripLabel();
            erpError = new ErrorProvider(components);
            tslRegistrar = new Button();
            tlsBuscar = new Button();
            tlsEliminar = new Button();
            tslOrdenar = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            tsmMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)erpError).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(187, 58);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "Codigo :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(187, 87);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(187, 116);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 2;
            label3.Text = "Cantidad :";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(290, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(149, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(290, 84);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(149, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(290, 113);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(65, 23);
            textBox3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(187, 142);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 6;
            label4.Text = "Precio Unitario:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(290, 142);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(65, 23);
            textBox4.TabIndex = 7;
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(187, 184);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowTemplate.Height = 25;
            dgvDatos.Size = new Size(542, 206);
            dgvDatos.TabIndex = 8;
            // 
            // tsmMenu
            // 
            tsmMenu.Items.AddRange(new ToolStripItem[] { tslAyuda, tslSalir });
            tsmMenu.Location = new Point(0, 0);
            tsmMenu.Name = "tsmMenu";
            tsmMenu.Size = new Size(767, 25);
            tsmMenu.TabIndex = 9;
            tsmMenu.Text = "toolStrip1";
            // 
            // tslAyuda
            // 
            tslAyuda.Name = "tslAyuda";
            tslAyuda.Size = new Size(41, 22);
            tslAyuda.Text = "Ayuda";
            tslAyuda.Click += toolStripLabel1_Click_1;
            // 
            // tslSalir
            // 
            tslSalir.Name = "tslSalir";
            tslSalir.Size = new Size(56, 22);
            tslSalir.Text = "     Salir    ";
            tslSalir.Click += tslSalir_Click;
            // 
            // erpError
            // 
            erpError.ContainerControl = this;
            // 
            // tslRegistrar
            // 
            tslRegistrar.BackColor = Color.Black;
            tslRegistrar.FlatAppearance.BorderColor = Color.Black;
            tslRegistrar.FlatAppearance.BorderSize = 0;
            tslRegistrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            tslRegistrar.FlatAppearance.MouseOverBackColor = Color.Gray;
            tslRegistrar.FlatStyle = FlatStyle.Flat;
            tslRegistrar.ForeColor = Color.Gainsboro;
            tslRegistrar.Location = new Point(3, 139);
            tslRegistrar.Name = "tslRegistrar";
            tslRegistrar.Size = new Size(164, 46);
            tslRegistrar.TabIndex = 10;
            tslRegistrar.Text = "Registrar";
            tslRegistrar.UseVisualStyleBackColor = false;
            tslRegistrar.Click += tslRegistrar_Click;
            // 
            // tlsBuscar
            // 
            tlsBuscar.FlatAppearance.BorderSize = 0;
            tlsBuscar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            tlsBuscar.FlatAppearance.MouseOverBackColor = Color.Gray;
            tlsBuscar.FlatStyle = FlatStyle.Flat;
            tlsBuscar.Location = new Point(0, 179);
            tlsBuscar.Name = "tlsBuscar";
            tlsBuscar.Size = new Size(164, 45);
            tlsBuscar.TabIndex = 11;
            tlsBuscar.Text = "Buscar";
            tlsBuscar.UseVisualStyleBackColor = true;
            tlsBuscar.Click += tlsBuscar_Click_1;
            // 
            // tlsEliminar
            // 
            tlsEliminar.FlatAppearance.BorderSize = 0;
            tlsEliminar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            tlsEliminar.FlatAppearance.MouseOverBackColor = Color.Gray;
            tlsEliminar.FlatStyle = FlatStyle.Flat;
            tlsEliminar.ForeColor = Color.Gainsboro;
            tlsEliminar.Location = new Point(0, 219);
            tlsEliminar.Name = "tlsEliminar";
            tlsEliminar.Size = new Size(164, 44);
            tlsEliminar.TabIndex = 12;
            tlsEliminar.Text = "Eliminar";
            tlsEliminar.UseVisualStyleBackColor = true;
            tlsEliminar.Click += tlsEliminar_Click_1;
            // 
            // tslOrdenar
            // 
            tslOrdenar.FlatAppearance.BorderSize = 0;
            tslOrdenar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            tslOrdenar.FlatAppearance.MouseOverBackColor = Color.Gray;
            tslOrdenar.FlatStyle = FlatStyle.Flat;
            tslOrdenar.Location = new Point(0, 260);
            tslOrdenar.Name = "tslOrdenar";
            tslOrdenar.Size = new Size(164, 44);
            tslOrdenar.TabIndex = 13;
            tslOrdenar.Text = "Ordenar";
            tslOrdenar.UseVisualStyleBackColor = true;
            tslOrdenar.Click += tslOrdenar_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(tslOrdenar);
            panel1.Controls.Add(tslRegistrar);
            panel1.Controls.Add(tlsBuscar);
            panel1.Controls.Add(tlsEliminar);
            panel1.ForeColor = Color.Gainsboro;
            panel1.Location = new Point(0, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(164, 433);
            panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_pantalla_2023_10_01_1629021;
            pictureBox1.Location = new Point(3, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 55);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(164, 85);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(179, 100);
            flowLayoutPanel1.TabIndex = 14;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.pngwing_com;
            pictureBox2.Location = new Point(601, 47);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(128, 118);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // FrmDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Goldenrod;
            ClientSize = new Size(767, 406);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(tsmMenu);
            Controls.Add(dgvDatos);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmDatos";
            Text = "Lista de Medicamentos G16";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            tsmMenu.ResumeLayout(false);
            tsmMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)erpError).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private DataGridView dgvDatos;
        private ToolStrip tsmMenu;
        private ToolStripLabel Buscar;
        private ErrorProvider erpError;
        private Button tslRegistrar;
        private Button tlsBuscar;
        private Button tlsEliminar;
        private Button tslOrdenar;
        private ToolStripLabel tslAyuda;
        private ToolStripLabel tslSalir;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}