using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EventsManager.Application.Dtos
{
    public class TaskDto
    {
        public int Id { get; set; }

        public string Tema { get; set; }

        public string Local { get; set; }

        public DateTime Data { get; set; }

        public int Participants { get; set; }

        public int Lote { get; set; }
    }
}
