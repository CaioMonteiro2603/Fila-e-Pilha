namespace FilaePilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fila fila = new Fila();
            fila.enqueue("Lara");
            fila.enqueue("Marcos");
            fila.enqueue("André");
            fila.enqueue("Mauro");
            fila.enqueue("João");
            fila.dequeue();
            fila.getAll(); 


            Pilha pilha = new Pilha();
            pilha.enstack("Lourdes");
            pilha.enstack("Lucas");
            pilha.enstack("Caio");
            pilha.enstack("Olivia");
            pilha.destack();
            pilha.getAll(); 

        }
    }
}