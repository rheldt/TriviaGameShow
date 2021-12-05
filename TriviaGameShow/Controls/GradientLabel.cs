using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TriviaGameShow.Controls
{
    // Adapted from codeproject.com/articles/4109/gradient-label-control-for-winforms
    public class GradientLabel : Label
    {
        private Color _StartColor = Color.FromArgb(0, 0, 110);
        private Color _EndColor = Color.FromArgb(0, 0, 150);

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush GBrush = new LinearGradientBrush(new Point(0, 0), new Point(0, this.Height), _StartColor, _EndColor); Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            e.Graphics.FillRectangle(GBrush, rect);
            SolidBrush drawBrush = new SolidBrush(this.ForeColor);
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            RectangleF rectF = new
            RectangleF(0, this.Height / 2 - Font.Height / 2, this.Width, this.Height);
            e.Graphics.DrawString(this.Text, this.Font, drawBrush, rectF, sf);
        }
    }
}