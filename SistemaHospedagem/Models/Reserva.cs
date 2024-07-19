namespace SistemaHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva()
        {
        }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            try
            {
                if (hospedes.Count > Suite.Capacidade)
                {
                    throw new Exception("A quantidade de hóspedes não pode exceder a capacidade da suite");
                }
                Hospedes = hospedes;
            }
            catch
            {
                throw;
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count();
        }

        public decimal CalcularValorDiaria()
        {
            return (DiasReservados >= 10 ? Suite.ValorDiaria * DiasReservados * 0.9M : Suite.ValorDiaria * DiasReservados) ;
        }
    }
}
