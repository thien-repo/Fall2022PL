const factorNumbers = (numbers) => {
  return numbers
    .flatMap((number) =>
        [...Array(number).keys()]
        .filter((factor) => number % factor === 0)
        .flatMap((factor) => [number, factor])
    )
    .filter((item, index, array) => array.indexOf(item) === index)
    .sort((first, second) => first - second);
};

module.exports = { factorNumbers };
