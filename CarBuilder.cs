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
      if (string.IsNullOrWhiteSpace(type))
        throw new ArgumentException("Type is required");
      _car.Type = type;
      return this;
    }

    public ICarBuilder SetBrand(string brand)
    {
      if (string.IsNullOrWhiteSpace(brand))
        throw new ArgumentException("Brand is required");
      _car.Brand = brand;
      return this;
    }

    public ICarBuilder SetModel(string model)
    {
      if (string.IsNullOrWhiteSpace(model))
        throw new ArgumentException("Model is required");
      _car.Model = model;
      return this;
    }

    public ICarBuilder SetYear(int year)
    {
      if (year < 1886 || year > DateTime.Now.Year + 1)
        throw new ArgumentException("Invalid year");
      _car.Year = year;
      return this;
    }

    public ICarBuilder SetPrice(decimal price)
    {
      if (price <= 0)
        throw new ArgumentException("Price must be positive");
      _car.Price = price;
      return this;
    }

    public ICarBuilder SetColor(string color)
    {
      if (string.IsNullOrWhiteSpace(color))
        throw new ArgumentException("Color is required");
      _car.Color = color;
      return this;
    }

    public ICarBuilder SetHorsepower(int horsepower)
    {
      if (horsepower <= 0)
        throw new ArgumentException("Horsepower must be positive");
      _car.Horsepower = horsepower;
      return this;
    }

    public ICarBuilder SetEngineType(string engineType)
    {
      if (string.IsNullOrWhiteSpace(engineType))
        throw new ArgumentException("Engine type is required");
      _car.EngineType = engineType;
      return this;
    }

    public ICarBuilder SetTransmission(string transmission)
    {
      if (string.IsNullOrWhiteSpace(transmission))
        throw new ArgumentException("Transmission is required");
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
