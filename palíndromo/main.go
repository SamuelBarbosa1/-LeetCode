package main

import (
	"fmt"
	"strings"
)

func isPalindrome(s string) bool {
	s = strings.ToLower(s)
	left, right := 0, len(s)-1

	for left < right {
		if s[left] != s[right] {
			return false
		}

		left++
		right--
	}
	return true
}

func main() {
	str := "Radar"
	fmt.Println("É palíndromo?", isPalindrome(str))
}

// 3. Verifique se uma string é um palíndromo:
