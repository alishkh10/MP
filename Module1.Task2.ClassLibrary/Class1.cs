using System;

namespace Module1.Task2.ClassLibrary
{
    public static class Greeter
    {
        public static string GetGreeting(string username)
        {
            return $"{DateTime.Now}: Hello, {username}!";
        }
    }
}
