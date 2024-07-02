namespace MpDeportes.TP1.Windows.Genres
{
    partial class FrmGenresAE
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGenresAE));
            ButtonCancelar = new Button();
            ButtonAceptar = new Button();
            TextBoxGenreName = new TextBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // ButtonCancelar
            // 
            ButtonCancelar.Image = (Image)resources.GetObject("ButtonCancelar.Image");
            ButtonCancelar.Location = new Point(273, 95);
            ButtonCancelar.Name = "ButtonCancelar";
            ButtonCancelar.Size = new Size(73, 45);
            ButtonCancelar.TabIndex = 9;
            ButtonCancelar.UseVisualStyleBackColor = true;
            ButtonCancelar.Click += ButtonCancelar_Click;
            // 
            // ButtonAceptar
            // 
            ButtonAceptar.Image = (Image)resources.GetObject("ButtonAceptar.Image");
            ButtonAceptar.Location = new Point(22, 95);
            ButtonAceptar.Name = "ButtonAceptar";
            ButtonAceptar.Size = new Size(73, 45);
            ButtonAceptar.TabIndex = 10;
            ButtonAceptar.UseVisualStyleBackColor = true;
            ButtonAceptar.Click += ButtonAceptar_Click;
            // 
            // TextBoxGenreName
            // 
            TextBoxGenreName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxGenreName.Location = new Point(88, 31);
            TextBoxGenreName.Name = "TextBoxGenreName";
            TextBoxGenreName.PlaceholderText = "Ingrese nombre del genero...";
            TextBoxGenreName.Size = new Size(258, 29);
            TextBoxGenreName.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 34);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 7;
            label1.Text = "Genre:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmGenresAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 174);
            Controls.Add(ButtonCancelar);
            Controls.Add(ButtonAceptar);
            Controls.Add(TextBoxGenreName);
            Controls.Add(label1);
            MaximumSize = new Size(393, 213);
            MinimumSize = new Size(393, 213);
            Name = "FrmGenresAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmGenresAE";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonCancelar;
        private Button ButtonAceptar;
        private TextBox TextBoxGenreName;
        private Label label1;
        private ErrorProvider errorProvider1;
    }
}