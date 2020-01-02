using System;

public static class TwoFer
{
    // In order to get the tests running, first you need to make sure the Speak method 
    // can be called both without any arguments and also by passing one string argument.
    public static string Speak(string v = null)
    {
        if (v == null)
        {
            return "One for you, one for me.";
        }
        else {
            string str = string.Format("One for {0}, one for me", v);
            return str;
        }

    }
}
