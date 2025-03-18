
namespace Pigs
{
    partial class MainForm
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
            flowLayoutPanelPens = new FlowLayoutPanel();
            buttonAdd = new Button();
            SuspendLayout();
            // 
            // flowLayoutPanelPens
            // 
            flowLayoutPanelPens.Dock = DockStyle.Fill;
            flowLayoutPanelPens.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelPens.Location = new Point(10, 10);
            flowLayoutPanelPens.Name = "flowLayoutPanelPens";
            flowLayoutPanelPens.Size = new Size(758, 924);
            flowLayoutPanelPens.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonAdd.Font = new Font("Segoe UI", 18F);
            buttonAdd.Location = new Point(0, 0);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(61, 67);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 944);
            Controls.Add(flowLayoutPanelPens);
            FloatButton();
            Name = "MainForm";
            Padding = new Padding(10);
            Text = "Main Form";
            ResumeLayout(false);
        }

        private void FloatButton()
        {
            var flowRect = flowLayoutPanelPens.Bounds;
            Controls.Add(buttonAdd);
            Controls.SetChildIndex(buttonAdd, 0);
            buttonAdd.Left = flowRect.Right - buttonAdd.Width;
            buttonAdd.Top = flowRect.Bottom - buttonAdd.Height;
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelPens;
        private Button buttonAdd;
    }
}
