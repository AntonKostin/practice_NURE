﻿using System.ComponentModel.DataAnnotations;

namespace practice_TrekCompany.Models.sparesTransmition
{
    public class Shifter
    {
        //Модель для таблицы sparesTransmition.Shifter
        [Key]
        public int shifterId { get; set; }
        public string shifterName { get; set; }
    }
}