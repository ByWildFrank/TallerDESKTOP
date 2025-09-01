namespace BeanPanelEscritorio
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            PnlNav = new FlowLayoutPanel();
            btnConfig = new Button();
            buttonAiMl = new Button();
            buttonCaja = new Button();
            buttonUsuarios = new Button();
            btnStock = new Button();
            BtnDashboard = new Button();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            panel3 = new Panel();
            label6 = new Label();
            label7 = new Label();
            imageList1 = new ImageList(components);
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            panel5 = new Panel();
            label9 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(PnlNav);
            panel1.Controls.Add(btnConfig);
            panel1.Controls.Add(buttonAiMl);
            panel1.Controls.Add(buttonCaja);
            panel1.Controls.Add(buttonUsuarios);
            panel1.Controls.Add(btnStock);
            panel1.Controls.Add(BtnDashboard);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 675);
            panel1.TabIndex = 0;
            // 
            // PnlNav
            // 
            PnlNav.BackColor = Color.DodgerBlue;
            PnlNav.Location = new Point(3, 190);
            PnlNav.Name = "PnlNav";
            PnlNav.Size = new Size(4, 100);
            PnlNav.TabIndex = 1;
            // 
            // btnConfig
            // 
            btnConfig.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnConfig.BackgroundImageLayout = ImageLayout.None;
            btnConfig.FlatAppearance.BorderSize = 0;
            btnConfig.FlatStyle = FlatStyle.Flat;
            btnConfig.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            btnConfig.ForeColor = Color.FromArgb(64, 158, 255);
            btnConfig.Image = (Image)resources.GetObject("btnConfig.Image");
            btnConfig.ImageAlign = ContentAlignment.MiddleRight;
            btnConfig.Location = new Point(0, 617);
            btnConfig.Name = "btnConfig";
            btnConfig.Padding = new Padding(25, 2, 25, 2);
            btnConfig.RightToLeft = RightToLeft.No;
            btnConfig.Size = new Size(230, 46);
            btnConfig.TabIndex = 6;
            btnConfig.Text = "Configuración";
            btnConfig.TextAlign = ContentAlignment.MiddleLeft;
            btnConfig.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnConfig.UseCompatibleTextRendering = true;
            btnConfig.UseVisualStyleBackColor = false;
            btnConfig.Click += btnConfig_Click;
            btnConfig.Leave += btnConfig_Leave;
            // 
            // buttonAiMl
            // 
            buttonAiMl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonAiMl.BackgroundImageLayout = ImageLayout.None;
            buttonAiMl.Dock = DockStyle.Top;
            buttonAiMl.FlatAppearance.BorderSize = 0;
            buttonAiMl.FlatStyle = FlatStyle.Flat;
            buttonAiMl.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            buttonAiMl.ForeColor = Color.FromArgb(64, 158, 255);
            buttonAiMl.Image = (Image)resources.GetObject("buttonAiMl.Image");
            buttonAiMl.ImageAlign = ContentAlignment.MiddleRight;
            buttonAiMl.Location = new Point(0, 436);
            buttonAiMl.Name = "buttonAiMl";
            buttonAiMl.Padding = new Padding(5, 2, 5, 2);
            buttonAiMl.RightToLeft = RightToLeft.No;
            buttonAiMl.Size = new Size(230, 73);
            buttonAiMl.TabIndex = 5;
            buttonAiMl.Text = "IA / ML";
            buttonAiMl.TextAlign = ContentAlignment.MiddleLeft;
            buttonAiMl.TextImageRelation = TextImageRelation.TextBeforeImage;
            buttonAiMl.UseCompatibleTextRendering = true;
            buttonAiMl.UseVisualStyleBackColor = false;
            buttonAiMl.Click += buttonAiMl_Click;
            buttonAiMl.Leave += buttonAiMl_Leave;
            // 
            // buttonCaja
            // 
            buttonCaja.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonCaja.BackgroundImageLayout = ImageLayout.None;
            buttonCaja.Dock = DockStyle.Top;
            buttonCaja.FlatAppearance.BorderSize = 0;
            buttonCaja.FlatStyle = FlatStyle.Flat;
            buttonCaja.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            buttonCaja.ForeColor = Color.FromArgb(64, 158, 255);
            buttonCaja.Image = (Image)resources.GetObject("buttonCaja.Image");
            buttonCaja.ImageAlign = ContentAlignment.MiddleRight;
            buttonCaja.Location = new Point(0, 363);
            buttonCaja.Name = "buttonCaja";
            buttonCaja.Padding = new Padding(5, 2, 5, 2);
            buttonCaja.RightToLeft = RightToLeft.No;
            buttonCaja.Size = new Size(230, 73);
            buttonCaja.TabIndex = 4;
            buttonCaja.Text = "Caja Registradora";
            buttonCaja.TextAlign = ContentAlignment.MiddleLeft;
            buttonCaja.TextImageRelation = TextImageRelation.TextBeforeImage;
            buttonCaja.UseCompatibleTextRendering = true;
            buttonCaja.UseVisualStyleBackColor = false;
            buttonCaja.Click += buttonCaja_Click;
            buttonCaja.Leave += buttonCaja_Leave;
            // 
            // buttonUsuarios
            // 
            buttonUsuarios.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonUsuarios.BackgroundImageLayout = ImageLayout.None;
            buttonUsuarios.Dock = DockStyle.Top;
            buttonUsuarios.FlatAppearance.BorderSize = 0;
            buttonUsuarios.FlatStyle = FlatStyle.Flat;
            buttonUsuarios.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            buttonUsuarios.ForeColor = Color.FromArgb(64, 158, 255);
            buttonUsuarios.Image = (Image)resources.GetObject("buttonUsuarios.Image");
            buttonUsuarios.ImageAlign = ContentAlignment.MiddleRight;
            buttonUsuarios.Location = new Point(0, 290);
            buttonUsuarios.Name = "buttonUsuarios";
            buttonUsuarios.Padding = new Padding(5, 2, 5, 2);
            buttonUsuarios.RightToLeft = RightToLeft.No;
            buttonUsuarios.Size = new Size(230, 73);
            buttonUsuarios.TabIndex = 3;
            buttonUsuarios.Text = "Gestión de Usuarios";
            buttonUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            buttonUsuarios.TextImageRelation = TextImageRelation.TextBeforeImage;
            buttonUsuarios.UseCompatibleTextRendering = true;
            buttonUsuarios.UseVisualStyleBackColor = false;
            buttonUsuarios.Click += buttonUsuarios_Click;
            buttonUsuarios.Leave += buttonUsuarios_Leave;
            // 
            // btnStock
            // 
            btnStock.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnStock.BackgroundImageLayout = ImageLayout.None;
            btnStock.Dock = DockStyle.Top;
            btnStock.FlatAppearance.BorderSize = 0;
            btnStock.FlatStyle = FlatStyle.Flat;
            btnStock.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            btnStock.ForeColor = Color.FromArgb(64, 158, 255);
            btnStock.Image = (Image)resources.GetObject("btnStock.Image");
            btnStock.ImageAlign = ContentAlignment.MiddleRight;
            btnStock.Location = new Point(0, 217);
            btnStock.Name = "btnStock";
            btnStock.Padding = new Padding(5, 2, 5, 2);
            btnStock.RightToLeft = RightToLeft.No;
            btnStock.Size = new Size(230, 73);
            btnStock.TabIndex = 2;
            btnStock.Text = "Gestión de Stock";
            btnStock.TextAlign = ContentAlignment.MiddleLeft;
            btnStock.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnStock.UseCompatibleTextRendering = true;
            btnStock.UseVisualStyleBackColor = false;
            btnStock.Click += btnStock_Click;
            btnStock.Leave += btnStock_Leave;
            // 
            // BtnDashboard
            // 
            BtnDashboard.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnDashboard.BackgroundImageLayout = ImageLayout.None;
            BtnDashboard.Dock = DockStyle.Top;
            BtnDashboard.FlatAppearance.BorderSize = 0;
            BtnDashboard.FlatStyle = FlatStyle.Flat;
            BtnDashboard.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            BtnDashboard.ForeColor = Color.FromArgb(64, 158, 255);
            BtnDashboard.Image = (Image)resources.GetObject("BtnDashboard.Image");
            BtnDashboard.ImageAlign = ContentAlignment.MiddleRight;
            BtnDashboard.Location = new Point(0, 144);
            BtnDashboard.Name = "BtnDashboard";
            BtnDashboard.Padding = new Padding(5, 2, 5, 2);
            BtnDashboard.RightToLeft = RightToLeft.No;
            BtnDashboard.Size = new Size(230, 73);
            BtnDashboard.TabIndex = 1;
            BtnDashboard.Text = "Dashboard";
            BtnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            BtnDashboard.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnDashboard.UseCompatibleTextRendering = true;
            BtnDashboard.UseVisualStyleBackColor = false;
            BtnDashboard.Click += BtnDashboard_Click;
            BtnDashboard.Leave += BtnDashboard_Leave;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(230, 144);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(74, 121);
            label2.Name = "label2";
            label2.Size = new Size(83, 12);
            label2.TabIndex = 2;
            label2.Text = "Tipo de Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 158, 255);
            label1.Location = new Point(74, 96);
            label1.Name = "label1";
            label1.Size = new Size(85, 16);
            label1.TabIndex = 1;
            label1.Text = "User Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(85, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(158, 161, 176);
            label3.Location = new Point(246, 21);
            label3.Name = "label3";
            label3.Size = new Size(156, 31);
            label3.TabIndex = 1;
            label3.Text = "Dashboard";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(74, 79, 99);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.ForeColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(801, 32);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(292, 20);
            textBox1.TabIndex = 2;
            textBox1.Text = "Búsqueda...";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(1113, 29);
            button1.Name = "button1";
            button1.Size = new Size(25, 25);
            button1.TabIndex = 3;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(37, 42, 64);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(291, 121);
            panel3.Name = "panel3";
            panel3.Size = new Size(258, 130);
            panel3.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 146, 249);
            label6.Location = new Point(37, 69);
            label6.Name = "label6";
            label6.Size = new Size(84, 21);
            label6.TabIndex = 0;
            label6.Text = "$150.000";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(24, 23);
            label7.Name = "label7";
            label7.Size = new Size(119, 30);
            label7.TabIndex = 2;
            label7.Text = "Recaudado";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(171, 23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 51);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(37, 42, 64);
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(602, 121);
            panel4.Name = "panel4";
            panel4.Size = new Size(304, 130);
            panel4.TabIndex = 6;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(235, 23);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(51, 51);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 146, 249);
            label4.Location = new Point(37, 69);
            label4.Name = "label4";
            label4.Size = new Size(50, 21);
            label4.TabIndex = 0;
            label4.Text = "1500";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(24, 23);
            label5.Name = "label5";
            label5.Size = new Size(205, 30);
            label5.TabIndex = 2;
            label5.Text = "Productos Vendidos";
            label5.Click += label5_Click_1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(37, 42, 64);
            panel5.Controls.Add(label9);
            panel5.Location = new Point(291, 334);
            panel5.Name = "panel5";
            panel5.Size = new Size(304, 130);
            panel5.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(24, 23);
            label9.Name = "label9";
            label9.Size = new Size(205, 30);
            label9.TabIndex = 2;
            label9.Text = "Productos Vendidos";
            label9.Click += label9_Click;
            // 
            // Form1
            // 



            ///
            //nuevo codigo uwu


            // Contenedor principal para cambiar de vistas
            this.panelContenedor = new Panel();
            this.panelContenedor.Dock = DockStyle.Fill;
            this.panelContenedor.BackColor = Color.FromArgb(46, 51, 73);
            this.panelContenedor.Location = new Point(230, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new Size(970, 675);
            this.panelContenedor.TabIndex = 99;

            this.Controls.Add(this.panelContenedor);
            this.Controls.SetChildIndex(this.panelContenedor, 0);

            ///



            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1200, 675);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Button BtnDashboard;
        private Button buttonCaja;
        private Button buttonUsuarios;
        private Button btnStock;
        private Button buttonAiMl;
        private Button btnConfig;
        private FlowLayoutPanel PnlNav;
        private Label label3;
        private TextBox textBox1;
        private Button button1;
        private Panel panel3;
        private Label label6;
        private PictureBox pictureBox2;
        private Label label7;
        private ImageList imageList1;
        private Panel panel4;
        private PictureBox pictureBox3;
        private Label label4;
        private Label label5;
        private Panel panel5;
        private Label label9;

        // este es el nuevo panel contenedor
        private Panel panelContenedor;

    }
}
