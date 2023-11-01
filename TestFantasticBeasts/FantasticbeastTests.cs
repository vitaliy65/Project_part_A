using Project_part_A;
using Environment = Project_part_A.Environment;

namespace TestFantasticBeasts
{
    [TestClass]
    public class FantasticbeastTests
    {
        [TestMethod]
        public void Name_GetSet_CorrectValue()
        {
            // Arrange
            string expectedName = "Test Beast";
            var beast = new Fantasticbeast(null, null, "Test Beast", Behavior.notKnown, Abilities.notKnown, Size.Small);

            // Act
            beast.Name = expectedName;
            var result = beast.Name;

            // Assert
            Assert.AreEqual(expectedName, result);
        }

        [TestMethod]
        public void GetFullInformationAboutBeast_ThrowsNotImplementedException()
        {
            // Arrange
            var beast = new Fantasticbeast(null, null, "", Behavior.notKnown, Abilities.notKnown, Size.Small);

            // Act & Assert
            Assert.ThrowsException<NotImplementedException>(() => beast.GetFullInformationAboutBeast());
        }

        [TestMethod]
        public void HistoryAndEnvironment_CanBeSet()
        {
            // Arrange
            var history =     new History(name: "test", origin: "test", myths: new List<string>{ "test1", "test2"});
            var environment = new Environment(location: "test", climate: "test", resources: new List<string> { "test1", "test2" });
            var beast =       new Fantasticbeast(null, null, "", Behavior.notKnown, Abilities.notKnown, Size.Small);

            // Act
            beast.history = history;
            beast.environment = environment;

            // Assert
            Assert.AreEqual(history, beast.history);
            Assert.AreEqual(environment, beast.environment);
        }
    }

    [TestClass]
    public class EnvironmentTests
    {
        [TestMethod]
        public void Location_GetSet_CorrectValue()
        {
            // Arrange
            string expectedLocation = "Test Location";
            var environment = new Environment(expectedLocation, "", new List<string>());

            // Act
            environment.Location = expectedLocation;
            var result = environment.Location;

            // Assert
            Assert.AreEqual(expectedLocation, result);
        }

        [TestMethod]
        public void Climate_GetSet_CorrectValue()
        {
            // Arrange
            string expectedClimate = "Test Climate";
            var environment = new Environment("", expectedClimate, new List<string>());

            // Act
            environment.Climate = expectedClimate;
            var result = environment.Climate;

            // Assert
            Assert.AreEqual(expectedClimate, result);
        }

        [TestMethod]
        public void Resources_GetSet_CorrectValue()
        {
            // Arrange
            var expectedResources = new List<string> { "Resource1", "Resource2" };
            var environment = new Environment("", "", new List<string>() { "Resource1", "Resource2" });

            // Act
            environment.Resources = expectedResources;
            var result = environment.Resources;

            // Assert
            CollectionAssert.AreEqual(expectedResources, result);
        }

        [TestMethod]
        public void GetFullInformationAboutLocation_ThrowsNotImplementedException()
        {
            // Arrange
            var environment = new Environment("", "", new List<string>());

            // Act & Assert
            Assert.ThrowsException<NotImplementedException>(() => environment.GetFullInformationAboutLocation());
        }
    }

    [TestClass]
    public class HistoryTests
    {
        [TestMethod]
        public void Name_GetSet_CorrectValue()
        {
            // Arrange
            string expectedName = "Test Name";
            var history = new History(expectedName, "", new List<string>());

            // Act
            history.Name = expectedName;
            var result = history.Name;

            // Assert
            Assert.AreEqual(expectedName, result);
        }

        [TestMethod]
        public void Myths_GetSet_CorrectValue()
        {
            // Arrange
            var expectedMyths = new List<string> { "Myth1", "Myth2" };
            var history = new History("", "", new List<string>() { "Myth1", "Myth2" });

            // Act
            history.Myths = expectedMyths;
            var result = history.Myths;

            // Assert
            CollectionAssert.AreEqual(expectedMyths, result);
        }

        [TestMethod]
        public void Origin_GetSet_CorrectValue()
        {
            // Arrange
            string expectedOrigin = "Test Origin";
            var history = new History("", expectedOrigin, new List<string>());

            // Act
            history.Origin = expectedOrigin;
            var result = history.Origin;

            // Assert
            Assert.AreEqual(expectedOrigin, result);
        }

        [TestMethod]
        public void GetAllLegends_ThrowsNotImplementedException()
        {
            // Arrange
            var history = new History("", "", new List<string>());

            // Act & Assert
            Assert.ThrowsException<NotImplementedException>(() => history.GetAllLegends());
        }
    }
}