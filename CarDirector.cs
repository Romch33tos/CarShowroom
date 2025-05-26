namespace CarShowroom
{
  public class CarDirector
  {
    private readonly ICarBuilder _builder;

    public CarDirector(ICarBuilder builder)
    {
      _builder = builder;
    }

    public Car ConstructSedan()
    {
      return _builder
        .SetType("Sedan")
        .SetBrand("Toyota")
        .SetModel("Camry")
        .SetYear(2009)
        .SetPrice(25000)
        .SetColor("Black")
        .SetHorsepower(203)
        .SetEngineType("V6")
        .SetTransmission("Automatic")
        .Build();
    }

    public Car ConstructSUV()
    {
      return _builder
        .SetType("SUV")
        .SetBrand("Land Rover")
        .SetModel("Discovery")
        .SetYear(2017)
        .SetPrice(35000)
        .SetColor("White")
        .SetHorsepower(300)
        .SetEngineType("V6")
        .SetTransmission("Automatic")
        .Build();
    }

    public Car ConstructSportsCar()
    {
      return _builder
        .SetType("Sports Car")
        .SetBrand("Chevrolet")
        .SetModel("Corvette")
        .SetYear(2014)
        .SetPrice(65000)
        .SetColor("Red")
        .SetHorsepower(495)
        .SetEngineType("V8")
        .SetTransmission("Automatic")
        .Build();
    }
  }
}