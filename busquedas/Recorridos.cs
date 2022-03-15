using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace busquedas
{
    class Recorridos{
        private int _v;
        public Recorridos(int v) {
            _v = v;
        }

        public void BFS(int inicio, LinkedList<int>[] _adj) {

            // Marcar que los vertices no han sido visitados. 
            bool[] isVisited = new bool[_v];
            for (int i = 0; i < _v; i++)
                isVisited[i] = false;

            LinkedList<int> queue = new LinkedList<int>();  // Queue para el BFS

            isVisited[inicio] = true;
            queue.AddLast(inicio);

            while (queue.Any()) {
                inicio = queue.First();
                Console.Write(inicio + " ");
                queue.RemoveFirst();

                LinkedList<int> lista = _adj[inicio];

                foreach (var elemento in lista) {
                    if (!isVisited[elemento]) {
                        isVisited[elemento] = true;
                        queue.AddLast(elemento);
                    }
                }

            }

            Console.WriteLine("\n\n");
        }
    }
}
