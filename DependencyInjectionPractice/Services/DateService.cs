namespace DependencyInjectionPractice.Services {
    public class DateService {
        public string GetDate() {
            return DateTime.Now.ToString();
        }
    }
}
