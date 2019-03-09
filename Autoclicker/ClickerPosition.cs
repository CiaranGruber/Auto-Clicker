using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoclicker
{
    /// <summary>
    /// Represents a point of the screen where the mouse will click
    /// </summary>
    public class ClickerPosition
    {
        /// <summary>Gets or sets the X position</summary>
        public int X { get; set; }
        /// <summary>Gets or sets the Y position</summary>
        public int Y { get; set; }
        /// <summary>Gets or sets the times to repeat</summary>
        public int TimesToRepeat { get; set; }

        /// <summary>
        /// Initialises a new <c>ClickerPosition</c> from parameters
        /// </summary>
        /// <param name="x">The X position</param>
        /// <param name="y">The Y position</param>
        /// <param name="timesToRepeat">The number of times to repeat the click</param>
        public ClickerPosition(int x, int y, int timesToRepeat)
        {
            X = x;
            Y = y;
            TimesToRepeat = timesToRepeat;
        }

        /// <summary>
        /// Initialises a new <c>ClickerPosition</c> from a string
        /// </summary>
        /// <param name="stringVersion">The string version of the <c>ClickerPosition</c></param>
        public ClickerPosition(string stringVersion)
        {
            int[] parts = stringVersion.Split(',').Select(x => Convert.ToInt32(x)).ToArray();
            X = parts[0];
            Y = parts[1];
            TimesToRepeat = parts[2];
        }

        /// <summary>
        /// Returns a string representation of the <c>ClickerPosition</c>
        /// </summary>
        /// <returns>A string representation of the <c>ClickerPosition</c></returns>
        public override string ToString()
        {
            return string.Join(",", X, Y, TimesToRepeat);
        }
    }
}
