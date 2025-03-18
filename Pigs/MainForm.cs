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
                    Width = flowLayoutPanelPens.Width - flowLayoutPanelPens.Padding.Horizontal,
                });
            };
        }
    }
}
