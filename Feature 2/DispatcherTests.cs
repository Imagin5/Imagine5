public class DispatcherTests
{

    [Fact]
    public void should_test_event1()
    {
        add_number(number);
        add_number(number2);
        add_number(number3);
    }

    [Fact]
    public void should_test_event2_again(string param1, string param2)
    {
        if(param1 == param2)
        {
            doSomething();
        }
        else
        {
            doSomethingelse();
        }
        else{
            third();
        }
        else{
            fourth();
        }
    }
}