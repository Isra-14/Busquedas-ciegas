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
using System.Linq;
using System.Collections.Generic;

namespace busquedas
{
    class Program {
        static void Main(string[] args){

            int size;
            int nodoInicio;
            int nodoFinal;
            int profundidad;

            string file = @"C:\Users\rodri\Documents\Tec ITC\8vo Semestre\Sistemas Inteligentes\Busquedas-ciegas\busquedas\grafo.txt";
            List<string> lines = File.ReadLines(file).ToList();

            size = Int32.Parse(lines[0]);
            lines.RemoveAt(0);

            if (size != 0) {
                Grafo g = new Grafo(size);

                int i = 0;
                foreach (string line in lines) {
                    string[] temp = line.Split(' ');
                    int n1 = Int32.Parse(temp[0]);
                    int n2 = Int32.Parse(temp[1]);

                    g.agregarVertice(n1, n2);

                    i++;
                }

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
