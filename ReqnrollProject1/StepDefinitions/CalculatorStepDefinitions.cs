namespace ReqnrollProject1.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private int _first;
        private int _second;
        private int _sum;
        private string _color;
        private string _password;

        // For additional details on Reqnroll step definitions see https://go.reqnroll.net/doc-stepdef

        [Given("the first number is {int}")]
        public void GivenTheFirstNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.reqnroll.net/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            _first = number;
        }

        [Given("the second number is {int}")]
        public void GivenTheSecondNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic

            _second = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            //TODO: implement act (action) logic

            _sum = _first + _second;
        }

        [Then("the result should be {int}")]
        public void ThenTheResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic

            _sum.Should().Be(result);
        }
        [Given("the color {word}")]
        public void GivenTheColor(string color)
        {
            _color = color;
        }
        [Then("the color should be {word}")]
        public void ThenTheColorShouldBe(string color)
        {
            _color.Should().Be(color);
        }
        [Given("the password is {word}")]
        public void GivenThePassordIs(string password)
        {
            _password = password;
        }
        [Then("the password should be {word}")]
        public void ThenThePasswordShouldBe(string password)
        {
            _password.Should().Be(password);
        }
    }
}
