namespace MyJourneyToWorkTest
{
    using Calculator;
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void TestSustainabilityWeighting_Petrol()
        {
            Calculator calculator = new Calculator
            {
                transportMode = TransportModes.petrol,
                distance = 50, 
                milesOrKms = DistanceMeasurement.kms,
                numDays = 3         
            };

            double result = calculator.sustainabilityWeighting;
            Assert.AreEqual(1491.2908613696013, result, 0.001);
        }

        [TestMethod]
        public void TestSustainabilityWeighting_Diesel()
        {
            Calculator calculator = new Calculator
            {
                transportMode = TransportModes.diesel,
                distance = 40,
                milesOrKms = DistanceMeasurement.miles,
                numDays = 6
            };

            double result = calculator.sustainabilityWeighting;
            Assert.AreEqual(4800, result, 0.001);
        }

        [TestMethod]
        public void TestSustainabilityWeighting_Hybrid()
        {
            Calculator calculator = new Calculator
            {
                transportMode = TransportModes.hybrid,
                distance = 100,
                milesOrKms = DistanceMeasurement.kms,
                numDays = 1
            };

            double result = calculator.sustainabilityWeighting;
            Assert.AreEqual(745.6454306848007, result, 0.001);
        }

        [TestMethod]
        public void TestSustainabilityWeighting_Electric()
        {
            Calculator calculator = new Calculator
            {
                transportMode = TransportModes.electric,
                distance = 30,
                milesOrKms = DistanceMeasurement.miles,
                numDays = 2
            };

            double result = calculator.sustainabilityWeighting;
            Assert.AreEqual(480, result, 0.001);
        }

        [TestMethod]
        public void TestSustainabilityWeighting_Motorbike()
        {
            Calculator calculator = new Calculator
            {
                transportMode = TransportModes.motorbike,
                distance = 60,
                milesOrKms = DistanceMeasurement.kms,
                numDays = 4
            };

            double result = calculator.sustainabilityWeighting;
            Assert.AreEqual(894.7745168217609, result, 0.001);
        }

        [TestMethod]
        public void TestSustainabilityWeighting_Electricbike()
        {
            Calculator calculator = new Calculator
            {
                transportMode = TransportModes.electricbike,
                distance = 80,
                milesOrKms = DistanceMeasurement.miles,
                numDays = 7
            };

            double result = calculator.sustainabilityWeighting;
            Assert.AreEqual(2240, result, 0.001);
        }

        [TestMethod]
        public void TestSustainabilityWeighting_Train()
        {
            Calculator calculator = new Calculator
            {
                transportMode = TransportModes.train,
                distance = 90,
                milesOrKms = DistanceMeasurement.kms,
                numDays = 5
            };

            double result = calculator.sustainabilityWeighting;
            Assert.AreEqual(1677.7022190408015, result, 0.001);
        }

        [TestMethod]
        public void TestSustainabilityWeighting_Bus()
        {
            Calculator calculator = new Calculator
            {
                transportMode = TransportModes.bus,
                distance = 55,
                milesOrKms = DistanceMeasurement.miles,
                numDays = 4
            };

            double result = calculator.sustainabilityWeighting;
            Assert.AreEqual(1320, result, 0.001);
        }

        [TestMethod]
        public void TestSustainabilityWeighting_Tram()
        {
            Calculator calculator = new Calculator
            {
                transportMode = TransportModes.tram,
                distance = 25,
                milesOrKms = DistanceMeasurement.kms,
                numDays = 1
            };

            double result = calculator.sustainabilityWeighting;
            Assert.AreEqual(93.20567883560008, result, 0.001);
        }

        [TestMethod]
        public void TestSustainabilityWeighting_Cycling()
        {
            Calculator calculator = new Calculator
            {
                transportMode = TransportModes.cycling,
                distance = 75,
                milesOrKms = DistanceMeasurement.miles,
                numDays = 7
            };

            double result = calculator.sustainabilityWeighting;
            Assert.AreEqual(5.25, result, 0.001);
        }

        /*[TestMethod]
        public void TestSustainabilityWeighting_Walking()
        {
            Calculator calculator = new Calculator
            {
                transportMode = TransportModes.walking,
                distance = 55,
                milesOrKms = DistanceMeasurement.kms,
                numDays = 3
            };

            double result = calculator.sustainabilityWeighting;
            Assert.AreEqual(1.0252624671916009, result, 0.001);
        }*/
    }
}