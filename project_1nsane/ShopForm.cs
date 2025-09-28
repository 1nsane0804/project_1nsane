```csharp
namespace ProjectInsane
{
  partial class ShopForm
  {
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.Label lblShopType;
    private System.Windows.Forms.ListBox lstItems;
    private System.Windows.Forms.Button btnBuy;

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
      this.lblShopType = new System.Windows.Forms.Label();
      this.lstItems = new System.Windows.Forms.ListBox();
      this.btnBuy = new System.Windows.Forms.Button();

      this.SuspendLayout();

      this.lblShopType.Location = new System.Drawing.Point(12, 9);
      this.lblShopType.Size = new System.Drawing.Size(260, 23);
      this.lblShopType.Text = "Shop";
      this.lblShopType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

      this.lstItems.Location = new System.Drawing.Point(12, 35);
      this.lstItems.Size = new System.Drawing.Size(260, 200);

      this.btnBuy.Location = new System.Drawing.Point(12, 241);
      this.btnBuy.Size = new System.Drawing.Size(260, 23);
      this.btnBuy.Text = "Buy Selected Item";
      this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);

      this.ClientSize = new System.Drawing.Size(284, 271);
      this.Controls.Add(this.btnBuy);
      this.Controls.Add(this.lstItems);
      this.Controls.Add(this.lblShopType);
      this.Name = "ShopForm";
      this.Text = "Shop";
      this.ResumeLayout(false);
    }
  }
}
```