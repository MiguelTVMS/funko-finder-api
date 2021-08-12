using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FunkoFinder.Api.Models
{
    /// <summary>
    /// A category that items can be on
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Unique identity of the category
        /// </summary>
        /// <value></value>
        [Required()]
        public Guid Id { get; set; }

        /// <summary>
        /// Unique identity from the parent category
        /// </summary>
        /// <value></value>
        public Guid? ParentCategoryId { get; set; }

        /// <summary>
        /// Name of the category
        /// </summary>
        /// <value></value>
        [Required()]
        public String Name { get; set; }

    }


}