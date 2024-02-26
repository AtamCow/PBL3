using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExamSystem.Presentation.Components
{
    public class CircularNamePictureBox : PictureBox
    {
        public string NameInitials { get; set; }
        public Color BackgroundColor { get; set; }
        public Color FontColor { get; set; }

        public CircularNamePictureBox()
        {
            FontColor = Color.White;
            BackgroundColor = Color.Red;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(gp);

            using (StringFormat sf = new StringFormat())
            {
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                using (SolidBrush brush = new SolidBrush(FontColor))
                {
                    using (Font font = new Font(this.Font.FontFamily, this.Font.Size * 3))
                    {
                        e.Graphics.FillEllipse(new SolidBrush(BackgroundColor), 0, 0, this.Width, this.Height);
                        e.Graphics.DrawString(NameInitials, font, brush, new RectangleF(0, 0, this.Width, this.Height), sf);
                    }
                }
            }
        }
    }
}
