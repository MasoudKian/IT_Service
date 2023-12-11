namespace IT_Service.Domain.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }

        public bool IsDelete { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;

    }
}
