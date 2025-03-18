namespace Pigs
{
    partial class Pig
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
            tableLayoutPanel = new TableLayoutPanel();
            textBoxID = new TextBox();
            comboBox1 = new ComboBox();
            buttonRemove = new Button();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.BackColor = SystemColors.Window;
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            tableLayoutPanel.Controls.Add(textBoxID, 0, 1);
            tableLayoutPanel.Controls.Add(comboBox1, 0, 0);
            tableLayoutPanel.Controls.Add(buttonRemove, 1, 0);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 4;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel.Size = new Size(150, 150);
            tableLayoutPanel.TabIndex = 0;
            // 
            // textBoxID
            // 
            tableLayoutPanel.SetColumnSpan(textBoxID, 2);
            textBoxID.Dock = DockStyle.Fill;
            textBoxID.Location = new Point(3, 40);
            textBoxID.Name = "textBoxID";
            textBoxID.PlaceholderText = "Id";
            textBoxID.Size = new Size(144, 31);
            textBoxID.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(3, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(99, 33);
            comboBox1.TabIndex = 0;
            // 
            // buttonRemove
            // 
            buttonRemove.BackColor = Color.Salmon;
            buttonRemove.Dock = DockStyle.Fill;
            buttonRemove.ForeColor = Color.White;
            buttonRemove.Location = new Point(105, 0);
            buttonRemove.Margin = new Padding(0);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(45, 37);
            buttonRemove.TabIndex = 2;
            buttonRemove.Text = "X";
            buttonRemove.UseVisualStyleBackColor = false;
            // 
            // Pig
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel);
            Name = "Pig";
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel;
        private ComboBox comboBox1;
        private TextBox textBoxID;
        private Button buttonRemove;
    }
}
