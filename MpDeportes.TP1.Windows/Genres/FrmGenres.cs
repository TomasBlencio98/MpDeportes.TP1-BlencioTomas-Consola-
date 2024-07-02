using MpDeportes.TP1.Entidades.Dto;
using MpDeportes.TP1.Entidades;
using MpDeportes.TP1.Servicios.Interfaces;
using MpDeportes.TP1.Windows.Helpers;
using MpDeportes.TP1.Windows.Shoes;

namespace MpDeportes.TP1.Windows.Genres
{
    public partial class FrmGenres : Form
    {
        private readonly IServicioGenre _servicio;
        private readonly IServicioShoe _servicioShoe;
        private List<Genre>? listaGenres;
        private List<ShoeListDto>? listaShoesDto;
        private List<Shoe>? listaShoes;
        public FrmGenres(IServicioGenre servicio,
            IServicioShoe servicioShoe)
        {
            InitializeComponent();
            _servicio = servicio;
            _servicioShoe = servicioShoe;
        }

        private void FrmGenres_Load(object sender, EventArgs e)
        {
            MostrarCantidadRegistros();
            RecargarGrilla();
        }

        private void RecargarGrilla()
        {
            try
            {
                listaGenres = _servicio.GetLista();
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
            if (listaGenres is not null)
            {
                foreach (var item in listaGenres)
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
            FrmGenresAE frm = new FrmGenresAE() { Text = "Agregar Genero" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            try
            {
                Genre? genre = frm.GetGenre();
                if (genre == null) return;
                if (!_servicio.Existe(genre))
                {
                    _servicio.Guardar(genre);
                    var r = GridHelpers.ConstruirFila(dgvDatos);
                    GridHelpers.SetearFila(r, genre);
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
            Genre? genre = r.Tag as Genre;
            DialogResult dr = MessageBox.Show($"¿Desea dar de baja el genero {genre?.GenreName}?",
                "Confirmar Operación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No) return;
            try
            {
                if (genre == null) return;
                if (!_servicio.EstaRelacionado(genre))
                {
                    _servicio.Borrar(genre);
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
            Genre? genre = r.Tag as Genre;
            FrmGenresAE frm = new FrmGenresAE() { Text = "Editar Genero" };
            frm.SetGenre(genre);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            try
            {
                genre = frm.GetGenre();
                if (genre == null) return;
                if (!_servicio.Existe(genre))
                {
                    _servicio.Guardar(genre);
                    GridHelpers.SetearFila(r, genre);
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
            Genre? genre = r.Tag as Genre;
            if (genre == null) return;
            var genreEnDB = _servicio.GetGenrePorId(genre.GenreId);
            listaShoes = _servicio.GetShoes(genreEnDB);
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
