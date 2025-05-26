namespace CarShowroom
{
  public interface IOrderView
  {
    Car SelectedCar { get; }
    string CustomerName { get; }
    string CustomerPhone { get; }
    string CustomerEmail { get; }

    event EventHandler PlaceOrderClicked;
    void ShowMessage(string message);
    void CloseForm();
  }
}
