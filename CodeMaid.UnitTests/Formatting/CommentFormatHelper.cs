﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SteveCadwallader.CodeMaid.Model.Comments;
using System;
using System.Collections.Generic;

namespace SteveCadwallader.CodeMaid.UnitTests.Formatting
{
    internal class CommentFormatHelper
    {
        public static string AssertEqualAfterFormat(string input)
        {
            return AssertEqualAfterFormat(input, input);
        }

        public static string AssertEqualAfterFormat(string input, string expected)
        {
            return AssertEqualAfterFormat(input, expected, null);
        }

        public static string AssertEqualAfterFormat(string input, string expected, string prefix)
        {
            var result = Format(input, prefix);
            Assert.AreEqual(expected, result);
            return result;
        }

        public static string Format(IEnumerable<string> text)
        {
            return Format(string.Join(Environment.NewLine, text));
        }

        public static string Format(string text)
        {
            return Format(text, null);
        }

        public static string Format(string text, string prefix)
        {
            return CodeComment.FormatXml(text, prefix);
        }
    }
}