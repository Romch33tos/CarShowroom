namespace CarShowroom
{
  public partial class CatalogForm : Form, ICatalogView
  {
    public CatalogForm()
    {
      InitializeComponent();
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
    }

    public List<Car> Cars
    {
      set
      {
        dgvCars.DataSource = null;
        dgvCars.DataSource = value;
        lblCount.Text = $"{value?.Count ?? 0} cars found";
      }
    }

    public Car SelectedCar => dgvCars.SelectedRows.Count > 0
        ? dgvCars.SelectedRows[0].DataBoundItem as Car
        : null;

    public string FilterType => cmbFilterType.SelectedItem?.ToString();
    public decimal? FilterMinPrice => nudMinPrice.Value > 0 ? nudMinPrice.Value : null;
    public decimal? FilterMaxPrice => nudMaxPrice.Value > 0 ? nudMaxPrice.Value : null;
    public string FilterBrand => txtBrand.Text;

    public event EventHandler FilterChanged;
    public event EventHandler AddNewCarClicked;
    public event EventHandler BuyCarClicked;

    public void ShowMessage(string message)
    {
      MessageBox.Show(message, "Catalog", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void OnBuyButtonClicked(object sender, EventArgs e)
    {
      BuyCarClicked?.Invoke(this, EventArgs.Empty);
    }

    public void ShowCarBuilderForm()
    {
      var builderForm = new CarBuilderForm();
      var builder = new CarBuilder();
      var presenter = new CarBuilderPresenter(builderForm, builder);

      builderForm.BuildCarClicked += (sender, e) =>
      {
        try
        {
          var car = builder
              .SetType(builderForm.CarType)
              .SetBrand(builderForm.Brand)
              .SetModel(builderForm.Model)
              .SetYear(builderForm.Year)
              .SetPrice(builderForm.Price)
              .SetColor(builderForm.Color)
              .SetHorsepower(builderForm.Horsepower)
              .SetEngineType(builderForm.EngineType)
              .SetTransmission(builderForm.Transmission)
              .Build();

          ((CatalogPresenter)this.Tag).AddNewCar(car);
          FilterChanged?.Invoke(this, EventArgs.Empty);
          builderForm.Close();
        }
        catch (Exception ex)
        {
          builderForm.ShowMessage($"Error building car: {ex.Message}");
        }
      };

      builderForm.ShowDialog();
    }

    public void ShowOrderForm(Car selectedCar)
    {
      var orderForm = new OrderForm(selectedCar);
      var orderPresenter = new OrderPresenter(orderForm, Program.Inventory);
      orderForm.ShowDialog(this);
      
      this.Cars = Program.Inventory;
    }
  }
}