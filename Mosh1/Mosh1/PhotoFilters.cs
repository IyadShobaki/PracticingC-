﻿using System;

namespace Mosh1
{
    public class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Apply brightness");
        }
        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Apply contrast");
        }
        public void ApplyResize(Photo photo)
        {
            Console.WriteLine("Resize photo");
        }
    }
}
