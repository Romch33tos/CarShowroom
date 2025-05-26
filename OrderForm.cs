namespace CarShowroom
{
  public partial class OrderForm : Form, IOrderView
  {
    private Car _selectedCar;

    public OrderForm(Car selectedCar)
    {
      InitializeComponent();
      ConfigureForm();
      DisplayCarInfo(selectedCar);
      _selectedCar = selectedCar;
      
      this.btnPlaceOrder.Click += (sender, e) => PlaceOrderClicked?.Invoke(this, EventArgs.Empty);
    }

    public Car SelectedCar => _selectedCar;
    public string CustomerName => txtName.Text;
    public string CustomerPhone => txtPhone.Text;
    public string CustomerEmail => txtEmail.Text;

    public event EventHandler PlaceOrderClicked;

    public void ShowMessage(string message)
    {
      MessageBox.Show(message, "Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    public void CloseForm()
    {
      this.Close();
    }

    private void ConfigureForm()
    {
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
    }

    private void DisplayCarInfo(Car car)
    {
      lblCarInfo.Text = $"{car.Brand} {car.Model} - {car.Price.ToString("C", new System.Globalization.CultureInfo("en-US"))}";
    }
  }
}