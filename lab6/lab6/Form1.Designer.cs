namespace lab6
{
    partial class Form1
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
            this.brushSize = new System.Windows.Forms.Button();
            this.brushSizeText = new System.Windows.Forms.TextBox();
            this.hexColor = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureNameBox = new System.Windows.Forms.TextBox();
            this.loadPictureBtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.GaussianSharpen = new System.Windows.Forms.Button();
            this.Edges = new System.Windows.Forms.Button();
            this.Grayscale = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // brushSize
            // 
            this.brushSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.brushSize.Location = new System.Drawing.Point(44, 292);
            this.brushSize.Name = "brushSize";
            this.brushSize.Size = new System.Drawing.Size(161, 34);
            this.brushSize.TabIndex = 9;
            this.brushSize.Text = "Change Brush Size";
            this.brushSize.UseVisualStyleBackColor = true;
            this.brushSize.Click += new System.EventHandler(this.brushSize_Click);
            // 
            // brushSizeText
            // 
            this.brushSizeText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.brushSizeText.Location = new System.Drawing.Point(44, 266);
            this.brushSizeText.Name = "brushSizeText";
            this.brushSizeText.Size = new System.Drawing.Size(161, 20);
            this.brushSizeText.TabIndex = 8;
            // 
            // hexColor
            // 
            this.hexColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hexColor.AutoSize = true;
            this.hexColor.Location = new System.Drawing.Point(125, 158);
            this.hexColor.Name = "hexColor";
            this.hexColor.Size = new System.Drawing.Size(50, 13);
            this.hexColor.TabIndex = 7;
            this.hexColor.Text = "#000000";
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Location = new System.Drawing.Point(41, 204);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 36);
            this.button3.TabIndex = 6;
            this.button3.Text = "Choose color";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // colorPanel
            // 
            this.colorPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.colorPanel.Location = new System.Drawing.Point(41, 147);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(55, 40);
            this.colorPanel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Picture name";
            // 
            // pictureNameBox
            // 
            this.pictureNameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureNameBox.Location = new System.Drawing.Point(41, 23);
            this.pictureNameBox.Name = "pictureNameBox";
            this.pictureNameBox.ReadOnly = true;
            this.pictureNameBox.Size = new System.Drawing.Size(167, 20);
            this.pictureNameBox.TabIndex = 2;
            // 
            // loadPictureBtn
            // 
            this.loadPictureBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loadPictureBtn.Location = new System.Drawing.Point(41, 61);
            this.loadPictureBtn.Name = "loadPictureBtn";
            this.loadPictureBtn.Size = new System.Drawing.Size(167, 24);
            this.loadPictureBtn.TabIndex = 1;
            this.loadPictureBtn.Text = "Load picture";
            this.loadPictureBtn.UseVisualStyleBackColor = true;
            this.loadPictureBtn.Click += new System.EventHandler(this.loadPictureBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1017, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 681);
            this.panel1.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.GaussianSharpen);
            this.panel3.Controls.Add(this.brushSizeText);
            this.panel3.Controls.Add(this.Edges);
            this.panel3.Controls.Add(this.loadPictureBtn);
            this.panel3.Controls.Add(this.Grayscale);
            this.panel3.Controls.Add(this.pictureNameBox);
            this.panel3.Controls.Add(this.saveFile);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.brushSize);
            this.panel3.Controls.Add(this.colorPanel);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.hexColor);
            this.panel3.Location = new System.Drawing.Point(9, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 450);
            this.panel3.TabIndex = 1;
            // 
            // GaussianSharpen
            // 
            this.GaussianSharpen.Location = new System.Drawing.Point(44, 423);
            this.GaussianSharpen.Name = "GaussianSharpen";
            this.GaussianSharpen.Size = new System.Drawing.Size(161, 23);
            this.GaussianSharpen.TabIndex = 13;
            this.GaussianSharpen.Text = "Gaussian Sharpen";
            this.GaussianSharpen.UseVisualStyleBackColor = true;
            this.GaussianSharpen.Click += new System.EventHandler(this.GaussianSharpen_Click);
            // 
            // Edges
            // 
            this.Edges.Location = new System.Drawing.Point(44, 394);
            this.Edges.Name = "Edges";
            this.Edges.Size = new System.Drawing.Size(161, 23);
            this.Edges.TabIndex = 12;
            this.Edges.Text = "Edges";
            this.Edges.UseVisualStyleBackColor = true;
            this.Edges.Click += new System.EventHandler(this.Edges_Click);
            // 
            // Grayscale
            // 
            this.Grayscale.Location = new System.Drawing.Point(44, 365);
            this.Grayscale.Name = "Grayscale";
            this.Grayscale.Size = new System.Drawing.Size(161, 23);
            this.Grayscale.TabIndex = 11;
            this.Grayscale.Text = "Grayscale ";
            this.Grayscale.UseVisualStyleBackColor = true;
            this.Grayscale.Click += new System.EventHandler(this.Grayscale_Click);
            // 
            // saveFile
            // 
            this.saveFile.Location = new System.Drawing.Point(41, 92);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(167, 22);
            this.saveFile.TabIndex = 10;
            this.saveFile.Text = "Save file";
            this.saveFile.UseVisualStyleBackColor = true;
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1017, 681);
            this.panel2.TabIndex = 11;
            this.panel2.Resize += new System.EventHandler(this.panel2_Resize);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1017, 681);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 681);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button brushSize;
        private System.Windows.Forms.TextBox brushSizeText;
        private System.Windows.Forms.Label hexColor;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pictureNameBox;
        private System.Windows.Forms.Button loadPictureBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button saveFile;
        private System.Windows.Forms.Button Grayscale;
        private System.Windows.Forms.Button Edges;
        private System.Windows.Forms.Button GaussianSharpen;
        private System.Windows.Forms.Panel panel3;
    }
}

