using System;
namespace IDSAnews.Domain.Entities
{
    public class Information
    {
        public string Header { get; set; }
        public Uri Link { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
}
