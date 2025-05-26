namespace CarShowroom
{
  public class OrderPresenter
  {
    private readonly IOrderView _view;
    private readonly List<Car> _inventory;

    public OrderPresenter(IOrderView view, List<Car> inventory)
    {
      _view = view ?? throw new ArgumentNullException(nameof(view));
      _inventory = inventory ?? throw new ArgumentNullException(nameof(inventory));
      _view.PlaceOrderClicked += OnPlaceOrderClicked;
    }

    private void OnPlaceOrderClicked(object sender, EventArgs e)
    {
      if (!ValidateOrder())
        return;

      ProcessOrder();
      _view.ShowMessage($"Order placed successfully for {_view.SelectedCar.Brand} {_view.SelectedCar.Model}");
      _view.CloseForm();
    }

    private bool ValidateOrder()
    {
      if (_view.SelectedCar == null)
      {
        _view.ShowMessage("Please select a car to order");
        return false;
      }

      if (string.IsNullOrWhiteSpace(_view.CustomerName))
      {
        _view.ShowMessage("Please enter your name");
        return false;
      }

      if (string.IsNullOrWhiteSpace(_view.CustomerPhone))
      {
        _view.ShowMessage("Please enter your phone number");
        return false;
      }

      return true;
    }

    private void ProcessOrder()
    {
      if (_inventory.Contains(_view.SelectedCar))
      {
        _inventory.Remove(_view.SelectedCar);
      }
    }
  }
}