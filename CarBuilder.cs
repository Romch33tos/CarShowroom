namespace CarShowroom
{
  public class CarBuilder : ICarBuilder
  {
    private Car _car;

    public CarBuilder()
    {
      Reset();
    }

    public ICarBuilder SetType(string type)
    {
      _car.Type = type;
      return this;
    }

    public ICarBuilder SetBrand(string brand)
    {
      _car.Brand = brand;
      return this;
    }

    public ICarBuilder SetModel(string model)
    {
      _car.Model = model;
      return this;
    }

    public ICarBuilder SetYear(int year)
    {
      _car.Year = year;
      return this;
    }

    public ICarBuilder SetPrice(decimal price)
    {
      _car.Price = price;
      return this;
    }

    public ICarBuilder SetColor(string color)
    {
      _car.Color = color;
      return this;
    }

    public ICarBuilder SetHorsepower(int horsepower)
    {
      _car.Horsepower = horsepower;
      return this;
    }

    public ICarBuilder SetEngineType(string engineType)
    {
      _car.EngineType = engineType;
      return this;
    }

    public ICarBuilder SetTransmission(string transmission)
    {
      _car.Transmission = transmission;
      return this;
    }

    public Car Build()
    {
      var result = _car;
      Reset();
      return result;
    }

    private void Reset()
    {
      _car = new Car();
    }
  }
}