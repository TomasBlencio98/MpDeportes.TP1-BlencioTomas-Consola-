namespace MpDeportes.TP1.Windows
{
    partial class MenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            ButtonBrands = new Button();
            ButtonGenres = new Button();
            ButtonShoes = new Button();
            ButtonSports = new Button();
            ButtonColors = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(151, 34);
            label1.Name = "label1";
            label1.Size = new Size(302, 32);
            label1.TabIndex = 0;
            label1.Text = "MENU DE FORMULARIOS";
            // 
            // ButtonBrands
            // 
            ButtonBrands.Location = new Point(29, 185);
            ButtonBrands.Name = "ButtonBrands";
            ButtonBrands.Size = new Size(84, 46);
            ButtonBrands.TabIndex = 1;
            ButtonBrands.Text = "Brands";
            ButtonBrands.UseVisualStyleBackColor = true;
            ButtonBrands.Click += ButtonBrands_Click;
            // 
            // ButtonGenres
            // 
            ButtonGenres.Location = new Point(144, 185);
            ButtonGenres.Name = "ButtonGenres";
            ButtonGenres.Size = new Size(84, 46);
            ButtonGenres.TabIndex = 2;
            ButtonGenres.Text = "Genres";
            ButtonGenres.UseVisualStyleBackColor = true;
            ButtonGenres.Click += ButtonGenres_Click;
            // 
            // ButtonShoes
            // 
            ButtonShoes.Location = new Point(262, 96);
            ButtonShoes.Name = "ButtonShoes";
            ButtonShoes.Size = new Size(84, 46);
            ButtonShoes.TabIndex = 0;
            ButtonShoes.Text = "Shoes";
            ButtonShoes.UseVisualStyleBackColor = true;
            ButtonShoes.Click += ButtonShoes_Click;
            // 
            // ButtonSports
            // 
            ButtonSports.Location = new Point(369, 185);
            ButtonSports.Name = "ButtonSports";
            ButtonSports.Size = new Size(84, 46);
            ButtonSports.TabIndex = 3;
            ButtonSports.Text = "Sports";
            ButtonSports.UseVisualStyleBackColor = true;
            ButtonSports.Click += ButtonSports_Click;
            // 
            // ButtonColors
            // 
            ButtonColors.Location = new Point(486, 185);
            ButtonColors.Name = "ButtonColors";
            ButtonColors.Size = new Size(84, 46);
            ButtonColors.TabIndex = 4;
            ButtonColors.Text = "Colors";
            ButtonColors.UseVisualStyleBackColor = true;
            ButtonColors.Click += ButtonColors_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 320);
            Controls.Add(ButtonColors);
            Controls.Add(ButtonSports);
            Controls.Add(ButtonShoes);
            Controls.Add(ButtonGenres);
            Controls.Add(ButtonBrands);
            Controls.Add(label1);
            MaximumSize = new Size(637, 359);
            MinimumSize = new Size(637, 359);
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button ButtonBrands;
        private Button ButtonGenres;
        private Button ButtonShoes;
        private Button ButtonSports;
        private Button ButtonColors;
    }
}
