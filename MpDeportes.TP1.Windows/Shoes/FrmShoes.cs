using MpDeportes.TP1.Entidades.Dto;
using MpDeportes.TP1.Entidades;
using MpDeportes.TP1.Servicios.Interfaces;
using MpDeportes.TP1.Windows.Helpers;
using MpDeportes.TP1.Entidades.Enums;

namespace MpDeportes.TP1.Windows.Shoes
{
    public partial class FrmShoes : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IServicioShoe _servicio;
        private List<ShoeListDto>? lista;
        private Orden orden = Orden.SinOrden;


        private Brand? brandFiltro = null;
        private Genre? genreFiltro = null;

        private bool FilterOn = false;

        private int pageCount;
        private int pageSize = 2;
        private int pageNum = 0;
        private int recordCount;

        public FrmShoes(IServicioShoe servicioShoe,
            IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _servicio = servicioShoe;
            _serviceProvider = serviceProvider;
        }

        private void FrmShoes_Load(object sender, EventArgs e)
        {
            MostrarCantidadRegistros();
            RecargarGrilla();
        }

        private void RecargarGrilla()
        {
            try
            {
                recordCount = _servicio.GetCantidad();
                pageCount = FormHelpers.CalcularPaginas(recordCount, pageSize);
                TxbCantRegistros.Text = pageCount.ToString();
                CombosHelpers.CargarCombosPaginas(pageCount, ref ComboBoxPaginas);
                lista = _servicio.GetListaPaginadaOrdenada(pageNum, pageSize);
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
            if (lista is not null)
            {
                foreach (var item in lista)
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
            FrmShoesAE frm = new FrmShoesAE(_serviceProvider);
            DialogResult df = frm.ShowDialog(this);
            if (df == DialogResult.Cancel) { return; }
            try
            {
                var shoe = frm.GetShoe();
                if (shoe == null) return;
                if (!_servicio.Existe(shoe))
                {
                    _servicio.Guardar(shoe);
                    ActualizarListaDespuesAgregar(shoe);
                    MessageBox.Show("Registro Agregado!!!", "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    MostrarCantidadRegistros();
                }
                else
                {
                    MessageBox.Show("Planta existente!!!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void ActualizarListaDespuesAgregar(Shoe shoe)
        {
            int paginaActual = pageNum;
            lista = _servicio.GetListaPaginadaOrdenada(paginaActual, pageSize);
            MostrarDatosEnGrilla();
            bool shoeAgregadoEnPaginaActual = lista
                .Any(p => p.ShoeId == shoe.ShoeId);

            if (!shoeAgregadoEnPaginaActual)
            {
                pageNum = pageCount - 1;
                ComboBoxPaginas.SelectedIndex = pageNum;
                lista = _servicio.GetListaPaginadaOrdenada(pageNum, pageSize);
                MostrarDatosEnGrilla();
            }
        }

        private void ButtonPrimero_Click(object sender, EventArgs e)
        {
            pageNum = 0;
            ComboBoxPaginas.SelectedIndex = pageNum;
            ActualizarListaPaginada();
        }

        private void ActualizarListaPaginada()
        {
            lista = _servicio.GetListaPaginadaOrdenada(pageNum, pageSize);
            MostrarDatosEnGrilla();
        }

        private void ButtonAnterior_Click(object sender, EventArgs e)
        {
            pageNum--;
            if (pageNum < 0) { pageNum = 0; }
            ComboBoxPaginas.SelectedIndex = pageNum;
            ActualizarListaPaginada();
        }

        private void ButtonUltimo_Click(object sender, EventArgs e)
        {
            pageNum = pageCount - 1;
            ComboBoxPaginas.SelectedIndex = pageNum;
            ActualizarListaPaginada();
        }

        private void ButtonSiguiente_Click(object sender, EventArgs e)
        {
            pageNum++;
            if (pageNum > pageCount - 1) { pageNum = pageCount - 1; }
            ComboBoxPaginas.SelectedIndex = pageNum;
            ActualizarListaPaginada();
        }

        private void TsButtonBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0) return;
            var r = dgvDatos.SelectedRows[0];
            ShoeListDto? shoeDto = r.Tag as ShoeListDto;
            if (shoeDto == null) return;
            Shoe? shoe = _servicio.GetShoePorId(shoeDto.ShoeId);
            DialogResult dr = MessageBox.Show($"¿Desea dar de baja el registro?",
                "Confirmar Operación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No) return;
            try
            {
                if (shoe == null) return;
                _servicio.Borrar(shoe);
                GridHelpers.QuitarFila(r, dgvDatos);
                MessageBox.Show("Registro Borrado!!!", "Mensaje",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarListaPaginada();
                MostrarCantidadRegistros();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TsButtonEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0) { return; }
            var r = dgvDatos.SelectedRows[0];
            ShoeListDto? shoeDto = r.Tag as ShoeListDto;
            if (shoeDto == null) return;
            Shoe? shoe = _servicio.GetShoePorId(shoeDto.ShoeId);
            FrmShoesAE frm = new FrmShoesAE(_serviceProvider)
            { Text = "Editar Shoe" };
            frm.SetShoe(shoe);
            DialogResult dr = frm.ShowDialog(this);
            try
            {
                shoe = frm.GetShoe();
                if (shoe == null) return;
                if (!_servicio.Existe(shoe))
                {
                    _servicio.Guardar(shoe);
                    MessageBox.Show("Registro Editado!!!", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //ActualizarListaDespuesAgregar(shoe);
                    ActualizarListaPaginada();
                }
                else
                {
                    MessageBox.Show("Shoe existente!!!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void aZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DesactivarButtons();
            MostrarOrdenado(Orden.AZ);
        }

        private void DesactivarButtons()
        {
            ToolButtonNuevo.Enabled = false;
            TsButtonBorrar.Enabled = false;
            TsButtonEditar.Enabled = false;
            TsButtonFiltrar.Enabled = false;
            ComboBoxPaginas.Enabled = true;
            TextBoxCantRegistros.Enabled = false;
            ButtonPrimero.Enabled = false;
            ButtonAnterior.Enabled = false;
            ButtonSiguiente.Enabled = false;
            ButtonUltimo.Enabled = false;
        }

        private void zAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DesactivarButtons();
            MostrarOrdenado(Orden.ZA);
        }

        private void menorAMayorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DesactivarButtons();
            MostrarOrdenado(Orden.MenorPrecio);
        }

        private void MostrarOrdenado(Orden orden)
        {
            var listaSHOE = _servicio.GetListaOrdenadaFiltradaEntreRangoPrecios(orden, null, null, null, null, null, null);
            lista = _servicio.PasarListaDto(listaSHOE);
            MostrarDatosEnGrilla();
        }

        private void mayorAMenorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DesactivarButtons();
            MostrarOrdenado(Orden.MayorPrecio);
        }

        private void TsButtonActualizar_Click(object sender, EventArgs e)
        {
            ActivarButtons();
            RecargarGrilla();
        }

        private void ActivarButtons()
        {
            ToolButtonNuevo.Enabled = true;
            TsButtonBorrar.Enabled = true;
            TsButtonEditar.Enabled = true;
            TsButtonFiltrar.Enabled = true;
            ComboBoxPaginas.Enabled = true;
            TextBoxCantRegistros.Enabled = true;
            ButtonPrimero.Enabled = true;
            ButtonAnterior.Enabled = true;
            ButtonSiguiente.Enabled = true;
            ButtonUltimo.Enabled = true;
        }
    }
}
