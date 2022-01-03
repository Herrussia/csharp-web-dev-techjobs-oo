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
            Assert.AreNotEqual("ID: ___6___ \nName: ___Web Developer___ \nEmployer: ___LaunchCode___ \nLocation: ___St. Louis___ \nPosition Type: ___Front-end developer___ \nCore Competency: ___JavaScript___\n", jobThree.ToString());
            Job job3 = new Job("Ice cream tester", new Employer(""), new Location("Home"), new PositionType("UX"), new CoreCompetency("Tasting ability"));
            Assert.AreEqual("ID: 7 \nName: Ice cream tester \nEmployer: Data not available \nLocation: Home \nPosition Type: UX \nCore Competency: Tasting ability\n", job3.ToString());
            Job jobEmpty = new Job();
            Assert.AreEqual("OOPS! This job does not seem to exist!", jobEmpty.ToString());
            //"OOPS! This Job does not seem to exist!" bonus test
        }
    }
}
