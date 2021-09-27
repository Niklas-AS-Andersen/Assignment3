using System;
using System.Collections.Generic;
using Xunit;

namespace BDSA2021.Assignment02.Tests
{
    public class QueriesTests
    {
        [Fact]
        public void Test_ReturnRowlingExt_returns_Harry_Potter()
        {
            var rowling = Queries.ReturnRowlingExt();

            var expected = new List<string>(){"Harry Potter","Smeagle"};
            Assert.Equal(expected, rowling);
        }

        [Fact]
        public void Test_ReturnRowlingLinq_returns_Harry_Potter()
        {
            var rowling = Queries.ReturnRowlingLinq();

            var expected = new List<string>(){"Harry Potter","Smeagle"};
            Assert.Equal(expected, rowling);
        }

        [Fact]
        public void Test_ReturnFirstSithlordYearExt_Returns_1977()
        {
            var vader = Queries.ReturnFirstSithlordYearExt();

            var expected = 1977;

            Assert.Equal(expected, vader);
        }

        
        [Fact]
        public void Test_ReturnFirstSithlordYearLinq_Returns_1977()
        {
            var vader = Queries.ReturnFirstSithlordYearLinq();

            var expected = 1977;

            Assert.Equal(expected, vader);
        }

        
        [Fact]
        public void Test_ReturnHarryPotterBooksNameAndYearExt_Returns_Harry_Potter_and_the_Philosophers_Stone_And_1997()
        {
            var vader = Queries.ReturnHarryPotterBooksNameAndYearExt();

            var expected = new List<(string, int?)>(){("Harry Potter",1997), ("Smeagle", 1999)};

            Assert.Equal(expected, vader);
        }

        [Fact]
        public void Test_ReturnHarryPotterBooksNameAndYearLinq_Returns_Harry_Potter_and_the_Philosophers_Stone_And_1997()
        {
            var vader = Queries.ReturnHarryPotterBooksNameAndYearLinq();

            var expected = new List<(string, int?)>(){("Harry Potter",1997), ("Smeagle", 1999)};

            Assert.Equal(expected, vader);
        }

        [Fact]
        public void Test_ReturnWizardNamesGroupedByCreatorReverseOrderExt_returns_that()
        {
            var reverse = Queries.ReturnWizardNamesGroupedByCreatorReverseOrderExt();

            var expected = new List<string>(){"Barbie","Jeff Bezos","Sauron","Harry Potter", "Smeagle", "Darth Maul", "Darth Vader", "Harold", "Fairy Godmother", "Merlin","Blue Man"};

            Assert.Equal(expected, reverse);
        }

        [Fact]
        public void Test_ReturnWizardNamesGroupedByCreatorReverseOrderLinq_returns_that()
        {
            var reverse = Queries.ReturnWizardNamesGroupedByCreatorReverseOrderLinq();

            var expected = new List<string>(){"Barbie","Jeff Bezos","Sauron","Harry Potter", "Smeagle", "Darth Maul", "Darth Vader", "Harold", "Fairy Godmother", "Merlin","Blue Man"};

            Assert.Equal(expected, reverse);
        }
    }
}
