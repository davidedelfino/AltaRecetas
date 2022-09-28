using AltaRecetas.Datos;
using AltaRecetas.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AltaRecetas
{
    public partial class Form1 : Form
    {
        private Receta oReceta;
        private DBHelper oDatos;
        public Form1()
        {
            InitializeComponent();
            oReceta = new Receta();
            oDatos=new DBHelper();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarCboTipos();
            CargarCboIngredientes();
        }

        private void CargarCboTipos()
        {
            cboTipoReceta.DataSource = oDatos.ConsultarDB("SP_TIPOS_RECETAS");
            cboTipoReceta.DisplayMember = "tipo";
            cboTipoReceta.ValueMember = "id_tipo";
        }

        private void CargarCboIngredientes()
        {
            cboIngredientes.DataSource = oDatos.ConsultarDB("SP_INGREDIENTES");
            cboIngredientes.DisplayMember = "ingrediente";
            cboIngredientes.ValueMember = "id_ingrediente";
        }

        private void ProximaReceta()
        {
            lblProximaReceta.Text = lblProximaReceta.Text += Convert.ToString(oDatos.ProximoID("SP_PROXIMA_RECETA"));
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            

            DataRowView item = (DataRowView)cboIngredientes.SelectedItem;

            int ingr = Convert.ToInt32(item.Row.ItemArray[0]);
            string nom = item.Row.ItemArray[1].ToString();
            Ingrediente ingrediente = new Ingrediente(ingr, nom);
            int cant = Convert.ToInt32(nudCantidad.Text);

            DetalleReceta detalle = new DetalleReceta(ingrediente, cant);

            oReceta.AgregarDetalle(detalle);

            dgvReceta.Rows.Add(new object[] { item.Row.ItemArray[0], item.Row.ItemArray[1], nudCantidad.Text });

            TotalIngredientes();
        }

        private void TotalIngredientes()
        {
            lblTotalIngredientes.Text = "Total de Ingredientes: " + Convert.ToString(oReceta.CantidadDetalles());
        }

        private void GuardarReceta()
        {
            oReceta.Nombre = txtNombre.Text;
            oReceta.Cheff = txtCheff.Text;
            oReceta.Tipo = (int)cboTipoReceta.SelectedValue;

            if (oDatos.ConfirmarReceta(oReceta))
            {
                MessageBox.Show("Receta Guardada");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo guardar la receta");
            }
        }
        private bool ExisteIngredienteRepetido(string text)
        {
            foreach (DataGridViewRow fila in dgvReceta.Rows)
            {
                if (fila.Cells["producto"].Value.Equals(text))
                    return true;
            }
            return false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvReceta.Rows.Count < 3)
            {
                MessageBox.Show("¿Ha olvidado algún ingrediente?", "Controls", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboIngredientes.Focus();
                return;

            }
            GuardarReceta();
            
        }

        private void LimpiarCampos()
        {
            txtCheff.Clear();
            txtNombre.Clear();
            cboIngredientes.Items.Clear();
        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvReceta.CurrentCell.ColumnIndex == 4)
            {
                oReceta.QuitarDetalle(dgvReceta.CurrentRow.Index);
                dgvReceta.Rows.Remove(dgvReceta.CurrentRow);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea cancelar?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Dispose();

            }
            else
            {
                return;
            }
        }
    }
}
