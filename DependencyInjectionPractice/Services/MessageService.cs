namespace DependencyInjectionPractice.Services {
    public class MessageService {
        private readonly DateService dateService;
        public MessageService(DateService dateService) {
            Console.WriteLine("MessageService Created");
            this.dateService = dateService;
        }
        public string GetMessage() {
            return $"Today is {dateService.GetDate()}";
        }
    }
}
