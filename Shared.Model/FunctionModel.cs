// <copyright file="CustomToolbarModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Shared.Model
{
    public enum FunctionType
    {
        /// <summary>
        /// To Select a User.
        /// </summary>
        User = 0,

        /// <summary>
        /// To Select a Cusstomer.
        /// </summary>
        Customer = 1,

        /// <summary>
        /// To Select a Product.
        /// </summary>
        Product = 2,

        /// <summary>
        /// To Open a Link
        /// </summary>
        WebLink = 3,

        /// <summary>
        /// To Save a Value like a text or Number in Button.
        /// </summary>
        PredefineValue = 4,

        /// <summary>
        /// To Set a Specific Action to Button.
        /// </summary>
        ActionShortcut = 5,

        /// <summary>
        /// To Set a Specific Page To Button.
        /// </summary>
        PageShortcut = 6,

        /// <summary>
        /// to use predefine payment method and payment type in transactions
        /// </summary>
        PaymentShortcut = 7,
    }

    /// <summary>
    /// Class FunctionModel.
    /// </summary>
    public class FunctionModel
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
        /// Gets or sets the type of the function.
        /// </summary>
        /// <value>The type of the function.</value>
        public FunctionType FunctionType { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        public object Value { get; set; }

    }
}