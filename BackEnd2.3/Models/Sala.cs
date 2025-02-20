namespace BackEnd2._3.Models
{
    public class Sala
    {
        public string NomeSala { get; set; }
        public int CapienzaMassima { get; set; } = 120;
        public int BigliettiInteriVenduti { get; set; }
        public int BigliettiRidottiVenduti { get; set; }


        public List<BigliettoVenduto> BigliettiVenduti { get; set; } = new List<BigliettoVenduto>();
    }

   
}
