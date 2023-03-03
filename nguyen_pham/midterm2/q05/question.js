//Given this JavaScript code

const sam = {name: 'Sam', mailing: { street: '101 Main' }, shipping: { street: '102 Clay'} };

function printDetails({ name, mailing: { street }, shipping: { street: shipStreet } }) { 
  console.log(`${name} receives mail at ${street} and deliveries at ${shipStreet}`);
}

printDetails(sam); //Sam receives mail at 101 Main and deliveries at 102 Clay
