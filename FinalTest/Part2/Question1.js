function getTheNumber(array) {
	let allNumbersSet = new Set();
	let theNumberSet = new Set();
	for (let num of array) {
		if(allNumbersSet.has(num)) {
			theNumberSet.delete(num);
		} else {
			allNumbersSet.add(num);
			theNumberSet.add(num);
		}
	}
	
	return theNumberSet.values().next().value;
}