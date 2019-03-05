namespace Autoclicker
{
    partial class Autoclicker
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.num_clicksPerSecond = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_clickAtMouse = new System.Windows.Forms.Button();
            this.btn_clickParticularly = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_setCursorPosition = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.num_xValue = new System.Windows.Forms.NumericUpDown();
            this.num_yValue = new System.Windows.Forms.NumericUpDown();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_clicksPerSecond)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_xValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_yValue)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 73);
            this.label2.TabIndex = 1;
            this.label2.Text = "Autoclicker";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.num_clicksPerSecond);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(50, 73);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(50, 10, 50, 20);
            this.panel2.Size = new System.Drawing.Size(384, 68);
            this.panel2.TabIndex = 3;
            // 
            // num_clicksPerSecond
            // 
            this.num_clicksPerSecond.Dock = System.Windows.Forms.DockStyle.Top;
            this.num_clicksPerSecond.Location = new System.Drawing.Point(50, 28);
            this.num_clicksPerSecond.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_clicksPerSecond.Name = "num_clicksPerSecond";
            this.num_clicksPerSecond.Size = new System.Drawing.Size(284, 20);
            this.num_clicksPerSecond.TabIndex = 3;
            this.num_clicksPerSecond.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(50, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Clicks per second";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_clickAtMouse
            // 
            this.btn_clickAtMouse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_clickAtMouse.Location = new System.Drawing.Point(50, 141);
            this.btn_clickAtMouse.Name = "btn_clickAtMouse";
            this.btn_clickAtMouse.Size = new System.Drawing.Size(384, 50);
            this.btn_clickAtMouse.TabIndex = 4;
            this.btn_clickAtMouse.Text = "Click wherever the mouse is (Ctrl+num0)";
            this.btn_clickAtMouse.UseVisualStyleBackColor = true;
            this.btn_clickAtMouse.Click += new System.EventHandler(this.btn_clickAtMouse_Click);
            // 
            // btn_clickParticularly
            // 
            this.btn_clickParticularly.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_clickParticularly.Location = new System.Drawing.Point(50, 191);
            this.btn_clickParticularly.Name = "btn_clickParticularly";
            this.btn_clickParticularly.Size = new System.Drawing.Size(384, 50);
            this.btn_clickParticularly.TabIndex = 5;
            this.btn_clickParticularly.Text = "Click in a certain position (Ctrl+num1)";
            this.btn_clickParticularly.UseVisualStyleBackColor = true;
            this.btn_clickParticularly.Click += new System.EventHandler(this.btn_clickParticularly_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(50, 241);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(50, 20, 50, 20);
            this.panel1.Size = new System.Drawing.Size(384, 86);
            this.panel1.TabIndex = 6;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(50, 20);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.num_xValue);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.num_yValue);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Size = new System.Drawing.Size(284, 46);
            this.splitContainer1.SplitterDistance = 137;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_setCursorPosition
            // 
            this.btn_setCursorPosition.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_setCursorPosition.Location = new System.Drawing.Point(87, 0);
            this.btn_setCursorPosition.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
            this.btn_setCursorPosition.MinimumSize = new System.Drawing.Size(100, 0);
            this.btn_setCursorPosition.Name = "btn_setCursorPosition";
            this.btn_setCursorPosition.Size = new System.Drawing.Size(200, 50);
            this.btn_setCursorPosition.TabIndex = 7;
            this.btn_setCursorPosition.Text = "Set co-ordinates to mouse position";
            this.btn_setCursorPosition.UseVisualStyleBackColor = true;
            this.btn_setCursorPosition.Click += new System.EventHandler(this.btn_setCursorPosition_Click);
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.btn_setCursorPosition);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(50, 327);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.panel3.Size = new System.Drawing.Size(384, 68);
            this.panel3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "X Value";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Y Value";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num_xValue
            // 
            this.num_xValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.num_xValue.Location = new System.Drawing.Point(0, 23);
            this.num_xValue.Name = "num_xValue";
            this.num_xValue.Size = new System.Drawing.Size(137, 20);
            this.num_xValue.TabIndex = 1;
            // 
            // num_yValue
            // 
            this.num_yValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.num_yValue.Location = new System.Drawing.Point(0, 23);
            this.num_yValue.Name = "num_yValue";
            this.num_yValue.Size = new System.Drawing.Size(143, 20);
            this.num_yValue.TabIndex = 2;
            // 
            // Autoclicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(484, 399);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_clickParticularly);
            this.Controls.Add(this.btn_clickAtMouse);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Name = "Autoclicker";
            this.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.Text = "Autoclicker";
            this.Load += new System.EventHandler(this.Autoclicker_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_clicksPerSecond)).EndInit();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_xValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_yValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown num_clicksPerSecond;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_clickAtMouse;
        private System.Windows.Forms.Button btn_clickParticularly;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.NumericUpDown num_xValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown num_yValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_setCursorPosition;
        private System.Windows.Forms.Panel panel3;
    }
}

