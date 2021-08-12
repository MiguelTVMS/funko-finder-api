using System;
using System.Collections.Generic;
using System.Linq;
using FunkoFinder.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FunkoFinder.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController
    {
        private readonly ILogger<CategoryController> _logger;

        public CategoryController(ILogger<CategoryController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Get a list of categories
        /// </summary>
        /// <returns>List of categories</returns>
        [HttpGet]
        public IEnumerable<Category> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Category
            {
                Id = Guid.NewGuid(),
                ParentCategoryId = Guid.NewGuid(),
                Name = $"Funko Name {Guid.NewGuid()}"
            })
            .ToArray();
        }
    }
}