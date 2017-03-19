﻿using System;
using NUnit.Framework;
using Refactoring.RenameMethod;

namespace Refactoring.Tests.RenameMethod
{
    [TestFixture]
    public class PersonTest
    {
        private const string OFFICE_NUMBER = "154689";
        private const string OFFICE_AREA_CODE = "016";

        [Test]
        public void GetTelephoneNumber()
        {
            Person person = new Person(OFFICE_AREA_CODE, OFFICE_NUMBER);

            var result = person.TelephoneNumber;
            Assert.AreEqual("(" + OFFICE_AREA_CODE + ") " + OFFICE_NUMBER, result);
        }
    }
}