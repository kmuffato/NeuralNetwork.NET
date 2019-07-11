﻿using JetBrains.Annotations;

namespace NeuralNetwork.NET.Core.Interfaces
{
    /// <summary>
    /// An interface for an object that supports deep cloning
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IClonable<out T> where T : class
    {
        /// <summary>
        /// Returns a deep clone of the current instance
        /// </summary>
        [Pure, NotNull]
        T Clone();
    }
}