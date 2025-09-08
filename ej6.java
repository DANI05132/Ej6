public class ej6 {
    public static void main(String[] args) {
        int[][] matriz = {
            {1, 3, 4},
            {9, 6, 7},
            {5, 8, 2}
        };

        System.out.println("El recorrido del arreglo por Renglón es:");
        for (int z = 0; z < 3; z++) {
            for (int x = 0; x < 3; x++) {
                System.out.print(matriz[z][x] + " ");
            }
        }
        System.out.println("\n");

        System.out.println("El recorrido del arreglo por Columna es:");
        for (int x = 0; x < 3; x++) {
            for (int z = 0; z < 3; z++) {
                System.out.print(matriz[z][x] + " ");
            }
        }
        System.out.println();
    }
}
