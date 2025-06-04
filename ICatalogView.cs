namespace CarShowroom
{
  public interface ICatalogView
  {
    List<Car> Cars { set; }
    Car SelectedCar { get; }
    string FilterType { get; }
    decimal? FilterMinPrice { get; }
    decimal? FilterMaxPrice { get; }
    string FilterBrand { get; }

    event EventHandler FilterChanged;
    event EventHandler AddNewCarClicked;
    event EventHandler BuyCarClicked;
    void ShowMessage(string message);
    void ShowCarBuilderForm();
    void ShowOrderForm(Car selectedCar);
  }
}
