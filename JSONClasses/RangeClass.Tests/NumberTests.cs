﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Classes.Tests
{
    public class NumberTests
    {
        [Fact]
        public void SimpleNumberShouldReturnTrueAndEmptyString()
        {
            var number = new Number();
            Assert.True(number.Match("1").Success());
            Assert.Equal("", number.Match("1").RemainingText());
        }
    }
}
