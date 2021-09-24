using System;
using Xunit;

namespace BDSA2021.Assignment02.Tests
{
    public class DelegatesTests
    {
        [Fact]
        public void Lampda_reverse_string()
        {
            Func<string, string> reverse = default(Func<string,string>);
            
            reverse = str => {
                char[] stringArray = str.ToCharArray();
                Array.Reverse(stringArray);
                return new string(stringArray);
                //return reversedStr;
            };

            var hello = "Hello";
            

            Assert.Equal("olleH", reverse(hello));
        }

        [Fact]
        public void Lampda_product_of_two_decimals()
        {
        //Given
            Func<int,int,int> product = (x, y) => x * y;
        //When

        //Then
            Assert.Equal(42, product(2,21));
        }

        [Fact]
        public void Lampda_takes_string_and_number_returns_true()
        {
        //Given
            Func<string,int,bool> same = (str, y) => Int32.Parse(str).Equals(y);
        //When
        
        //Then
            Assert.True(same(" 0042", 42));
        }

        [Fact]
        public void Lampda_takes_string_and_number_returns_false()
        {
        //Given
            Func<string,int,bool> same = (str, y) => Int32.Parse(str).Equals(y);
        //When
        
        //Then
            Assert.False(same("0024", 42));
        }
    }
}
