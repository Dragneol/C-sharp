using System;
using NUnit.Framework;
using CheckDate;

[TestFixture]
public class TestLogging
{

    #region CheckDaysInMonths
    [Test]
    [TestCase(999, 0, 0)]
    //[TestCase(1000a, 1, 0)]
    [TestCase(3001, 2, 0)]
    [TestCase(3000, 11, 30)]
    [TestCase(2999, 12, 31)]
    [TestCase(2000, 13, 0)]
    //[TestCase(1001, 1a,0)]
    [TestCase(1000, 12, 31)]
    [TestCase(1001, 11, 30)]
    [TestCase(2000, 2, 29)]
    [TestCase(1000, 2, 28)]
    [TestCase(1996, 2, 29)]
    [TestCase(1001, 2, 28)]
    public void CheckDayInMonth(int year, int month, int expected)
    {
        CheckDateMethod test = new CheckDateMethod();
        Assert.AreEqual(expected, actual: test.DaysInMonth(year, month));
    }
    #region OldTestCode
    //public void CheckDayInMonth()
    //{
    //    TestedClass test = new TestedClass();            
    //    Assert.AreEqual(0, test.DaysInMonth(999, 0));
    //    //Assert.AreEqual(0, test.DaysInMonth(1000a, 1));
    //    Assert.AreEqual(0, test.DaysInMonth(3001, 2));
    //    Assert.AreEqual(30, test.DaysInMonth(3000, 11));
    //    Assert.AreEqual(31, test.DaysInMonth(2999, 12));
    //    Assert.AreEqual(0, test.DaysInMonth(2000, 13));
    //    //Assert.AreEqual(0, test.DaysInMonth(1001, 1a));
    //    Assert.AreEqual(31, test.DaysInMonth(1000, 12));
    //    Assert.AreEqual(30, test.DaysInMonth(1001, 11));
    //    Assert.AreEqual(29, test.DaysInMonth(2000, 2));
    //    Assert.AreEqual(28, test.DaysInMonth(1000, 2));
    //    Assert.AreEqual(29, test.DaysInMonth(1996, 2));
    //    Assert.AreEqual(28, test.DaysInMonth(1001, 2));
    //}
    #endregion
    #endregion
    #region CheckValidate
    [Test]
    [TestCase(999, 0, 0, false)]
    //[TestCase(1000a, 1, 1, false)]
    [TestCase(3001, 2, 2, false)]
    [TestCase(3000, 11, 28, true)]
    [TestCase(2999, 12, 29, true)]
    [TestCase(2000, 13, 30, false)]
    //[TestCase(1001, 1a,31, false)]
    [TestCase(1000, 12, 32, false)]
    [TestCase(1001, 11, 31, false)]
    [TestCase(2000, 2, 30, false)]
    [TestCase(1000, 2, 29, false)]
    [TestCase(1996, 2, 28, true)]
    [TestCase(1996, 6, 31, false)]
    [TestCase(1001, 2, 2, true)]
    [TestCase(1000, 2, 1, true)]
    //[TestCase(999, 2, 1a, false)]
    public void CheckValidDate(int year, int month, int day, bool expected)
    {
        CheckDateMethod test = new CheckDateMethod();
        Assert.AreEqual(expected, test.IsValidDate(year, month, day));
    }
    #region OldTestCode
    //public void CheckValidDate()
    //{
    //    TestedClass test = new TestedClass();
    //    Assert.AreEqual(false, test.IsValidDate(999, 0, 0));
    //    //Assert.AreEqual(false, test.IsValidDate(1000a, 1, 1));
    //    Assert.AreEqual(false, test.IsValidDate(3001, 2, 2));
    //    Assert.AreEqual(true, test.IsValidDate(3000, 11, 28));
    //    Assert.AreEqual(true, test.IsValidDate(2999, 12, 29));
    //    Assert.AreEqual(false, test.IsValidDate(2000, 13, 30));
    //    //Assert.AreEqual(false, test.IsValidDate(1001, 1a, 31));
    //    Assert.AreEqual(false, test.IsValidDate(1000, 12, 32));
    //    Assert.AreEqual(false, test.IsValidDate(1001, 11, 31));
    //    Assert.AreEqual(false, test.IsValidDate(2000, 2, 30));
    //    Assert.AreEqual(false, test.IsValidDate(1000, 2, 29));
    //    Assert.AreEqual(true, test.IsValidDate(1996, 2, 28));
    //    Assert.AreEqual(false, test.IsValidDate(1996, 6, 31));
    //    Assert.AreEqual(true, test.IsValidDate(1001, 2, 2));
    //    Assert.AreEqual(true, test.IsValidDate(1000, 2, 1));
    //    //Assert.AreEqual(false, test.IsValidDate(999, 2, 1a));
    //}
    #endregion
    #endregion
}

