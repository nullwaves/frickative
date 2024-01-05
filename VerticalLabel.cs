using System.Drawing.Drawing2D;

namespace frickative
{
    public class VerticalLabel : Label
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            using (StringFormat sf = new StringFormat(StringFormatFlags.DirectionVertical))
            {
                using (Matrix matrix = new Matrix())
                {
                    //matrix.RotateAt(180, new(ClientSize.Width/2, ClientSize.Height/2));
                    //e.Graphics.Transform = matrix;
                    // Draw the vertically oriented text
                    e.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), ClientRectangle, sf);
                }
            }
        }
    }
}
