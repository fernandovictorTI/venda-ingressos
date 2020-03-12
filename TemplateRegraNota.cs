using System.Collections.Generic;

namespace venda_ingressos
{
    public abstract class TemplateRegraNota
    {
        protected List<int> TrocoDisponivel { get; private set; }

        public abstract bool ValidarTrocoDisponivel();
        public abstract void AplicarRegrasNota();
        public virtual bool Vender(int nota, List<int> trocoDisponivel)
        {
            TrocoDisponivel = trocoDisponivel;

            if (ValidarTrocoDisponivel())
            {
                AplicarRegrasNota();
                trocoDisponivel.Add(nota);

                return true;
            }

            return false;
        }
    }
}
