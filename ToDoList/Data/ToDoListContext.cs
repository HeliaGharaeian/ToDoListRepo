namespace ToDoList.Data
{
    public class ToDoListContext
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
        public bool Delete { get; set; }
    }
}
