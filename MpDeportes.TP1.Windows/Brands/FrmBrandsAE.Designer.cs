namespace MpDeportes.TP1.Windows.Brands
{
    partial class FrmBrandsAE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBrandsAE));
            label1 = new Label();
            TextBoxBrandName = new TextBox();
            ButtonAceptar = new Button();
            ButtonCancelar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 42);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 0;
            label1.Text = "Marca: ";
            // 
            // TextBoxBrandName
            // 
            TextBoxBrandName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxBrandName.Location = new Point(92, 39);
            TextBoxBrandName.Name = "TextBoxBrandName";
            TextBoxBrandName.PlaceholderText = "Ingrese nombre de la marca...";
            TextBoxBrandName.Size = new Size(258, 29);
            TextBoxBrandName.TabIndex = 1;
            // 
            // ButtonAceptar
            // 
            ButtonAceptar.Image = (Image)resources.GetObject("ButtonAceptar.Image");
            ButtonAceptar.Location = new Point(26, 103);
            ButtonAceptar.Name = "ButtonAceptar";
            ButtonAceptar.Size = new Size(73, 45);
            ButtonAceptar.TabIndex = 2;
            ButtonAceptar.UseVisualStyleBackColor = true;
            ButtonAceptar.Click += ButtonAceptar_Click;
            // 
            // ButtonCancelar
            // 
            ButtonCancelar.Image = (Image)resources.GetObject("ButtonCancelar.Image");
            ButtonCancelar.Location = new Point(277, 103);
            ButtonCancelar.Name = "ButtonCancelar";
            ButtonCancelar.Size = new Size(73, 45);
            ButtonCancelar.TabIndex = 2;
            ButtonCancelar.UseVisualStyleBackColor = true;
            ButtonCancelar.Click += ButtonCancelar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmBrandsAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 174);
            Controls.Add(ButtonCancelar);
            Controls.Add(ButtonAceptar);
            Controls.Add(TextBoxBrandName);
            Controls.Add(label1);
            MaximumSize = new Size(393, 213);
            MinimumSize = new Size(393, 213);
            Name = "FrmBrandsAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmBrandsAE";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TextBoxBrandName;
        private Button ButtonAceptar;
        private Button ButtonCancelar;
        private ErrorProvider errorProvider1;
    }
}