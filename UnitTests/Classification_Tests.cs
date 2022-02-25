using NUnit.Framework;
using CodeToTest;

namespace UnitTests;
public class Classification_Tests
{
    [Test]
    public void ShouldReturn_U_PG_When_AgeIsLessThan12()
    {
        //arrange
        int ageOfViewer = 10;

        //act
        string result = Program.AvailableClassifications(ageOfViewer);

        //assert
        Assert.That(result, Is.EqualTo("U & PG films are available."));
    }

    [Test]
    public void ShouldReturn_U_PG_12_When_AgeIsGreaterThan11ButLessThan15()
    {
        //arrange
        int ageOfViewer = 12;

        //act
        string result = Program.AvailableClassifications(ageOfViewer);

        //assert
        Assert.That(result, Is.EqualTo("U, PG & 12 films are available."));
    }
    
    [Test]
    public void ShouldReturn_U_PG_12_15_When_AgeIsGreaterThan14ButLessThan18()
    {
        //arrange
        int ageOfViewer = 15;

        //act
        string result = Program.AvailableClassifications(ageOfViewer);

        //assert
        Assert.That(result, Is.EqualTo("U, PG, 12 & 15 films are available."));
    }

    [Test]
    public void ShouldReturn_AllFilms_WhenAgeIs_18_OrMore()
    {
        //arrange
        int ageOfViewer = 20;

        //act
        string result = Program.AvailableClassifications(ageOfViewer);

        //assert
        Assert.That(result, Is.EqualTo("All films are available."));
    }

    [Category("Lower & Upper Boundry")]
    [TestCase(-1)]
    [TestCase(125)]
    public void ShouldReturn_InvalidInput(int ageOfViewer)
    {
        //arrange
        //act
        string result = Program.AvailableClassifications(ageOfViewer);

        //assert
        Assert.That(result, Is.EqualTo("Invalid input."));
    }
    
    [Category("Edge")]
    [TestCase(0, "U & PG films are available.")]
    [TestCase(12, "U, PG & 12 films are available.")]
    [TestCase(15, "U, PG, 12 & 15 films are available.")]
    [TestCase(18, "All films are available.")]
    public void shouldPassEdgeCase(int ageOfViewer, string expected)
    {
        //arrange
        //act
        string result = Program.AvailableClassifications(ageOfViewer);

        //assert
        Assert.That(result, Is.EqualTo(expected));
    }

}
