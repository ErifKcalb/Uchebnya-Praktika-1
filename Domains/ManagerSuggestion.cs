using System;

namespace FirstRepository.Domain
{
    public class ManagerSuggestion
    {
        public int Id { get; set; }
        public string Massage { get; set; }
        public int Club { get; set; }
        public int Footballer { get; set; }
        public int Manager { get; set; }
    }
}
