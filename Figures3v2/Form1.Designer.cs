
namespace Figures3v2
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
            this.drawPanel = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.figureChoise = new System.Windows.Forms.Panel();
            this.rectangleButton = new System.Windows.Forms.RadioButton();
            this.triangleButton = new System.Windows.Forms.RadioButton();
            this.lineButton = new System.Windows.Forms.RadioButton();
            this.circleButton = new System.Windows.Forms.RadioButton();
            this.colorButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblR = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.r2 = new System.Windows.Forms.TextBox();
            this.r1 = new System.Windows.Forms.TextBox();
            this.corY3 = new System.Windows.Forms.TextBox();
            this.corY2 = new System.Windows.Forms.TextBox();
            this.corY1 = new System.Windows.Forms.TextBox();
            this.corX3 = new System.Windows.Forms.TextBox();
            this.corX2 = new System.Windows.Forms.TextBox();
            this.corX1 = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.lblRad = new System.Windows.Forms.Label();
            this.radiusBar = new System.Windows.Forms.TrackBar();
            this.clearButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.figureChoise.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radiusBar)).BeginInit();
            this.SuspendLayout();
            // 
            // drawPanel
            // 
            this.drawPanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.drawPanel.Location = new System.Drawing.Point(160, -1);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Size = new System.Drawing.Size(711, 518);
            this.drawPanel.TabIndex = 1;
            this.drawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.drawPanel_Paint);
            this.drawPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.drawPanel_MouseClick);
            // 
            // figureChoise
            // 
            this.figureChoise.Controls.Add(this.rectangleButton);
            this.figureChoise.Controls.Add(this.triangleButton);
            this.figureChoise.Controls.Add(this.lineButton);
            this.figureChoise.Controls.Add(this.circleButton);
            this.figureChoise.Location = new System.Drawing.Point(14, 0);
            this.figureChoise.Name = "figureChoise";
            this.figureChoise.Size = new System.Drawing.Size(139, 116);
            this.figureChoise.TabIndex = 0;
            // 
            // rectangleButton
            // 
            this.rectangleButton.AutoSize = true;
            this.rectangleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rectangleButton.Location = new System.Drawing.Point(19, 92);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Size = new System.Drawing.Size(77, 19);
            this.rectangleButton.TabIndex = 3;
            this.rectangleButton.TabStop = true;
            this.rectangleButton.Text = "Rectangle";
            this.rectangleButton.UseVisualStyleBackColor = true;
            this.rectangleButton.CheckedChanged += new System.EventHandler(this.rectangleButton_CheckedChanged);
            // 
            // triangleButton
            // 
            this.triangleButton.AutoSize = true;
            this.triangleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.triangleButton.Location = new System.Drawing.Point(19, 66);
            this.triangleButton.Name = "triangleButton";
            this.triangleButton.Size = new System.Drawing.Size(64, 19);
            this.triangleButton.TabIndex = 2;
            this.triangleButton.TabStop = true;
            this.triangleButton.Text = "Tiangle";
            this.triangleButton.UseVisualStyleBackColor = true;
            this.triangleButton.CheckedChanged += new System.EventHandler(this.triangleButton_CheckedChanged);
            // 
            // lineButton
            // 
            this.lineButton.AutoSize = true;
            this.lineButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lineButton.Location = new System.Drawing.Point(19, 40);
            this.lineButton.Name = "lineButton";
            this.lineButton.Size = new System.Drawing.Size(47, 19);
            this.lineButton.TabIndex = 1;
            this.lineButton.TabStop = true;
            this.lineButton.Text = "Line";
            this.lineButton.UseVisualStyleBackColor = true;
            this.lineButton.CheckedChanged += new System.EventHandler(this.lineButton_CheckedChanged);
            // 
            // circleButton
            // 
            this.circleButton.AutoSize = true;
            this.circleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.circleButton.Location = new System.Drawing.Point(19, 14);
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(55, 19);
            this.circleButton.TabIndex = 0;
            this.circleButton.TabStop = true;
            this.circleButton.Text = "Circle";
            this.circleButton.UseVisualStyleBackColor = true;
            // 
            // colorButton
            // 
            this.colorButton.BackColor = System.Drawing.Color.Silver;
            this.colorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorButton.Location = new System.Drawing.Point(15, 366);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(65, 23);
            this.colorButton.TabIndex = 1;
            this.colorButton.Text = "Color";
            this.colorButton.UseVisualStyleBackColor = false;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Controls.Add(this.lbl3);
            this.panel1.Controls.Add(this.lbl2);
            this.panel1.Controls.Add(this.lblR);
            this.panel1.Controls.Add(this.lblY);
            this.panel1.Controls.Add(this.lblX);
            this.panel1.Controls.Add(this.r2);
            this.panel1.Controls.Add(this.r1);
            this.panel1.Controls.Add(this.corY3);
            this.panel1.Controls.Add(this.corY2);
            this.panel1.Controls.Add(this.corY1);
            this.panel1.Controls.Add(this.corX3);
            this.panel1.Controls.Add(this.corX2);
            this.panel1.Controls.Add(this.corX1);
            this.panel1.Location = new System.Drawing.Point(14, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 123);
            this.panel1.TabIndex = 2;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(32, 96);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(13, 15);
            this.lbl1.TabIndex = 13;
            this.lbl1.Text = "1";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(93, 96);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(13, 15);
            this.lbl3.TabIndex = 12;
            this.lbl3.Text = "3";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(60, 96);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(13, 15);
            this.lbl2.TabIndex = 11;
            this.lbl2.Text = "2";
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Location = new System.Drawing.Point(0, 73);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(14, 15);
            this.lblR.TabIndex = 10;
            this.lblR.Text = "R";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(0, 44);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(14, 15);
            this.lblY.TabIndex = 9;
            this.lblY.Text = "Y";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(0, 15);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(14, 15);
            this.lblX.TabIndex = 8;
            this.lblX.Text = "X";
            // 
            // r2
            // 
            this.r2.Location = new System.Drawing.Point(53, 70);
            this.r2.Name = "r2";
            this.r2.Size = new System.Drawing.Size(28, 23);
            this.r2.TabIndex = 7;
            // 
            // r1
            // 
            this.r1.Location = new System.Drawing.Point(19, 70);
            this.r1.Name = "r1";
            this.r1.Size = new System.Drawing.Size(28, 23);
            this.r1.TabIndex = 6;
            // 
            // corY3
            // 
            this.corY3.Location = new System.Drawing.Point(87, 41);
            this.corY3.Name = "corY3";
            this.corY3.Size = new System.Drawing.Size(28, 23);
            this.corY3.TabIndex = 5;
            // 
            // corY2
            // 
            this.corY2.Location = new System.Drawing.Point(53, 41);
            this.corY2.Name = "corY2";
            this.corY2.Size = new System.Drawing.Size(28, 23);
            this.corY2.TabIndex = 4;
            // 
            // corY1
            // 
            this.corY1.Location = new System.Drawing.Point(19, 41);
            this.corY1.Name = "corY1";
            this.corY1.Size = new System.Drawing.Size(28, 23);
            this.corY1.TabIndex = 3;
            // 
            // corX3
            // 
            this.corX3.Location = new System.Drawing.Point(87, 12);
            this.corX3.Name = "corX3";
            this.corX3.Size = new System.Drawing.Size(28, 23);
            this.corX3.TabIndex = 2;
            // 
            // corX2
            // 
            this.corX2.Location = new System.Drawing.Point(53, 12);
            this.corX2.Name = "corX2";
            this.corX2.Size = new System.Drawing.Size(28, 23);
            this.corX2.TabIndex = 1;
            // 
            // corX1
            // 
            this.corX1.Location = new System.Drawing.Point(19, 12);
            this.corX1.Name = "corX1";
            this.corX1.Size = new System.Drawing.Size(28, 23);
            this.corX1.TabIndex = 0;
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.White;
            this.createButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createButton.Location = new System.Drawing.Point(15, 395);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(139, 42);
            this.createButton.TabIndex = 3;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar1.Location = new System.Drawing.Point(18, 264);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(126, 45);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.controlPanel.Controls.Add(this.label1);
            this.controlPanel.Controls.Add(this.radiusBar);
            this.controlPanel.Controls.Add(this.createButton);
            this.controlPanel.Controls.Add(this.lblRad);
            this.controlPanel.Controls.Add(this.clearButton);
            this.controlPanel.Controls.Add(this.loadButton);
            this.controlPanel.Controls.Add(this.saveButton);
            this.controlPanel.Controls.Add(this.trackBar1);
            this.controlPanel.Controls.Add(this.panel1);
            this.controlPanel.Controls.Add(this.colorButton);
            this.controlPanel.Controls.Add(this.figureChoise);
            this.controlPanel.Location = new System.Drawing.Point(-7, -1);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(208, 518);
            this.controlPanel.TabIndex = 0;
            this.controlPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.controlPanel_Paint);
            // 
            // lblRad
            // 
            this.lblRad.AutoSize = true;
            this.lblRad.Location = new System.Drawing.Point(19, 297);
            this.lblRad.Name = "lblRad";
            this.lblRad.Size = new System.Drawing.Size(125, 15);
            this.lblRad.TabIndex = 9;
            this.lblRad.Text = "MouseClick Circle Size";
            this.lblRad.Click += new System.EventHandler(this.lblRad_Click);
            // 
            // radiusBar
            // 
            this.radiusBar.Location = new System.Drawing.Point(18, 315);
            this.radiusBar.Name = "radiusBar";
            this.radiusBar.Size = new System.Drawing.Size(126, 45);
            this.radiusBar.TabIndex = 8;
            // 
            // clearButton
            // 
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.Location = new System.Drawing.Point(86, 366);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(67, 23);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadButton.Location = new System.Drawing.Point(86, 483);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(67, 23);
            this.loadButton.TabIndex = 6;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Location = new System.Drawing.Point(14, 483);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(66, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pen Width";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 517);
            this.Controls.Add(this.drawPanel);
            this.Controls.Add(this.controlPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.figureChoise.ResumeLayout(false);
            this.figureChoise.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radiusBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel drawPanel;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel figureChoise;
        private System.Windows.Forms.RadioButton rectangleButton;
        private System.Windows.Forms.RadioButton triangleButton;
        private System.Windows.Forms.RadioButton lineButton;
        private System.Windows.Forms.RadioButton circleButton;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.TextBox r2;
        private System.Windows.Forms.TextBox r1;
        private System.Windows.Forms.TextBox corY3;
        private System.Windows.Forms.TextBox corY2;
        private System.Windows.Forms.TextBox corY1;
        private System.Windows.Forms.TextBox corX3;
        private System.Windows.Forms.TextBox corX2;
        private System.Windows.Forms.TextBox corX1;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblRad;
        private System.Windows.Forms.TrackBar radiusBar;
        private System.Windows.Forms.Label label1;
    }
}

