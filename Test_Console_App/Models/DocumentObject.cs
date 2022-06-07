using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Console_App.Models
{
    internal class DocumentObject
    {
        public string Id { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentObject"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="logicalId">The logical identifier.</param>
        public DocumentObject(string id, string logicalId)
        {
            Id = id;
            LogicalId = logicalId;
        }

        /// <summary>
        /// The document type.
        /// </summary>
        /// <value>The document type.</value>
        public string DocumentObjectType { get; set; }

        /// <summary>
        /// The language card identifier.
        /// </summary>
        /// <value>The language card identifier.</value>
        public long? LanguageCardId { get; set; }

        /// <summary>
        /// The version card identifier.
        /// </summary>
        /// <value>The version card identifier.</value>
        public long? VersionCardId { get; set; }

        /// <summary>
        /// The logical identifier.
        /// </summary>
        /// <value>The logical identifier.</value>
        public string LogicalId { get; }

        /// <summary>
        /// The version.
        /// </summary>
        /// <value>The version.</value>
        public string? Version { get; set; }

        /// <summary>
        /// The language identifier.
        /// </summary>
        /// <value>The language identifier.</value>
        public string? LanguageId { get; set; }

        /// <summary>
        /// The resolution identifier.
        /// </summary>
        /// <value>The resolution identifier.</value>
        public string? ResolutionId { get; set; }
    }
}
