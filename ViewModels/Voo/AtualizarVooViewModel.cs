﻿namespace VoeAirlines.ViewModels.Voo
{
    public class AtualizarVooViewModel
    {
        public string Origem { get; set; }
        public string Destino { get; set; }
        public DateTime DataHoraPartida { get; set; }
        public DateTime DataHoraChegada { get; set; }
        public int AeronaveId { get; set; }
        public int PilotoId { get; set; }

        public AtualizarVooViewModel(string origem, string destino, DateTime dataHoraPartida, DateTime dataHoraChegada, int aeronaveId, int pilotoId)
        {
            Origem = origem;
            Destino = destino;
            DataHoraPartida = dataHoraPartida;
            DataHoraChegada = dataHoraChegada;
            AeronaveId = aeronaveId;
            PilotoId = pilotoId;
        }
    }
}
