using System.Collections.Generic;
using System.Linq;

namespace venda_ingressos
{
    public class TemplateRegraNota50 : TemplateRegraNota, ITemplateRegra
    {
        public ITemplateRegra Proximo { get; set; }
        public override void AplicarRegrasNota()
        {
            var indiceNota25 = TrocoDisponivel.FindIndex(c => c == 25);
            TrocoDisponivel.RemoveAt(indiceNota25);
        }

        public override bool ValidarTrocoDisponivel()
        {
            if (TrocoDisponivel.Any(c => c == 25))
                return true;

            return false;
        }

        public override bool Vender(int nota, List<int> trocoDisponivel)
        {
            if (nota != 50)
                return Proximo.Vender(nota, trocoDisponivel);

            return base.Vender(nota, trocoDisponivel);
        }
    }
}
