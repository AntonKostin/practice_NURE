﻿using System.ComponentModel.DataAnnotations;

namespace practice_TrekCompany.Models.sparesTransmition
{
    public class Cassette
    {
        //Модель для таблицы sparesTransmition.Cassette
        [Key]
        public int cassetteId { get; set; }
        public string cassetteName { get; set; }

    }
}
