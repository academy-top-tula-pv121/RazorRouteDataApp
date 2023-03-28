namespace RazorRouteDataApp
{
    public interface ITimeService
    {
        string GetTime { get; }
    }
    public class SimpleTimeService : ITimeService
    {
        public string GetTime => DateTime.Now.ToShortTimeString();
    }
}
