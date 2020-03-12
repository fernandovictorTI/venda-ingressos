using System.Collections.Generic;
using System.Linq;
using System;

namespace venda_ingressos {

    public class TemplateRegraNota100 : TemplateRegraNota, ITemplateRegra {

        public ITemplateRegra Proximo { get; set; }
        public override void AplicarRegrasNota()
        {
            var indiceNota50 = TrocoDisponivel.FindIndex(c => c == 50);

            if (indiceNota50 > 0)
            {
                AplicarRegrasTroco25_50();
                return;
            }

            AplicarRegrasTroco3de25();
        }

        private void AplicarRegrasTroco25_50()
        {
            var indiceNota25 = TrocoDisponivel.FindIndex(c => c == 25);
            TrocoDisponivel.RemoveAt(indiceNota25);
            var indiceNota50 = TrocoDisponivel.FindIndex(c => c == 50);
            TrocoDisponivel.RemoveAt(indiceNota50);
        }

        private void AplicarRegrasTroco3de25()
        {
            var indiceNota25 = TrocoDisponivel.FindIndex(c => c == 25);
            TrocoDisponivel.RemoveAt(indiceNota25);
            indiceNota25 = TrocoDisponivel.FindIndex(c => c == 25);
            TrocoDisponivel.RemoveAt(indiceNota25);
            indiceNota25 = TrocoDisponivel.FindIndex(c => c == 25);
            TrocoDisponivel.RemoveAt(indiceNota25);
        }

        public override bool ValidarTrocoDisponivel()
        {
            if (TrocoDisponivel.Any(c => c == 25) && TrocoDisponivel.Any(c => c == 50))
                return true;

            if (TrocoDisponivel.Where(c => c == 25).Count() >= 3)
                return true;

            return false;
        }

        public override bool Vender(int nota, List<int> trocoDisponivel)
        {
            if (nota != 100)
                return Proximo.Vender(nota, trocoDisponivel);

            return base.Vender(nota, trocoDisponivel);
        }
    }
}