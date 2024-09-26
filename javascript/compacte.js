function removeConsecutiveDuplicates(str) {
    let result = '';

    for (let i = 0; i < str.length; i++) {
        if (i === 0 || str[i] !== str[i - 1]) {
            result += str[i];
        }
    }

    return result;
}

// Teste
let string = "aaabbbccddd";
console.log("String compactada:", removeConsecutiveDuplicates(string)); // Saída: "abcd"
