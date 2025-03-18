namespace Pigs
{
    partial class Pen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            horizontalLayoutPanel = new TableLayoutPanel();
            flowLayoutPanel = new FlowLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonAdd = new Button();
            buttonRemove = new Button();
            horizontalLayoutPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // horizontalLayoutPanel
            // 
            horizontalLayoutPanel.ColumnCount = 2;
            horizontalLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 51F));
            horizontalLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            horizontalLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            horizontalLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            horizontalLayoutPanel.Controls.Add(flowLayoutPanel, 1, 0);
            horizontalLayoutPanel.Controls.Add(tableLayoutPanel1, 0, 0);
            horizontalLayoutPanel.Dock = DockStyle.Fill;
            horizontalLayoutPanel.Location = new Point(0, 0);
            horizontalLayoutPanel.Name = "horizontalLayoutPanel";
            horizontalLayoutPanel.RowCount = 1;
            horizontalLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            horizontalLayoutPanel.Size = new Size(710, 185);
            horizontalLayoutPanel.TabIndex = 0;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.BackColor = Color.PaleTurquoise;
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.Location = new Point(54, 3);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(653, 179);
            flowLayoutPanel.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(buttonAdd, 0, 1);
            tableLayoutPanel1.Controls.Add(buttonRemove, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(51, 185);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            buttonAdd.Font = new Font("Segoe UI", 20F);
            buttonAdd.Location = new Point(3, 95);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(45, 87);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonRemove
            // 
            buttonRemove.BackColor = Color.DarkSalmon;
            buttonRemove.Dock = DockStyle.Top;
            buttonRemove.ForeColor = Color.Gray;
            buttonRemove.Location = new Point(3, 3);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(45, 45);
            buttonRemove.TabIndex = 2;
            buttonRemove.Text = "X";
            buttonRemove.UseVisualStyleBackColor = false;
            // 
            // Pen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(horizontalLayoutPanel);
            Name = "Pen";
            Size = new Size(710, 185);
            horizontalLayoutPanel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel horizontalLayoutPanel;
        private FlowLayoutPanel flowLayoutPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonAdd;
        private Button buttonRemove;
    }
}
