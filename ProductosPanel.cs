using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BeanPanelEscritorio
{
    public partial class ProductosPanel : UserControl
    {
        private DataGridView dgvProductos;
        private Button btnAgregar, btnEditar, btnEliminar;

        private List<Producto> productos = new List<Producto>();

        public ProductosPanel()
        {
            InitializeComponent();
            CargarProductos();
        }

        private void InitializeComponent()
        {
            this.Dock = DockStyle.Fill;
            this.BackColor = Color.FromArgb(37, 42, 64);

            // DataGridView
            dgvProductos = new DataGridView();
            dgvProductos.Dock = DockStyle.Top;
            dgvProductos.Height = 300;
            dgvProductos.BackgroundColor = Color.FromArgb(74, 79, 99);
            dgvProductos.ForeColor = Color.White;
            dgvProductos.GridColor = Color.Black;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Botones
            FlowLayoutPanel panelBotones = new FlowLayoutPanel();
            panelBotones.Dock = DockStyle.Top;
            panelBotones.Height = 50;

            btnAgregar = new Button();
            btnAgregar.Text = "Agregar";
            btnAgregar.Click += BtnAgregar_Click;

            btnEditar = new Button();
            btnEditar.Text = "Editar";
            btnEditar.Click += BtnEditar_Click;

            btnEliminar = new Button();
            btnEliminar.Text = "Eliminar";
            btnEliminar.Click += BtnEliminar_Click;

            panelBotones.Controls.Add(btnAgregar);
            panelBotones.Controls.Add(btnEditar);
            panelBotones.Controls.Add(btnEliminar);

            this.Controls.Add(dgvProductos);
            this.Controls.Add(panelBotones);
        }

        private void CargarProductos()
        {
            // Lista ficticia
            productos = new List<Producto>()
            {
                new Producto { Id = 1, Nombre = "Café Espresso", Precio = 500 },
                new Producto { Id = 2, Nombre = "Capuccino", Precio = 650 },
                new Producto { Id = 3, Nombre = "Latte", Precio = 700 }
            };

            dgvProductos.DataSource = null;
            dgvProductos.DataSource = productos;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            productos.Add(new Producto { Id = productos.Count + 1, Nombre = "Nuevo Producto", Precio = 0 });
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = productos;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                Producto prod = (Producto)dgvProductos.CurrentRow.DataBoundItem;
                prod.Nombre += " (Editado)";
                dgvProductos.Refresh();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                Producto prod = (Producto)dgvProductos.CurrentRow.DataBoundItem;
                productos.Remove(prod);
                dgvProductos.DataSource = null;
                dgvProductos.DataSource = productos;
            }
        }
    }

    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
    }
}
