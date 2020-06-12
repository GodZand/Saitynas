using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Saintynas.Models
{

    /// <summary>
    /// represents one specific person.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// ID from SQL
        /// </summary>
        public int Id { get; set; } = 0;
        /// <summary>
        /// user firstname
        /// </summary>
        public string FirstName { get; set; } = "";
        /// <summary>
        /// make a wild guess
        /// </summary>
        public string LastName { get; set; } = "";

    }
}