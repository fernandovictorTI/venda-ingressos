using System.Collections.Generic;

namespace venda_ingressos
{
    public class TemplateRegraNota25 : TemplateRegraNota, ITemplateRegra
    {
        public ITemplateRegra Proximo { get; set; }

        public override void AplicarRegrasNota()
        {
        }

        public override bool ValidarTrocoDisponivel()
        {
            return true;
        }

        public override bool Vender(int nota, List<int> trocoDisponivel)
        {
            if (nota != 25)
                return Proximo.Vender(nota, trocoDisponivel);

            return base.Vender(nota, trocoDisponivel);
        }
    }
}
