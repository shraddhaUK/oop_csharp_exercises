using Xunit;
using TechReturners.Exercises;

namespace TechReturners.Tests
{
    public class CatTest
    {
        [Fact]
        public void CheckCatIsAwake()
        {
            ICat c = new DomesticCat();
            Assert.False(c.IsAsleep);
        }

        [Fact]
        public void CheckCatCanGoToSleep()
        {
            ICat c = new DomesticCat();
            c.GoToSleep();
            Assert.True(c.IsAsleep);
        }

        [Fact]
        public void CheckCatCanWakeUp()
        {
            ICat c = new DomesticCat();
            c.GoToSleep();
            c.WakeUp();
            Assert.False(c.IsAsleep);
        }

        [Fact]
        public void CheckCatSetting()
        {
            ICat c = new DomesticCat();
            Assert.Equal("domestic", c.Setting);
        }

        [Fact]
        public void CheckCatHeight()
        {
            ICat c = new DomesticCat();
            Assert.Equal(23, c.AverageHeight);
        }

        [Fact]
        public void CheckLionHeight()
        {
            ICat c = new LionCat();
            Assert.Equal(1100, c.AverageHeight);
        }

        [Fact]
        public void CheckFeedLion()
        {
            ICat c = new LionCat();
            Assert.Equal("Roar!!!!", c.Eat());
        }

        [Fact]
        public void CheckFeedCheetah()
        {
            ICat c = new CheetahCat();
            Assert.Equal("Zzzzzzz", c.Eat());
        }

        [Fact]
        public void CheckFeedCat()
        {
            ICat c = new DomesticCat();
            Assert.Equal("Purrrrrrr", c.Eat());
        }
    }
}
