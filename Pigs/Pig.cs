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
    public partial class Pig : UserControl
    {
        public Pig()
        {
            InitializeComponent();
            buttonRemove.Click += (sender, e) => Parent?.Controls.Remove(this); ;
        }
    }
}
