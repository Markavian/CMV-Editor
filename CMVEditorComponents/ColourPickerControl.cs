using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace CMVEditorComponents
{
    public partial class ColourPickerControl : UserControl
    {
        FlowLayoutPanel flowPanel;
        List<PlainButton> colourButtons;
        Color[] colors;

        public delegate void ColorEvent(Color colour);
        public event ColorEvent ColorSelected;

        public ColourPickerControl()
        {
            InitializeComponent();

            createChildren();
            createButtons();
        }

        private void createChildren()
        {
            colourButtons = new List<PlainButton>();
            colors = new Color[0];

            flowPanel = new FlowLayoutPanel();
            flowPanel.Margin = new Padding(2);
            flowPanel.Dock = DockStyle.Fill;
            flowPanel.Parent = this;
        }

        private void createButtons()
        {
            PlainButton button;

            removeButtons();

            colourButtons = new List<PlainButton>();

            for (int i = 0; i < colors.Length; i++)
            {
                button = new PlainButton();
                button.BackColor = colors[i];
                button.Margin = new Padding(0);
                button.Width = 15;
                button.Height = 15;

                button.Parent = flowPanel;
                colourButtons.Add(button);
            }

            assignActions();
        }

        private void removeButtons()
        {
            foreach (PlainButton button in colourButtons)
            {
                button.Parent = null;
                button.Dispose();
            }
        }

        public Color[] Colors
        {
            get { return colors; }
            set { colors = value; createButtons(); }
        }

        public void assignActions()
        {
            foreach (PlainButton colourButton in colourButtons)
            {
                colourButton.Click += new EventHandler(colourButton_Click);
            }
        }

        void colourButton_Click(object sender, EventArgs e)
        {
            PlainButton colourButton;
            Color selectedColour;

            colourButton = (PlainButton)sender;
            selectedColour = colourButton.BackColor;

            if(ColorSelected != null)
                ColorSelected(selectedColour);
        }
    }
}
