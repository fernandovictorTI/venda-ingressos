using System;
using System.Collections.Generic;

namespace venda_ingressos
{
    public class TemplateRegraSemNota : TemplateRegraNota, ITemplateRegra
    {
        public ITemplateRegra Proximo { get; set; }

        public override void AplicarRegrasNota()
        {
        }

        public override bool ValidarTrocoDisponivel()
        {
            return false;
        }

        public override bool Vender(int nota, List<int> trocoDisponivel)
        {
            throw new Exception("Nota não existe.");
        }
    }
}
