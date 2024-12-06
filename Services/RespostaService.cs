// using Microsoft.AspNetCore.Mvc.Formatters;
// using Elevate.QuizApi.Dominio.Entities;
// using Elevate.QuizApi.Services.Interfaces;


// namespace Elevate.QuizApi.Services
// {

//     public class RespostaService : IRespostaService
//     {

//         private readonly IRespostaService _respostaService;

//         public RespostaService(IRespostaService respostaService
        
//         )
//         {
//             _respostaService = respostaService;
//         }

//         public async Task<Resposta> AdicionarResposta(Resposta obj)
//         {
//             try
//             {
//                 var resposta = new Resposta(obj.Texto, obj.IsCorreta)
//                 {
//                     Texto = obj.Texto,
//                     IsCorreta = obj.IsCorreta
                    
//                 };

//                 return await _respostaService.AdicionarResposta(resposta);
//             }
//             catch(Exception ex)
//             {
//                 throw new InvalidOperationException("Erro ao adicionar resposta", ex);


//             }
//         }

//     }
// }