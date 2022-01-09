using System;
using System.ComponentModel;

namespace Forbex.DAL.Data
{
    public class Contract
    {
        public int Id { get; set; }
        
        public string? Address { get; set; }
        
        /// <summary>
        /// Дата заключения договора аренды
        /// </summary>
        [DisplayName("Дата заключения")]
        public DateTime ConclusionDate { get; set; }

        /// <summary>
        /// ИФНС
        /// </summary>
        [DisplayName("ИФНС")]
        public string? Ifts { get; set; }
        
        /// <summary>
        /// Номер договора
        /// </summary>
        [DisplayName("Номер договора")]
        public string? ContractNumber { get; set; }

        /// <summary>
        /// Дата начала договора
        /// </summary>
        public DateTime LeaseStartDate { get; set; }
    }
}