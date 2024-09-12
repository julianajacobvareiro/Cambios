namespace Cambios
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            TextBoxValor = new TextBox();
            label2 = new Label();
            label3 = new Label();
            ComboBoxOrigem = new ComboBox();
            ComboBoxDestino = new ComboBox();
            buttonConverter = new Button();
            LabelResultado = new Label();
            LabelStatus = new Label();
            ProgressBar1 = new ProgressBar();
            ButtonTroca = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(87, 69);
            label1.Name = "label1";
            label1.Size = new Size(57, 23);
            label1.TabIndex = 0;
            label1.Text = "Valor:";
            // 
            // TextBoxValor
            // 
            TextBoxValor.Location = new Point(150, 65);
            TextBoxValor.Name = "TextBoxValor";
            TextBoxValor.Size = new Size(378, 27);
            TextBoxValor.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(87, 125);
            label2.Name = "label2";
            label2.Size = new Size(161, 23);
            label2.TabIndex = 2;
            label2.Text = "Moeda de Origem:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(87, 180);
            label3.Name = "label3";
            label3.Size = new Size(161, 23);
            label3.TabIndex = 3;
            label3.Text = "Moeda de Destino:";
            // 
            // ComboBoxOrigem
            // 
            ComboBoxOrigem.FormattingEnabled = true;
            ComboBoxOrigem.Location = new Point(267, 120);
            ComboBoxOrigem.Name = "ComboBoxOrigem";
            ComboBoxOrigem.Size = new Size(261, 28);
            ComboBoxOrigem.TabIndex = 4;
            // 
            // ComboBoxDestino
            // 
            ComboBoxDestino.FormattingEnabled = true;
            ComboBoxDestino.Location = new Point(267, 180);
            ComboBoxDestino.Name = "ComboBoxDestino";
            ComboBoxDestino.Size = new Size(261, 28);
            ComboBoxDestino.TabIndex = 5;
            // 
            // buttonConverter
            // 
            buttonConverter.Enabled = false;
            buttonConverter.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonConverter.Location = new Point(572, 69);
            buttonConverter.Name = "buttonConverter";
            buttonConverter.Size = new Size(129, 52);
            buttonConverter.TabIndex = 6;
            buttonConverter.Text = "Converter";
            buttonConverter.UseVisualStyleBackColor = true;
            buttonConverter.Click += buttonConverter_Click;
            // 
            // LabelResultado
            // 
            LabelResultado.AutoSize = true;
            LabelResultado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LabelResultado.Location = new Point(267, 244);
            LabelResultado.Name = "LabelResultado";
            LabelResultado.Size = new Size(374, 23);
            LabelResultado.TabIndex = 7;
            LabelResultado.Text = "Escolha um valor, moeda de origem e destino";
            // 
            // LabelStatus
            // 
            LabelStatus.AutoSize = true;
            LabelStatus.Location = new Point(87, 313);
            LabelStatus.Name = "LabelStatus";
            LabelStatus.Size = new Size(49, 20);
            LabelStatus.TabIndex = 8;
            LabelStatus.Text = "Status";
            // 
            // ProgressBar1
            // 
            ProgressBar1.Location = new Point(504, 305);
            ProgressBar1.Name = "ProgressBar1";
            ProgressBar1.Size = new Size(181, 28);
            ProgressBar1.TabIndex = 9;
            // 
            // ButtonTroca
            // 
            ButtonTroca.Enabled = false;
            ButtonTroca.Image = (Image)resources.GetObject("ButtonTroca.Image");
            ButtonTroca.Location = new Point(596, 142);
            ButtonTroca.Name = "ButtonTroca";
            ButtonTroca.Size = new Size(75, 66);
            ButtonTroca.TabIndex = 10;
            ButtonTroca.UseVisualStyleBackColor = true;
            ButtonTroca.Click += ButtonTroca_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 384);
            Controls.Add(ButtonTroca);
            Controls.Add(ProgressBar1);
            Controls.Add(LabelStatus);
            Controls.Add(LabelResultado);
            Controls.Add(buttonConverter);
            Controls.Add(ComboBoxDestino);
            Controls.Add(ComboBoxOrigem);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TextBoxValor);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Câmbios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TextBoxValor;
        private Label label2;
        private Label label3;
        private ComboBox ComboBoxOrigem;
        private ComboBox ComboBoxDestino;
        private Button buttonConverter;
        private Label LabelResultado;
        private Label LabelStatus;
        private ProgressBar ProgressBar1;
        private Button ButtonTroca;
    }
}
