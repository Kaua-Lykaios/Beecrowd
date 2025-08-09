const input = require('fs').readFileSync('/dev/stdin', 'utf8');
const lines = input.split('\n');

const a = lines[0];
const b = parseFloat(lines[1]);
const c = parseFloat(lines[2]);

let salario = ((c * 0.15) + b).toFixed(2);

console.log(`TOTAL = R$ ${salario}`);
