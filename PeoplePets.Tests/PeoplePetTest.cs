using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeoplePets.BusinessLayer;

namespace PeoplePets.Tests
{
    /// <summary>
    /// Summary description for PeoplePetTests
    /// </summary>
    [TestClass]
    public class PeoplePetTest
    {
        [TestMethod]
        public void GetCatNames()
        {
            var expected = new List<Owner>
            {
                new Owner
                {
                    Gender = "Male",
                    CatNames = new List<string>
                    {
                        "Garfield",
                        "Jim",
                        "Max",
                        "Tom",
                    }
                },
                new Owner
                {
                    Gender = "Female",
                    CatNames = new List<string>
                    {
                        "Garfield",
                        "Simba",
                        "Tabby",
                    }
                }
             };

            var owerCatNames = (List<Owner>)new PeoplePets.BusinessLayer.People().GetOwnerCatNames();
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i].Gender, owerCatNames[i].Gender);
                CollectionAssert.AreEqual(expected[i].CatNames, owerCatNames[i].CatNames);
            }
        }
    }
}
