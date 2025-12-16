using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_hill_Adam
{
    /// <summary>
    /// Abstract base class representing a general game.
    /// Cannot be instantiated directly; meant to be inherited by specific game types.
    /// </summary>
    abstract class Game
    {

        /// <summary>
        /// Gets or sets the ESRB rating of the game.
        /// </summary>
        public string Esrb {  get; set; }

        /// <summary>
        /// Gets or sets the title of the game.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Constructor for the Game class. Initializes the title and ESRB rating.
        /// </summary>
        /// <param name="esrbParam">The ESRB rating of the game.</param>
        /// <param name="titleParam">The title of the game.</param>
        public Game(string esrbParam, string titleParam) 
        {
            Esrb = esrbParam;
            Title = titleParam;
        }

        /// <summary>
        /// Prints the title and say it is starting.
        /// </summary>
        public void PlayGame()
        {
            Console.WriteLine($"{Title} is Starting!");
        }

        /// <summary>
        /// Abstract method that must be overridden in derived classes.
        /// Returns a description of the game.
        /// </summary>
        /// <returns>A string describing the game.</returns>
        public abstract string Describe();
    }
}
