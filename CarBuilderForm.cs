namespace CarShowroom
{
  public partial class CarBuilderForm : Form, ICarBuilderView
  {
    public CarBuilderForm()
    {
      InitializeComponent();
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
    }

    public string CarType
    {
      get => cmbType.SelectedItem?.ToString();
      set => cmbType.SelectedItem = value;
    }

    public string Brand
    {
      get => txtBrand.Text;
      set => txtBrand.Text = value;
    }

    public string Model
    {
      get => txtModel.Text;
      set => txtModel.Text = value;
    }

    public int Year
    {
      get => (int)nudYear.Value;
      set => nudYear.Value = value;
    }

    public decimal Price
    {
      get => nudPrice.Value;
      set => nudPrice.Value = value;
    }

    public string Color
    {
      get => txtColor.Text;
      set => txtColor.Text = value;
    }

    public int Horsepower
    {
      get => (int)nudHorsepower.Value;
      set => nudHorsepower.Value = value;
    }

    public string EngineType
    {
      get => txtEngineType.Text;
      set => txtEngineType.Text = value;
    }

    public string Transmission
    {
      get => cmbTransmission.SelectedItem?.ToString();
      set => cmbTransmission.SelectedItem = value;
    }

    public event EventHandler BuildCarClicked;

    public void ShowMessage(string message)
    {
      MessageBox.Show(message, "Car Builder", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnBuild_Click(object sender, EventArgs e)
    {
      BuildCarClicked?.Invoke(this, EventArgs.Empty);
    }

    private void CarBuilderForm_Load(object sender, EventArgs e)
    {
      cmbType.Items.AddRange(new[] { "Sedan", "SUV", "Sports Car" });
      cmbTransmission.Items.AddRange(new[] { "Automatic", "Manual" });
    }
  }
}
