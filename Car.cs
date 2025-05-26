public class Car
{
  public string Type { get; set; }
  public string Brand { get; set; }
  public string Model { get; set; }
  public int Year { get; set; }
  public decimal Price { get; set; }
  public string Color { get; set; }
  public int Horsepower { get; set; }
  public string EngineType { get; set; }
  public string Transmission { get; set; }

  public override string ToString()
  {
    return $"{Brand} {Model} ({Year}), Type: {Type}, Price: {Price:C}, Color: {Color}, HP: {Horsepower}, Engine: {EngineType}, Transmission: {Transmission}";
  }
}
