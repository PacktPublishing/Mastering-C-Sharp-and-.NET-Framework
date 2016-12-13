using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter03_01
{
    class Program
    {
        static void Main(string[] args)
        {
            /* NOTE: classes Polygon and Triangle are define at the end*/ 
            //Polygon p = new Triangle();
            //Polygon.GreaterThan(new Triangle(), new Rectangle());

            List<Triangle> triangles = new List<Triangle>
            {
                new Triangle(),
                new Triangle()
            };
            List<Rectangle> rectangles = new List<Rectangle>
            {
                new Rectangle(),
                new Rectangle()
            };

            //List<Polygon> polygons = triangles.ToList<Polygon>();
            IEnumerable<Polygon> polygons = triangles.ToList<Polygon>();

            IEnumerable<Polygon> polygons2 =
                new List<Triangle> {
                new Triangle(), new Triangle()};

            //IList<Polygon> polygons3 =
            //    new List<Triangle> {
            //    new Triangle(), new Triangle()};

            //polygons3[1] = new Rectangle();

            IEnumerable<Func<Polygon>> dp =
                new List<Func<Rectangle>>();

            //IEnumerable<int> ints = new int[] { 1, 2, 3 };
            //IEnumerable<double> doubles = ints;

            // UNIONS
            polygons = polygons.Union(triangles);
            //var y = triangles.Union(rectangles);
            //var y = triangles.Union<Polygon>(rectangles);

            // Contravariance
            //IComparer<Polygon> polygonComparer = new
            //    ComparePolygons();
            //triangles = triangles.Sort(polygonComparer);

        }

        public abstract class Polygon
        {
            public abstract double Area();
            public static Polygon GreaterThan(Polygon p1, Polygon p2)
            {
                return (p1.Area() > p2.Area()) ? p1 : p2;
            }
            public static double TotalArea(IEnumerable<Polygon> polygons)
            {
                double r = 0.0;
                foreach (var p in polygons) r += p.Area();
                return r;
            }
            //...
        }
        public class Rectangle : Polygon
        {
            public override double Area()
            {
                return default(double);
            }
        }
        public class Triangle : Polygon
        {
            public override double Area()
            {
                return default(double);
            }
        }
    }
}
