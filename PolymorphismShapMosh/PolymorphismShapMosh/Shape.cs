using System;

namespace PolymorphismShapMosh
{
    public abstract class Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public Position Position { get; set; }

        public abstract void Draw();

        public void Copy()
        {
            Console.WriteLine("Copy shape into clipboard.");
        }
        public void Select()
        {
            Console.WriteLine("Select the shape.");
        }
    }
}
