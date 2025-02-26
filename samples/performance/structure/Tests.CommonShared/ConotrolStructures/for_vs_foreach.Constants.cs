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

namespace UnitTests.CSharp.Performance.ConotrolStructures
{
    public partial class for_vs_foreach
    {
        IEnumerable<int> ienumerable_int_01 = null;
        IEnumerable<double> ienumerable_dbl_01 = null;
        int[] array_int_01 = null;
        int[] array_01 = null;

        int result_dummy_int = -1;

        [Benchmark]
        public string Loop_for_IEeumerable_of_int_1()
        {
            string retval = "";
            for (int i = 0; i <= ienumerable_int_01.Count() - 1; i++)
            {
                // empty loop will be optimized to NO-OP, so the reuslt will be N/A
                result_dummy_int = ienumerable_int_01.ElementAt(i);
                retval += result_dummy_int.ToString();
            }

            return retval;
        }

        [Test]
        public void Loop_for_IEeumerable_of_int_1_Test()
        {
            Console.WriteLine($"OperatorPlus_Test");
            //====================================================================================================
            //  Arrange
            ienumerable_int_01 = Enumerable.Repeat(42, 1000);
            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            string s = Loop_for_IEeumerable_of_int_1();

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
        public string Loop_for_IEeumerable_of_int_2()
        {
            string retval = "";
            int n = ienumerable_int_01.Count();

            for (int i = 0; i <= n -1; i++)
            {
                // empty loop will be optimized to NO-OP, so the reuslt will be N/A
                result_dummy_int = ienumerable_int_01.ElementAt(i);
                retval += result_dummy_int.ToString();
            }

            return retval;
        }

        [Test]
        public void Loop_for_IEeumerable_of_int_2_Test()
        {
            Console.WriteLine($"OperatorPlus_Test");
            //====================================================================================================
            //  Arrange
            ienumerable_int_01 = Enumerable.Repeat(42, 1000);
            sw = Stopwatch.StartNew();

            //----------------------------------------------------------------------------------------------------
            // Act
            //      extracted to atomic Benchmark method
            string s = Loop_for_IEeumerable_of_int_2();

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
