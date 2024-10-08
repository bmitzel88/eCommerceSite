﻿using System.ComponentModel.DataAnnotations;

namespace eCommerceSite.Models
{

    /// <summary>
    /// Represents a single product available for purchase
    /// </summary>
    public class Product
    {
        /// <summary>
        /// The unique identifier for each vintage product
        /// </summary>
        [Key]
        public int ProductID { get; set; }

        /// <summary>
        /// The title of the vintage product
        /// </summary>
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// The sales price of the vintage product
        /// </summary>
        [Range(0, 100_000)]
        public double Price { get; set; }

        /// <summary>
        /// The manufacturing year of the vintage product
        /// The company does not sell anything newer then 1990
        /// </summary>
        [Range(1800, 1990)]
        public int Year { get; set; }

        //Todo: Add rating
    }
}
