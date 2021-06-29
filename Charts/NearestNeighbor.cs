using System;
using System.Collections.Generic;
using System.Drawing;

namespace Сhart
{
    class NearestNeighbor
    {
        List<Point> points;
        public List<Point> GetPoints()
        {
            return points;
        }
        public void AddPoints(Point point)
        {
            points.Add(point);
        }
        List<Point> pointsSorted;
        public List<Point> GetpointsSorted()
        {
            return pointsSorted;
        }

        public NearestNeighbor()
        {
            points = new List<Point>();
            pointsSorted = new List<Point>();
        }
        

        public double Greedy(int indexStartPoint)
        {
            List<Point> tempPoints = new List<Point>(points);
            pointsSorted.Clear();
            double minPath=0;
            double minDistance;
            Point testPoint = tempPoints[indexStartPoint];
            while (tempPoints.Count>0)
            {
                int delIndex=0;
                minDistance = double.MaxValue;
                for (int i=0; tempPoints.Count>i;i++)
                {
                    double distance = DistancePoint(testPoint, tempPoints[i]);
                    if (minDistance > distance)
                    {
                        minDistance = distance;
                        delIndex = i;
                    }
                }
                testPoint = tempPoints[delIndex];
                pointsSorted.Add(testPoint);
                tempPoints.RemoveAt(delIndex);
                minPath += minDistance;
            }
            minPath += DistancePoint(pointsSorted[pointsSorted.Count-1], pointsSorted[0]);
            return minPath;

        }

        double DistancePoint(Point first, Point second)
        {
            return Math.Sqrt(Math.Pow(second.X - first.X, 2) + Math.Pow(second.Y - first.Y,2));
        }

        public bool FreeSpaceAvailable(Point unsavedPoint)
        {
            foreach (Point point in points)
            {
                if ((Math.Pow(point.X - unsavedPoint.X, 2) + Math.Pow(point.Y - unsavedPoint.Y, 2) < 1600))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
