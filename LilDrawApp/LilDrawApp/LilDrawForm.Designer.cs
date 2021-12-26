
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
            this.clearButton = new System.Windows.Forms.Button();
            this.colorSelectPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonXS = new System.Windows.Forms.Button();
            this.buttonXL = new System.Windows.Forms.Button();
            this.buttonL = new System.Windows.Forms.Button();
            this.buttonM = new System.Windows.Forms.Button();
            this.buttonS = new System.Windows.Forms.Button();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.drawingArea)).BeginInit();
            this.colorSelectPanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // fullScreenButton
            // 
            this.fullScreenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fullScreenButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fullScreenButton.BackgroundImage")));
            this.fullScreenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fullScreenButton.Location = new System.Drawing.Point(78, 7);
            this.fullScreenButton.Margin = new System.Windows.Forms.Padding(6);
            this.fullScreenButton.Name = "fullScreenButton";
            this.fullScreenButton.Size = new System.Drawing.Size(50, 50);
            this.fullScreenButton.TabIndex = 0;
            this.fullScreenButton.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.fullScreenButton.UseVisualStyleBackColor = true;
            this.fullScreenButton.Click += new System.EventHandler(this.fullScreenButton_Click);
            // 
            // drawingArea
            // 
            this.drawingArea.BackColor = System.Drawing.Color.White;
            this.drawingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawingArea.Location = new System.Drawing.Point(0, 0);
            this.drawingArea.Name = "drawingArea";
            this.drawingArea.Size = new System.Drawing.Size(1264, 985);
            this.drawingArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.drawingArea.TabIndex = 1;
            this.drawingArea.TabStop = false;
            this.drawingArea.Click += new System.EventHandler(this.drawingArea_Click);
            this.drawingArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawingArea_MouseDown);
            this.drawingArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawingArea_MouseMove);
            this.drawingArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawingArea_MouseUp);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clearButton.BackgroundImage")));
            this.clearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearButton.Location = new System.Drawing.Point(19, 7);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(50, 50);
            this.clearButton.TabIndex = 3;
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // colorSelectPanel
            // 
            this.colorSelectPanel.Controls.Add(this.button1);
            this.colorSelectPanel.Controls.Add(this.button2);
            this.colorSelectPanel.Controls.Add(this.button4);
            this.colorSelectPanel.Controls.Add(this.button6);
            this.colorSelectPanel.Controls.Add(this.button3);
            this.colorSelectPanel.Controls.Add(this.button10);
            this.colorSelectPanel.Controls.Add(this.button11);
            this.colorSelectPanel.Controls.Add(this.button5);
            this.colorSelectPanel.Controls.Add(this.button9);
            this.colorSelectPanel.Controls.Add(this.button8);
            this.colorSelectPanel.Controls.Add(this.button7);
            this.colorSelectPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.colorSelectPanel.Location = new System.Drawing.Point(0, 0);
            this.colorSelectPanel.Name = "colorSelectPanel";
            this.colorSelectPanel.Size = new System.Drawing.Size(666, 64);
            this.colorSelectPanel.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(10, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(70, 10);
            this.button2.Margin = new System.Windows.Forms.Padding(10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Orange;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(130, 10);
            this.button4.Margin = new System.Windows.Forms.Padding(10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 40);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Yellow;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(190, 10);
            this.button6.Margin = new System.Windows.Forms.Padding(10);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(40, 40);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Lime;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(250, 10);
            this.button3.Margin = new System.Windows.Forms.Padding(10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 40);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.DarkGreen;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(310, 10);
            this.button10.Margin = new System.Windows.Forms.Padding(10);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(40, 40);
            this.button10.TabIndex = 9;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.DodgerBlue;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(370, 10);
            this.button11.Margin = new System.Windows.Forms.Padding(10);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(40, 40);
            this.button11.TabIndex = 10;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Blue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(430, 10);
            this.button5.Margin = new System.Windows.Forms.Padding(10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 40);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Purple;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(490, 10);
            this.button9.Margin = new System.Windows.Forms.Padding(10);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(40, 40);
            this.button9.TabIndex = 8;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Gray;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(550, 10);
            this.button8.Margin = new System.Windows.Forms.Padding(10);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(40, 40);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Black;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(610, 10);
            this.button7.Margin = new System.Windows.Forms.Padding(10);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(40, 40);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.panel1);
            this.menuPanel.Controls.Add(this.buttonsPanel);
            this.menuPanel.Controls.Add(this.colorSelectPanel);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuPanel.Location = new System.Drawing.Point(0, 921);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(1264, 64);
            this.menuPanel.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonXS);
            this.panel1.Controls.Add(this.buttonXL);
            this.panel1.Controls.Add(this.buttonL);
            this.panel1.Controls.Add(this.buttonM);
            this.panel1.Controls.Add(this.buttonS);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(666, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 64);
            this.panel1.TabIndex = 7;
            // 
            // buttonXS
            // 
            this.buttonXS.BackColor = System.Drawing.Color.White;
            this.buttonXS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXS.Location = new System.Drawing.Point(21, 13);
            this.buttonXS.Name = "buttonXS";
            this.buttonXS.Size = new System.Drawing.Size(62, 40);
            this.buttonXS.TabIndex = 4;
            this.buttonXS.Text = "XS";
            this.buttonXS.UseVisualStyleBackColor = false;
            this.buttonXS.Click += new System.EventHandler(this.buttonXS_Click);
            // 
            // buttonXL
            // 
            this.buttonXL.BackColor = System.Drawing.Color.White;
            this.buttonXL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXL.Location = new System.Drawing.Point(311, 13);
            this.buttonXL.Name = "buttonXL";
            this.buttonXL.Size = new System.Drawing.Size(62, 40);
            this.buttonXL.TabIndex = 3;
            this.buttonXL.Text = "XL";
            this.buttonXL.UseVisualStyleBackColor = false;
            this.buttonXL.Click += new System.EventHandler(this.buttonXL_Click);
            // 
            // buttonL
            // 
            this.buttonL.BackColor = System.Drawing.Color.White;
            this.buttonL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonL.Location = new System.Drawing.Point(237, 13);
            this.buttonL.Name = "buttonL";
            this.buttonL.Size = new System.Drawing.Size(64, 40);
            this.buttonL.TabIndex = 2;
            this.buttonL.Text = "L";
            this.buttonL.UseVisualStyleBackColor = false;
            this.buttonL.Click += new System.EventHandler(this.buttonL_Click);
            // 
            // buttonM
            // 
            this.buttonM.BackColor = System.Drawing.Color.White;
            this.buttonM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonM.Location = new System.Drawing.Point(165, 13);
            this.buttonM.Name = "buttonM";
            this.buttonM.Size = new System.Drawing.Size(62, 40);
            this.buttonM.TabIndex = 1;
            this.buttonM.Text = "M";
            this.buttonM.UseVisualStyleBackColor = false;
            this.buttonM.Click += new System.EventHandler(this.buttonM_Click);
            // 
            // buttonS
            // 
            this.buttonS.BackColor = System.Drawing.Color.White;
            this.buttonS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonS.Location = new System.Drawing.Point(93, 13);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(62, 40);
            this.buttonS.TabIndex = 0;
            this.buttonS.Text = "S";
            this.buttonS.UseVisualStyleBackColor = false;
            this.buttonS.Click += new System.EventHandler(this.buttonS_Click);
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.clearButton);
            this.buttonsPanel.Controls.Add(this.fullScreenButton);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonsPanel.Location = new System.Drawing.Point(1128, 0);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(136, 64);
            this.buttonsPanel.TabIndex = 6;
            // 
            // LilDrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.drawingArea);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LilDrawForm";
            this.Text = "LilDrawApp";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LilDrawForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.drawingArea)).EndInit();
            this.colorSelectPanel.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.buttonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fullScreenButton;
        private System.Windows.Forms.PictureBox drawingArea;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.FlowLayoutPanel colorSelectPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonL;
        private System.Windows.Forms.Button buttonM;
        private System.Windows.Forms.Button buttonS;
        private System.Windows.Forms.Button buttonXS;
        private System.Windows.Forms.Button buttonXL;
    }
}

