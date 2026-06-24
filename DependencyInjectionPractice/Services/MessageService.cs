namespace DependencyInjectionPractice.Services {
    public class MessageService {

        public MessageService() {
            Console.WriteLine("MessageService Created");
        }
        public string GetMessage() {
            return "Hello DI";
        }
    }
}
