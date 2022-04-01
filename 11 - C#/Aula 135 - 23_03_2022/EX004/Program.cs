using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Time> time = new List<Time>();
            List<Jogador> plantel = new List<Jogador>();
            List<Jogador> relacionados = new List<Jogador>();

            plantel.Add(new Jogador(1, "Marcos", "Marcão", DateTime.Parse("04/09/1973"), 1, "Goleiro", 90, 0, false));
            plantel.Add(new Jogador(2, "Cafú", "Capita", DateTime.Parse("07/06/1970"), 2, "Lateral Esquerdo", 100, 1, false));
            plantel.Add(new Jogador(3, "Lúcio", "Lúcio", DateTime.Parse("08/03/1978"), 3, "Zagueiro", 70, 0, false));
            plantel.Add(new Jogador(4, "Roque Júnior", "Roque", DateTime.Parse("03/08/1976"), 4, "Zagueiro", 70, 1, false));
            plantel.Add(new Jogador(5, "José Edmílson", "Edmílson", DateTime.Parse("07/07/1976"), 5, "Zagueiro", 80, 0, false));
            plantel.Add(new Jogador(6, "Roberto Carlos", "R6", DateTime.Parse("10/04/1973"), 6, "Lateral Direito", 100, 0, false));
            plantel.Add(new Jogador(7, "Ricardo Luís", "Ricardinhos", DateTime.Parse("23/03/1976"), 7, "Meio-campista", 80, 0, true));
            plantel.Add(new Jogador(8, "Gilberto Silva", "Gilberto", DateTime.Parse("07/10/1976"), 8, "Volante", 90, 1, false));
            plantel.Add(new Jogador(9, "Ronaldo", "R9", DateTime.Parse("22/09/1976"), 9, "Atacante", 10, 0, false));
            plantel.Add(new Jogador(10, "Rivaldo Vítor", "Rivaldo", DateTime.Parse("19/04/1972"), 10, "Atacante", 95, 0, false));
            plantel.Add(new Jogador(11, "Ronaldinho Gaúcho", "R10", DateTime.Parse("21/03/1980"), 11, "Meio-campista", 90, 0, false));
            plantel.Add(new Jogador(12, "Marcos1", "Marcão", DateTime.Parse("04/09/1973"), 1, "Goleiro", 60, 0, false));
            plantel.Add(new Jogador(13, "Cafú1", "Capita", DateTime.Parse("07/06/1970"), 2, "Lateral Esquerdo", 40, 1, false));
            plantel.Add(new Jogador(14, "Lúcio1", "Lúcio", DateTime.Parse("08/03/1978"), 3, "Zagueiro", 80, 0, false));
            plantel.Add(new Jogador(15, "Roque Júnior1", "Roque", DateTime.Parse("03/08/1976"), 4, "Zagueiro", 78, 1, false));
            plantel.Add(new Jogador(16, "José Edmílson1", "Edmílson", DateTime.Parse("07/07/1976"), 5, "Zagueiro", 82, 0, false));
            plantel.Add(new Jogador(17, "Roberto Carlos1", "R6", DateTime.Parse("10/04/1973"), 6, "Lateral Direito", 99, 0, false));
            plantel.Add(new Jogador(18, "Ricardo Luís1", "Ricardinhos", DateTime.Parse("23/03/1976"), 7, "Meio-campista", 43, 0, true));
            plantel.Add(new Jogador(19, "Gilberto Silva1", "Gilberto", DateTime.Parse("07/10/1976"), 8, "Volante", 73, 1, false));
            plantel.Add(new Jogador(20, "Ronaldo1", "R9", DateTime.Parse("22/09/1976"), 9, "Atacante", 86, 0, false));
            plantel.Add(new Jogador(21, "Rivaldo Vítor1", "Rivaldo", DateTime.Parse("19/04/1972"), 10, "Atacante", 65, 0, false));
            plantel.Add(new Jogador(22, "Ronaldinho Gaúcho1", "R10", DateTime.Parse("21/03/1980"), 11, "Meio-campista", 23, 0, false));
            plantel.Add(new Jogador(23, "kaka", "R10", DateTime.Parse("21/03/1980"), 18, "Meio-campista", 98, 0, false));

            time.Add(new Time("Brazil", "Brazuca", DateTime.Parse("07/05/1837"), plantel, relacionados));
            time.Add(new Time("Brazil2", "Brazuca2", DateTime.Parse("07/05/1837"), plantel, relacionados));
        }
    }
}
