/*
    15-03-2022
    Rodrigo S. de la Rosa Andres
    Israel Sanchez Hinojosa
 
    Programa para mostrar los algoritmos de busquedas en grafos (anchura, profundidad y profundidad limitada)
*/


using System;

namespace busquedas
{
    class Program {
        static void Main(string[] args){
            Grafo g = new Grafo(10);

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


            Console.Write("Breadth First Search (BFS)\n");
            Recorridos recorrido = new Recorridos(g.getSize());
            recorrido.BFS(2, g.getAdj());

            Console.ReadLine();
        }
    }
}
