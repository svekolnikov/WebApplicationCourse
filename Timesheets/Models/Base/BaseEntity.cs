namespace Timesheets.Models.Base
{
    public class BaseEntity : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
