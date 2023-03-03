const { question } = require("readline-sync");

const {
    guess,
    createTarget
} = require("./src/number-guesser");

const target = createTarget();

guess(target, question, console.log);

