using System;

namespace olc3DProject
{
    class Program
    {
        public struct Vec3D
        {
            double x, y, z;

            public Vec3D(double v1, double v2, double v3) : this()
            {
                x = v1;
                y = v2;
                z = v3;
            }
        }
        public struct Triangle
        {
            Vec3D coorA, coorB, coorC;
            public Triangle(Vec3D a, Vec3D b, Vec3D c)
            {
                coorA = a;
                coorB = b;
                coorC = c;
            }
        };
        public struct Mesh
        {
            Triangle[] tris;
            public Mesh(Triangle[] meshVar)
            {
                tris = meshVar;
            }
        };

        static void Main(string[] args)
        {
            olc3DEngine demo = new olc3DEngine("First Engine");
            if (demo.ConstructConsole(256, 240, 4, 4))
            {
                demo.Start();
            }
            else
            {
                Console.WriteLine("Error occurrs");

            }

            //Triangle creating block
            var south1 = new Triangle(new Vec3D(1.0, 0.0, 0.0), new Vec3D(1.0, 0.0, 1.0), new Vec3D(1.0, 1.0, 1));
            var top1 = new Triangle(new Vec3D(1.0, 0.0, 1.0), new Vec3D(0.0, 0.0, 1.0), new Vec3D(0.0, 1.0, 1));
            var north1 = new Triangle(new Vec3D(0.0, 0.0, 1.0), new Vec3D(0.0, 0.0, 0.0), new Vec3D(0.0, 1.0, 0));
            var bottom1 = new Triangle(new Vec3D(0.0, 0.0, 0.0), new Vec3D(1.0, 0.0, 0.0), new Vec3D(1.0, 1.0, 0));

            var south2 = new Triangle(new Vec3D(1.0, 1.0, 1.0), new Vec3D(0.0, 1.0, 1.0), new Vec3D(1.0, 0.0, 0));
            var top2 = new Triangle(new Vec3D(0.0, 1.0, 1.0), new Vec3D(0.0, 1.0, 0.0), new Vec3D(1.0, 0.0, 1));
            var north2 = new Triangle(new Vec3D(0.0, 1.0, 0.0), new Vec3D(1.0, 1.0, 0.0), new Vec3D(0.0, 0.0, 1));
            var bottom2 = new Triangle(new Vec3D(1.0, 1.0, 0.0), new Vec3D(1.0, 1.0, 1.0), new Vec3D(0.0, 0.0, 0));

            var west1 = new Triangle(new Vec3D(0.0, 0.0, 0.0), new Vec3D(0.0, 0.0, 1.0), new Vec3D(1.0, 0.0, 1));
            var west2 = new Triangle(new Vec3D(1.0, 0.0, 1.0), new Vec3D(1.0, 0.0, 0.0), new Vec3D(0.0, 0.0, 0));

            var east1 = new Triangle(new Vec3D(1.0, 1.0, 0.0), new Vec3D(1.0, 1.0, 1.0), new Vec3D(0.0, 1.0, 1));
            var east2 = new Triangle(new Vec3D(0.0, 1.0, 1.0), new Vec3D(0.0, 1.0, 0.0), new Vec3D(1.0, 1.0, 0));

            Triangle[] groupOfTris = {
                south1,
                top1,
                north1,
                bottom1,
                south2,
                top2,
                north2,
                bottom2,
                east1,
                east2,
                west1,
                west2
            };
            Mesh meshCube = new Mesh(groupOfTris);

            // foreach ( in ) //


        }
    }
}

