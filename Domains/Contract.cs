using System;

namespace FirstRepository.Domain
{
    public class Contract
    {
        public int Id { get; set; }
        public int DurationContract { get; set; }
        public decimal Salary { get; set; }
        public DateTime DateContract { get; set; }
        public int Club { get; set; }
        public int Footballer { get; set; }
        public int Manager { get; set; }
    }
}
