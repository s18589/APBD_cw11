using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APBD_cw11.Models
{
    public class Prescription
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime DueDate { get; set; }
        [ForeignKey("Doctor")]
        public int IdDoctor { get; set; }
        [ForeignKey("Patient")]
        public int IdPatient { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
        
        public IList<PrescrtiptionMedicament> PrescrtiptionMedicament { get; set; }
    }
}
