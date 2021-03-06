//-----------------------------------------------------------------------
// <copyright file="BooksFormatsTests.cs" company="EpamTraining">
//     All rights reserved.
// </copyright>
// <author>Eduard Adasko</author>
//-----------------------------------------------------------------------
namespace BooksFormatsTests
{
    using System;
    using System.Globalization;
    using BooksTask;
    using NUnit.Framework;

    /// <summary>
    /// Provides tests for string representations of books.
    /// </summary>
    public class BooksFormatsTests
    {
        /// <summary>
        /// IFormatProvider for converting book to string.
        /// </summary>
        private readonly IFormatProvider provider = CultureInfo.CreateSpecificCulture("en");

        /// <summary>
        /// Custom formatter.
        /// </summary>
        private readonly BookCustomFormatting customProvider = new BookCustomFormatting(CultureInfo.CreateSpecificCulture("en"));

        /// <summary>
        /// Book to convert.
        /// </summary>
        private readonly Book book = new Book("978-0-7356-6754-7", "Jeffrey Richter", "CLR via C#", "Microsoft Press", 2012, 826, 59.99M);

        /// <summary>
        /// Tests converting book to different formats.
        /// </summary>
        /// <param name="format">
        /// Format to convert.
        /// </param>
        /// <param name="expected">
        /// Expected result.
        /// </param>
        [TestCase("AT", "Jeffrey Richter, CLR via C#")]
        [TestCase("TY", "CLR via C#, 2012")]
        [TestCase("tc", "CLR via C#, $59.99")]
        [TestCase("AThY", "Jeffrey Richter, CLR via C#, Microsoft Press, 2012")]
        [TestCase("aTHyNC", "Jeffrey Richter, CLR via C#, Microsoft Press, 2012, P. 826, $59.99")]
        public void ToStringTest(string format, string expected)
        {
            string result = string.Format(this.provider, "{0:" + format + "}", this.book);
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Tests throwing FormatException when wrong format was passed.
        /// </summary>
        [Test]
        public void ToStringFormatExceptionTest()
        {
            Assert.Throws<FormatException>(() => string.Format(this.provider, "{0: fewwfw}", this.book));
        }

        /// <summary>
        /// Tests additional formats provided by BookCustomFormatting.
        /// </summary>
        /// <param name="format">
        /// Format to convert.
        /// </param>
        /// <returns>
        /// Expected result.
        /// </returns>
        [TestCase("full", ExpectedResult = "Jeffrey Richter, CLR via C#, Microsoft Press, 2012, P. 826, $59.99, 978-0-7356-6754-7")]
        [TestCase("short", ExpectedResult = "Jeffrey Richter, CLR via C#, 2012")]
        public string CustomFormattingTest(string format) =>
            string.Format(this.customProvider, "{0:" + format + "}", this.book);
    }
}