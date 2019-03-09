using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Autoclicker
{
    /// <summary>
    /// Holds a list of layouts avalaible and searches and finds them on demand
    /// </summary>
    public class LayoutCollection
    {
        /// <summary>The save location for the layouts</summary>
        public const string SaveLocation = "./Layouts.txt";

        /// <summary>Gets the layouts available</summary>
        public List<string> LayoutsAvailable { get; private set; }

        /// <summary>
        /// Intialises the <c>LayoutCollection</c> and loads the layouts available
        /// </summary>
        public LayoutCollection()
        {
            Load();
        }

        private void Load()
        {
            LayoutsAvailable = new List<string>();

            // If file doesn't exist, ignore
            try
            {
                // Read file and add layout choices
                string[] layoutFile = File.ReadAllLines(SaveLocation);
                for (int i = 0; i < layoutFile.Length; i++)
                {
                    if (layoutFile[i] == "---------")
                    {
                        LayoutsAvailable.Add(layoutFile[i + 1]);
                    }
                }
            }
            catch { }
        }

        /// <summary>
        /// Gets a layout from the save location and returns the retrieved layout
        /// </summary>
        /// <param name="layoutName">The layout to select</param>
        public Layout GetLayout(string layoutName)
        {
            int index = 0;
            List<string> layoutArray = new List<string>();

            // Open file
            string[] layoutFile = File.ReadAllLines(SaveLocation);

            // Find layout
            while (layoutFile[index] != layoutName) index++;

            // Add layout information
            while (index < layoutFile.Length && layoutFile[index] != "---------")
            {
                layoutArray.Add(layoutFile[index]);
                index++;
            }

            // Return processed layout
            return new Layout(layoutArray);
        }

        /// <summary>
        /// Saves a layout to the save file
        /// </summary>
        /// <param name="layoutName">The name of the layout</param>
        public void SaveLayout(Layout layout)
        {
            // Doesn't allow for the same name
            if (LayoutsAvailable.Contains(layout.Name))
            {
                throw new LayoutAlreadyExistsException("The given layout name already exists");
            }

            // Add the availability list
            LayoutsAvailable.Add(layout.Name);

            // Ignore if no existing file currently
            List<string> existingFile;
            try
            {
                existingFile = File.ReadAllLines(SaveLocation).ToList();
            }
            catch
            {
                existingFile = new List<string>();
            }

            // Add layout to file
            existingFile.Add("---------");
            existingFile.AddRange(layout.ToStringArray());

            // Save file
            File.WriteAllLines(SaveLocation, existingFile);
        }

        /// <summary>
        /// Deletes a layout from the save file
        /// </summary>
        /// <param name="layoutName">The name of the layout to delete</param>
        public void DeleteLayout(string layoutName)
        {
            int index = 0;
            List<string> layoutFile = File.ReadAllLines(SaveLocation).ToList();

            // Find layout
            while (layoutFile[index] != layoutName) index++;

            // Remove seperator line
            layoutFile.RemoveAt(index - 1);
            index--;

            // Remove layout
            while (index < layoutFile.Count && layoutFile[index] != "---------") layoutFile.RemoveAt(index);

            // Save file
            File.WriteAllLines(SaveLocation, layoutFile);

            // Remove from avalailable
            LayoutsAvailable.Remove(layoutName);
        }
    }

    /// <summary>
    /// Represents a layout for <c>ClickerPosition</c>s with a name and the list of positions
    /// </summary>
    public class Layout
    {
        /// <summary>The name of the <c>Layout</c></summary>
        public string Name { get; set; }

        /// <summary>The list of <c>ClickerPosition</c>s in the <c>Layout</c></summary>
        public List<ClickerPosition> Positions { get; set; }

        /// <summary>
        /// Initialises a new <c>Layout</c>
        /// </summary>
        /// <param name="name">The name of the <c>Layout</c></param>
        /// <param name="clickerPositions">The list of <c>ClickerPosition</c>s</param>
        public Layout(string name, List<ClickerPosition> clickerPositions)
        {
            Name = name;
            Positions = clickerPositions;
        }

        /// <summary>
        /// Initialises a new <c>Layout</c> from a list of strings
        /// </summary>
        /// <param name="stringList">The list of strings</param>
        public Layout(IList<string> stringList)
        {
            Name = stringList[0];

            // Add positions
            Positions = new List<ClickerPosition>();
            foreach (string layout in stringList.Skip(1))
            {
                Positions.Add(new ClickerPosition(layout));
            }
        }

        /// <summary>
        /// Converts the layout to a string array
        /// </summary>
        /// <returns></returns>
        public string[] ToStringArray()
        {
            List<string> stringList = new List<string>() { Name };

            // Get positions as a string and add to the list
            stringList.AddRange(Positions.Select(x => x.ToString()));
            return stringList.ToArray();
        }
    }

    [Serializable]
    /// <summary>The exception that is thrown when a layout already exists (name-wise_</summary>
    public class LayoutAlreadyExistsException : Exception
    {
        /// <summary>Initialises a new instance of the <c>LayoutAlreadyExistsException</c> class</summary>
        public LayoutAlreadyExistsException()
        {
        }

        /// <summary>Initialises a new instance of the <c>LayoutAlreadyExistsException</c> class with a message</summary>
        /// <param name="message">The error message that explains the reason for the exception</param>
        public LayoutAlreadyExistsException(string message)
            : base(message)
        {
        }

        /// <summary>Initialises a new instance of the <c>LayoutAlreadyExistsException</c> class with a message and a reference to the inner exception that is the cause of this error</summary>
        /// <param name="message">The error message that explains the reason for the exception</param>
        /// <param name="inner">The exception that is the cause of this exception. If the inner parameter is not a null reference (Nothing in Visual Basic), the current exception is raised in a catch block that handles the inner exception</param>
        public LayoutAlreadyExistsException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
