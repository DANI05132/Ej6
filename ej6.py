matriz = [
    [1, 3, 4],
    [9, 6, 7],
    [5, 8, 2]
]

# Recorrido por Renglones
print("El recorrido del arreglo por Renglón es:")
for z in range(3):         # filas
    for x in range(3):     # columnas
        print(matriz[z][x], end=" ")
print()

print()

# Recorrido por Columnas
print("El recorrido del arreglo por Columna es:")
for x in range(3):         # columnas
    for z in range(3):     # filas
        print(matriz[z][x], end=" ")
print()