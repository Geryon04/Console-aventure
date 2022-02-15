namespace Console_aventure{
    class Program{

        public static void Main(string[] args){
            Console.WriteLine("ingrese la cantidad de columnas");
            int ancho = int.Parse(Console.ReadLine());

            int posX = 3;
            int posY = 3;


            Entorno escenario = new Entorno(alto , ancho);
            Avatar personaje = new Avatar(escenario , posX , posY);
            escenario.construirEntorno();
            personaje.posicionInicial(posX ,posY);
            System.Console.Clear();
            escenario.imprimir(); 

            Console.WriteLine("ingrese una nueva posicion del avatar");
            string posicion = Console.ReadLine();

            while (posicion != "nada"){
                if(posicion == "arriba"){
                    posX--;
                    escenario.construirEntorno();
                    personaje.posicionInicial(posX ,posY);
                    System.Console.Clear();
                    escenario.imprimir();
                    Console.WriteLine("ingrese una nueva posicion del avatar");
                    posicion = Console.ReadLine();
                }
                if(posicion == "abajo"){
                    posX++;
                    escenario.construirEntorno();
                    personaje.posicionInicial(posX ,posY);
                    System.Console.Clear();
                    escenario.imprimir();
                    Console.WriteLine("ingrese una nueva posicion del avatar");
                    posicion = Console.ReadLine();
                }
                if(posicion == "derecha"){
                    posY++;
                    escenario.construirEntorno();
                    personaje.posicionInicial(posX ,posY);
                    System.Console.Clear();
                    escenario.imprimir();
                    Console.WriteLine("ingrese una nueva posicion del avatar");
                    posicion = Console.ReadLine();
                }
                if(posicion == "izquierda"){
                    posY--;
                    escenario.construirEntorno();
                    personaje.posicionInicial(posX ,posY);
                    System.Console.Clear();
                    escenario.imprimir();
                    Console.WriteLine("ingrese una nueva posicion del avatar");
                    posicion = Console.ReadLine();
                }
            }


            Console.ReadKey(true);
        }
        
    }
}