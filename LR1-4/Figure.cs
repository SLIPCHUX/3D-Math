using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LR1_4
{
    public class Point3D
    {
        public double x, y, z;
        public Point3D(double ax, double ay, double az)
        {
            x = ax;
            y = ay;
            z = az;
        }
    }
    public class Object3D
    {
        protected Point3D[] points;
        protected int num;
        protected int projType;
        virtual public void Init() { }
        public void SetType(int i)
        {
            projType = i;
        }
        public Point Isometry(Point3D point3D)
        {
            Point p = new Point();
            p.X = (int)((point3D.x - point3D.z) * 0.707f) + 200;
            p.Y = (int)(point3D.x * (-0.408f) + point3D.y * 0.816 + point3D.z * (-0.408f)) + 200;
            return p;
        }
    }
    public class Figure : Object3D
    {
        public Figure()
        {
            num = 8;
            points = new Point3D[8];
            Init();
        }
        public override void Init()
        {
            points[0] = new Point3D(100, 100, 0);
            points[1] = new Point3D(250, 100, 0);
            points[2] = new Point3D(250, 250, 0);
            points[3] = new Point3D(100, 250, 0);
            points[4] = new Point3D(100, 100, 100);
            points[5] = new Point3D(250, 100, 100);
            points[6] = new Point3D(250, 250, 100);
            points[7] = new Point3D(100, 250, 100);
        }
        internal void Move(double kx, double ky, double kz)
        {
            for (int i = 0; i < num; i++)
            {
                points[i].x += kx;
                points[i].y += ky;
                points[i].z += kz;
            }
        }
        public void Draw(Graphics g)
        {
            Point[] tmp = { };
            Point[] tmp2 = { };
            Pen pen2 = new Pen(Color.White, 2);
            //Фронатальный вид
            if (projType == 0)
            {
                Point[] tm = {new Point((int)points[0].x, (int)points[0].y),
                new Point((int)points[1].x, (int)points[1].y),
                new Point((int)points[2].x, (int)points[2].y),
                new Point((int)points[3].x, (int)points[3].y),
                new Point((int)points[0].x, (int)points[0].y)};

                Point[] bk = {new Point((int)points[4].x, (int)points[4].y),
                new Point((int)points[5].x, (int)points[5].y),
                new Point((int)points[6].x, (int)points[6].y),
                new Point((int)points[7].x, (int)points[7].y),
                new Point((int)points[4].x, (int)points[4].y)};
                tmp = tm;
                tmp2 = bk;
            }
            if (projType == 1) //Top
            {
                Point[] tm = {new Point((int)points[0].x, (int)points[0].z),
                new Point((int)points[1].x, (int)points[1].z),
                new Point((int)points[2].x, (int)points[2].z),
                new Point((int)points[3].x, (int)points[3].z),
                new Point((int)points[0].x, (int)points[0].z)};
                Point[] bk = {new Point((int)points[4].x, (int)points[4].z),
                new Point((int)points[5].x, (int)points[5].z),
                new Point((int)points[6].x, (int)points[6].z),
                new Point((int)points[7].x, (int)points[7].z),
                new Point((int)points[4].x, (int)points[4].z)};
                tmp = tm;
                tmp2 = bk;
            }
            if (projType == 2) //Side
            {
                Point[] tm = {new Point((int)points[0].z, (int)points[0].y),
                new Point((int)points[1].z, (int)points[1].y),
                new Point((int)points[2].z, (int)points[2].y),
                new Point((int)points[3].z, (int)points[3].y),
                new Point((int)points[0].z, (int)points[0].y)};
                Point[] bk = {new Point((int)points[4].z, (int)points[4].y),
                new Point((int)points[5].z, (int)points[5].y),
                new Point((int)points[6].z, (int)points[6].y),
                new Point((int)points[7].z, (int)points[7].y),
                new Point((int)points[4].z, (int)points[4].y)};
                tmp = tm;
                tmp2 = bk;
            }
            if (projType == 3)
            {
                Point[] tm = { Isometry(points[0]),
                    Isometry(points[1]),
                    Isometry(points[2]),
                    Isometry(points[3]),
                    Isometry(points[0])};

                Point[] bk = {Isometry(points[4]),
                    Isometry(points[5]),
                    Isometry(points[6]),
                    Isometry(points[7]),
                    Isometry(points[4])};
                tmp = tm;
                tmp2 = bk;
            }
            g.DrawLines(Pens.Black, tmp);
            g.DrawLines(Pens.Red, tmp2);
            for (int i = 0; i < 4; i++)
                g.DrawLine(Pens.White, tmp[i], tmp2[i]);
        }
        public void Rotate(bool axisX, bool axisY, bool axisZ, double angle)
        {
            angle = angle * Math.PI / 180.0;
            Point3D centr = new Point3D(points[0].x, points[0].y, points[0].z);
            Move(-centr.x, -centr.y, -centr.z);
            if (axisX) // X
            {
                for (int i = 0; i < num; i++)
                {
                    Point3D tmp = new Point3D(points[i].x, points[i].y, points[i].z);
                    points[i].y = tmp.y * Math.Cos(angle) + tmp.z * Math.Sin(angle);
                    points[i].z = -tmp.y * Math.Sin(angle) + tmp.z * Math.Cos(angle);
                }
            }
            if (axisY) // Y
            {
                for (int i = 0; i < num; i++)
                {
                    Point3D tmp = new Point3D(points[i].x, points[i].y, points[i].z);
                    points[i].x = tmp.x * Math.Cos(angle) + tmp.z * Math.Sin(angle);
                    points[i].z = -tmp.x * Math.Sin(angle) + tmp.z * Math.Cos(angle);
                }
            }
            if (axisZ) // Z
            {
                for (int i = 0; i < num; i++)
                {
                    Point3D tmp = new Point3D(points[i].x, points[i].y, points[i].z);
                    points[i].x = tmp.x * Math.Cos(angle) + tmp.y * Math.Sin(angle);
                    points[i].y = -tmp.x * Math.Sin(angle) + tmp.y * Math.Cos(angle);
                }
            }
            Move(centr.x, centr.y, centr.z);
        }
        internal void Scale(double kX, double kY, double kZ)
        {
            Point3D centr = new Point3D(points[0].x, points[0].y, points[0].z);
            Move(-centr.x, -centr.y, -centr.z);
            for (int i = 0; i < num; i++)
            {
                points[i].x *= kX;
                points[i].y *= kY;
                points[i].z *= kZ;
            }
            Move(centr.x, centr.y, centr.z);
        }
        public void SetType(int i)
        {
            projType = i;
        }
    }
    public class Surface : Object3D
    {
        public Surface()
        {
            num = 16;
            points = new Point3D[num];
            for (int i = 0; i < 16; i++)
            {
                points[i] = new Point3D(0, 0, 0);
            }
            Init();
        }
        public Point3D GetPoint(int i, int j)
        {
            return points[i + j * 4];
        }
        public void SetPoint(float x, float y, float z, int i, int j)
        {
            points[i + j * 4].x = x;
            points[i + j * 4].y = y;
            points[i + j * 4].z = z;
        }
        public override void Init()
        {
            double Y = 50;
            double Z = 0;
            for (int i = 0; i < 4; i++)
            {
                double X = 50;
                for (int j = 0; j < 4; j++)
                {
                    points[i + j * 4].x = X;
                    points[i + j * 4].y = Y;
                    points[i + j * 4].z = Z;
                    X += 100;
                }
                Y += 120;
            }
        }

        public void Draw(Graphics g)
        {
            float[,] Ms = { {-1,  3, -3, 1 },
                            { 3, -6,  3, 0 },
                            {-3,  0,  3, 0 },
                            { 1,  4,  1, 0 }};
            float[,] MsT = new float[4, 4];
            float[,] Px = new float[4, 4];
            float[,] Py = new float[4, 4];
            float[,] Pz = new float[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Ms[i, j] *= 1f / 6f;
                    MsT[j, i] = Ms[i, j];
                    Px[i, j] = (float)points[i + j * 4].x;
                    Py[i, j] = (float)points[i + j * 4].y;
                    Pz[i, j] = (float)points[i + j * 4].z;
                }
            }

            for (float s = 0; s < 1; s += 0.05f)
            {
                float[,] S = { { s * s * s, s * s, s, 1 } };
                for (float t = 0; t < 1; t += 0.05f)
                {
                    float[,] T = { { t * t * t },
                                    { t*t },
                                     { t },
                                     { 1 }};
                    float x = Mul(Mul(Mul(Mul(S, Ms), Px), MsT), T)[0, 0];
                    float y = Mul(Mul(Mul(Mul(S, Ms), Py), MsT), T)[0, 0];
                    float z = Mul(Mul(Mul(Mul(S, Ms), Pz), MsT), T)[0, 0];
                    DrawDot(x, y, z, g);
                }
            }
        }

        private void DrawDot(float x, float y, float z, Graphics g)
        {
            Point tm = new Point();
            if (projType == 0) //Frontal
            {
                tm.X = (int)x;
                tm.Y = (int)y;
            }
            if (projType == 1) //Top
            {
                tm.X = (int)x;
                tm.Y = (int)z;
            }
            if (projType == 2) //Side
            {
                tm.X = (int)z;
                tm.Y = (int)y;
            }
            if (projType == 3) //Isometry
            {
                tm = Isometry(new Point3D(x, y, z));
            }
            Pen pen = new Pen(Color.White, 1);
            g.DrawEllipse(pen, tm.X, tm.Y, 2, 2);
        }

        public float[,] Mul(float[,] f, float[,] s)
        {
            float[,] Result = new float[f.GetLength(0), s.GetLength(1)];
            for (int i = 0; i < f.GetLength(0); i++)
            {
                for (int j = 0; j < s.GetLength(1); j++)
                {
                    Result[i, j] = 0;
                    for (int k = 0; k < f.GetLength(1); k++)
                    {
                        Result[i, j] += f[i, k] * s[k, j];
                    }
                }
            }
            return Result;
        }

        internal void Move(double kX, double kY, double kZ)
        {
            for (int i = 0; i < num; i++)
            {
                points[i].x += kX;
                points[i].y += kY;
                points[i].z += kZ;
            }
        }

        internal void Rotate(bool axisX, bool axisY, bool axisZ, double angle)
        {
            angle = angle * Math.PI / 180.0;
            Point3D centr = new Point3D(points[10].x, points[10].y, points[10].z);
            Move(-centr.x, -centr.y, -centr.z);
            if (axisX) // X
            {
                for (int i = 0; i < num; i++)
                {
                    Point3D tmp = new Point3D(points[i].x, points[i].y, points[i].z);
                    points[i].y = tmp.y * Math.Cos(angle) + tmp.z * Math.Sin(angle);
                    points[i].z = -tmp.y * Math.Sin(angle) + tmp.z * Math.Cos(angle);
                }
            }
            if (axisY) // Y
            {
                for (int i = 0; i < num; i++)
                {
                    Point3D tmp = new Point3D(points[i].x, points[i].y, points[i].z);
                    points[i].x = tmp.x * Math.Cos(angle) + tmp.z * Math.Sin(angle);
                    points[i].z = -tmp.x * Math.Sin(angle) + tmp.z * Math.Cos(angle);
                }
            }
            if (axisZ) // Z
            {
                for (int i = 0; i < num; i++)
                {
                    Point3D tmp = new Point3D(points[i].x, points[i].y, points[i].z);
                    points[i].x = tmp.x * Math.Cos(angle) + tmp.y * Math.Sin(angle);
                    points[i].y = -tmp.x * Math.Sin(angle) + tmp.y * Math.Cos(angle);
                }
            }
            Move(centr.x, centr.y, centr.z);
        }

        public void Scale(double kX, double kY, double kZ)
        {
            Point3D centr = new Point3D(points[6].x, points[6].y, points[6].z);
            Move(-centr.x, -centr.y, -centr.z);
            for (int i = 0; i < num; i++)
            {
                points[i].x *= kX;
                points[i].y *= kY;
                points[i].z *= kZ;
            }
            Move(centr.x, centr.y, centr.z);
        }
    }
}
