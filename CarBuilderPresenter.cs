namespace CarShowroom
{
  public class CarBuilderPresenter
  {
    private readonly ICarBuilderView _view;
    private readonly ICarBuilder _builder;

    public CarBuilderPresenter(ICarBuilderView view, ICarBuilder builder)
    {
      _view = view;
      _builder = builder;
      _view.BuildCarClicked += OnBuildCarClicked;
    }

    private void OnBuildCarClicked(object sender, EventArgs e)
    {
      try
      {
        var car = _builder
          .SetType(_view.CarType)
          .SetBrand(_view.Brand)
          .SetModel(_view.Model)
          .SetYear(_view.Year)
          .SetPrice(_view.Price)
          .SetColor(_view.Color)
          .SetHorsepower(_view.Horsepower)
          .SetEngineType(_view.EngineType)
          .SetTransmission(_view.Transmission)
          .Build();

        _view.ShowMessage($"Car built successfully:\n{car}");
      }
      catch (Exception ex)
      {
        _view.ShowMessage($"Error building car: {ex.Message}");
      }
    }
  }
}
