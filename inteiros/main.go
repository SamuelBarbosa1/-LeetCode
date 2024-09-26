package main

import "fmt"

func mostFrequent(arr []int) int {
	frequency := make(map[int]int)
	maxCount := 0
	mostFrequentElement := arr[0]

	for _, num := range arr {
		frequency[num]++
		if frequency[num] > maxCount {
			maxCount = frequency[num]
			mostFrequentElement = num
		}
	}
	return mostFrequentElement
}

func main() {
	arr := []int{1, 3, 2, 3, 4, 1, 3}
	fmt.Println("Elemento que aparece mais vezes:", mostFrequent(arr))
}

//1. Encontre o elemento que aparece mais vezes em um array de números inteiros:
