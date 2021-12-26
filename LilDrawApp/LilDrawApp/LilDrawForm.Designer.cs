
namespace LilDrawApp
{
    partial class LilDrawForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LilDrawForm));
            this.fullScreenButton = new System.Windows.Forms.Button();
            this.drawingArea = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.drawingArea)).BeginInit();
            this.SuspendLayout();
            // 
            // fullScreenButton
            // 
            this.fullScreenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fullScreenButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fullScreenButton.BackgroundImage")));
            this.fullScreenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fullScreenButton.Location = new System.Drawing.Point(536, 352);
            this.fullScreenButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.fullScreenButton.Name = "fullScreenButton";
            this.fullScreenButton.Size = new System.Drawing.Size(73, 74);
            this.fullScreenButton.TabIndex = 0;
            this.fullScreenButton.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.fullScreenButton.UseVisualStyleBackColor = true;
            this.fullScreenButton.Click += new System.EventHandler(this.fullScreenButton_Click);
            // 
            // drawingArea
            // 
            this.drawingArea.BackColor = System.Drawing.Color.White;
            this.drawingArea.Dock = System.Windows.Forms.DockStyle.Left;
            this.drawingArea.Location = new System.Drawing.Point(0, 0);
            this.drawingArea.Name = "drawingArea";
            this.drawingArea.Size = new System.Drawing.Size(520, 441);
            this.drawingArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.drawingArea.TabIndex = 1;
            this.drawingArea.TabStop = false;
            this.drawingArea.Click += new System.EventHandler(this.drawingArea_Click);
            // 
            // LilDrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.drawingArea);
            this.Controls.Add(this.fullScreenButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LilDrawForm";
            this.Text = "LilDrawApp";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LilDrawForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.drawingArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fullScreenButton;
        private System.Windows.Forms.PictureBox drawingArea;
    }
}

