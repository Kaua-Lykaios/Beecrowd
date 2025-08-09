const input = require('fs').readFileSync('/dev/stdin', 'utf8');
const linhas = input.split('\n');

const peca1 = linhas[0].split(' ');
const peca2 = linhas[1].split(' ');

const qtd1 = parseInt(peca1[1]);
const valor1 = parseFloat(peca1[2]);

const qtd2 = parseInt(peca2[1]);
const valor2 = parseFloat(peca2[2]);

const total = (qtd1 * valor1) + (qtd2 * valor2);

console.log(`VALOR A PAGAR: R$ ${total.toFixed(2)}`);