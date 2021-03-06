﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APBD_cw11.Models
{
    public class PrescrtiptionMedicament
    {
        public Medicament Medicament { get; set; }
        public Prescription Prescription { get; set; }

        [ForeignKey("Medicament")]
        public int IdMedicament { get; set; }

        [ForeignKey("Prescription")]
        public int IdPrescription { get; set; }

        public int Dose { get; set; }
        [MaxLength(100)]
        public string Details { get; set; }

    }
}
