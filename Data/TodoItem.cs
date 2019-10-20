using System;
namespace API.Modelos
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public bool IsComplete { get; set; }
    }
}
