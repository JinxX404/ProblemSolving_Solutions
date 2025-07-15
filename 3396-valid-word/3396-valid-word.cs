public class Solution {
            public bool IsValid(string word)
        {
            word = word.ToLower();
            if (word.Length < 3) return false;

            return hasVowel(word) && hasDigitsandLetters(word) && hasConsonant(word);

        }
        private bool hasVowel(string word)
        {
            var vowels = "aieou";

            return word.Any(c => vowels.Contains(c));
            
        }
        private bool hasConsonant(string word)
        {
            var consonants = "BCDFGHJKLMNPQRSTVWXYZbcdfghjklmnpqrstvwxyz";
            return word.Any(c => consonants.Contains(c));
        }
        private bool hasDigitsandLetters(string word)
        {
            return word.All(char.IsLetterOrDigit);
        }
}