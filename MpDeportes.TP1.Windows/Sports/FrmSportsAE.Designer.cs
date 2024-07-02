namespace MpDeportes.TP1.Windows.Sports
{
    partial class FrmSportsAE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSportsAE));
            ButtonCancelar = new Button();
            ButtonAceptar = new Button();
            TextBoxSportName = new TextBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // ButtonCancelar
            // 
            ButtonCancelar.Image = (Image)resources.GetObject("ButtonCancelar.Image");
            ButtonCancelar.Location = new Point(273, 84);
            ButtonCancelar.Name = "ButtonCancelar";
            ButtonCancelar.Size = new Size(73, 45);
            ButtonCancelar.TabIndex = 13;
            ButtonCancelar.UseVisualStyleBackColor = true;
            ButtonCancelar.Click += ButtonCancelar_Click;
            // 
            // ButtonAceptar
            // 
            ButtonAceptar.Image = (Image)resources.GetObject("ButtonAceptar.Image");
            ButtonAceptar.Location = new Point(22, 84);
            ButtonAceptar.Name = "ButtonAceptar";
            ButtonAceptar.Size = new Size(73, 45);
            ButtonAceptar.TabIndex = 14;
            ButtonAceptar.UseVisualStyleBackColor = true;
            ButtonAceptar.Click += ButtonAceptar_Click;
            // 
            // TextBoxSportName
            // 
            TextBoxSportName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxSportName.Location = new Point(88, 20);
            TextBoxSportName.Name = "TextBoxSportName";
            TextBoxSportName.PlaceholderText = "Ingrese nombre del deporte...";
            TextBoxSportName.Size = new Size(258, 29);
            TextBoxSportName.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 23);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 11;
            label1.Text = "Sport: ";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmSportsAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 174);
            Controls.Add(ButtonCancelar);
            Controls.Add(ButtonAceptar);
            Controls.Add(TextBoxSportName);
            Controls.Add(label1);
            MaximumSize = new Size(393, 213);
            MinimumSize = new Size(393, 213);
            Name = "FrmSportsAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmSportsAE";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonCancelar;
        private Button ButtonAceptar;
        private TextBox TextBoxSportName;
        private Label label1;
        private ErrorProvider errorProvider1;
    }
}