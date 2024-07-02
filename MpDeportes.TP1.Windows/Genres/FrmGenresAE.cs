using MpDeportes.TP1.Entidades;

namespace MpDeportes.TP1.Windows.Genres
{
    public partial class FrmGenresAE : Form
    {
        private Genre? genre;
        public FrmGenresAE()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (genre != null)
            {
                TextBoxGenreName.Text = genre.GenreName;
            }
        }

        private void ButtonAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (genre == null)
                {
                    genre = new Genre();

                }
                genre.GenreName = TextBoxGenreName.Text;

                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valid = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(TextBoxGenreName.Text))
            {
                valid = false;
                errorProvider1.SetError(TextBoxGenreName, "El genero es requerido!!!");
            }
            else if (double.TryParse(TextBoxGenreName.Text, out _))
            // _ se utiliza como descartar cuando no necesitas
            // almacenar el valor de salida del método TryParse
            {
                valid = false;
                errorProvider1.SetError(TextBoxGenreName, "El genero no debe ser un número!!!");
            }
            return valid;
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        public Genre? GetGenre()
        {
            return genre;
        }

        public void SetGenre(Genre? genree)
        {
            genre = genree;
        }
    }
}
