using System;


namespace olc3DProject
{
    class olc3DEngine : IGameEngine
    {
        private string Name { get; set; }

        public olc3DEngine() { this.Name = "No Name"; }
        public olc3DEngine(string name)
        {
            this.Name = name;
        }

        public bool OnUserCreate() 
        {

            return true;
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public bool ConstructConsole(int width, int heigh, int chPixWidth, int chPixHeigh)
        {
            throw new NotImplementedException();
        }

        public bool OnUserUpdate(double dElapsedTime)
        {

        
            return true;
        }
    }
}
