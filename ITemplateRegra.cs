using System.Collections.Generic;

namespace venda_ingressos
{
    public interface ITemplateRegra
    {
        ITemplateRegra Proximo { get; set; }
        bool Vender(int nota, List<int> trocoDisponivel);
    }
}
