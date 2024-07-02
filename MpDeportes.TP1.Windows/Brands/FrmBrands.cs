using MpDeportes.TP1.Entidades;
using MpDeportes.TP1.Entidades.Dto;
using MpDeportes.TP1.Servicios.Interfaces;
using MpDeportes.TP1.Windows.Helpers;
using MpDeportes.TP1.Windows.Shoes;

namespace MpDeportes.TP1.Windows.Brands
{
    public partial class FrmBrands : Form
    {
        private readonly IServicioBrand _servicio;
        private readonly IServicioShoe _servicioShoe;
        private List<Brand>? listaBrands;
        private List<ShoeListDto>? listaShoesDto;
        private List<Shoe>? listaShoes;
        public FrmBrands(IServicioBrand servicio,
            IServicioShoe servicioShoe)
        {
            InitializeComponent();
            _servicio = servicio;
            _servicioShoe = servicioShoe;
        }

        private void FrmBrands_Load(object sender, EventArgs e)
        {
            MostrarCantidadRegistros();
            RecargarGrilla();
        }

        private void MostrarCantidadRegistros()
        {
            TextBoxCantRegistros.Text = _servicio.GetCantidad().ToString();
        }

        private void RecargarGrilla()
        {
            try
            {
                listaBrands = _servicio.GetLista();
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
            if (listaBrands is not null)
            {
                foreach (var item in listaBrands)
                {
                    DataGridViewRow r = GridHelpers.ConstruirFila(dgvDatos);
                    GridHelpers.SetearFila(r, item);
                    GridHelpers.AgregarFila(r, dgvDatos);
                }
            }
        }

        private void ToolButtonNuevo_Click(object sender, EventArgs e)
        {
            FrmBrandsAE frm = new FrmBrandsAE() { Text = "Agregar Marca" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            try
            {
                Brand? brand = frm.GetBrand();
                if (brand == null) return;
                if (!_servicio.Existe(brand))
                {
                    _servicio.Guardar(brand);
                    var r = GridHelpers.ConstruirFila(dgvDatos);
                    GridHelpers.SetearFila(r, brand);
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
            Brand? brand = r.Tag as Brand;
            DialogResult dr = MessageBox.Show($"¿Desea dar de baja a la marca {brand?.BrandName}?",
                "Confirmar Operación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No) return;
            try
            {
                if (brand == null) return;
                if (!_servicio.EstaRelacionado(brand))
                {
                    _servicio.Borrar(brand);
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
            Brand? brand = r.Tag as Brand;
            FrmBrandsAE frm = new FrmBrandsAE() { Text = "Editar Marca" };
            frm.SetBrand(brand);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            try
            {
                brand = frm.GetBrand();
                if (brand == null) return;
                if (!_servicio.Existe(brand))
                {
                    _servicio.Guardar(brand);
                    GridHelpers.SetearFila(r, brand);
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
            Brand? brand = r.Tag as Brand;
            if (brand == null) return;
            var brandEnDB = _servicio.GetBrandPorId(brand.BrandId);
            listaShoes = _servicio.GetShoes(brandEnDB);
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
