public class Solution {
    private int Evaluate(int n2, int n1, string symbol){
        return symbol switch
        {
            "+" => n1 + n2,
            "-" => n1 - n2,
            "*" => n1 * n2,
            "/" => n1 / n2,
            _ => n1 + n2,
        };
    }
    public int EvalRPN(string[] tokens) {
         Stack<int> s = new();
        
        foreach(var c in tokens){
            if(int.TryParse(c, out int number)){
                s.Push(number);
            }else{
                s.Push(Evaluate(s.Pop(), s.Pop(), c));
            }


        }
        return s.Pop();
    }
}
