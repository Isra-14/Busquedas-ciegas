using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace busquedas
{
    class Recorridos{
        int _v;
        public Recorridos(int v) {
            _v = v;
        }

        // Funciones auxiliares para recorrer las adyacencias de cada nodo.

        // DFS SIN busqueda
        void DFSHelper(int inicio, bool[] isVisited, LinkedList<int>[] _adj) {
            isVisited[inicio] = true;       // Se marca que este nodo ya se visitó.
            Console.Write(inicio + " ");    // Indicamos que nodo fue el que se visito.

            // Verficamos si existen vertices en el nodo actual
            if (_adj[inicio] != null) {
                foreach (var elemento in _adj[inicio]) // Pasamos por los nodos adyacentes
                    if (!isVisited[elemento])
                        DFSHelper(elemento, isVisited, _adj); // Hacemos una llamada recursiva a la funcion
            }
        }

        // DFS CON busqueda
        void DFSHelper(int inicio, int busqueda, bool[] isVisited, LinkedList<int>[] _adj) {
            isVisited[inicio] = true;       // Se marca que este nodo ya se visitó.
            Console.Write(inicio + " ");    // Indicamos que nodo fue el que se visito.

            // Verficamos si existen vertices en el nodo actual
            if (_adj[inicio] != null) {
                foreach (var elemento in _adj[inicio]) {// Pasamos por los nodos adyacentes
                    if (elemento == busqueda) {
                        Console.Write(elemento + " ");
                        break;
                    }

                    if (!isVisited[elemento])
                            DFSHelper(elemento, busqueda, isVisited, _adj); // Hacemos una llamada recursiva a la funcion
                }
            }
        }

        // DLS SIN busqueda
        void DLSHelper(int inicio, bool[] isVisited, LinkedList<int>[] _adj, int limite) {
            isVisited[inicio] = true;       // Se marca que este nodo ya se visitó.
            Console.Write(inicio + " ");    // Indicamos que nodo fue el que se visito.

            if (limite != 0) {
                // Verficamos si existen vertices en el nodo actual
                if (_adj[inicio] != null)
                {
                    foreach (var elemento in _adj[inicio]) // Pasamos por los nodos adyacentes
                        if (!isVisited[elemento])
                            DLSHelper(elemento, isVisited, _adj, limite - 1); // Hacemos una llamada recursiva a la funcion
                }
            }
        }

        // DLS CON busqueda
        void DLSHelper(int inicio, int busqueda, bool[] isVisited, LinkedList<int>[] _adj, int limite) {
            isVisited[inicio] = true;       // Se marca que este nodo ya se visitó.
            Console.Write(inicio + " ");    // Indicamos que nodo fue el que se visito.

            if (limite != 0){
                // Verficamos si existen vertices en el nodo actual
                if (_adj[inicio] != null){
                    foreach (var elemento in _adj[inicio]) { // Pasamos por los nodos adyacentes
                        if (elemento == busqueda) {
                            Console.Write(elemento + " ");
                            break;
                        }
                        if (!isVisited[elemento])
                            DLSHelper(elemento, isVisited, _adj, limite - 1); // Hacemos una llamada recursiva a la funcion
                    }
                }
            }
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

        public void DFS(int inicio, LinkedList<int>[] _adj) {
            bool[] isVisited = new bool[_v];    // Inicializamos el arreglo de visitados con el tamaño del grafo

            DFSHelper(inicio, isVisited, _adj);

            Console.WriteLine("\n\n");
        }
        
        public void DLS(int inicio, LinkedList<int>[] _adj, int limite) {
            bool[] isVisited = new bool[_v];    // Inicializamos el arreglo de visitados con el tamaño del grafo

            DLSHelper(inicio, isVisited, _adj, limite);
            Console.WriteLine("\n\n");
        }

        // CON busqueda
        public void BFS(int inicio, int busqueda, LinkedList<int>[] _adj) {

            // Marcar que los vertices no han sido visitados. 
            bool[] isVisited = new bool[_v];
            for (int i = 0; i < _v; i++)
                isVisited[i] = false;

            LinkedList<int> queue = new LinkedList<int>();  // Queue para el BFS

            isVisited[inicio] = true;
            queue.AddLast(inicio);

            while (queue.Any()) {
                if (inicio == busqueda)
                    break;

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

        public void DFS(int inicio, int busqueda, LinkedList<int>[] _adj) {
            bool[] isVisited = new bool[_v];    // Inicializamos el arreglo de visitados con el tamaño del grafo

            DFSHelper(inicio, busqueda, isVisited, _adj);

            Console.WriteLine("\n\n");
        }

        public void DLS(int inicio, int busqueda, LinkedList<int>[] _adj, int limite) {
            bool[] isVisited = new bool[_v];    // Inicializamos el arreglo de visitados con el tamaño del grafo

            DLSHelper(inicio, busqueda, isVisited, _adj, limite);
            Console.WriteLine("\n\n");
        }
    }
}
