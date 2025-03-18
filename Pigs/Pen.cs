using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pigs
{
    public partial class Pen : UserControl
    {
        public Pen()
        {
            InitializeComponent();
            buttonAdd.Click += (sender, e) =>
            {
                flowLayoutPanel.Controls.Add(new Pig
                {
                    Height = flowLayoutPanel.Height - flowLayoutPanel.Padding.Vertical - this.Margin.Vertical,
                });
                AutoResize();
                buttonAdd.Enabled = flowLayoutPanel.Controls.Count < 4;
            };
            buttonRemove.Click += (sender, e) => Parent?.Controls.Remove(this);
            SizeChanged += (sender, e) => AutoResize();
        }

        private void AutoResize()
        {
            foreach (var pig in flowLayoutPanel.Controls.OfType<Pig>())
            {
                var availableWidth = flowLayoutPanel.Width - SystemInformation.VerticalScrollBarWidth;
                pig.Width = (flowLayoutPanel.Width/4) - pig.Margin.Horizontal - flowLayoutPanel.Padding.Horizontal;
            }
        }
    }
}
