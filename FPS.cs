using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_hill_Adam
{

    // FPS class inherits from Game and represents a first-person shooter game
    class FPS : Game
    {
        // <summary>
        /// Constructor for FPS class. Passes the title and ESRB rating to the base Game class.
        /// </summary>
        /// <param name="esrbParam">The ESRB rating of the game.</param>
        /// <param name="titleParam">The title of the game.</param>
        public FPS(string esrbParam, string titleParam) : base(esrbParam, titleParam)
        {
            // Initialize the properties specific to this FPS game
            Title = titleParam;
            Esrb = esrbParam;
        }
        /// <summary>
        /// Provides a description of the FPS game including its title and rating.
        /// Overrides the base Describe() method.
        /// </summary>
        /// <returns>A formatted string describing the FPS game.</returns>
        public override string Describe()
        {
            return $"{Title} is a fps game rated {Esrb}!";
        }
    }
}
