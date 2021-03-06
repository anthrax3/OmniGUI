namespace OmniGui
{
    using Geometry;

    public interface IDrawingContext
    {
        void DrawRectangle(Rect rect, Pen pen);
        void FillRectangle(Rect rect, Brush brush);
        void DrawRoundedRectangle(Rect rect, Pen pen, CornerRadius cornerRadius);
        void FillRoundedRectangle(Rect rect, Brush brush, CornerRadius cornerRadius);
        void DrawText(FormattedText formattedText, Point point);
        void DrawBitmap(Bitmap bmp, Rect sourceRect, Rect rect);
        void DrawLine(Point startPoint, Point endPoint, Pen pen);
    }
}