using System.Runtime.InteropServices;
namespace BeanPanelEscritorio
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            PnlNav.Height = BtnDashboard.Height;
            PnlNav.Top = BtnDashboard.Top;
            PnlNav.Left = BtnDashboard.Left;
            PnlNav.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            BtnDashboard.BackColor = Color.FromArgb(46, 51, 73);
            PnlNav.Height = BtnDashboard.Height;
            PnlNav.Top = BtnDashboard.Top;
            PnlNav.Left = BtnDashboard.Left;
            PnlNav.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void btnStock_Click(object sender, EventArgs e)
        {
            btnStock.BackColor = Color.FromArgb(46, 51, 73);
            PnlNav.Height = btnStock.Height;
            PnlNav.Top = btnStock.Top;
            PnlNav.Left = btnStock.Left;
            PnlNav.BackColor = Color.FromArgb(46, 51, 73);

            // Mostrar panel de productos
            panelContenedor.Controls.Clear();
            ProductosPanel productosPanel = new ProductosPanel();
            panelContenedor.Controls.Add(productosPanel);
        }


        private void buttonUsuarios_Click(object sender, EventArgs e)
        {
            buttonUsuarios.BackColor = Color.FromArgb(46, 51, 73);
            PnlNav.Height = buttonUsuarios.Height;
            PnlNav.Top = buttonUsuarios.Top;
            PnlNav.Left = buttonUsuarios.Left;
            PnlNav.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void buttonCaja_Click(object sender, EventArgs e)
        {
            buttonCaja.BackColor = Color.FromArgb(46, 51, 73);
            PnlNav.Height = buttonCaja.Height;
            PnlNav.Top = buttonCaja.Top;
            PnlNav.Left = buttonCaja.Left;
            PnlNav.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void buttonAiMl_Click(object sender, EventArgs e)
        {
            buttonAiMl.BackColor = Color.FromArgb(46, 51, 73);
            PnlNav.Height = buttonAiMl.Height;
            PnlNav.Top = buttonAiMl.Top;
            PnlNav.Left = buttonAiMl.Left;
            PnlNav.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void btnConfig_Click(object sender, EventArgs e)
        {
            btnConfig.BackColor = Color.FromArgb(46, 51, 73);
            PnlNav.Height = btnConfig.Height;
            PnlNav.Top = btnConfig.Top;
            PnlNav.Left = btnConfig.Left;
            PnlNav.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void BtnDashboard_Leave(object sender, EventArgs e)
        {
            BtnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnStock_Leave(object sender, EventArgs e)
        {
            btnStock.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void buttonUsuarios_Leave(object sender, EventArgs e)
        {
            buttonUsuarios.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void buttonCaja_Leave(object sender, EventArgs e)
        {
            buttonCaja.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void buttonAiMl_Leave(object sender, EventArgs e)
        {
            buttonAiMl.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnConfig_Leave(object sender, EventArgs e)
        {
            btnConfig.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}

