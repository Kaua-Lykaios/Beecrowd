const input = require('fs').readFileSync('/dev/stdin', 'utf8');
const lines = input.split('\n');

const a = parseFloat(lines[0]);
const b = parseFloat(lines[1]);
const c = parseFloat(lines[2]);

const media = (2 * a + 3 * b + 5 * c) / (2 + 3 + 5);

console.log(`MEDIA = ${media.toFixed(1)}`);
