using DeafioFramework.Model;
using DeafioFramework.Response;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DesafioFramework.Controller
{
    public class NumeroController
    {
        private const string MENSAGEM_PADRAO_RESULT = "Não possível verficar o seu numero. Por favor, tente novamente em alguns minutos.";
        public ResponseNumero VerficaPrimoeDivisores(ModelNumero numero)
        {
            var result = ResponseNumero.DivisoresEPrimos(numero.Numero);
            if (result == null)
                throw new ValidationException(result != null ? (!string.IsNullOrEmpty(result.Mensagem) ? result.Mensagem : MENSAGEM_PADRAO_RESULT) : MENSAGEM_PADRAO_RESULT);
            return result;
        }

        
    }
}
