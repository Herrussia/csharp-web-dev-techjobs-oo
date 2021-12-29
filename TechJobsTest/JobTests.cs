using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTest
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job jobOne = new Job();
            Job jobTwo = new Job();
            Assert.AreNotEqual(jobOne, jobTwo);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job productTester = new Job("Product Tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreEqual("Product Tester", productTester.Name);
            Assert.AreEqual("ACME", productTester.EmployerName.ToString());
            Assert.AreEqual("Desert", productTester.EmployerLocation.ToString());
            Assert.AreEqual("Quality control", productTester.JobType.ToString());
            Assert.AreEqual("Persistence", productTester.JobCoreCompetency.ToString());
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job jobThree = new Job("Web Developer", new Employer("LaunchCode"), new Location("St. Louis"), new PositionType("Front-end developer"), new CoreCompetency("JavaScript"));
            Job jobFour = new Job("Web Developer", new Employer("LaunchCode"), new Location("St. Louis"), new PositionType("Front-end developer"), new CoreCompetency("JavaScript"));
            Assert.IsFalse(jobThree.Equals(jobFour));
        }

        [TestMethod]
        public void TestToString()
        {
            Job jobThree = new Job("Web Developer", new Employer("LaunchCode"), new Location("St. Louis"), new PositionType("Front-end developer"), new CoreCompetency("JavaScript"));
            Assert.AreEqual("ID: ___6___ \nName: ___Web Developer___ \nEmployer: ___LaunchCode___ \nLocation: ___St. Louis___ \nPosition Type: ___Front-end developer___ \nCore Competency: ___JavaScript___\n", jobThree.ToString());
            Job job3 = new Job("Ice cream tester", new Employer(""), new Location("Home"), new PositionType("UX"), new CoreCompetency("Tasting ability"));
            Assert.AreEqual("ID: ___7___ \nName: ___Ice cream tester___ \nEmployer: ___Data not available___ \nLocation: ___Home___ \nPosition Type: ___UX___ \nCore Competency: ___Tasting ability___\n", job3.ToString());
            Job jobIdOnly = new Job("", new Employer(""), new Location(""), new PositionType(""), new CoreCompetency(""));
            Assert.AreEqual("ID: ___8___ \nName: ___Data not available___ \nEmployer: ___Data not available___ \nLocation: ___Data not available___ \nPosition Type: ___Data not available___ \nCore Competency: ___Data not available___\n", jobIdOnly.ToString());
        //I chose not to complete the bonus test for the "OOPS! This job does not seem to exsist!" at this time and to try again later.
        }

    }
}
