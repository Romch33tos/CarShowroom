namespace CarShowroom
{
  partial class CatalogForm
  {
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.DataGridView dgvCars;
    private System.Windows.Forms.Label lblFilterType;
    private System.Windows.Forms.ComboBox cmbFilterType;
    private System.Windows.Forms.Label lblBrand;
    private System.Windows.Forms.TextBox txtBrand;
    private System.Windows.Forms.Label lblPriceRange;
    private System.Windows.Forms.NumericUpDown nudMinPrice;
    private System.Windows.Forms.Label lblTo;
    private System.Windows.Forms.NumericUpDown nudMaxPrice;
    private System.Windows.Forms.Button btnApplyFilters;
    private System.Windows.Forms.Label lblCount;
    private System.Windows.Forms.Button btnAddCar;
    private System.Windows.Forms.Button btnBuyCar;

    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.dgvCars = new System.Windows.Forms.DataGridView();
      this.lblFilterType = new System.Windows.Forms.Label();
      this.cmbFilterType = new System.Windows.Forms.ComboBox();
      this.lblBrand = new System.Windows.Forms.Label();
      this.txtBrand = new System.Windows.Forms.TextBox();
      this.lblPriceRange = new System.Windows.Forms.Label();
      this.nudMinPrice = new System.Windows.Forms.NumericUpDown();
      this.lblTo = new System.Windows.Forms.Label();
      this.nudMaxPrice = new System.Windows.Forms.NumericUpDown();
      this.btnApplyFilters = new System.Windows.Forms.Button();
      this.lblCount = new System.Windows.Forms.Label();
      this.btnAddCar = new System.Windows.Forms.Button();
      this.btnBuyCar = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudMinPrice)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudMaxPrice)).BeginInit();
      this.SuspendLayout();

      // dgvCars
      this.dgvCars.AllowUserToAddRows = false;
      this.dgvCars.AllowUserToDeleteRows = false;
      this.dgvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvCars.Location = new System.Drawing.Point(10, 70);
      this.dgvCars.Name = "dgvCars";
      this.dgvCars.ReadOnly = true;
      this.dgvCars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvCars.Size = new System.Drawing.Size(700, 300);
      this.dgvCars.TabIndex = 0;
      this.dgvCars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

      // lblFilterType
      this.lblFilterType.AutoSize = true;
      this.lblFilterType.Location = new System.Drawing.Point(10, 10);
      this.lblFilterType.Name = "lblFilterType";
      this.lblFilterType.Size = new System.Drawing.Size(35, 15);
      this.lblFilterType.Text = "Type:";

      // cmbFilterType
      this.cmbFilterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbFilterType.FormattingEnabled = true;
      this.cmbFilterType.Items.AddRange(new object[] { "", "Sedan", "SUV", "Sports Car" });
      this.cmbFilterType.Location = new System.Drawing.Point(50, 7);
      this.cmbFilterType.Name = "cmbFilterType";
      this.cmbFilterType.Size = new System.Drawing.Size(120, 23);
      this.cmbFilterType.TabIndex = 1;

      // lblBrand
      this.lblBrand.AutoSize = true;
      this.lblBrand.Location = new System.Drawing.Point(180, 10);
      this.lblBrand.Name = "lblBrand";
      this.lblBrand.Size = new System.Drawing.Size(41, 15);
      this.lblBrand.Text = "Brand:";

      // txtBrand
      this.txtBrand.Location = new System.Drawing.Point(230, 7);
      this.txtBrand.Name = "txtBrand";
      this.txtBrand.Size = new System.Drawing.Size(120, 23);
      this.txtBrand.TabIndex = 2;

      // lblPriceRange
      this.lblPriceRange.AutoSize = true;
      this.lblPriceRange.Location = new System.Drawing.Point(360, 10);
      this.lblPriceRange.Name = "lblPriceRange";
      this.lblPriceRange.Size = new System.Drawing.Size(36, 15);
      this.lblPriceRange.Text = "Price:";

      // nudMinPrice
      this.nudMinPrice.DecimalPlaces = 2;
      this.nudMinPrice.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
      this.nudMinPrice.Location = new System.Drawing.Point(400, 7);
      this.nudMinPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
      this.nudMinPrice.Name = "nudMinPrice";
      this.nudMinPrice.Size = new System.Drawing.Size(80, 23);
      this.nudMinPrice.TabIndex = 3;

      // lblTo
      this.lblTo.AutoSize = true;
      this.lblTo.Location = new System.Drawing.Point(485, 10);
      this.lblTo.Name = "lblTo";
      this.lblTo.Size = new System.Drawing.Size(19, 15);
      this.lblTo.Text = "to";

      // nudMaxPrice
      this.nudMaxPrice.DecimalPlaces = 2;
      this.nudMaxPrice.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
      this.nudMaxPrice.Location = new System.Drawing.Point(510, 7);
      this.nudMaxPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
      this.nudMaxPrice.Name = "nudMaxPrice";
      this.nudMaxPrice.Size = new System.Drawing.Size(80, 23);
      this.nudMaxPrice.TabIndex = 4;

      // btnApplyFilters
      this.btnApplyFilters.Location = new System.Drawing.Point(600, 6);
      this.btnApplyFilters.Name = "btnApplyFilters";
      this.btnApplyFilters.Size = new System.Drawing.Size(110, 25);
      this.btnApplyFilters.TabIndex = 5;
      this.btnApplyFilters.Text = "Apply Filters";
      this.btnApplyFilters.UseVisualStyleBackColor = true;
      this.btnApplyFilters.Click += (sender, e) => FilterChanged?.Invoke(this, EventArgs.Empty);

      // lblCount
      this.lblCount.AutoSize = true;
      this.lblCount.Location = new System.Drawing.Point(10, 45);
      this.lblCount.Name = "lblCount";
      this.lblCount.Size = new System.Drawing.Size(70, 15);
      this.lblCount.Text = "0 cars found";

      // btnAddCar
      this.btnAddCar.Location = new System.Drawing.Point(10, 380);
      this.btnAddCar.Name = "btnAddCar";
      this.btnAddCar.Size = new System.Drawing.Size(120, 30);
      this.btnAddCar.TabIndex = 6;
      this.btnAddCar.Text = "Add New Car";
      this.btnAddCar.UseVisualStyleBackColor = true;
      this.btnAddCar.Click += (sender, e) => AddNewCarClicked?.Invoke(this, EventArgs.Empty);

      // btnBuyCar
      this.btnBuyCar.Location = new System.Drawing.Point(560, 380);
      this.btnBuyCar.Name = "btnBuyCar";
      this.btnBuyCar.Size = new System.Drawing.Size(150, 30);
      this.btnBuyCar.TabIndex = 6;
      this.btnBuyCar.Text = "Buy Selected Car";
      this.btnBuyCar.UseVisualStyleBackColor = true;
      this.btnBuyCar.Click += new System.EventHandler(this.OnBuyButtonClicked);

      // CatalogForm
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(720, 420);
      this.Controls.Add(this.btnBuyCar);
      this.Controls.Add(this.btnAddCar);
      this.Controls.Add(this.lblCount);
      this.Controls.Add(this.btnApplyFilters);
      this.Controls.Add(this.nudMaxPrice);
      this.Controls.Add(this.lblTo);
      this.Controls.Add(this.nudMinPrice);
      this.Controls.Add(this.lblPriceRange);
      this.Controls.Add(this.txtBrand);
      this.Controls.Add(this.lblBrand);
      this.Controls.Add(this.cmbFilterType);
      this.Controls.Add(this.lblFilterType);
      this.Controls.Add(this.dgvCars);
      this.Name = "CatalogForm";
      this.Text = "Car Catalog";
      ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudMinPrice)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudMaxPrice)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}