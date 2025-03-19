const fs = require("fs");
const readline = require("readline");

// Criar uma interface para leitura da entrada padrão
const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout
});

// Solicitar a entrada do usuário
rl.question("Digite dois números separados por espaço: ", function(input) {
  // Processa a entrada e divide por espaço
  let line = input.split(/\s+/);

  // Converte os valores para inteiros
  let a = parseInt(line.shift());
  let b = parseInt(line.shift());

  // Calcula a soma
  const soma = a + b;

  // Exibe o resultado
  console.log(`X = ${soma}`);

  // Fecha a interface de leitura
  rl.close();
});
