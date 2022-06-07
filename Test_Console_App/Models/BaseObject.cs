namespace Test_Console_App.Models
{
    internal class BaseObject
    { 
        /// <summary>
        /// The identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public string? Id { get; }

        /// <summary>
        /// The title.
        /// </summary>
        /// <value>The title.</value>
        public string? Title { get; set; }

        /// <summary>
        /// The description.
        /// </summary>
        /// <value>The description.</value>
        public string? Description { get; set; }
    }
}
