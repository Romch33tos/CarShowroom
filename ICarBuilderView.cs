namespace CarShowroom
{
  public interface ICarBuilderView
  {
    string CarType { get; set; }
    string Brand { get; set; }
    string Model { get; set; }
    int Year { get; set; }
    decimal Price { get; set; }
    string Color { get; set; }
    int Horsepower { get; set; }
    string EngineType { get; set; }
    string Transmission { get; set; }

    event EventHandler BuildCarClicked;
    void ShowMessage(string message);
  }
}