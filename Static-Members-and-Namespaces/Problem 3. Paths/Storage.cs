using System.Text.RegularExpressions;

namespace Problem_3.Paths
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    using Static_Members_and_Namespaces;

    class Storage
    {
        public static void SavePath(string file, string path)
        {
            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.WriteLine(path);
            }
        }

        public static Path3D LoadPath(string file)
        {
            Path3D loadedPath = new Path3D(new List<Point3D>());

            using (StreamReader reader = new StreamReader(file))
            {
                string line = reader.ReadLine();

                const string PointPattern = @"Point [0-9]+ Coordinates { ([0-9]+), ([0-9]+), ([0-9]+) }";

                while (line != null)
                {
                    if (line != "")
                    {
                        MatchCollection matches = Regex.Matches(line, PointPattern);

                        if (matches[0].Groups.Count == 4)
                        {
                            int x = int.Parse(matches[0].Groups[1].Value);
                            int y = int.Parse(matches[0].Groups[2].Value);
                            int z = int.Parse(matches[0].Groups[3].Value);

                            Point3D point = new Point3D(x, y, z);
                            loadedPath.SequenceOfPoints.Add(point);
                        }
                    }

                    line = reader.ReadLine();
                }
            }

            return loadedPath;
        }
    }
}