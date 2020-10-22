namespace Autoclicker
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pnl_cps = new System.Windows.Forms.Panel();
            this.num_clicksPerSecond = new System.Windows.Forms.NumericUpDown();
            this.lbl_cps = new System.Windows.Forms.Label();
            this.btn_clickAtMouse = new System.Windows.Forms.Button();
            this.btn_clickParticularly = new System.Windows.Forms.Button();
            this.pnl_coordinates = new System.Windows.Forms.Panel();
            this.splt_coordinates = new System.Windows.Forms.SplitContainer();
            this.num_xValue = new System.Windows.Forms.NumericUpDown();
            this.lbl_xValue = new System.Windows.Forms.Label();
            this.num_yValue = new System.Windows.Forms.NumericUpDown();
            this.lbl_yValue = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_setCursorPosition = new System.Windows.Forms.Button();
            this.splt_formSplitter = new System.Windows.Forms.SplitContainer();
            this.btn_addValue = new System.Windows.Forms.Button();
            this.pnl_tableTitle = new System.Windows.Forms.Panel();
            this.splt_tableTitle12Against3 = new System.Windows.Forms.SplitContainer();
            this.splt_tableTitle1Against2 = new System.Windows.Forms.SplitContainer();
            this.btn_saveLayout = new System.Windows.Forms.Button();
            this.lbl_tableTitle = new System.Windows.Forms.Label();
            this.btn_delLayout = new System.Windows.Forms.Button();
            this.cBo_layout = new System.Windows.Forms.ComboBox();
            this.tbl_xAndY = new Autoclicker.DBLayoutPanel(this.components);
            this.lbl_repeats = new System.Windows.Forms.Label();
            this.lbl_yValues = new System.Windows.Forms.Label();
            this.lbl_xValues = new System.Windows.Forms.Label();
            this.pnl_cps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_clicksPerSecond)).BeginInit();
            this.pnl_coordinates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splt_coordinates)).BeginInit();
            this.splt_coordinates.Panel1.SuspendLayout();
            this.splt_coordinates.Panel2.SuspendLayout();
            this.splt_coordinates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_xValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_yValue)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splt_formSplitter)).BeginInit();
            this.splt_formSplitter.Panel1.SuspendLayout();
            this.splt_formSplitter.Panel2.SuspendLayout();
            this.splt_formSplitter.SuspendLayout();
            this.pnl_tableTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splt_tableTitle12Against3)).BeginInit();
            this.splt_tableTitle12Against3.Panel1.SuspendLayout();
            this.splt_tableTitle12Against3.Panel2.SuspendLayout();
            this.splt_tableTitle12Against3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splt_tableTitle1Against2)).BeginInit();
            this.splt_tableTitle1Against2.Panel1.SuspendLayout();
            this.splt_tableTitle1Against2.Panel2.SuspendLayout();
            this.splt_tableTitle1Against2.SuspendLayout();
            this.tbl_xAndY.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Title.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(50, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(641, 73);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "Autoclicker";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_cps
            // 
            this.pnl_cps.AutoSize = true;
            this.pnl_cps.Controls.Add(this.num_clicksPerSecond);
            this.pnl_cps.Controls.Add(this.lbl_cps);
            this.pnl_cps.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_cps.Location = new System.Drawing.Point(0, 0);
            this.pnl_cps.Name = "pnl_cps";
            this.pnl_cps.Padding = new System.Windows.Forms.Padding(50, 10, 50, 20);
            this.pnl_cps.Size = new System.Drawing.Size(303, 81);
            this.pnl_cps.TabIndex = 9;
            // 
            // num_clicksPerSecond
            // 
            this.num_clicksPerSecond.Dock = System.Windows.Forms.DockStyle.Top;
            this.num_clicksPerSecond.Location = new System.Drawing.Point(50, 41);
            this.num_clicksPerSecond.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_clicksPerSecond.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_clicksPerSecond.Name = "num_clicksPerSecond";
            this.num_clicksPerSecond.Size = new System.Drawing.Size(203, 20);
            this.num_clicksPerSecond.TabIndex = 3;
            this.num_clicksPerSecond.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lbl_cps
            // 
            this.lbl_cps.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_cps.Location = new System.Drawing.Point(50, 10);
            this.lbl_cps.Name = "lbl_cps";
            this.lbl_cps.Size = new System.Drawing.Size(203, 31);
            this.lbl_cps.TabIndex = 2;
            this.lbl_cps.Text = "The interval time between each click (Milliseconds)";
            this.lbl_cps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_clickAtMouse
            // 
            this.btn_clickAtMouse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_clickAtMouse.Location = new System.Drawing.Point(0, 81);
            this.btn_clickAtMouse.Name = "btn_clickAtMouse";
            this.btn_clickAtMouse.Size = new System.Drawing.Size(303, 50);
            this.btn_clickAtMouse.TabIndex = 10;
            this.btn_clickAtMouse.Text = "Click wherever the mouse is (F8)";
            this.btn_clickAtMouse.UseVisualStyleBackColor = true;
            this.btn_clickAtMouse.Click += new System.EventHandler(this.btn_clickAtMouse_Click);
            // 
            // btn_clickParticularly
            // 
            this.btn_clickParticularly.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_clickParticularly.Location = new System.Drawing.Point(0, 131);
            this.btn_clickParticularly.Name = "btn_clickParticularly";
            this.btn_clickParticularly.Size = new System.Drawing.Size(303, 50);
            this.btn_clickParticularly.TabIndex = 11;
            this.btn_clickParticularly.Text = "Click in a certain position (F7)";
            this.btn_clickParticularly.UseVisualStyleBackColor = true;
            this.btn_clickParticularly.Click += new System.EventHandler(this.btn_clickParticularly_Click);
            // 
            // pnl_coordinates
            // 
            this.pnl_coordinates.Controls.Add(this.splt_coordinates);
            this.pnl_coordinates.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_coordinates.Location = new System.Drawing.Point(0, 181);
            this.pnl_coordinates.Name = "pnl_coordinates";
            this.pnl_coordinates.Padding = new System.Windows.Forms.Padding(50, 20, 50, 20);
            this.pnl_coordinates.Size = new System.Drawing.Size(303, 86);
            this.pnl_coordinates.TabIndex = 12;
            // 
            // splt_coordinates
            // 
            this.splt_coordinates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splt_coordinates.IsSplitterFixed = true;
            this.splt_coordinates.Location = new System.Drawing.Point(50, 20);
            this.splt_coordinates.Name = "splt_coordinates";
            // 
            // splt_coordinates.Panel1
            // 
            this.splt_coordinates.Panel1.Controls.Add(this.num_xValue);
            this.splt_coordinates.Panel1.Controls.Add(this.lbl_xValue);
            // 
            // splt_coordinates.Panel2
            // 
            this.splt_coordinates.Panel2.Controls.Add(this.num_yValue);
            this.splt_coordinates.Panel2.Controls.Add(this.lbl_yValue);
            this.splt_coordinates.Size = new System.Drawing.Size(203, 46);
            this.splt_coordinates.SplitterDistance = 96;
            this.splt_coordinates.TabIndex = 0;
            // 
            // num_xValue
            // 
            this.num_xValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.num_xValue.Location = new System.Drawing.Point(0, 23);
            this.num_xValue.Name = "num_xValue";
            this.num_xValue.Size = new System.Drawing.Size(96, 20);
            this.num_xValue.TabIndex = 1;
            this.num_xValue.ValueChanged += new System.EventHandler(this.num_xValue_ValueChanged);
            this.num_xValue.Enter += new System.EventHandler(this.num_xValue_Enter);
            this.num_xValue.Leave += new System.EventHandler(this.num_xValue_Leave);
            // 
            // lbl_xValue
            // 
            this.lbl_xValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_xValue.Location = new System.Drawing.Point(0, 0);
            this.lbl_xValue.Name = "lbl_xValue";
            this.lbl_xValue.Size = new System.Drawing.Size(96, 23);
            this.lbl_xValue.TabIndex = 0;
            this.lbl_xValue.Text = "X Value";
            this.lbl_xValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num_yValue
            // 
            this.num_yValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.num_yValue.Location = new System.Drawing.Point(0, 23);
            this.num_yValue.Name = "num_yValue";
            this.num_yValue.Size = new System.Drawing.Size(103, 20);
            this.num_yValue.TabIndex = 2;
            this.num_yValue.ValueChanged += new System.EventHandler(this.num_yValue_ValueChanged);
            this.num_yValue.Enter += new System.EventHandler(this.num_yValue_Enter);
            this.num_yValue.Leave += new System.EventHandler(this.num_yValue_Leave);
            // 
            // lbl_yValue
            // 
            this.lbl_yValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_yValue.Location = new System.Drawing.Point(0, 0);
            this.lbl_yValue.Name = "lbl_yValue";
            this.lbl_yValue.Size = new System.Drawing.Size(103, 23);
            this.lbl_yValue.TabIndex = 1;
            this.lbl_yValue.Text = "Y Value";
            this.lbl_yValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.btn_setCursorPosition);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 267);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.panel3.Size = new System.Drawing.Size(303, 59);
            this.panel3.TabIndex = 14;
            // 
            // btn_setCursorPosition
            // 
            this.btn_setCursorPosition.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_setCursorPosition.Location = new System.Drawing.Point(45, 0);
            this.btn_setCursorPosition.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
            this.btn_setCursorPosition.MinimumSize = new System.Drawing.Size(100, 0);
            this.btn_setCursorPosition.Name = "btn_setCursorPosition";
            this.btn_setCursorPosition.Size = new System.Drawing.Size(200, 41);
            this.btn_setCursorPosition.TabIndex = 7;
            this.btn_setCursorPosition.Text = "Set co-ordinates to mouse position";
            this.btn_setCursorPosition.UseVisualStyleBackColor = true;
            this.btn_setCursorPosition.Click += new System.EventHandler(this.btn_setCursorPosition_Click);
            // 
            // splt_formSplitter
            // 
            this.splt_formSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splt_formSplitter.IsSplitterFixed = true;
            this.splt_formSplitter.Location = new System.Drawing.Point(50, 73);
            this.splt_formSplitter.Margin = new System.Windows.Forms.Padding(2);
            this.splt_formSplitter.Name = "splt_formSplitter";
            // 
            // splt_formSplitter.Panel1
            // 
            this.splt_formSplitter.Panel1.Controls.Add(this.btn_addValue);
            this.splt_formSplitter.Panel1.Controls.Add(this.panel3);
            this.splt_formSplitter.Panel1.Controls.Add(this.pnl_coordinates);
            this.splt_formSplitter.Panel1.Controls.Add(this.btn_clickParticularly);
            this.splt_formSplitter.Panel1.Controls.Add(this.btn_clickAtMouse);
            this.splt_formSplitter.Panel1.Controls.Add(this.pnl_cps);
            // 
            // splt_formSplitter.Panel2
            // 
            this.splt_formSplitter.Panel2.Controls.Add(this.tbl_xAndY);
            this.splt_formSplitter.Panel2.Controls.Add(this.pnl_tableTitle);
            this.splt_formSplitter.Size = new System.Drawing.Size(641, 367);
            this.splt_formSplitter.SplitterDistance = 303;
            this.splt_formSplitter.SplitterWidth = 3;
            this.splt_formSplitter.TabIndex = 2;
            // 
            // btn_addValue
            // 
            this.btn_addValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_addValue.Location = new System.Drawing.Point(0, 326);
            this.btn_addValue.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addValue.Name = "btn_addValue";
            this.btn_addValue.Size = new System.Drawing.Size(303, 41);
            this.btn_addValue.TabIndex = 0;
            this.btn_addValue.Text = "Add Co-ordinate";
            this.btn_addValue.UseVisualStyleBackColor = true;
            this.btn_addValue.Click += new System.EventHandler(this.btn_addValue_Click);
            // 
            // pnl_tableTitle
            // 
            this.pnl_tableTitle.Controls.Add(this.splt_tableTitle12Against3);
            this.pnl_tableTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_tableTitle.Location = new System.Drawing.Point(0, 0);
            this.pnl_tableTitle.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_tableTitle.Name = "pnl_tableTitle";
            this.pnl_tableTitle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.pnl_tableTitle.Size = new System.Drawing.Size(335, 61);
            this.pnl_tableTitle.TabIndex = 5;
            // 
            // splt_tableTitle12Against3
            // 
            this.splt_tableTitle12Against3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splt_tableTitle12Against3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splt_tableTitle12Against3.IsSplitterFixed = true;
            this.splt_tableTitle12Against3.Location = new System.Drawing.Point(0, 0);
            this.splt_tableTitle12Against3.Margin = new System.Windows.Forms.Padding(2);
            this.splt_tableTitle12Against3.Name = "splt_tableTitle12Against3";
            // 
            // splt_tableTitle12Against3.Panel1
            // 
            this.splt_tableTitle12Against3.Panel1.Controls.Add(this.splt_tableTitle1Against2);
            // 
            // splt_tableTitle12Against3.Panel2
            // 
            this.splt_tableTitle12Against3.Panel2.Controls.Add(this.btn_delLayout);
            this.splt_tableTitle12Against3.Panel2.Controls.Add(this.cBo_layout);
            this.splt_tableTitle12Against3.Size = new System.Drawing.Size(335, 41);
            this.splt_tableTitle12Against3.SplitterDistance = 208;
            this.splt_tableTitle12Against3.SplitterWidth = 3;
            this.splt_tableTitle12Against3.TabIndex = 0;
            // 
            // splt_tableTitle1Against2
            // 
            this.splt_tableTitle1Against2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splt_tableTitle1Against2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splt_tableTitle1Against2.IsSplitterFixed = true;
            this.splt_tableTitle1Against2.Location = new System.Drawing.Point(0, 0);
            this.splt_tableTitle1Against2.Margin = new System.Windows.Forms.Padding(2);
            this.splt_tableTitle1Against2.Name = "splt_tableTitle1Against2";
            // 
            // splt_tableTitle1Against2.Panel1
            // 
            this.splt_tableTitle1Against2.Panel1.Controls.Add(this.btn_saveLayout);
            // 
            // splt_tableTitle1Against2.Panel2
            // 
            this.splt_tableTitle1Against2.Panel2.Controls.Add(this.lbl_tableTitle);
            this.splt_tableTitle1Against2.Size = new System.Drawing.Size(208, 41);
            this.splt_tableTitle1Against2.SplitterDistance = 100;
            this.splt_tableTitle1Against2.SplitterWidth = 3;
            this.splt_tableTitle1Against2.TabIndex = 0;
            // 
            // btn_saveLayout
            // 
            this.btn_saveLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_saveLayout.Location = new System.Drawing.Point(0, 0);
            this.btn_saveLayout.Margin = new System.Windows.Forms.Padding(2);
            this.btn_saveLayout.Name = "btn_saveLayout";
            this.btn_saveLayout.Size = new System.Drawing.Size(100, 41);
            this.btn_saveLayout.TabIndex = 0;
            this.btn_saveLayout.Text = "Save Layout";
            this.btn_saveLayout.UseVisualStyleBackColor = true;
            this.btn_saveLayout.Click += new System.EventHandler(this.btn_saveLayout_Click);
            // 
            // lbl_tableTitle
            // 
            this.lbl_tableTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_tableTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tableTitle.Location = new System.Drawing.Point(0, 0);
            this.lbl_tableTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_tableTitle.Name = "lbl_tableTitle";
            this.lbl_tableTitle.Size = new System.Drawing.Size(105, 41);
            this.lbl_tableTitle.TabIndex = 2;
            this.lbl_tableTitle.Text = "X and Y Positions";
            this.lbl_tableTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_delLayout
            // 
            this.btn_delLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_delLayout.Location = new System.Drawing.Point(0, 21);
            this.btn_delLayout.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delLayout.Name = "btn_delLayout";
            this.btn_delLayout.Size = new System.Drawing.Size(124, 20);
            this.btn_delLayout.TabIndex = 1;
            this.btn_delLayout.Text = "Delete Layout";
            this.btn_delLayout.UseVisualStyleBackColor = true;
            this.btn_delLayout.Click += new System.EventHandler(this.btn_delLayout_Click);
            // 
            // cBo_layout
            // 
            this.cBo_layout.Dock = System.Windows.Forms.DockStyle.Top;
            this.cBo_layout.FormattingEnabled = true;
            this.cBo_layout.Location = new System.Drawing.Point(0, 0);
            this.cBo_layout.Margin = new System.Windows.Forms.Padding(2);
            this.cBo_layout.Name = "cBo_layout";
            this.cBo_layout.Size = new System.Drawing.Size(124, 21);
            this.cBo_layout.TabIndex = 0;
            this.cBo_layout.Text = "Choose layout...";
            this.cBo_layout.SelectionChangeCommitted += new System.EventHandler(this.cBo_layout_SelectionChangeCommitted);
            // 
            // tbl_xAndY
            // 
            this.tbl_xAndY.AutoScroll = true;
            this.tbl_xAndY.ColumnCount = 5;
            this.tbl_xAndY.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_xAndY.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_xAndY.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_xAndY.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_xAndY.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_xAndY.Controls.Add(this.lbl_repeats, 3, 0);
            this.tbl_xAndY.Controls.Add(this.lbl_yValues, 2, 0);
            this.tbl_xAndY.Controls.Add(this.lbl_xValues, 1, 0);
            this.tbl_xAndY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_xAndY.Location = new System.Drawing.Point(0, 61);
            this.tbl_xAndY.Margin = new System.Windows.Forms.Padding(2);
            this.tbl_xAndY.Name = "tbl_xAndY";
            this.tbl_xAndY.RowCount = 2;
            this.tbl_xAndY.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_xAndY.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tbl_xAndY.Size = new System.Drawing.Size(335, 306);
            this.tbl_xAndY.TabIndex = 6;
            // 
            // lbl_repeats
            // 
            this.lbl_repeats.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_repeats.Location = new System.Drawing.Point(203, 0);
            this.lbl_repeats.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_repeats.Name = "lbl_repeats";
            this.lbl_repeats.Size = new System.Drawing.Size(63, 16);
            this.lbl_repeats.TabIndex = 4;
            this.lbl_repeats.Text = "Repeats";
            this.lbl_repeats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_yValues
            // 
            this.lbl_yValues.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_yValues.Location = new System.Drawing.Point(136, 0);
            this.lbl_yValues.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_yValues.Name = "lbl_yValues";
            this.lbl_yValues.Size = new System.Drawing.Size(63, 16);
            this.lbl_yValues.TabIndex = 2;
            this.lbl_yValues.Text = "Y Values";
            this.lbl_yValues.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_xValues
            // 
            this.lbl_xValues.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_xValues.Location = new System.Drawing.Point(69, 0);
            this.lbl_xValues.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_xValues.Name = "lbl_xValues";
            this.lbl_xValues.Size = new System.Drawing.Size(63, 16);
            this.lbl_xValues.TabIndex = 1;
            this.lbl_xValues.Text = "X Values";
            this.lbl_xValues.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(741, 456);
            this.Controls.Add(this.splt_formSplitter);
            this.Controls.Add(this.lbl_Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(379, 45);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(50, 0, 50, 16);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Autoclicker";
            this.Load += new System.EventHandler(this.Autoclicker_Load);
            this.Leave += new System.EventHandler(this.Autoclicker_Leave);
            this.pnl_cps.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_clicksPerSecond)).EndInit();
            this.pnl_coordinates.ResumeLayout(false);
            this.splt_coordinates.Panel1.ResumeLayout(false);
            this.splt_coordinates.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splt_coordinates)).EndInit();
            this.splt_coordinates.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_xValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_yValue)).EndInit();
            this.panel3.ResumeLayout(false);
            this.splt_formSplitter.Panel1.ResumeLayout(false);
            this.splt_formSplitter.Panel1.PerformLayout();
            this.splt_formSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splt_formSplitter)).EndInit();
            this.splt_formSplitter.ResumeLayout(false);
            this.pnl_tableTitle.ResumeLayout(false);
            this.splt_tableTitle12Against3.Panel1.ResumeLayout(false);
            this.splt_tableTitle12Against3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splt_tableTitle12Against3)).EndInit();
            this.splt_tableTitle12Against3.ResumeLayout(false);
            this.splt_tableTitle1Against2.Panel1.ResumeLayout(false);
            this.splt_tableTitle1Against2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splt_tableTitle1Against2)).EndInit();
            this.splt_tableTitle1Against2.ResumeLayout(false);
            this.tbl_xAndY.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Panel pnl_cps;
        private System.Windows.Forms.NumericUpDown num_clicksPerSecond;
        private System.Windows.Forms.Label lbl_cps;
        private System.Windows.Forms.Button btn_clickAtMouse;
        private System.Windows.Forms.Button btn_clickParticularly;
        private System.Windows.Forms.Panel pnl_coordinates;
        private System.Windows.Forms.SplitContainer splt_coordinates;
        private System.Windows.Forms.NumericUpDown num_xValue;
        private System.Windows.Forms.Label lbl_xValue;
        private System.Windows.Forms.NumericUpDown num_yValue;
        private System.Windows.Forms.Label lbl_yValue;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_setCursorPosition;
        private System.Windows.Forms.SplitContainer splt_formSplitter;
        private System.Windows.Forms.Button btn_addValue;
        private Autoclicker.DBLayoutPanel tbl_xAndY;
        private System.Windows.Forms.Label lbl_repeats;
        private System.Windows.Forms.Label lbl_yValues;
        private System.Windows.Forms.Label lbl_xValues;
        private System.Windows.Forms.Panel pnl_tableTitle;
        private System.Windows.Forms.SplitContainer splt_tableTitle12Against3;
        private System.Windows.Forms.SplitContainer splt_tableTitle1Against2;
        private System.Windows.Forms.Button btn_saveLayout;
        private System.Windows.Forms.Label lbl_tableTitle;
        private System.Windows.Forms.Button btn_delLayout;
        private System.Windows.Forms.ComboBox cBo_layout;
    }
}

