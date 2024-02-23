namespace CRM_UI.Forms.Functionalities
{
    partial class FormCrearVenta
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
            pictureBoxClose = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Image = Properties.Resources.cruz;
            pictureBoxClose.Location = new Point(10, 10);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(40, 40);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxClose.TabIndex = 1;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(pictureBoxClose);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1056, 522);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // FormCrearVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 522);
            Controls.Add(panel1);
            Name = "FormCrearVenta";
            Text = "FormCrearVenta";
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBoxClose;
        private Panel panel1;
    }
}