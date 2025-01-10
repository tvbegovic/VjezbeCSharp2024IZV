namespace GameshopWeb
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Order
    {
        public int Id { get; set; }
        public int? IdUser { get; set; }
        public int? IdEmployee { get; set; }
        public DateTime? DateOrdered { get; set; }
        public DateTime? DateSent { get; set; }
    }
    public class OrderDetail
    {
        public int Id { get; set; }
        public int? IdOrder { get; set; }
        public int? IdGame { get; set; }
        public int? Quantity { get; set; }
        public decimal? Unitprice { get; set; }
    }
    public class User
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool? Admin { get; set; }
        public string City { get; set; }
    }
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int? IdGenre { get; set; }
        public int? IdPublisher { get; set; }
        public decimal? Price { get; set; }
        public int? IdDeveloper { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string Image { get; set; }
    }
}
