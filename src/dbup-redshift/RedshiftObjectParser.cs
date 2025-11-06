using DbUp.Support;

namespace DbUp.Redshift
{
    /// <summary>
    /// Parses Sql Objects and performs quoting functions
    /// </summary>
    public class RedshiftObjectParser : SqlObjectParser
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RedshiftObjectParser"/> class.
        /// </summary>
        public RedshiftObjectParser() : base("\"", "\"")
        {
        }
    }
}
