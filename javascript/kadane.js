function maxSubArraySum(arr) {
    let maxSoFar = arr[0];
    let currentMax = arr[0];

    for (let i = 1; i < arr.length; i++) {
        currentMax = Math.max(arr[i], currentMax + arr[i]);
        maxSoFar = Math.max(maxSoFar, currentMax);
    }

    return maxSoFar;
}

// Teste
let array2 = [-2, -3, 4, -1, -2, 1, 5, -3];
console.log("Soma máxima de subarray:", maxSubArraySum(array2)); // Saída: 7

// 2. Soma máxima de um subarray contíguo (Algoritmo de Kadane):
