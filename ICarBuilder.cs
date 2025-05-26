namespace CarShowroom
{
  public interface ICarBuilder
  {
    ICarBuilder SetType(string type);
    ICarBuilder SetBrand(string brand);
    ICarBuilder SetModel(string model);
    ICarBuilder SetYear(int year);
    ICarBuilder SetPrice(decimal price);
    ICarBuilder SetColor(string color);
    ICarBuilder SetHorsepower(int horsepower);
    ICarBuilder SetEngineType(string engineType);
    ICarBuilder SetTransmission(string transmission);
    Car Build();
  }
}