
namespace FacebookWinFormApp
{
    partial class ComposerForm
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
            this.buttonBuilder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBuilder
            // 
            this.buttonBuilder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuilder.Location = new System.Drawing.Point(78, 103);
            this.buttonBuilder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBuilder.Name = "buttonBuilder";
            this.buttonBuilder.Size = new System.Drawing.Size(145, 42);
            this.buttonBuilder.TabIndex = 0;
            this.buttonBuilder.Text = "Show Info";
            this.buttonBuilder.UseVisualStyleBackColor = true;
            this.buttonBuilder.Click += new System.EventHandler(this.buttonBuilder_Click);
            // 
            // ComposerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 197);
            this.Controls.Add(this.buttonBuilder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ComposerForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComposerForm";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button buttonBuilder;

    }
}