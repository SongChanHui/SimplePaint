namespace SimplePaint
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
            lblAppName = new Label();
            picCanvas = new PictureBox();
            groupBox1 = new GroupBox();
            btnCircle = new Button();
            btnRectangle = new Button();
            btnLine = new Button();
            groupBox2 = new GroupBox();
            cmbColor = new ComboBox();
            groupBox3 = new GroupBox();
            trbLineWidth = new TrackBar();
            btnSaveFile = new Button();
            btnOpenFile = new Button();
            pnlCanvas = new Panel();
            ((System.ComponentModel.ISupportInitialize)picCanvas).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trbLineWidth).BeginInit();
            pnlCanvas.SuspendLayout();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("맑은 고딕", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppName.ForeColor = Color.Blue;
            lblAppName.Location = new Point(53, 35);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(492, 100);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Simple Paint";
            // 
            // picCanvas
            // 
            picCanvas.BackColor = Color.White;
            picCanvas.BorderStyle = BorderStyle.FixedSingle;
            picCanvas.Location = new Point(3, 3);
            picCanvas.Name = "picCanvas";
            picCanvas.Size = new Size(1444, 667);
            picCanvas.TabIndex = 1;
            picCanvas.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCircle);
            groupBox1.Controls.Add(btnRectangle);
            groupBox1.Controls.Add(btnLine);
            groupBox1.Location = new Point(62, 168);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(450, 160);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "도형 선택";
            // 
            // btnCircle
            // 
            btnCircle.Image = (Image)resources.GetObject("btnCircle.Image");
            btnCircle.ImageAlign = ContentAlignment.TopCenter;
            btnCircle.Location = new Point(315, 51);
            btnCircle.Name = "btnCircle";
            btnCircle.Size = new Size(117, 86);
            btnCircle.TabIndex = 2;
            btnCircle.Text = "원";
            btnCircle.TextAlign = ContentAlignment.BottomCenter;
            btnCircle.UseVisualStyleBackColor = true;
            // 
            // btnRectangle
            // 
            btnRectangle.Image = (Image)resources.GetObject("btnRectangle.Image");
            btnRectangle.ImageAlign = ContentAlignment.TopCenter;
            btnRectangle.Location = new Point(166, 51);
            btnRectangle.Name = "btnRectangle";
            btnRectangle.Size = new Size(117, 86);
            btnRectangle.TabIndex = 1;
            btnRectangle.Text = "사각형";
            btnRectangle.TextAlign = ContentAlignment.BottomCenter;
            btnRectangle.UseVisualStyleBackColor = true;
            // 
            // btnLine
            // 
            btnLine.Image = Properties.Resources.KakaoTalk_20260430_100205471_02;
            btnLine.ImageAlign = ContentAlignment.TopCenter;
            btnLine.Location = new Point(17, 51);
            btnLine.Name = "btnLine";
            btnLine.Size = new Size(117, 86);
            btnLine.TabIndex = 0;
            btnLine.Text = "직선";
            btnLine.TextAlign = ContentAlignment.BottomCenter;
            btnLine.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbColor);
            groupBox2.Location = new Point(543, 168);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 160);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "색 선택";
            // 
            // cmbColor
            // 
            cmbColor.FormattingEnabled = true;
            cmbColor.Items.AddRange(new object[] { "Black 검정", "Red 빨강", "Blue 파랑", "Green 녹색" });
            cmbColor.Location = new Point(23, 74);
            cmbColor.Margin = new Padding(20);
            cmbColor.Name = "cmbColor";
            cmbColor.Size = new Size(204, 40);
            cmbColor.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(trbLineWidth);
            groupBox3.Location = new Point(824, 168);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(310, 160);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "선 두께";
            // 
            // trbLineWidth
            // 
            trbLineWidth.Location = new Point(6, 64);
            trbLineWidth.Name = "trbLineWidth";
            trbLineWidth.Size = new Size(298, 90);
            trbLineWidth.TabIndex = 0;
            // 
            // btnSaveFile
            // 
            btnSaveFile.BackColor = Color.FromArgb(192, 255, 255);
            btnSaveFile.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveFile.ImageAlign = ContentAlignment.TopCenter;
            btnSaveFile.Location = new Point(1362, 195);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(150, 125);
            btnSaveFile.TabIndex = 3;
            btnSaveFile.Text = "저장";
            btnSaveFile.UseVisualStyleBackColor = false;
            // 
            // btnOpenFile
            // 
            btnOpenFile.BackColor = Color.FromArgb(255, 255, 192);
            btnOpenFile.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOpenFile.ImageAlign = ContentAlignment.TopCenter;
            btnOpenFile.Location = new Point(1178, 195);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(150, 125);
            btnOpenFile.TabIndex = 5;
            btnOpenFile.Text = "열기";
            btnOpenFile.UseVisualStyleBackColor = false;
            // 
            // pnlCanvas
            // 
            pnlCanvas.AutoScroll = true;
            pnlCanvas.Controls.Add(picCanvas);
            pnlCanvas.Location = new Point(62, 350);
            pnlCanvas.Name = "pnlCanvas";
            pnlCanvas.Size = new Size(1450, 673);
            pnlCanvas.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1574, 1079);
            Controls.Add(pnlCanvas);
            Controls.Add(btnOpenFile);
            Controls.Add(btnSaveFile);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblAppName);
            Name = "Form1";
            Text = "Simple Paint v1.0";
            ((System.ComponentModel.ISupportInitialize)picCanvas).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trbLineWidth).EndInit();
            pnlCanvas.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private PictureBox picCanvas;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnLine;
        private Button btnOpenFile;
        private Button btnSaveFile;
        private Button btnCircle;
        private Button btnRectangle;
        private ComboBox cmbColor;
        private TrackBar trbLineWidth;
        private Panel pnlCanvas;
    }
}
