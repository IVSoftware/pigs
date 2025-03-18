I'd like to suggest using `FlowLayout` panels for this, where you could add pens and pigs either on the UI or programmatically.

The basic idea is to have a `UserControl` to represent a Pig.

```
public partial class Pig : UserControl
{
    public Pig()
    {
        InitializeComponent();
        buttonRemove.Click += (sender, e) => Parent?.Controls.Remove(this); ;
    }
}
```

Another `UserControl` would represent a Pen.


```
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
```

___

**MainForm with FlowLayoutPanel**

This shows how to add pens and pigs with the UI. You can easily do programmatic versions of this basic scheme as well.

```
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
```

