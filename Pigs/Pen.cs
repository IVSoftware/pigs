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
                    Height = this.Height - this.Padding.Vertical,
                });
            };
        }
    }
}
