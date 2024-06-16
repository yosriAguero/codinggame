// merge-string.component.spec.ts
import { mergeString } from "./merge-string.component";

describe('MergeStringComponent', () => {

  it('should merge "ab" and "pqrs" to "apbqrs"', () => {
    const word1 = 'ab';
    const word2 = 'pqrs';
    const expectedResult = 'apbqrs';
    expect(mergeString(word1, word2)).toEqual(expectedResult);
  });

  it('should merge "abc" and "xyz" to "axbycz"', () => {
    const word1 = 'abc';
    const word2 = 'xyz';
    const expectedResult = 'axbycz';
    expect(mergeString(word1, word2)).toEqual(expectedResult);
  });

  it('should merge "abcd" and "xy" to "axbycd"', () => {
    const word1 = 'abcd';
    const word2 = 'xy';
    const expectedResult = 'axbycd';
    expect(mergeString(word1, word2)).toEqual(expectedResult);
  });

  it('should merge "" and "xyz" to "xyz"', () => {
    const word1 = '';
    const word2 = 'xyz';
    const expectedResult = 'xyz';
    expect(mergeString(word1, word2)).toEqual(expectedResult);
  });

  it('should merge "abc" and "" to "abc"', () => {
    const word1 = 'abc';
    const word2 = '';
    const expectedResult = 'abc';
    expect(mergeString(word1, word2)).toEqual(expectedResult);
  });

  it('should merge two empty strings to an empty string', () => {
    const word1 = '';
    const word2 = '';
    const expectedResult = '';
    expect(mergeString(word1, word2)).toEqual(expectedResult);
  });
});




