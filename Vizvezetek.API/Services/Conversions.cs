using System.Linq;
using Vizvezetek.API.DTOs;
using Vizvezetek.API.Models;

namespace Vizvezetek.API.Services
{
    public static class Conversions
    {
        public static MunkalapDTO ToDTO(this Munkalap munkalap)
        {
            return new MunkalapDTO(munkalap.id, munkalap.beadas_datum, munkalap.javitas_datum, munkalap.hely.telepules, munkalap.hely.utca, munkalap.szerelo.nev, munkalap.munkaora, munkalap.anyagar);
        }

        public static List<MunkalapDTO> ToDTO(this IEnumerable<Munkalap> munkalapok)
        {
            return munkalapok.Select(ToDTO).ToList();
        }
    }
}
