using System;

namespace refactoring_method_extraction
{
    class CylinderDemo
    {
        public static double GetVolume(int radius, int height)
        {
            double baseArea = Math.PI * radius * radius;
            double perimeter = 2 * Math.PI * radius;
            double volume = perimeter * height + 2 * baseArea;
            return volume;
        }
    }
}
