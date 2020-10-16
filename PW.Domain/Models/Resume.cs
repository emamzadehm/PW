
namespace PW.Domain.Models
{
    public class Resume
    {
        public int Id { get; private set; }
        public int Priority { get; private set; }
        public string FromYear { get; private set; }
        public string ToYear { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public bool Status { get; private set; }

        protected Resume()
        {

        }
        public Resume(int priority, string fromYear, string toYear, string title, string description)
        {
            Priority = priority;
            FromYear = fromYear;
            ToYear = toYear;
            Title = title;
            Description = description;
            Status = true;
        }
        public void Edit(int priority, string fromYear, string toYear, string title, string description)
        {
            Priority = priority;
            FromYear = fromYear;
            ToYear = toYear;
            Title = title;
            Description = description;
        }

        public void Remove()
        {
            Status = false;
        }
    }
}
