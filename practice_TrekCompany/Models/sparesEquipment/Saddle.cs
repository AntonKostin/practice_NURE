﻿using System.ComponentModel.DataAnnotations;

namespace practice_TrekCompany.Models.sparesEquipment
{
    public class Saddle
    {
        //Модель для таблицы sparesEquipment.Brake
        [Key]
        public int saddleId { get; set; }
        public string saddleName { get; set; }

    }
}
