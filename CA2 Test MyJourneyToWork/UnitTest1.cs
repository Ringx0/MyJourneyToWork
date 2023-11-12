namespace MyJourneyToWorkTest
{
    using Calculator;
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void TestSustainabilityWeighting_PetrolTransportMode()
        {
            // Arrange
            Calculator calculator = new Calculator
            {
                transportMode = TransportModes.petrol,
                distance = 50, 
                milesOrKms = DistanceMeasurement.kms,
                numDays = 3         
            };

            // Act
            double result = calculator.sustainabilityWeighting;

            // Assert
            Assert.AreEqual(1491.2908613696013, result, 0.001);
        }

        [TestMethod]
        public void TestSustainabilityWeighting_DieselTransportMode()
        {
            // Arrange
            Calculator calculator = new Calculator
            {
                transportMode = TransportModes.diesel,
                distance = 40,
                milesOrKms = DistanceMeasurement.miles,
                numDays = 6
            };

            // Act
            double result = calculator.sustainabilityWeighting;

            // Assert
            Assert.AreEqual(4800, result, 0.001);
        }

        [TestMethod]
        public void TestSustainabilityWeighting_HybridTransportMode()
        {
            // Arrange
            Calculator calculator = new Calculator
            {
                transportMode = TransportModes.hybrid,
                distance = 100,
                milesOrKms = DistanceMeasurement.kms,
                numDays = 1
            };

            // Act
            double result = calculator.sustainabilityWeighting;

            // Assert
            Assert.AreEqual(745.6454306848007, result, 0.001);
        }

        [TestMethod]
        public void TestSustainabilityWeighting_ElectricTransportMode()
        {
            // Arrange
            Calculator calculator = new Calculator
            {
                transportMode = TransportModes.electric,
                distance = 30,
                milesOrKms = DistanceMeasurement.miles,
                numDays = 2
            };

            // Act
            double result = calculator.sustainabilityWeighting;

            // Assert
            Assert.AreEqual(480, result, 0.001);
        }

        [TestMethod]
        public void TestSustainabilityWeighting_MotorbikeTransportMode()
        {
            // Arrange
            Calculator calculator = new Calculator
            {
                transportMode = TransportModes.motorbike,
                distance = 60,
                milesOrKms = DistanceMeasurement.kms,
                numDays = 4
            };

            // Act
            double result = calculator.sustainabilityWeighting;

            // Assert
            Assert.AreEqual(894.7745168217609, result, 0.001);
        }

        [TestMethod]
        public void TestSustainabilityWeighting_ElectricbikeTransportMode()
        {
            // Arrange
            Calculator calculator = new Calculator
            {
                transportMode = TransportModes.electricbike,
                distance = 80,
                milesOrKms = DistanceMeasurement.miles,
                numDays = 7
            };

            // Act
            double result = calculator.sustainabilityWeighting;

            // Assert
            Assert.AreEqual(2240, result, 0.001);
        }

        [TestMethod]
        public void TestSustainabilityWeighting_TrainTransportMode()
        {
            // Arrange
            Calculator calculator = new Calculator
            {
                transportMode = TransportModes.train,
                distance = 90,
                milesOrKms = DistanceMeasurement.kms,
                numDays = 5
            };

            // Act
            double result = calculator.sustainabilityWeighting;

            // Assert
            Assert.AreEqual(1677.7022190408015, result, 0.001);
        }

        [TestMethod]
        public void TestSustainabilityWeighting_BusTransportMode()
        {
            // Arrange
            Calculator calculator = new Calculator
            {
                transportMode = TransportModes.bus,
                distance = 55,
                milesOrKms = DistanceMeasurement.miles,
                numDays = 4
            };

            // Act
            double result = calculator.sustainabilityWeighting;

            // Assert
            Assert.AreEqual(1320, result, 0.001);
        }

        [TestMethod]
        public void TestSustainabilityWeighting_TramTransportMode()
        {
            // Arrange
            Calculator calculator = new Calculator
            {
                transportMode = TransportModes.tram,
                distance = 25,
                milesOrKms = DistanceMeasurement.kms,
                numDays = 1
            };

            // Act
            double result = calculator.sustainabilityWeighting;

            // Assert
            Assert.AreEqual(93.20567883560008, result, 0.001);
        }

        [TestMethod]
        public void TestSustainabilityWeighting_CyclingTransportMode()
        {
            // Arrange
            Calculator calculator = new Calculator
            {
                transportMode = TransportModes.cycling,
                distance = 75,
                milesOrKms = DistanceMeasurement.miles,
                numDays = 7
            };

            // Act
            double result = calculator.sustainabilityWeighting;

            // Assert
            Assert.AreEqual(5.25, result, 0.001);
        }

        [TestMethod]
        public void TestSustainabilityWeighting_WalkingTransportMode()
        {
            // Arrange
            Calculator calculator = new Calculator
            {
                transportMode = TransportModes.walking,
                distance = 55,
                milesOrKms = DistanceMeasurement.kms,
                numDays = 3
            };

            // Act
            double result = calculator.sustainabilityWeighting;

            // Assert
            Assert.AreEqual(1.0252624671916009, result, 0.001);
        }

        [TestMethod]
        public void TestSustainabilityWeighting_IsDistanceGreaterThan1000_InvalidDistance()
        {
            // Arrange
            Calculator calculator = new Calculator
            {
                transportMode = TransportModes.walking,
                distance = 10001,
                milesOrKms = DistanceMeasurement.miles,
                numDays = 3
            };

            // Act
            double result = calculator.sustainabilityWeighting;

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestSustainabilityWeighting_IsDaysGreaterThan7_InvalidDays()
        {
            // Arrange
            Calculator calculator = new Calculator
            {
                transportMode = TransportModes.electric,
                distance = 100,
                milesOrKms = DistanceMeasurement.kms,
                numDays = 8
            };

            // Act
            double result = calculator.sustainabilityWeighting;

            // Assert
            Assert.AreEqual(0, result);
        }
    }
}