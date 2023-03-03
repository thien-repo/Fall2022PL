"use strict";

const { expect } = require("chai");

const sinon = require("sinon");

const {
    isGuessCorrect,
    evaluateGuess,
    guess,
    createTarget
} = require("../src/number-guesser");
const { GuessResult } = require("../src/guess-result");
const { LOWER, EQUAL, HIGHER } = GuessResult;

describe("Number Guesser Tests", () => {
    it("is a canary test", () => {
        expect(true).to.be.true;
    });

    const samplesIsGuessCorrect = [
        { guess: 1, answer: 1, expected: EQUAL },
        { guess: 1, answer: 2, expected: LOWER },
        { guess: 2, answer: 1, expected: HIGHER },
    ];

    samplesIsGuessCorrect.forEach(({ guess, answer, expected }) => {
        it(`guess ${guess} against ${answer} should return ${expected}`, () => {
            expect(isGuessCorrect(guess, answer)).to.equal(expected);
        });
    });

    const samplesEvaluateGuess = [
        { guess: 20, target: 20, attempts: 0, expected: [EQUAL, 1] },
        { guess: 20, target: 20, attempts: 3, expected: [EQUAL, 4] },
        { guess: 20, target: 10, attempts: 1, expected: [HIGHER, 2] },
        { guess: 20, target: 40, attempts: 2, expected: [LOWER, 3] },
    ];

    samplesEvaluateGuess.forEach(({ guess, target, attempts, expected }) => {
        it(`guess ${guess} against ${target} with ${attempts} attempts should return ${expected}`, () => {
            expect(evaluateGuess(target, guess, attempts)).to.eql(expected);
        });
    });

    it("user guess correctly in the 1st attempt", () => {
        const readGuess = sinon.stub().returns(20);
        const report = sinon.spy();

        guess(20, readGuess, report);

        expect(report.calledWith("You got it in 1 attempt")).to.be.true;
    });

    it("user guesses right in the 2nd attempt", () => {
        const readGuess = sinon
            .stub()
            .onFirstCall()
            .returns(10)
            .onSecondCall()
            .returns(15);

        const report = sinon.spy();

        guess(15, readGuess, report);

        expect(report.calledWith("Your guess is LOWER, try again")).to.be.true;
        expect(report.calledWith("You got it in 2 attempts")).to.be.true;
    });

    it("user guesses with 2 attempts", () => {
        const readGuess = sinon
            .stub()
            .onFirstCall()
            .returns(20)
            .onSecondCall()
            .returns(15);

        const report = sinon.spy();

        guess(15, readGuess, report);

        expect(report.calledWith("Your guess is HIGHER, try again")).to.be.true;
        expect(report.calledWith("You got it in 2 attempts")).to.be.true;
    });

    it("user guesses with 3 attempts", () => {
        const readGuess = sinon
            .stub()
            .onFirstCall()
            .returns(20)
            .onSecondCall()
            .returns(10)
            .onThirdCall()
            .returns(15);

        const report = sinon.spy();

        guess(15, readGuess, report);

        expect(report.calledWith("Your guess is HIGHER, try again")).to.be.true;
        expect(report.calledWith("Your guess is LOWER, try again")).to.be.true;
        expect(report.calledWith("You got it in 3 attempts")).to.be.true;
    });

    it("createTarget creates two different random numbers", () => {
        const first = createTarget();
        const second = createTarget();

        expect(first).to.not.equal(second);
    })
});
