namespace OnlineShopWeb
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Client
    {
        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Code { get; set; }
        public int? IdCompany { get; set; }
    }
    public class Company
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    public class Employee
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
    public class Invoice
    {
        public int ID { get; set; }
        public string Number { get; set; }
        public DateTime? DateIssued { get; set; }
        public bool? Paid { get; set; }
        public int? IdClient { get; set; }
        public DateTime? DatePaid { get; set; }
    }
    public class InvoiceDetail
    {
        public int ID { get; set; }
        public int? IdProduct { get; set; }
        public int? Quantity { get; set; }
        public int? IdInvoice { get; set; }
        public decimal? UnitPrice { get; set; }
    }
    public class Manufacturer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
    }
    public class Order
    {
        public int Id { get; set; }
        public DateTime? DateOrdered { get; set; }
        public DateTime? DateSent { get; set; }
        public int? IdClient { get; set; }
        public bool? Cancelled { get; set; }
        public DateTime? DateProcessed { get; set; }
        public int? IdEmployee { get; set; }
    }
    public class OrderDetail
    {
        public int Id { get; set; }
        public int? IdOrder { get; set; }
        public int? IdProduct { get; set; }
        public int? Quantity { get; set; }
        public int? UnitPrice { get; set; }
        public double? Rebate { get; set; }
    }
    public class Payment
    {
        public int Id { get; set; }
        public DateTime? DateOfPayment { get; set; }
        public decimal? Amount { get; set; }
        public int? IdOrder { get; set; }
    }
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public decimal? Price { get; set; }
        public int? IdManufacturer { get; set; }
        public int? IdCategory { get; set; }
    }
}
