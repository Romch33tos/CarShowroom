namespace CarShowroom
{
  partial class CarBuilderForm
  {
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.Label lblType;
    private System.Windows.Forms.ComboBox cmbType;
    private System.Windows.Forms.Label lblBrand;
    private System.Windows.Forms.TextBox txtBrand;
    private System.Windows.Forms.Label lblModel;
    private System.Windows.Forms.TextBox txtModel;
    private System.Windows.Forms.Label lblYear;
    private System.Windows.Forms.NumericUpDown nudYear;
    private System.Windows.Forms.Label lblPrice;
    private System.Windows.Forms.NumericUpDown nudPrice;
    private System.Windows.Forms.Label lblColor;
    private System.Windows.Forms.TextBox txtColor;
    private System.Windows.Forms.Label lblHorsepower;
    private System.Windows.Forms.NumericUpDown nudHorsepower;
    private System.Windows.Forms.Label lblEngineType;
    private System.Windows.Forms.TextBox txtEngineType;
    private System.Windows.Forms.Label lblTransmission;
    private System.Windows.Forms.ComboBox cmbTransmission;
    private System.Windows.Forms.Button btnBuild;

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
      this.lblType = new System.Windows.Forms.Label();
      this.cmbType = new System.Windows.Forms.ComboBox();
      this.lblBrand = new System.Windows.Forms.Label();
      this.txtBrand = new System.Windows.Forms.TextBox();
      this.lblModel = new System.Windows.Forms.Label();
      this.txtModel = new System.Windows.Forms.TextBox();
      this.lblYear = new System.Windows.Forms.Label();
      this.nudYear = new System.Windows.Forms.NumericUpDown();
      this.lblPrice = new System.Windows.Forms.Label();
      this.nudPrice = new System.Windows.Forms.NumericUpDown();
      this.lblColor = new System.Windows.Forms.Label();
      this.txtColor = new System.Windows.Forms.TextBox();
      this.lblHorsepower = new System.Windows.Forms.Label();
      this.nudHorsepower = new System.Windows.Forms.NumericUpDown();
      this.lblEngineType = new System.Windows.Forms.Label();
      this.txtEngineType = new System.Windows.Forms.TextBox();
      this.lblTransmission = new System.Windows.Forms.Label();
      this.cmbTransmission = new System.Windows.Forms.ComboBox();
      this.btnBuild = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudHorsepower)).BeginInit();
      this.SuspendLayout();

      // lblType
      this.lblType.AutoSize = true;
      this.lblType.Location = new System.Drawing.Point(10, 10);
      this.lblType.Name = "lblType";
      this.lblType.Size = new System.Drawing.Size(35, 15);
      this.lblType.Text = "Type:";

      // cmbType
      this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbType.FormattingEnabled = true;
      this.cmbType.Location = new System.Drawing.Point(120, 7);
      this.cmbType.Name = "cmbType";
      this.cmbType.Size = new System.Drawing.Size(200, 23);
      this.cmbType.TabIndex = 1;

      // lblBrand
      this.lblBrand.AutoSize = true;
      this.lblBrand.Location = new System.Drawing.Point(10, 40);
      this.lblBrand.Name = "lblBrand";
      this.lblBrand.Size = new System.Drawing.Size(41, 15);
      this.lblBrand.Text = "Brand:";

      // txtBrand
      this.txtBrand.Location = new System.Drawing.Point(120, 37);
      this.txtBrand.Name = "txtBrand";
      this.txtBrand.Size = new System.Drawing.Size(200, 23);
      this.txtBrand.TabIndex = 2;

      // lblModel
      this.lblModel.AutoSize = true;
      this.lblModel.Location = new System.Drawing.Point(10, 70);
      this.lblModel.Name = "lblModel";
      this.lblModel.Size = new System.Drawing.Size(44, 15);
      this.lblModel.Text = "Model:";

      // txtModel
      this.txtModel.Location = new System.Drawing.Point(120, 67);
      this.txtModel.Name = "txtModel";
      this.txtModel.Size = new System.Drawing.Size(200, 23);
      this.txtModel.TabIndex = 3;

      // lblYear
      this.lblYear.AutoSize = true;
      this.lblYear.Location = new System.Drawing.Point(10, 100);
      this.lblYear.Name = "lblYear";
      this.lblYear.Size = new System.Drawing.Size(32, 15);
      this.lblYear.Text = "Year:";

      // nudYear
      this.nudYear.Location = new System.Drawing.Point(120, 97);
      this.nudYear.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
      this.nudYear.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
      this.nudYear.Name = "nudYear";
      this.nudYear.Size = new System.Drawing.Size(200, 23);
      this.nudYear.TabIndex = 4;
      this.nudYear.Value = new decimal(new int[] { 2023, 0, 0, 0 });

      // lblPrice
      this.lblPrice.AutoSize = true;
      this.lblPrice.Location = new System.Drawing.Point(10, 130);
      this.lblPrice.Name = "lblPrice";
      this.lblPrice.Size = new System.Drawing.Size(36, 15);
      this.lblPrice.Text = "Price:";

      // nudPrice
      this.nudPrice.DecimalPlaces = 2;
      this.nudPrice.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
      this.nudPrice.Location = new System.Drawing.Point(120, 127);
      this.nudPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
      this.nudPrice.Name = "nudPrice";
      this.nudPrice.Size = new System.Drawing.Size(200, 23);
      this.nudPrice.TabIndex = 5;
      this.nudPrice.ThousandsSeparator = true;

      // lblColor
      this.lblColor.AutoSize = true;
      this.lblColor.Location = new System.Drawing.Point(10, 160);
      this.lblColor.Name = "lblColor";
      this.lblColor.Size = new System.Drawing.Size(39, 15);
      this.lblColor.Text = "Color:";

      // txtColor
      this.txtColor.Location = new System.Drawing.Point(120, 157);
      this.txtColor.Name = "txtColor";
      this.txtColor.Size = new System.Drawing.Size(200, 23);
      this.txtColor.TabIndex = 6;

      // lblHorsepower
      this.lblHorsepower.AutoSize = true;
      this.lblHorsepower.Location = new System.Drawing.Point(10, 190);
      this.lblHorsepower.Name = "lblHorsepower";
      this.lblHorsepower.Size = new System.Drawing.Size(76, 15);
      this.lblHorsepower.Text = "Horsepower:";

      // nudHorsepower
      this.nudHorsepower.Location = new System.Drawing.Point(120, 187);
      this.nudHorsepower.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
      this.nudHorsepower.Minimum = new decimal(new int[] { 50, 0, 0, 0 });
      this.nudHorsepower.Name = "nudHorsepower";
      this.nudHorsepower.Size = new System.Drawing.Size(200, 23);
      this.nudHorsepower.TabIndex = 7;
      this.nudHorsepower.Value = new decimal(new int[] { 150, 0, 0, 0 });

      // lblEngineType
      this.lblEngineType.AutoSize = true;
      this.lblEngineType.Location = new System.Drawing.Point(10, 220);
      this.lblEngineType.Name = "lblEngineType";
      this.lblEngineType.Size = new System.Drawing.Size(74, 15);
      this.lblEngineType.Text = "Engine Type:";

      // txtEngineType
      this.txtEngineType.Location = new System.Drawing.Point(120, 217);
      this.txtEngineType.Name = "txtEngineType";
      this.txtEngineType.Size = new System.Drawing.Size(200, 23);
      this.txtEngineType.TabIndex = 8;

      // lblTransmission
      this.lblTransmission.AutoSize = true;
      this.lblTransmission.Location = new System.Drawing.Point(10, 250);
      this.lblTransmission.Name = "lblTransmission";
      this.lblTransmission.Size = new System.Drawing.Size(80, 15);
      this.lblTransmission.Text = "Transmission:";

      // cmbTransmission
      this.cmbTransmission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbTransmission.FormattingEnabled = true;
      this.cmbTransmission.Location = new System.Drawing.Point(120, 247);
      this.cmbTransmission.Name = "cmbTransmission";
      this.cmbTransmission.Size = new System.Drawing.Size(200, 23);
      this.cmbTransmission.TabIndex = 9;

      // btnBuild
      this.btnBuild.Location = new System.Drawing.Point(120, 280);
      this.btnBuild.Name = "btnBuild";
      this.btnBuild.Size = new System.Drawing.Size(200, 30);
      this.btnBuild.TabIndex = 10;
      this.btnBuild.Text = "Build Car";
      this.btnBuild.UseVisualStyleBackColor = true;
      this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);

      // CarBuilderForm
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(334, 321);
      this.Controls.Add(this.btnBuild);
      this.Controls.Add(this.cmbTransmission);
      this.Controls.Add(this.lblTransmission);
      this.Controls.Add(this.txtEngineType);
      this.Controls.Add(this.lblEngineType);
      this.Controls.Add(this.nudHorsepower);
      this.Controls.Add(this.lblHorsepower);
      this.Controls.Add(this.txtColor);
      this.Controls.Add(this.lblColor);
      this.Controls.Add(this.nudPrice);
      this.Controls.Add(this.lblPrice);
      this.Controls.Add(this.nudYear);
      this.Controls.Add(this.lblYear);
      this.Controls.Add(this.txtModel);
      this.Controls.Add(this.lblModel);
      this.Controls.Add(this.txtBrand);
      this.Controls.Add(this.lblBrand);
      this.Controls.Add(this.cmbType);
      this.Controls.Add(this.lblType);
      this.Name = "CarBuilderForm";
      this.Text = "Car Builder";
      this.Load += new System.EventHandler(this.CarBuilderForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudHorsepower)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}