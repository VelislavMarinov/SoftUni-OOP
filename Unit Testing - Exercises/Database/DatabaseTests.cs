using NUnit.Framework;
using System;

namespace Tests
{
    public class DatabaseTests
    {
        [SetUp]
        public void DatabaseDataCountShouldNotBeMoreThan16Lenght()
        {

           Database database = new Database();
            for (int i = 0; i < 16; i++)
            {
                database.Add(i);
            }

            Assert.Throws<InvalidOperationException>(() => database.Add(1));
        }
        [Test]
        public void DatabaseShoudAddToTheCount()
        {
            
           Database database = new Database();

            database.Add(10);
            database.Add(10);
            database.Add(10);


            Assert.AreEqual(3, database.Count);

        }


        [Test]
        public void DatabaseShoudAddAtTheEndOfTheArray()
        {
            int[] num = new int[15];
            Database database = new Database(num);

            database.Add(152);
            var array = database.Fetch();

            Assert.AreEqual(152, array[array.Length - 1]);

        }
        [Test]
        public void DatabaseShoudThrowExceptionIfEmptyOrNull()
        {
            var array = new int[0];
            Database database = new Database(array);


            Assert.Throws<InvalidOperationException>(() => database.Remove());

        }
        [Test]
        public void DatabaseShoudRemoveTheLastElement()
        {
            int[] num = new int[15];
            Database database = new Database(num);

            database.Remove();


            Assert.AreEqual(14, database.Count);

        }
        [Test]
        public void FetchShouldReturnAnArrayOfIntegers()
        {
            Database databese = new Database(1, 2, 3, 4);
            databese.Remove();
            databese.Add(1);

            var result = databese.Fetch();

            var expectedResult = new int[4] { 1, 2, 3, 1 };
            Assert.AreEqual(result, expectedResult);
        }




    }
}