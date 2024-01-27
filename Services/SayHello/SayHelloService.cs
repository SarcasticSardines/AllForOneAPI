namespace AllForOneAPI.Services.SayHello;

    public class SayHelloService : ISayHelloService
    {
        public string GetName(string userName)
    {
        return ("Salut, Hola, Greetings, and Salutations " + userName + "!");
    }
    }
