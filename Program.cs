namespace inheritance_hill_Adam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FPS myFPS = new FPS("E", "ZombCube");

            Console.WriteLine(myFPS.Describe());
            myFPS.PlayGame();


            FPS R6 = new FPS("M","R6");
            Console.WriteLine(R6.Describe());
            R6.PlayGame();
        }
    }
}
