namespace inheritance_hill_Adam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new FPS game object with ESRB rating "E" and title "ZombCube"
            FPS myFPS = new FPS("E", "ZombCube");


            // Display a description of the first FPS game
            Console.WriteLine(myFPS.Describe());
            // Call the PlayGame method to indicate the game is starting
            myFPS.PlayGame();

            // Create another FPS game object with ESRB rating "M" and title "R6"
            FPS R6 = new FPS("M","R6");

            // Display a description of the second FPS game
            Console.WriteLine(R6.Describe());
            // Call the PlayGame method for the second game
            R6.PlayGame();
        }
    }
}
