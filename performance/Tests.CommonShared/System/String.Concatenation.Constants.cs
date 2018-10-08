// /*
//    Copyright (c) 2017-12
//
//    moljac
//    Test.cs
//
//    Permission is hereby granted, free of charge, to any person
//    obtaining a copy of this software and associated documentation
//    files (the "Software"), to deal in the Software without
//    restriction, including without limitation the rights to use,
//    copy, modify, merge, publish, distribute, sublicense, and/or sell
//    copies of the Software, and to permit persons to whom the
//    Software is furnished to do so, subject to the following
//    conditions:
//
//    The above copyright notice and this permission notice shall be
//    included in all copies or substantial portions of the Software.
//
//    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
//    EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
//    OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
//    NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
//    HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
//    WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
//    FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
//    OTHER DEALINGS IN THE SOFTWARE.
// */

#if XUNIT
using Xunit;
// NUnit aliases
using Test = Xunit.FactAttribute;
using OneTimeSetUp = HolisticWare.Core.Testing.UnitTests.UnitTestsCompatibilityAliasAttribute;
// XUnit aliases
using TestClass = HolisticWare.Core.Testing.UnitTests.UnitTestsCompatibilityAliasAttribute;
#elif NUNIT
using NUnit.Framework;
// MSTest aliases
using TestInitialize = NUnit.Framework.SetUpAttribute;
using TestProperty = NUnit.Framework.PropertyAttribute;
using TestClass = NUnit.Framework.TestFixtureAttribute;
using TestMethod = NUnit.Framework.TestAttribute;
using TestCleanup = NUnit.Framework.TearDownAttribute;
// XUnit aliases
using Fact=NUnit.Framework.TestAttribute;
#elif MSTEST
using Microsoft.VisualStudio.TestTools.UnitTesting;
// NUnit aliases
using Test = Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute;
using OneTimeSetUp = Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute;
// XUnit aliases
using Fact = Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute;
#endif

#if BENCHMARKDOTNET
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Attributes.Jobs;
#else
using Benchmark = HolisticWare.Core.Testing.BenchmarkTests.Benchmark;using ShortRunJob = HolisticWare.Core.Testing.BenchmarkTests.ShortRunJob;
#endif

using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Collections.ObjectModel;

namespace UnitTests.CSharp.Performance.System
{
    public partial class String_Concatenation
    {

        [Benchmark]
        public string Constants_OperatorPlus()
        {
            return "something" + "anything" + "everything";
        }

        [Test]
        public void Constants_OperatorPlus_Test()
        {
            Console.WriteLine($"OperatorPlus_Test");
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            string s = Constants_OperatorPlus();

            sw.Stop();
            Console.WriteLine($"OperatorPlus_Test");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            //#if NUNIT
            //Assert.AreEqual(3.00, mean, 0.00001);
            //#elif XUNIT
            //Assert.Equal(3.00, mean, 5);
            //#elif MSTEST
            //Assert.AreEqual(3.00, mean, 0.00001);
            //#endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public string Constants_String_Concat()
        {
            return string.Concat("something", "anything", "everything");
        }

        [Test]
        public void Constants_String_Concat_Test()
        {
            Console.WriteLine($"OperatorPlus_Test");
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            string s = Constants_String_Concat();

            sw.Stop();
            Console.WriteLine($"OperatorPlus_Test");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            //#if NUNIT
            //Assert.AreEqual(3.00, mean, 0.00001);
            //#elif XUNIT
            //Assert.Equal(3.00, mean, 5);
            //#elif MSTEST
            //Assert.AreEqual(3.00, mean, 0.00001);
            //#endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public string Constants_String_Join()
        {
            return string.Join("something", "anything", "everything");
        }

        [Test]
        public void Constants_String_Join_Test()
        {
            Console.WriteLine($"OperatorPlus_Test");
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            string s = Constants_String_Join();

            sw.Stop();
            Console.WriteLine($"OperatorPlus_Test");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            //#if NUNIT
            //Assert.AreEqual(3.00, mean, 0.00001);
            //#elif XUNIT
            //Assert.Equal(3.00, mean, 5);
            //#elif MSTEST
            //Assert.AreEqual(3.00, mean, 0.00001);
            //#endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public string Constants_String_Format()
        {
            return string.Format("{0},{1},{2}", "something", "anything", "everything");
        }

        [Test]
        public void Constants_String_Format_Test()
        {
            Console.WriteLine($"OperatorPlus_Test");
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            string s = Constants_String_Format();

            sw.Stop();
            Console.WriteLine($"OperatorPlus_Test");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            //#if NUNIT
            //Assert.AreEqual(3.00, mean, 0.00001);
            //#elif XUNIT
            //Assert.Equal(3.00, mean, 5);
            //#elif MSTEST
            //Assert.AreEqual(3.00, mean, 0.00001);
            //#endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public string Constants_StringBuilder()
        {
            return
                (new global::System.Text.StringBuilder().Append("something").Append("anything").Append("everything"))
                .ToString();
        }

        [Test]
        public void Constants_StringBuilder_Test()
        {
            Console.WriteLine($"OperatorPlus_Test");
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            string s = Constants_StringBuilder();

            sw.Stop();
            Console.WriteLine($"OperatorPlus_Test");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            //#if NUNIT
            //Assert.AreEqual(3.00, mean, 0.00001);
            //#elif XUNIT
            //Assert.Equal(3.00, mean, 5);
            //#elif MSTEST
            //Assert.AreEqual(3.00, mean, 0.00001);
            //#endif
            //====================================================================================================

            return;
        }

        [Benchmark]
        public string Constants_LINQ_Aggregate()
        {
            return
                new[] { "something", "anything", "everything" }.Aggregate((tmp, word) => $"{tmp}{word}");
        }

        [Test]
        public void Constants_LINQ_Aggregate_Test()
        {
            Console.WriteLine($"OperatorPlus_Test");
            //====================================================================================================
            //  Arrange
            //  reading data from files

            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            string s = Constants_StringBuilder();

            sw.Stop();
            Console.WriteLine($"OperatorPlus_Test");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            //----------------------------------------------------------------------------------------------------
            // Assert
            //#if NUNIT
            //Assert.AreEqual(3.00, mean, 0.00001);
            //#elif XUNIT
            //Assert.Equal(3.00, mean, 5);
            //#elif MSTEST
            //Assert.AreEqual(3.00, mean, 0.00001);
            //#endif
            //====================================================================================================

            return;
        }

    }
}
