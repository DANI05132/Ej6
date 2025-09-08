let matriz = [
    [1, 3, 4],
    [9, 6, 7],
    [5, 8, 2]
];

console.log("El recorrido del arreglo por Renglón es:");
for (let z = 0; z < 3; z++) {
    for (let x = 0; x < 3; x++) {
        process.stdout.write(matriz[z][x] + " ");
    }
}
console.log("\n");

console.log("El recorrido del arreglo por Columna es:");
for (let x = 0; x < 3; x++) {
    for (let z = 0; z < 3; z++) {
        process.stdout.write(matriz[z][x] + " ");
    }
}
console.log();
