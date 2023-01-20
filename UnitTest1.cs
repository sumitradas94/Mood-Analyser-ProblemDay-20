using MoodAnalyserProject;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethodForHappyMood()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am in happy Mood");
            string expected = "happy";
            string actual = moodAnalyser.AnalyzeMood();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodForSadMood()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am in sad Mood");
            string expected = "sad";
            string actual = moodAnalyser.AnalyzeMood();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodForCustomizedNullException()

        {
            string expected = "Mood should not be NULL";
            try
            {

                MoodAnalyser moodAnalyser = new MoodAnalyser(null);
                moodAnalyser.AnalyzeMood();
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestMethod]
        public void TestMethodForCustomizedEmptyException()

        {
            string expected = "Mood should not be empty";
            try
            {

                MoodAnalyser moodAnalyser = new MoodAnalyser(string.Empty);
                moodAnalyser.AnalyzeMood();
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }

        }
        [TestMethod]
        public void Fordefault()
        {
            MoodAnalyser expected = new MoodAnalyser();
            object obj = null;
            try
            {
                obj = MoodAnalyserFactory.CreateMoodAnalyse("ModeAnalyserPro.MoodAnalyser", "MoodAnalyser");

            }
            catch (CustomException e)
            {
                throw new System.Exception(e.Message);
            }
        }
        [TestMethod]

        public void Reflection_Return_Default_Constructor_No_Class_Found()
        {
            string expected = "Class not Found";
            object obj = null;
            try
            {

                obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyserProject.Mood", "Mood");

            }
            catch (CustomException actual)

            {
                Assert.AreEqual(expected, actual.Message);
            }
        }

        [TestMethod]
        public void Reflection_Return_Default_Constructor_No_Constructor_Found()
        {
            string expected = "Constructor not found";

            try
            {

                MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyserPro.MoodAnalyser", "MoodAnaly");

            }
            catch (CustomException actual)

            {
                Assert.AreEqual(expected, actual.Message);
            }
        }
    }
}