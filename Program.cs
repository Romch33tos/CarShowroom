namespace CarShowroom
{
  internal static class Program
  {
    public static List<Car> Inventory { get; private set; } = new List<Car>();

    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      InitializeInventory();
      
      var catalogView = new CatalogForm();
      var catalogPresenter = new CatalogPresenter(catalogView, Inventory);
      catalogView.Tag = catalogPresenter;

      Application.Run(catalogView);
    }

    private static void InitializeInventory()
    {
      var builder = new CarBuilder();
      var director = new CarDirector(builder);

      Inventory.Add(director.ConstructSedan());
      Inventory.Add(director.ConstructSUV());
      Inventory.Add(director.ConstructSportsCar());
    }
  }
}