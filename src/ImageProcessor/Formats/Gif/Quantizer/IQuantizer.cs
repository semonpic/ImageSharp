﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IQuantizer.cs" company="James South">
//   Copyright © James South and contributors.
//   Licensed under the Apache License, Version 2.0.
// </copyright>
// <summary>
//   Provides methods for allowing quantization of images pixels.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ImageProcessor.Formats
{
    /// <summary>
    /// Provides methods for allowing quantization of images pixels.
    /// </summary>
    public interface IQuantizer
    {
        /// <summary>
        /// Quantize an image and return the resulting output pixels.
        /// </summary>
        /// <param name="image">The image to quantize.</param>
        /// <returns>
        /// A <see cref="T:byte[]"/> representing a quantized version of the image pixels.
        /// </returns>
        byte[] Quantize(ImageBase image);
    }
}
