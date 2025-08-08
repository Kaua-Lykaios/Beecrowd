const input = require("fs").readFileSync('/dev/stdin', 'utf8');
const lines = input.split('\n');
const pi = 3.14159;

const raio = parseFloat(lines[0]); // leia como número decimal

const area = pi * (raio ** 2); // fórmula correta: π * r²

console.log(`A=${area.toFixed(4)}`);