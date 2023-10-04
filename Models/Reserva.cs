namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Reserva(Suite suite) 
        {
            this.Suite = suite;
   
        }
                public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
           if (Suite == null)
            {
                throw new Exception("A suíte ainda não foi registrada.");
            }

            if (hospedes.Count > Suite.Capacidade)
            {
                throw new Exception("O número de hóspedes excede a capacidade da suíte.");
            }
            else
            {
                Hospedes = hospedes;
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*
             return Hospedes?.Count ?? 0;
            
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*

            decimal valor = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
            {
                // Desconto de 10%
                decimal desconto = valor * 0.1m;
                valor -= desconto;
            }

            return valor;
        }
    }
}

