/*
    15-03-2022
    Rodrigo S. de la Rosa Andres
    Israel Sanchez Hinojosa
 
    Programa para mostrar los algoritmos de busquedas en grafos (anchura, profundidad y profundidad limitada)

    Algunos algoritmos fueron tomados en cuenta para la realización de este código:
    -   https://www.koderdojo.com/blog/breadth-first-search-and-shortest-path-in-csharp-and-net-core
    -   https://www.geeksforgeeks.org/depth-first-search-or-dfs-for-a-graph/
*/


using System;
using System.IO;

namespace busquedas
{
    class Program {
        static void Main(string[] args){

            int size;
            int nodoInicio;
            int nodoFinal;
            int profundidad;

            size = 10; // TODO: Leer desde archivo

            if (size != 0) { 
                Grafo g = new Grafo(size);

                g.agregarVertice(0, 1);
                g.agregarVertice(0, 2);
                g.agregarVertice(1, 3);
                g.agregarVertice(2, 4);
                g.agregarVertice(2, 5);
                g.agregarVertice(4, 5);
                g.agregarVertice(3, 6);
                g.agregarVertice(4, 6);
                g.agregarVertice(4, 7);
                g.agregarVertice(7, 8);
                g.agregarVertice(7, 9);
                g.agregarVertice(8, 9);


                Console.WriteLine("Ingresa el nodo de inicio: ");
                nodoInicio = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingresa el nodo de fin: ");
                nodoFinal = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Limite de profundidad: ");
                profundidad = Convert.ToInt32(Console.ReadLine());

                Recorridos recorrido = new Recorridos(g.getSize());

                Console.Write("Breadth First Search (BFS)\n");
                recorrido.BFS(nodoInicio, g.getAdj());

                Console.Write("Depth First Search (DFS)\n");
                recorrido.DFS(nodoInicio, g.getAdj());

                Console.Write("Depth Limited Search (DLS)\n");
                recorrido.DLS(nodoInicio, g.getAdj(), profundidad);

                Console.Write("Breadth First Search Con busqueda (BFS)\n");
                recorrido.BFS(nodoInicio, nodoFinal, g.getAdj());

                Console.Write("Depth First Search Con busqueda (DFS)\n");
                recorrido.DFS(nodoInicio, nodoFinal, g.getAdj());

                Console.Write("Depth Limited Search Con busqueda (DLS)\n");
                recorrido.DLS(nodoInicio, nodoFinal, g.getAdj(), profundidad);

                Console.ReadLine();
            }
            
        }
    }
}
