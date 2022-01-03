using System;

namespace Comput_volume
{
    class Program
    {
        static void Main(string[] args)
        {
            CubeVolume(3);
            CubeVolume(3, 3, 3);

            SphereVolume(4);
            SphereVolume(4, 4, 4);

            PyramidTriangularVolume(3, 3, 5);
            PyramidTriangularVolume(3, 5);

            CylinderVolume(2, 3);
            CylinderVolume(2, 2, 3);

            TorusVolume(5, 5);
            TorusVolume(5);
        }

        public static void CubeVolume(int l, int L, int h)
        {
            Console.WriteLine("cube volume = {0}", l * L * h);
        }

        public static void CubeVolume(int a)
        {
            CubeVolume(a, a, a);
        }

        public static void SphereVolume(float height, float width, float depth)
        {
            float volume = 0.0F;

            volume = (float)(4.0 / 3 * Math.PI * height * width * depth);

            Console.WriteLine("Sphere volume = {0}", volume);
        }

        public static void SphereVolume(int radius)
        {
            SphereVolume(radius, radius, radius);
        }

        public static void PyramidTriangularVolume(int a, int b, int h)
        {
            float vol = (float)(0.1666) * a * b * h;

            Console.WriteLine("Pyramid volume = {0}", vol);
        }

        public static void PyramidTriangularVolume(int a, int h)
        {
            PyramidTriangularVolume(a, a, h);
        }

        public static void CylinderVolume(float l, float w, float h)
        {
            double volume = Math.PI * (l * w) * h;

            Console.WriteLine("Cylinder volume = {0}", volume);
        }

        public static void CylinderVolume(float radius, float height)
        {
            CylinderVolume(radius, radius, height);
        }


        public static void TorusVolume(float bigRadius, float smallRadius)
        {
            double volume = 2 * (Math.PI * Math.PI) * bigRadius * (smallRadius * smallRadius);

            Console.WriteLine("Torus volume = {0}", volume);
        }

        public static void TorusVolume(float radius)
        {
            TorusVolume(radius, radius);
        }
    }


}

