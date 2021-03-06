using NUnit.Framework;
using PDBot.Core.GameObservers;

namespace Tests
{
    class TestTransforms
    {
        [Test]
        public void TestRearFaces()
        {
            Assert.IsFalse(BaseLegalityChecker.IsRearFace("Delver of Secrets"));
            Assert.IsTrue(BaseLegalityChecker.IsRearFace("Insectile Aberration"));
        }

        [Test]
        public void TestMelds()
        {
            Assert.IsFalse(BaseLegalityChecker.IsRearFace("Graf Rats"));
            Assert.IsTrue(BaseLegalityChecker.IsRearFace("Chittering Host"));
        }

        [Test]
        public void TestAdventure()
        {
            Assert.IsFalse(BaseLegalityChecker.IsRearFace("Smitten Swordmaster"));
            Assert.IsTrue(BaseLegalityChecker.IsRearFace("Curry Favor"));
        }
    }
}
