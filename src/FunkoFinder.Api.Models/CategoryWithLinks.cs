using System;
using System.Collections.Generic;

namespace FunkoFinder.Api.Models
{
    public class CategoryWithLinks : Category
    {
        public CategoryLinks Links { get; } = new CategoryLinks();

        public CategoryWithLinks() : base() { }

        public static CategoryWithLinks FromCategory(Category category, string formatCategoryLink)
        {
            if (category is null)
                throw new ArgumentException("Cannot be Null.", nameof(category));

            if (String.IsNullOrEmpty(formatCategoryLink))
                throw new ArgumentException("Cannot be Null or empty.", nameof(formatCategoryLink));

            var categoryWithLinks = (CategoryWithLinks)category;
            String stringUriCategoryLink

            try
            {
                String.Format(formatCategoryLink, categoryWithLinks.ParentCategoryId.ToString()
            }
            catch (System.Exception ex)
            {

                throw;
            }

            if (!Uri.TryCreate())
            {

            }




            if (Uri.TryCreate())
            {

            }

            categoryWithLinks.Links.Category = new Uri(String.Format(formatCategoryLink, categoryWithLinks.ParentCategoryId.ToString()))
        }

    }
}