namespace CodingGame.Reverse_World
{
    public static class ReverseWorld
    {
        public static void ReverseWord()
        {
            //Input: s = "the sky is blue"
            string Input = "the sky is blue";

            string[] inputSplitted = Input.Split(' ');
            Stack<string> stack = new Stack<string>();
            foreach (string word in inputSplitted)
            {
                stack.Push(word);
            }
           // string output = 
        }
    }
}
