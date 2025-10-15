public static class ScrabbleScore
{
    public static int Score(string input)
    {
        int points = 0;
        input = input.ToUpper();
        foreach(char letter in input){
            if("AEIOULNRST".Contains(letter)){
                points+=1;
            }
            else if("DG".Contains(letter)){
                points+=2;
            }
            else if("BCMP".Contains(letter)){
                points+=3;
            }
            else if("FHVWY".Contains(letter)){
                points+=4;
            }
            else if("K".Contains(letter)){
                points+=5;
            }
            else if("JX".Contains(letter)){
                points+=8;
            }
            else if("QZ".Contains(letter)){
                points+=10;
            }
        }

        return points;
        throw new NotImplementedException("You need to implement this method.");
    }
}