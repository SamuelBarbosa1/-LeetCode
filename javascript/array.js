function secondLargest(arr) {
    if (arr.length < 2) {
        throw new Error("O array deve conter pelo menos dois elementos");
    }

    let first = -Infinity, second = -Infinity;

    for (let i = 0; i < arr.length; i++) {
        if (arr[i] > first) {
            second = first;
            first = arr[i];
        } else if (arr[i] > second && arr[i] !== first) {
            second = arr[i];
        }
    }

    return second;
}

// Teste
let array = [12, 35, 1, 10, 34, 1];
console.log("Segundo maior número:", secondLargest(array)); // Saída: 34

// 1. Encontre o segundo maior elemento em um array:
