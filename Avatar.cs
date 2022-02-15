namespace Console_aventure
{
    public class Avatar
    {
        private int posX;
        private int posY;
        private Entorno entorno;
        private int[,] posicion;

        public Avatar(Entorno nivel, int x , int y){
            posX = x;
            posY = y;
            entorno = nivel;
            posicion = new int[x , y];
        }

        public void posicionInicial(int x, int y){
            entorno.posicionAvatar(x,y);           
        }
    }
}