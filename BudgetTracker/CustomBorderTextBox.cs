using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetTracker
{
    public partial class CustomBorderTextBox : TextBox
    {
        private Color _bottomcolor = Color.Black;
        private Color _focusColor = Color.Black;

        public CustomBorderTextBox()
        {
            // Set the border type
            BorderStyle = BorderStyle.None;
            AutoSize = false;

            // Add a label to the control to simulate the bottom border
            Controls.Add(new Label
            {
                Height = 2,
                Dock = DockStyle.Bottom,
                BackColor = _bottomcolor
            });
      
        }

        [Browsable(false)]
        public new BorderStyle BorderStyle
        {
            get { return base.BorderStyle; }
            set { base.BorderStyle = value; }
        }

        public Color BottomColor
        {
            get { return _bottomcolor; }
            set
            {
                _bottomcolor = value;
                Controls[0].BackColor = _bottomcolor;
            }
        }

        public Color BottomBorderColorOnFocus
        {
            get { return _focusColor; }
            set { _focusColor = value; }
        }

        private void CustomBorderTextBox_Enter(object sender, EventArgs e)
        {
            Controls[0].BackColor = _focusColor;
        }

        private void CustomBorderTextBox_Leave(object sender, EventArgs e)
        {
            Controls[0].BackColor = _bottomcolor;
        }
    }
}

