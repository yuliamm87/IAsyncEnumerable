namespace Test_Console_App.Models;

public enum DocumentObjectType
{
    /// <summary>
    /// The document type cannot be specified.
    /// </summary>
    Undefined,

    /// <summary>
    /// The document is an illustration.
    /// </summary>
    Illustration,

    /// <summary>
    /// The document is a library.
    /// </summary>
    Library,

    /// <summary>
    /// The document is a map.
    /// </summary>
    Map,

    /// <summary>
    /// The document is a template (Other (PDF, Word...)).
    /// </summary>
    Other,

    /// <summary>
    /// The document is a topic.
    /// </summary>
    Topic
}