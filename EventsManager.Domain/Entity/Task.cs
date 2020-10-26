using System;
namespace EventsManager.Domain.Entity
{
    public class Task : Base
    { 
        public string Tema { get; set; }

        public string Local { get; set; }

        public DateTime Data { get; set; }

        public int Participants { get; set; }

        public int Lote { get; set; }
    }
}
