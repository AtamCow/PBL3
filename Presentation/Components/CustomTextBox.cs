using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExamSystem.Presentation.Components
{
    public class CustomTextBox : TextBox
    {
        private Color borderColor;

        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; Invalidate(); } // Invalidate() forces the control to redraw
        }

        public CustomTextBox()
        {
            
        }
    }
}
