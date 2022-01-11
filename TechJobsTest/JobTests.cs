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
            Assert.IsTrue(jobOne.Id +1 == jobTwo.Id);
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
            Assert.AreEqual("\nID: 6 \nName: Web Developer \nEmployer: LaunchCode \nLocation: St. Louis \nPosition Type: Front-end developer \nCore Competency: JavaScript\n", jobThree.ToString());
            Job job3 = new Job("Ice cream tester", new Employer(""), new Location("Home"), new PositionType("UX"), new CoreCompetency("Tasting ability"));
            Assert.AreEqual("\nID: 7 \nName: Ice cream tester \nEmployer: Data not available \nLocation: Home \nPosition Type: UX \nCore Competency: Tasting ability\n", job3.ToString());
            Job jobEmpty = new Job();
            Assert.AreEqual("OOPS! This job does not seem to exist!", jobEmpty.ToString());
            Assert.IsTrue(jobThree.ToString().StartsWith("\n"));
            Assert.IsTrue(jobThree.ToString().EndsWith("\n"));
        }
    }
}
