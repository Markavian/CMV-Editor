using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CMVEditor
{
    public partial class ChooseDimensionsBox : Form
    {
        public ChooseDimensionsBox()
        {
            InitializeComponent();
        }

        public int FormWidth
        {
            get { return (int)formWidth.Value; }
        }

        public int FormHeight
        {
            get { return (int)formHeight.Value; }
        }
    }
}
