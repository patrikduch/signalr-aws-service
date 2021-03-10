namespace NetCore_Dockerization.Models
{
    /// <summary>
    /// ProjectDetail model class, that represents all basic information about web project.
    /// </summary>
    public class ProjectDetail
    {
        /// <summary>
        ///  Gets or sets project identifier.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets name of web project.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets author name of this app.
        /// </summary>
        public string Author { get; set; }

    }
}
