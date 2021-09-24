using System;
using System.Collections.Generic;
using Xunit;

namespace BDSA2020.Assignment02.Tests
{
    public class ExtensionsTests
    {
        [Fact]
        public void Flatten_given_two_list_returns_one_list()
        {
            var list1 = new List<int>(){1,2,2,3,4,5};
            var list2 = new List<int>(){4,6,8,4,2,7};

            var collected = new List<List<int>>(){list1, list2};

            Assert.Equal(collected.Flatten(), new List<int>(){1,2,2,3,4,5,4,6,8,4,2,7});
        }

        [Fact]
        public void Filter_given_list_and_predicate_fortytwo_returns_correct()
        {
            var list = new List<int>(){1,4,7,9,3,5628,87,77,42,144};

            Assert.Equal(list.Filter(fortytwoModuloSeven), new List<int>(){5628,77});
        }

        [Fact]
        public void Filter_given_list_and_predicate_returns_leapyears()
        {
            var list = new List<int>(){2012,2013,2014,2015,2016,2017,2018,2019,2020,2021};

            Assert.Equal(list.Filter(leapyear), new List<int>(){2012,2016,2020});
        }

        [Fact]
        public void IsSecure_given_uri_returns_true()
        {
         var uri = new Uri("https://learnit.itu.dk/");

        Assert.True(uri.IsSecure());
        }

        [Fact]
        public void IsSecure_given_uri_returns_false()
        {
         var uri = new Uri("http://learnit.itu.dk/");

        Assert.False(uri.IsSecure());
        }

        [Fact]
        public void WordCount_given_sentence_returns_six()
        {
        var sentence = "Hello world, my name is Bob!";

        Assert.Equal(6, sentence.WordCount());
        }



        //Predicate methods
        public bool fortytwoModuloSeven(int number)
        {
            return (number > 42 && number % 7 == 0) ? true : false;
        }

        public bool leapyear(int year)
        {
            return DateTime.IsLeapYear(year);
        }
    }
}
