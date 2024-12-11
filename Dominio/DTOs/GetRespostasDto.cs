
namespace Elevate.QuizApi.Dominio.DTOs
{

    public class GetRespostasDto : ModelBaseDto
    {
        public int TotalRespostas { get; set; }
        public int TotalCorretas { get; set; }

        public GetRespostasDto(int TotalRespostas, int TotalCorretas)
        {
            this.TotalRespostas = TotalRespostas;
            this.TotalCorretas = TotalCorretas;
        }

        public GetRespostasDto()
        {

        }
    }



}