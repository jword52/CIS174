using System;
using Xunit;
using FirstResponsiveWebAppOrd.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstResponsiveWebAppTest
{
    public class UnitTest1
    {
        [Fact]
        public void PassAgeThisYear()
        {
            // Tests a birthdate of 3/1/2000 with method AgeThisYear()
            // Arrange
            FirstResponseModel age = new FirstResponseModel();
            age.BirthYear = new DateTime(2000, 3, 1, 7, 0, 0);
            int expected = 22;

            // Act
            int actual = age.AgeThisYear();

            // Assert
            Assert.Equal(actual, expected);
        }


        [Fact]
        public void PassAgeAtEndOfYear()
        {
            // Tests a birthdate of 12/31/2021 with method AgeByEndOfYear()
            // Arrange
            FirstResponseModel age = new FirstResponseModel();
            age.BirthYear = new DateTime(1998, 12, 31, 12, 0, 0);
            int expected = 25;

            // Act
            int actual = age.AgeByEndOfYear();

            // Assert
            Assert.Equal(actual, expected);
        }
    }
}