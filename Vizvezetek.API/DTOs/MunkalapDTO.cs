using Vizvezetek.API.Models;

namespace Vizvezetek.API.DTOs
{
    public class MunkalapDTO
    {
        public int id { get; set; }
        public DateTime beadas_datum { get; set; }
        public DateTime javitas_datum { get; set; }
        public string helyszin { get; set; }
        public string szerelo { get; set; }
        public int munkaora { get; set; }
        public int anyagar { get; set; }

        public MunkalapDTO(int id, DateTime beadas_datum, DateTime javitas_datum, string telepules, string utca, string szerelo, int munkaora, int anyagar)
        {
            this.id = id;
            this.beadas_datum = beadas_datum;
            this.javitas_datum = javitas_datum;
            this.helyszin = telepules + ", " + utca;
            this.szerelo = szerelo;
            this.munkaora = munkaora;
            this.anyagar = anyagar;
        }
    }
}
