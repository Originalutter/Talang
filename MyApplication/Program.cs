//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Valtech">
//      Copyright (c) Valtech. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace MyApplication
{
    using System;
    using System.Collections.Generic;
    /// <summary>
    /// Program class
    /// </summary>
    public class Program
    { 
        /// <summary>
        /// Main method run at start of execution
        /// </summary>
        /// <param name="args">Arguments passed to function</param>
        public static void Main(string[] args)
        {
            var cat = new Cat();
        }

        /// <summary>
        /// Prints an array of integers
        /// </summary>
        /// <param name="arr">Argument passed to function</param>
        public static void PrintIntArray(IEnumerable<int> arr)
        {
            Console.Write("{");
            foreach (var i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("}");
        }

        /// <summary>
        /// Tests value type
        /// </summary>
        /// <param name="i">The integer to test</param>
        /// <returns>The result</returns>
        public static int TestValueType(int i)
        {
            i++;
            return i;
        }

        /// <summary>
        /// Tests reference type
        /// </summary>
        /// <param name="arr">An array of integers</param>
        /// <returns>The updated array</returns>
        public static int[] TestRefType(int[] arr)
        {
            arr[0] = 4;
            return arr;
        }
    }
}