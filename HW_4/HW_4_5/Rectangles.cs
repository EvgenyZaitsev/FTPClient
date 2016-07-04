using System;

namespace HW_4_5
{
    public class Rectangles
    {
        public double HeightOne { get; set; }
        public double WidthOne { get; set; }
        public double HeightTwo { get; set; }
        public double WidthTwo { get; set; }

        public Rectangles (double h1, double w1, double h2, double w2)
        {
            if (h1 <= 0 || w1 <= 0 || h2 <= 0 || w2 <= 0)
            {
                Console.WriteLine("Sides can't be less or equal zero.");
                Environment.Exit(-1);
            }
                this.HeightOne = h1;
                this.WidthOne = w1;

                this.HeightTwo = h2;
                this.WidthTwo = w2;
        }
        public int VerticalAmount()
        {
            int verticalRectangles = (int)(HeightOne / HeightTwo);
            int horizontalRectangles = (int)(WidthOne / WidthTwo);
            int totalVertical = verticalRectangles * horizontalRectangles;

            double lostVerticalSpace = HeightOne - verticalRectangles * HeightTwo;
            int lostVerticalRectanglesV = (int)(lostVerticalSpace / WidthTwo);
            int lostHorizontalRectanglesV = (int)(WidthOne / HeightTwo);
            int lostTotalVertical = lostVerticalRectanglesV * lostHorizontalRectanglesV > 0 ? lostVerticalRectanglesV * lostHorizontalRectanglesV : 0;

            double lostHorizontalSpace = WidthOne - horizontalRectangles * WidthTwo;
            int lostVerticalRectanglesH = (int)(HeightOne / WidthTwo);
            int lostHorizontalRectanglesH = (int)(lostHorizontalSpace / HeightTwo);
            int lostTotalHorizontal = lostVerticalRectanglesH * lostHorizontalRectanglesH > 0 ? lostVerticalRectanglesH * lostHorizontalRectanglesH : 0;

            return totalVertical + lostTotalVertical + lostTotalHorizontal;
        }
        public int HorizontalAmount()
        {
            int verticalRectangles = (int)(HeightOne / WidthTwo);
            int horizontalRectangles = (int)(WidthOne / HeightTwo);
            int totalHorizontal = verticalRectangles * horizontalRectangles;

            double lostVerticalSpace = HeightOne - verticalRectangles * WidthTwo;
            int lostVerticalRectanglesV = (int)(lostVerticalSpace / HeightTwo);
            int lostHorizontalRectanglesV = (int)(WidthOne / WidthTwo);
            int lostTotalVertical = lostVerticalRectanglesV * lostHorizontalRectanglesV > 0 ? lostVerticalRectanglesV * lostHorizontalRectanglesV : 0;

            double lostHorizontalSpace = WidthOne - horizontalRectangles * HeightTwo;
            int lostVerticalRectanglesH = (int)(HeightOne / HeightTwo);
            int lostHorizontalRectanglesH = (int)(lostHorizontalSpace / WidthTwo);            
            int lostTotalHorizontal = lostVerticalRectanglesH * lostHorizontalRectanglesH > 0 ? lostVerticalRectanglesH * lostHorizontalRectanglesH : 0;

            return totalHorizontal + lostTotalVertical + lostTotalHorizontal;
        }
        public int TotalAmount()
        {
            return Math.Max(VerticalAmount(), HorizontalAmount());
        }
    }
}
