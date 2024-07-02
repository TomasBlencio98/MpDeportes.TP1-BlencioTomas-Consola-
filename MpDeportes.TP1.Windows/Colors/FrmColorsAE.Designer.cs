namespace MpDeportes.TP1.Windows.Colors
{
    partial class FrmColorsAE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmColorsAE));
            ButtonCancelar = new Button();
            ButtonAceptar = new Button();
            TextBoxColorName = new TextBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // ButtonCancelar
            // 
            ButtonCancelar.Image = (Image)resources.GetObject("ButtonCancelar.Image");
            ButtonCancelar.Location = new Point(279, 97);
            ButtonCancelar.Name = "ButtonCancelar";
            ButtonCancelar.Size = new Size(73, 45);
            ButtonCancelar.TabIndex = 5;
            ButtonCancelar.UseVisualStyleBackColor = true;
            ButtonCancelar.Click += ButtonCancelar_Click;
            // 
            // ButtonAceptar
            // 
            ButtonAceptar.Image = (Image)resources.GetObject("ButtonAceptar.Image");
            ButtonAceptar.Location = new Point(28, 97);
            ButtonAceptar.Name = "ButtonAceptar";
            ButtonAceptar.Size = new Size(73, 45);
            ButtonAceptar.TabIndex = 6;
            ButtonAceptar.UseVisualStyleBackColor = true;
            ButtonAceptar.Click += ButtonAceptar_Click;
            // 
            // TextBoxColorName
            // 
            TextBoxColorName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxColorName.Location = new Point(94, 33);
            TextBoxColorName.Name = "TextBoxColorName";
            TextBoxColorName.PlaceholderText = "Ingrese nombre del color...";
            TextBoxColorName.Size = new Size(258, 29);
            TextBoxColorName.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 36);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 3;
            label1.Text = "Color: ";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmColorsAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 174);
            Controls.Add(ButtonCancelar);
            Controls.Add(ButtonAceptar);
            Controls.Add(TextBoxColorName);
            Controls.Add(label1);
            MaximumSize = new Size(393, 213);
            MinimumSize = new Size(393, 213);
            Name = "FrmColorsAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmColorsAE";
            //Load += FrmColorsAE_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonCancelar;
        private Button ButtonAceptar;
        private TextBox TextBoxColorName;
        private Label label1;
        private ErrorProvider errorProvider1;
    }
}