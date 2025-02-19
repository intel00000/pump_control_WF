namespace testing
{
    partial class Mainwindow
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
            tabContainer = new TabControl();
            hardwareControl = new TabPage();
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBox1 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            pumpCtlSelectComboBox1 = new ComboBox();
            pumpCtlConnectbutton1 = new Button();
            pumpCtlResetbutton1 = new Button();
            pumpCtlNameLabel1 = new Label();
            pumpCtlStatusLabel1 = new Label();
            pumpCtlDisconnectbutton1 = new Button();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            experimentScheduler = new TabPage();
            eChemSequenceViewer = new TabPage();
            tabContainer.SuspendLayout();
            hardwareControl.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabContainer
            // 
            tabContainer.Controls.Add(hardwareControl);
            tabContainer.Controls.Add(experimentScheduler);
            tabContainer.Controls.Add(eChemSequenceViewer);
            tabContainer.Dock = DockStyle.Fill;
            tabContainer.Location = new Point(15, 15);
            tabContainer.Name = "tabContainer";
            tabContainer.SelectedIndex = 0;
            tabContainer.Size = new Size(1557, 1037);
            tabContainer.TabIndex = 0;
            // 
            // hardwareControl
            // 
            hardwareControl.AccessibleDescription = "Hardware control";
            hardwareControl.Controls.Add(flowLayoutPanel1);
            hardwareControl.Location = new Point(4, 34);
            hardwareControl.Name = "hardwareControl";
            hardwareControl.Padding = new Padding(20);
            hardwareControl.Size = new Size(1549, 999);
            hardwareControl.TabIndex = 0;
            hardwareControl.Text = "Hardware control";
            hardwareControl.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(groupBox1);
            flowLayoutPanel1.Controls.Add(groupBox2);
            flowLayoutPanel1.Controls.Add(groupBox3);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(20, 20);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1509, 959);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(910, 182);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select Port";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 27);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(904, 152);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(pumpCtlSelectComboBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(pumpCtlConnectbutton1, 2, 0);
            tableLayoutPanel1.Controls.Add(pumpCtlResetbutton1, 4, 0);
            tableLayoutPanel1.Controls.Add(pumpCtlNameLabel1, 0, 0);
            tableLayoutPanel1.Controls.Add(pumpCtlStatusLabel1, 5, 0);
            tableLayoutPanel1.Controls.Add(pumpCtlDisconnectbutton1, 3, 0);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(898, 40);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pumpCtlSelectComboBox1
            // 
            pumpCtlSelectComboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pumpCtlSelectComboBox1.FormattingEnabled = true;
            pumpCtlSelectComboBox1.Location = new Point(167, 3);
            pumpCtlSelectComboBox1.Name = "pumpCtlSelectComboBox1";
            pumpCtlSelectComboBox1.Size = new Size(182, 33);
            pumpCtlSelectComboBox1.TabIndex = 1;
            // 
            // pumpCtlConnectbutton1
            // 
            pumpCtlConnectbutton1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pumpCtlConnectbutton1.Location = new Point(355, 3);
            pumpCtlConnectbutton1.Name = "pumpCtlConnectbutton1";
            pumpCtlConnectbutton1.Size = new Size(112, 34);
            pumpCtlConnectbutton1.TabIndex = 2;
            pumpCtlConnectbutton1.Text = "Connect";
            pumpCtlConnectbutton1.UseVisualStyleBackColor = true;
            // 
            // pumpCtlResetbutton1
            // 
            pumpCtlResetbutton1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pumpCtlResetbutton1.Location = new Point(591, 3);
            pumpCtlResetbutton1.Name = "pumpCtlResetbutton1";
            pumpCtlResetbutton1.Size = new Size(112, 34);
            pumpCtlResetbutton1.TabIndex = 4;
            pumpCtlResetbutton1.Text = "Reset";
            pumpCtlResetbutton1.UseVisualStyleBackColor = true;
            // 
            // pumpCtlNameLabel1
            // 
            pumpCtlNameLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pumpCtlNameLabel1.AutoSize = true;
            pumpCtlNameLabel1.Location = new Point(3, 0);
            pumpCtlNameLabel1.Name = "pumpCtlNameLabel1";
            pumpCtlNameLabel1.Size = new Size(158, 40);
            pumpCtlNameLabel1.TabIndex = 0;
            pumpCtlNameLabel1.Text = "Pump controller 1:";
            pumpCtlNameLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pumpCtlStatusLabel1
            // 
            pumpCtlStatusLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pumpCtlStatusLabel1.AutoSize = true;
            pumpCtlStatusLabel1.Location = new Point(709, 0);
            pumpCtlStatusLabel1.Name = "pumpCtlStatusLabel1";
            pumpCtlStatusLabel1.Size = new Size(186, 40);
            pumpCtlStatusLabel1.TabIndex = 5;
            pumpCtlStatusLabel1.Text = "Status: Not connected";
            pumpCtlStatusLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pumpCtlDisconnectbutton1
            // 
            pumpCtlDisconnectbutton1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pumpCtlDisconnectbutton1.Location = new Point(473, 3);
            pumpCtlDisconnectbutton1.Name = "pumpCtlDisconnectbutton1";
            pumpCtlDisconnectbutton1.Size = new Size(112, 34);
            pumpCtlDisconnectbutton1.TabIndex = 3;
            pumpCtlDisconnectbutton1.Text = "Disconnect";
            pumpCtlDisconnectbutton1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(3, 191);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(258, 184);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(3, 381);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(240, 210);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // experimentScheduler
            // 
            experimentScheduler.AccessibleDescription = "Experiment scheduler";
            experimentScheduler.Location = new Point(4, 34);
            experimentScheduler.Name = "experimentScheduler";
            experimentScheduler.Padding = new Padding(3);
            experimentScheduler.Size = new Size(1549, 999);
            experimentScheduler.TabIndex = 1;
            experimentScheduler.Text = "Experiment scheduler";
            experimentScheduler.UseVisualStyleBackColor = true;
            // 
            // eChemSequenceViewer
            // 
            eChemSequenceViewer.Location = new Point(4, 34);
            eChemSequenceViewer.Name = "eChemSequenceViewer";
            eChemSequenceViewer.Padding = new Padding(3);
            eChemSequenceViewer.Size = new Size(1549, 999);
            eChemSequenceViewer.TabIndex = 2;
            eChemSequenceViewer.Text = "EChem sequence viewer";
            eChemSequenceViewer.UseVisualStyleBackColor = true;
            // 
            // Mainwindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1587, 1067);
            Controls.Add(tabContainer);
            Name = "Mainwindow";
            Padding = new Padding(15);
            Text = "Pump Control & Automation";
            tabContainer.ResumeLayout(false);
            hardwareControl.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabContainer;
        private TabPage hardwareControl;
        private TabPage experimentScheduler;
        private TabPage eChemSequenceViewer;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel1;
        private Label pumpCtlNameLabel1;
        private ComboBox pumpCtlSelectComboBox1;
        private Label pumpCtlStatusLabel1;
        private Button pumpCtlConnectbutton1;
        private Button pumpCtlDisconnectbutton1;
        private Button pumpCtlResetbutton1;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
