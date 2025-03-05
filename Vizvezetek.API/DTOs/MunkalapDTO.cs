namespace Vizvezetek.API.DTOs
{
    public class MunkalapDTO
    {
        public int id { get; set; }
        public DateOnly beadas_datum { get; set; }
        public DateOnly javitas_datum { get; set; }
        public string Helyszin { get; set; }
        public string szerelo { get; set; }
        public int munkaora { get; set; }
        public int anyagar { get; set; }
    }
}
