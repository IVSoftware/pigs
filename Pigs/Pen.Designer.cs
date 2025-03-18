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
            SuspendLayout();
            // 
            // horizontalLayoutPanel
            // 
            horizontalLayoutPanel.ColumnCount = 4;
            horizontalLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            horizontalLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            horizontalLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            horizontalLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            horizontalLayoutPanel.Dock = DockStyle.Fill;
            horizontalLayoutPanel.Location = new Point(0, 0);
            horizontalLayoutPanel.Name = "horizontalLayoutPanel";
            horizontalLayoutPanel.RowCount = 1;
            horizontalLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            horizontalLayoutPanel.Size = new Size(710, 185);
            horizontalLayoutPanel.TabIndex = 0;
            // 
            // Pen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(horizontalLayoutPanel);
            Name = "Pen";
            Size = new Size(710, 185);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel horizontalLayoutPanel;
    }
}
