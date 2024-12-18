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
<<<<<<< HEAD
            //string output = 
=======
           // string output = 
>>>>>>> 6a80767af8f34aaf84ac4109f5c78c36aa1d1fb2
        }
    }
}
