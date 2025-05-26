namespace CarShowroom
{
  public class CatalogPresenter
  {
    private readonly ICatalogView _view;
    private List<Car> _allCars;

    public CatalogPresenter(ICatalogView view, List<Car> cars)
    {
      _view = view;
      _allCars = cars;
      _view.FilterChanged += OnFilterChanged;
      _view.AddNewCarClicked += OnAddNewCarClicked;
      _view.BuyCarClicked += OnBuyCarClicked;
      ApplyFilters();
    }

    private void OnFilterChanged(object sender, EventArgs e)
    {
      ApplyFilters();
    }

    private void OnAddNewCarClicked(object sender, EventArgs e)
    {
      _view.ShowCarBuilderForm();
    }

    private void OnBuyCarClicked(object sender, EventArgs e)
    {
      if (_view.SelectedCar == null)
      {
        _view.ShowMessage("Please select a car to buy");
        return;
      }

      _view.ShowOrderForm(_view.SelectedCar);
    }

    private void ApplyFilters()
    {
      var filteredCars = _allCars.AsEnumerable();

      if (!string.IsNullOrEmpty(_view.FilterType))
        filteredCars = filteredCars.Where(c => c.Type == _view.FilterType);

      if (!string.IsNullOrEmpty(_view.FilterBrand))
        filteredCars = filteredCars.Where(c => c.Brand.Contains(_view.FilterBrand, StringComparison.OrdinalIgnoreCase));

      if (_view.FilterMinPrice.HasValue)
        filteredCars = filteredCars.Where(c => c.Price >= _view.FilterMinPrice.Value);

      if (_view.FilterMaxPrice.HasValue)
        filteredCars = filteredCars.Where(c => c.Price <= _view.FilterMaxPrice.Value);

      _view.Cars = filteredCars.ToList();
    }

    public void AddNewCar(Car car)
    {
      _allCars.Add(car);
      ApplyFilters();
    }
  }
}