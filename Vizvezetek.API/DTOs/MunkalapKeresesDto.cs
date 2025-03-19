namespace Vizvezetek.API.DTOs
{
    public class MunkalapKeresesDto
    {
        public int helyszinId { get; set; }
        public int szereloId { get; set; }

        public MunkalapKeresesDto(int hId, int szId)
        {
            helyszinId = hId;
            szereloId = szId;
        }
    }
}
