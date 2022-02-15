namespace Console_aventure
{
    public class Entorno
    {
        private int ancho;
        private int alto;

        private int[,] area;

        public Entorno (int alto, int ancho){
            this.alto = alto;
            this.ancho = ancho;
            area = new int[alto , ancho];
        }

        public int getFilas(){
            return alto;
        }

        public int getColumnas(){
            return ancho;
        }

        public int[,] construirEntorno(){           
            for (int fila = 0; fila < alto; fila++)
            {
                for(int columna = 0; columna < ancho; columna++){
                    int casilla = 0;
                    area[fila , columna] = casilla;
                }
            }
            return area;
        }

        public void posicionAvatar(int x, int y){
            area[x , y] = 1;
        }

        public void imprimir(){
            for(int fila = 0; fila < alto; fila++){
                for(int columna = 0; columna < ancho; columna++){
                    Console.Write(area[fila,columna] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey(true);
        }
    }
}