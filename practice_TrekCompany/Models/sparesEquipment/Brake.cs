﻿using System.ComponentModel.DataAnnotations;

namespace practice_TrekCompany.Models.sparesEquipment
{
    public class Brake
    {
        //Модель для таблицы sparesEquipment.Brake
        [Key]
        public int brakeId { get; set; }
        public string brakeName { get; set; }
    }
}
