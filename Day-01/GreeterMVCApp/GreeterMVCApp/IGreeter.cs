namespace GreeterMVCApp
{
    public interface IGreeter
    {
        string Name { get; set; }
        string GreetMsg { get; set; }
        void Greet();
    }
}