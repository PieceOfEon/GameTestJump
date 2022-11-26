using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTestJump.Classes
{
    public static class PlatformController
    {
        public static List<platform> platforms;
        public static int startPlatformPosY = 400;
        public static int score = 0;

        public static void AddPlatform(PointF position)
        {
            platform platform = new platform(position);
            platforms.Add(platform);
            
            
        }

        public static void GenerateStartSequence()
        {
            Random r = new Random();
            for(int i=0; i<10;i++)
            {
                int x = r.Next(0, 270);
                int y = r.Next(30, 40);
                startPlatformPosY -= y;
                PointF position = new PointF(x,startPlatformPosY);
                platform platform = new platform(position);
                platforms.Add(platform);
            }
        }

        public static void GenerateRandomPlatform()
        {
            Random r = new Random();
            int x = r.Next(0, 270);
            PointF position = new PointF(x, startPlatformPosY);
            platform platform = new platform(position);
            platforms.Add(platform);
            
        }

        public static void ClearPlatforms()
        {
            for(int i = 0; i<platforms.Count;i++)
            {
                if (platforms[i].transform.position.Y>=700)
                {
                    platforms.RemoveAt(i);
                }
            }
        }
    }
}
