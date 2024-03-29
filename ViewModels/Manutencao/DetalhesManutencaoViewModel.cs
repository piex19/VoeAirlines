﻿using VoeAirlines.Entities.Enums;

namespace VoeAirlines.ViewModels.Manutencao
{
    public class DetalhesManutencaoViewModel
    {
        public int Id { get; set; }
        public DateTime DataHora { get; set; }
        public TipoManutencao TipoManutencao { get; set; }
        public string? Observacao { get; set; }
        public int AeronaveId { get; set; }

        public DetalhesManutencaoViewModel(int id, DateTime dataHora, TipoManutencao tipoManutencao, string? observacao, int aeronaveId)
        {
            Id = id;
            DataHora = dataHora;
            TipoManutencao = tipoManutencao;
            Observacao = observacao;
            AeronaveId = aeronaveId;
        }
    }
}
