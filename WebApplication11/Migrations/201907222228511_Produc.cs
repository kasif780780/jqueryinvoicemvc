







namespace WebApplication11.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Produc : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "CustomerID", "dbo.Customers");
            DropIndex("dbo.Orders", new[] { "CustomerID" });
            RenameColumn(table: "dbo.Orders", name: "CustomerID", newName: "Customer_CustomerID");
            CreateTable(
                "dbo.OrderProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.OrderId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        Quantity = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Orders", "Date", c => c.String());
            AddColumn("dbo.Orders", "TotalAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Orders", "Customer_CustomerID", c => c.Int());
            CreateIndex("dbo.Orders", "Customer_CustomerID");
            AddForeignKey("dbo.Orders", "Customer_CustomerID", "dbo.Customers", "CustomerID");
            DropColumn("dbo.Orders", "ProductName");
            DropColumn("dbo.Orders", "Quantity");
            DropColumn("dbo.Orders", "Price");
            DropColumn("dbo.Orders", "Amount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "Amount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Orders", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Orders", "Quantity", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "ProductName", c => c.String());
            DropForeignKey("dbo.Orders", "Customer_CustomerID", "dbo.Customers");
            DropForeignKey("dbo.OrderProducts", "ProductId", "dbo.Products");
            DropForeignKey("dbo.OrderProducts", "OrderId", "dbo.Orders");
            DropIndex("dbo.OrderProducts", new[] { "ProductId" });
            DropIndex("dbo.OrderProducts", new[] { "OrderId" });
            DropIndex("dbo.Orders", new[] { "Customer_CustomerID" });
            AlterColumn("dbo.Orders", "Customer_CustomerID", c => c.Int(nullable: false));
            DropColumn("dbo.Orders", "TotalAmount");
            DropColumn("dbo.Orders", "Date");
            DropTable("dbo.Products");
            DropTable("dbo.OrderProducts");
            RenameColumn(table: "dbo.Orders", name: "Customer_CustomerID", newName: "CustomerID");
            CreateIndex("dbo.Orders", "CustomerID");
            AddForeignKey("dbo.Orders", "CustomerID", "dbo.Customers", "CustomerID", cascadeDelete: true);
        }
    }
}
