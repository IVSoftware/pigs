

namespace Pigs
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            buttonAdd.Click += (sender, e) =>
            {
                flowLayoutPanelPens.Controls.Add(new Pen 
                {
                    Width =
                        (flowLayoutPanelPens.Width - flowLayoutPanelPens.Padding.Horizontal) 
                        - SystemInformation.VerticalScrollBarWidth,
                });
                flowLayoutPanelPens.MaximumSize = 
                    new Size(Width - SystemInformation.VerticalScrollBarWidth, 0);
            };
            Load += (sender, e) => FloatPlusButton();
        }

        private void FloatPlusButton()
        {
            var flowRect = flowLayoutPanelPens.Bounds;
            Controls.Add(buttonAdd);
            Controls.SetChildIndex(buttonAdd, 0);
            buttonAdd.Left = flowRect.Right - buttonAdd.Width;
            buttonAdd.Top = flowRect.Bottom - buttonAdd.Height;
        }
    }
}
