function mergeAlternately(word1, word2) {
    let mergedString = '';
    let length1 = word1.length;
    let length2 = word2.length;
    let maxLength = Math.max(length1, length2);

    for (let i = 0; i < maxLength; i++) {
        if (i < length1) {
            mergedString += word1[i];
        }
        if (i < length2) {
            mergedString += word2[i];
        }
    }

    return mergedString;
}

// Example 1
let word1 = "abc";
let word2 = "pqr";
console.log(mergeAlternately(word1, word2)); // Output: "apbqcr"

// Example 2
word1 = "ab";
word2 = "pqrs";
console.log(mergeAlternately(word1, word2)); // Output: "apbqrs"

// Example 3
word1 = "abcd";
word2 = "pq";
console.log(mergeAlternately(word1, word2)); // Output: "apbqcd"
