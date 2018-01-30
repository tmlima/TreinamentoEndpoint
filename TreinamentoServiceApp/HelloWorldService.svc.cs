using System;

namespace TreinamentoServiceApp
{
    public class HelloWorldService : IHelloWorldService
    {
        public string Hello( string name )
        {
            return "Olá " + name + "!";
        }
    }
}
