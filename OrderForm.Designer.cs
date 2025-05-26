namespace CarShowroom
{
  partial class OrderForm
  {
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.Label lblCarInfo;
    private System.Windows.Forms.Label lblName;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.Label lblPhone;
    private System.Windows.Forms.TextBox txtPhone;
    private System.Windows.Forms.Label lblEmail;
    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.Button btnPlaceOrder;

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
      this.lblCarInfo = new System.Windows.Forms.Label();
      this.lblName = new System.Windows.Forms.Label();
      this.txtName = new System.Windows.Forms.TextBox();
      this.lblPhone = new System.Windows.Forms.Label();
      this.txtPhone = new System.Windows.Forms.TextBox();
      this.lblEmail = new System.Windows.Forms.Label();
      this.txtEmail = new System.Windows.Forms.TextBox();
      this.btnPlaceOrder = new System.Windows.Forms.Button();
      this.SuspendLayout();

      // lblCarInfo
      this.lblCarInfo.AutoSize = true;
      this.lblCarInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblCarInfo.Location = new System.Drawing.Point(20, 20);
      this.lblCarInfo.Name = "lblCarInfo";
      this.lblCarInfo.Size = new System.Drawing.Size(0, 21);
      this.lblCarInfo.TabIndex = 0;

      // lblName
      this.lblName.AutoSize = true;
      this.lblName.Location = new System.Drawing.Point(20, 60);
      this.lblName.Name = "lblName";
      this.lblName.Size = new System.Drawing.Size(42, 15);
      this.lblName.Text = "Name:";

      // txtName
      this.txtName.Location = new System.Drawing.Point(80, 57);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(250, 23);
      this.txtName.TabIndex = 1;

      // lblPhone
      this.lblPhone.AutoSize = true;
      this.lblPhone.Location = new System.Drawing.Point(20, 90);
      this.lblPhone.Name = "lblPhone";
      this.lblPhone.Size = new System.Drawing.Size(44, 15);
      this.lblPhone.Text = "Phone:";

      // txtPhone
      this.txtPhone.Location = new System.Drawing.Point(80, 87);
      this.txtPhone.Name = "txtPhone";
      this.txtPhone.Size = new System.Drawing.Size(250, 23);
      this.txtPhone.TabIndex = 2;

      // lblEmail
      this.lblEmail.AutoSize = true;
      this.lblEmail.Location = new System.Drawing.Point(20, 120);
      this.lblEmail.Name = "lblEmail";
      this.lblEmail.Size = new System.Drawing.Size(39, 15);
      this.lblEmail.Text = "Email:";

      // txtEmail
      this.txtEmail.Location = new System.Drawing.Point(80, 117);
      this.txtEmail.Name = "txtEmail";
      this.txtEmail.Size = new System.Drawing.Size(250, 23);
      this.txtEmail.TabIndex = 3;

      // btnPlaceOrder
      this.btnPlaceOrder.Location = new System.Drawing.Point(80, 150);
      this.btnPlaceOrder.Name = "btnPlaceOrder";
      this.btnPlaceOrder.Size = new System.Drawing.Size(250, 30);
      this.btnPlaceOrder.TabIndex = 4;
      this.btnPlaceOrder.Text = "Place Order";
      this.btnPlaceOrder.UseVisualStyleBackColor = true;

      // OrderForm
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(350, 200);
      this.Controls.Add(this.btnPlaceOrder);
      this.Controls.Add(this.txtEmail);
      this.Controls.Add(this.lblEmail);
      this.Controls.Add(this.txtPhone);
      this.Controls.Add(this.lblPhone);
      this.Controls.Add(this.txtName);
      this.Controls.Add(this.lblName);
      this.Controls.Add(this.lblCarInfo);
      this.Name = "OrderForm";
      this.Text = "Place Order";
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}