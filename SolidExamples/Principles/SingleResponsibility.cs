using System;

namespace SolidExamples
{
    public class SingleResponsibility
    {
        public void Greeting()
        {
            InitiateGreeting();
            var userName = ReceiveUserName();
            RespondToUser(userName);
        }

        private void InitiateGreeting()
        {
            Console.WriteLine("Hello!");
        }

        private string ReceiveUserName()
        {
            Console.WriteLine("What is your name?");
            return Console.ReadLine();
        }

        private void RespondToUser(string userName)
        {

            Console.WriteLine("Nice to meet you " + userName);
        }
    }
}
