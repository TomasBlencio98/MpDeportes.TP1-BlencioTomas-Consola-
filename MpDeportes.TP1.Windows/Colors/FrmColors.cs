using MpDeportes.TP1.Entidades.Dto;
using MpDeportes.TP1.Entidades;
using MpDeportes.TP1.Servicios.Interfaces;
using Color = MpDeportes.TP1.Entidades.Color;
using MpDeportes.TP1.Windows.Helpers;
using MpDeportes.TP1.Windows.Shoes;

namespace MpDeportes.TP1.Windows.Colors
{
    public partial class FrmColors : Form
    {
        private readonly IServicioColor _servicio;
        private readonly IServicioShoe _servicioShoe;
        private List<Color>? listaColors;
        private List<ShoeListDto>? listaShoesDto;
        private List<Shoe>? listaShoes;
        public FrmColors(IServicioColor servicio,
            IServicioShoe servicioShoe)
        {
            InitializeComponent();
            _servicio = servicio;
            _servicioShoe = servicioShoe;
        }

        private void FrmColors_Load(object sender, EventArgs e)
        {
            MostrarCantidadRegistros();
            RecargarGrilla();
        }

        private void RecargarGrilla()
        {
            try
            {
                listaColors = _servicio.GetLista();
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
            if (listaColors is not null)
            {
                foreach (var item in listaColors)
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
            FrmColorsAE frm = new FrmColorsAE() { Text = "Agregar Color" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            try
            {
                Color? color = frm.GetColor();
                if (color == null) return;
                if (!_servicio.Existe(color))
                {
                    _servicio.Guardar(color);
                    var r = GridHelpers.ConstruirFila(dgvDatos);
                    GridHelpers.SetearFila(r, color);
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
            Color? color = r.Tag as Color;
            DialogResult dr = MessageBox.Show($"¿Desea dar de baja al color {color?.ColorName}?",
                "Confirmar Operación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No) return;
            try
            {
                if (color == null) return;
                if (!_servicio.EstaRelacionado(color))
                {
                    _servicio.Borrar(color);
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
            Color? color = r.Tag as Color;
            FrmColorsAE frm = new FrmColorsAE() { Text = "Editar Color" };
            frm.SetColor(color);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            try
            {
                color = frm.GetColor();
                if (color == null) return;
                if (!_servicio.Existe(color))
                {
                    _servicio.Guardar(color);
                    GridHelpers.SetearFila(r, color);
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
            Color? color = r.Tag as Color;
            if (color == null) return;
            var colorEnDB = _servicio.GetColorPorId(color.ColorId);
            listaShoes = _servicio.GetShoes(colorEnDB);
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
