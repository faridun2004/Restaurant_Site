namespace Restaurant_Site.Models
{
    public abstract class Person: BaseEntity
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Address { get; set; }

        public string? ContactInfo { get; set; }

        public string? FullName => $"{FirstName} {LastName}";
    }
}
