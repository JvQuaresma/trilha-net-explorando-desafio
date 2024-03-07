using System.Linq.Expressions;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            
            // IMPLEMENTADO!!!
        
                if (Suite.Capacidade >= hospedes.Count())
                {
                    Hospedes = hospedes;
                }
            
            else
            {
                // IMPLEMENTADO!!!
                throw new Exception("A capacidade de hóspedes não pode exceder a capacidade da suíte.");
                
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // IMPLEMENTADO!!!
            return Hospedes.Count;      
        }

        public decimal CalcularValorDiaria()
        {
            // IMPLEMENTADO!!!
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // IMPLEMENTADO!!!
            if (DiasReservados >=10)
            {
                decimal desconto = DiasReservados * Suite.ValorDiaria * 0.10M;
                valor = (DiasReservados * Suite.ValorDiaria) - desconto;
            }

            return valor;

        }
    }
}