using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CyclingManager
{
    class GameWorld
    {
        private Graphics dc; 
        
        //Gameobjects?

        public static int currentFps;
        public static int milliseconds;
        public static float myDeltaTime;
        public static TimeSpan deltaTime;
        public DateTime endTime;
        private BufferedGraphics backBuffer;
        public static PointF worldsize;

        public GameWorld(Graphics dc, Rectangle displayRectangle)
        {
            
        }

        public void SetupWorld()
        { 
            
        }

        public void GameLoop()
        {
            DateTime starttime = DateTime.Now;
            deltaTime = starttime - endTime;
            milliseconds = deltaTime.Milliseconds > 0 ? deltaTime.Milliseconds : 1;

            currentFps = 1000 / milliseconds;
            myDeltaTime = 1 / (float)currentFps;
            endTime = DateTime.Now;
            

        }

        public void Update()
        { 
        
        }
    }
}
