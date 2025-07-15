public class Solution {
                   public bool IsValid(string word)
        {
    
            if (word.Length < 3) return false;

            bool hasVowel = false;
            bool hasConsonant = false;

            foreach (var c in word.ToLower())
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return false;
                }


                if ("aieou".Contains(c))
                {
                    hasVowel = true;
                }
                else if(!char.IsDigit(c)) // if not a vowel and not a digit so it will be consonant
                {
                    hasConsonant = true;
                }

            }

            return hasConsonant && hasVowel;
        }
}