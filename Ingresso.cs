using System.Collections.Generic;
using System.Linq;

namespace venda_ingressos
{
    public class Ingresso
    {
        public static List<int> TrocoDisponivel { get; set; }

        public static bool Vender(List<int> pessoasNaFila)
        {
            TrocoDisponivel = new List<int>();

            if (!pessoasNaFila.Any())
                return false;

            ITemplateRegra vendaIngressoComNota25 = new TemplateRegraNota25();
            ITemplateRegra vendaIngressoComNota50 = new TemplateRegraNota50();
            ITemplateRegra vendaIngressoComNota100 = new TemplateRegraNota100();
            ITemplateRegra vendaIngressoSemNota = new TemplateRegraSemNota();

            vendaIngressoComNota25.Proximo = vendaIngressoComNota50;
            vendaIngressoComNota50.Proximo = vendaIngressoComNota100;
            vendaIngressoComNota100.Proximo = vendaIngressoSemNota;                

            foreach (var nota in pessoasNaFila)
            {               
                var possuiTrocoDisponivel = vendaIngressoComNota25.Vender(nota, TrocoDisponivel);

                if (!possuiTrocoDisponivel)
                    return false;
            }

            return true;
        }
    }
}
