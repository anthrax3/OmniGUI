﻿using Android.Graphics;
using OmniGui;

namespace AndroidApp.AndPlugin
{
    using OmniGui.Geometry;
    using Bitmap = OmniGui.Bitmap;

    public class AndroidDrawingContext : IDrawingContext
    {
        private readonly Canvas canvas;

        public AndroidDrawingContext(Canvas canvas)
        {
            this.canvas = canvas;
        }

        //public void DrawRectangle(OmniGui.Geometry.Rect rect, Pen pen)
        //{
        //    var paint = new Paint();
        //    paint.Color = pen.Brush.Color.ToAndroid();
        //    canvas.DrawRect(rect.ToAndroid(), paint);
        //}

        //public void DrawRoundedRectangle(OmniGui.Geometry.Rect rect, Pen pen, CornerRadius cornerRadius)
        //{
        //    var paint = new Paint();
        //    paint.SetStyle(Paint.Style.Stroke);
        //    paint.StrokeWidth = (float) pen.Thickness;
        //    paint.Color = pen.Brush.Color.ToAndroid();
        //    var rx = cornerRadius.BottomLeft;
        //    var ry = cornerRadius.BottomLeft;

        //    canvas.DrawRoundRect(rect.ToAndroid(), (float)rx, (float)ry, paint);
        //}

        //public void DrawText(FormattedText formattedText, Point point)
        //{
        //    var paint = new Paint();
        //    paint.TextSize = formattedText.FontSize;
        //    paint.Color = formattedText.Brush.Color.ToAndroid();
        //    canvas.DrawText(formattedText.Text, (float) point.X, (float) point.Y, paint);
        //}

        //public void FillRectangle(OmniGui.Geometry.Rect rect, Brush brush)
        //{
        //    var paint = new Paint();
        //    paint.Color = brush.Color.ToAndroid();
        //    canvas.DrawRect(rect.ToAndroid(), paint);

        //}

        //public void FillRoundedRectangle(OmniGui.Geometry.Rect rect, Brush brush, CornerRadius cornerRadius)
        //{
        //    var paint = new Paint();
        //    paint.Color = brush.Color.ToAndroid();
        //    var rx = cornerRadius.BottomLeft;
        //    var ry = cornerRadius.BottomLeft;

        //    canvas.DrawRoundRect(rect.ToAndroid(), (float)rx, (float)ry, paint);
        //}

        //public void DrawRectangle(OmniGui.Geometry.Rect rect, Pen pen)
        //{
        //    throw new System.NotImplementedException();
        //}

        //public void FillRectangle(OmniGui.Geometry.Rect rect, Brush brush)
        //{
        //    throw new System.NotImplementedException();
        //}

        //public void DrawRoundedRectangle(OmniGui.Geometry.Rect rect, Pen pen, CornerRadius cornerRadius)
        //{
        //    throw new System.NotImplementedException();
        //}

        //public void FillRoundedRectangle(OmniGui.Geometry.Rect rect, Brush brush, CornerRadius cornerRadius)
        //{
        //    throw new System.NotImplementedException();
        //}

        //public void DrawText(FormattedText formattedText, OmniGui.Geometry.Point point)
        //{
        //    throw new System.NotImplementedException();
        //}

        //public void DrawBitmap(Bitmap bmp, OmniGui.Geometry.Rect sourceRect, OmniGui.Geometry.Rect rect)
        //{
        //    throw new System.NotImplementedException();
        //}

        //public void DrawLine(OmniGui.Geometry.Point startPoint, OmniGui.Geometry.Point endPoint, Pen pen)
        //{
        //    throw new System.NotImplementedException();
        //}
        public void DrawRectangle(Rect rect, Pen pen)
        {
            throw new System.NotImplementedException();
        }

        public void FillRectangle(Rect rect, Brush brush)
        {
            throw new System.NotImplementedException();
        }

        public void DrawRoundedRectangle(Rect rect, Pen pen, CornerRadius cornerRadius)
        {
            throw new System.NotImplementedException();
        }

        public void FillRoundedRectangle(Rect rect, Brush brush, CornerRadius cornerRadius)
        {
            throw new System.NotImplementedException();
        }

        public void DrawText(FormattedText formattedText, Point point)
        {
            throw new System.NotImplementedException();
        }

        public void DrawBitmap(Bitmap bmp, Rect sourceRect, Rect rect)
        {
            throw new System.NotImplementedException();
        }

        public void DrawLine(Point startPoint, Point endPoint, Pen pen)
        {
            throw new System.NotImplementedException();
        }
    }
}