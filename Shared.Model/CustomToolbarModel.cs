// <copyright file="CustomToolbarModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Shared.Model
{
    using System.Collections.Generic;

    /// <summary>
    /// Class CustomToolbarModel.
    /// </summary>
    public class CustomToolbarModel
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the caption.
        /// </summary>
        /// <value>The caption.</value>
        public string Caption { get; set; }

        /// <summary>
        /// Gets or sets the pages.
        /// </summary>
        /// <value>The pages.</value>
        public List<RibbonPageModel> Pages { get; set; }

    }
}
