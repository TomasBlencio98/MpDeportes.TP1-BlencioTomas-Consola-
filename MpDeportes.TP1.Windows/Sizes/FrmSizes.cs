using MpDeportes.TP1.Entidades.Dto;
using MpDeportes.TP1.Entidades;
using MpDeportes.TP1.Servicios.Interfaces;
using Size = MpDeportes.TP1.Entidades.Size;
using MpDeportes.TP1.Windows.Helpers;
using MpDeportes.TP1.Windows.Genres;
using MpDeportes.TP1.Windows.Shoes;

namespace MpDeportes.TP1.Windows.Sizes
{
    public partial class FrmSizes : Form
    {
        private readonly IServicioSize _servicio;
        private readonly IServicioShoe _servicioShoe;
        private List<Size>? listaSizes;
        private List<ShoeListDto>? listaShoesDto;
        private List<Shoe>? listaShoes;
        public FrmSizes(IServicioSize servicio,
            IServicioShoe servicioShoe)
        {
            InitializeComponent();
            _servicio = servicio;
            _servicioShoe = servicioShoe;
        }

        private void FrmSizes_Load(object sender, EventArgs e)
        {
            MostrarCantidadRegistros();
            RecargarGrilla();
        }

        private void RecargarGrilla()
        {
            try
            {
                listaSizes = _servicio.GetLista();
                MostrarDatosEnGrilla();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void MostrarDatosEnGrilla()
        {
            GridHelpers.LimpiarGrilla(dgvDatos);
            if (listaSizes is not null)
            {
                foreach (var item in listaSizes)
                {
                    DataGridViewRow r = GridHelpers.ConstruirFila(dgvDatos);
                    GridHelpers.SetearFila(r, item);
                    GridHelpers.AgregarFila(r, dgvDatos);
                }
            }
        }

        private void MostrarCantidadRegistros()
        {
            TextBoxCantRegistros.Text = _servicio.GetCantidad().ToString();
        }

        private void ToolButtonNuevo_Click(object sender, EventArgs e)
        {
            FrmSizesAE frm = new FrmSizesAE() { Text = "Agregar Talle" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            try
            {
                Size? size = frm.GetSize();
                if (size == null) return;
                if (!_servicio.Existe(size))
                {
                    _servicio.Guardar(size);
                    var r = GridHelpers.ConstruirFila(dgvDatos);
                    GridHelpers.SetearFila(r, size);
                    GridHelpers.AgregarFila(r, dgvDatos);
                    MessageBox.Show("Registro Agregado!!!", "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    MostrarCantidadRegistros();
                }
                else
                {
                    MessageBox.Show("Registro Duplicado", "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void TsButtonBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0) return;
            var r = dgvDatos.SelectedRows[0];
            Size? size = r.Tag as Size;
            DialogResult dr = MessageBox.Show($"¿Desea dar de baja el Talle {size?.SizeNumber}?",
                "Confirmar Operación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No) return;
            try
            {
                if (size == null) return;
                if (!_servicio.EstaRelacionado(size))
                {
                    _servicio.Borrar(size);
                    GridHelpers.QuitarFila(r, dgvDatos);
                    MessageBox.Show("Registro Borrado!!!", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarCantidadRegistros();
                }
                else
                {
                    MessageBox.Show("Registro Relacionado...Baja denegada!!!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TsButtonEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0) return;
            var r = dgvDatos.SelectedRows[0];
            Size? size = r.Tag as Size;
            FrmSizesAE frm = new FrmSizesAE() { Text = "Editar Talle" };
            frm.SetSize(size);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            try
            {
                size = frm.GetSize();
                if (size == null) return;
                if (!_servicio.Existe(size))
                {
                    _servicio.Guardar(size);
                    GridHelpers.SetearFila(r, size);
                    MessageBox.Show("Registro Editado!!!", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Registro duplicado", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TsButtonFiltrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0) return;
            var r = dgvDatos.SelectedRows[0];
            Size? size = r.Tag as Size;
            if (size == null) return;
            var sizeEnDB = _servicio.GetSizesPorId(size.SizeId);
            listaShoes = _servicio.GetShoes(sizeEnDB);
            if (listaShoes == null) return;
            listaShoesDto = _servicioShoe.PasarListaDto(listaShoes);
            FrmMostrarShoes frm = new FrmMostrarShoes();
            frm.SetLista(listaShoesDto);
            frm.ShowDialog(this);
        }

        private void TsButtonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
