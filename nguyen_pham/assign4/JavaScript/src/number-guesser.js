"use strict";

const { GuessResult } = require("./guess-result");
const { LOWER, EQUAL, HIGHER } = GuessResult;

const isGuessCorrect = (guess, answer) => [LOWER, EQUAL, HIGHER][Math.sign(guess - answer) + 1];

const evaluateGuess = (target, guess, attempts) => [ isGuessCorrect(guess, target), attempts + 1];

const guess = (target, readGuess, report) => {
  [...Array(100).keys()].some((attempt) => {
    const [result, newAttempt] = evaluateGuess(target, readGuess("Guess a number between 1 to 100: "), attempt);
    const message =
      result === EQUAL
        ? `You got it in ${newAttempt} attempt${newAttempt === 1 ? "" : "s"}`
        : `Your guess is ${result}, try again`;

    report(message);

    if (result === EQUAL) return true;
  });
};

const createTarget = () => Math.floor(Math.random() * 100) + 1;

module.exports = { isGuessCorrect, evaluateGuess, guess, createTarget };
