#include <iostream>
using namespace std;

int main() {
    int matriz[3][3] = {
        {1, 3, 4},
        {9, 6, 7},
        {5, 8, 2}
    };

    cout << "El recorrido del arreglo por Renglón es:" << endl;
    for (int z = 0; z < 3; z++) {
        for (int x = 0; x < 3; x++) {
            cout << matriz[z][x] << " ";
        }
    }
    cout << "\n\n";

    cout << "El recorrido del arreglo por Columna es:" << endl;
    for (int x = 0; x < 3; x++) {
        for (int z = 0; z < 3; z++) {
            cout << matriz[z][x] << " ";
        }
    }
    cout << endl;

    return 0;
}
