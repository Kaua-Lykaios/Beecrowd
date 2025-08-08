const input = require("fs").readFileSync('/dev/stadin/', utf-8);
const lines = input.split('\n');

const a = parseFloat(lines[0])
const b = parseFloat(lines[1])

const media = ((a * 3.5) + (b * 7.5)) / 11;

console.log(`MEDIA = ${media.toFixed(5)}`);
