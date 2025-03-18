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
            buttonAdd = new Button();
            flowLayoutPanel = new FlowLayoutPanel();
            horizontalLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // horizontalLayoutPanel
            // 
            horizontalLayoutPanel.ColumnCount = 2;
            horizontalLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 51F));
            horizontalLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            horizontalLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            horizontalLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            horizontalLayoutPanel.Controls.Add(buttonAdd, 0, 0);
            horizontalLayoutPanel.Controls.Add(flowLayoutPanel, 1, 0);
            horizontalLayoutPanel.Dock = DockStyle.Fill;
            horizontalLayoutPanel.Location = new Point(0, 0);
            horizontalLayoutPanel.Name = "horizontalLayoutPanel";
            horizontalLayoutPanel.RowCount = 1;
            horizontalLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            horizontalLayoutPanel.Size = new Size(710, 185);
            horizontalLayoutPanel.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            buttonAdd.Font = new Font("Segoe UI", 20F);
            buttonAdd.Location = new Point(3, 3);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(45, 179);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.Location = new Point(54, 3);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(653, 179);
            flowLayoutPanel.TabIndex = 1;
            // 
            // Pen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(horizontalLayoutPanel);
            Name = "Pen";
            Size = new Size(710, 185);
            horizontalLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel horizontalLayoutPanel;
        private Button buttonAdd;
        private FlowLayoutPanel flowLayoutPanel;
    }
}
