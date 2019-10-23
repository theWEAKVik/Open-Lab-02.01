using NUnit.Framework;

namespace Open_Lab_02._01
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Create5Numbers()
        {
            var exercise = new Exercise();
            Assert.That(exercise.Create5Numbers(), Is.Not.Null);
            Assert.That(exercise.Create5Numbers().Length, Is.EqualTo(5));
        }

        [Test]
        public void GetSecond()
        {
            var exercise = new Exercise();
            var array = new[] {3.1, 3.2, 3.3, 5.4, 6.8};
            Assert.That(exercise.GetSecond(array), Is.EqualTo(3.2));
        }
    }
}