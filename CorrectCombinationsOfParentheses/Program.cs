// See https://aka.ms/new-console-template for more information

int n = 3;
char[] str = new char[2 * n];
 
PrintParenthesis(str,0, n,0,0);

void PrintParenthesis(char[] str, int pos, int n, int open, int close)
{
    if (close == n) {
        // print the possible combinations
        for (int i = 0; i < str.Length; i++)
            Console.Write(str[i]);
 
        Console.WriteLine();
    }
    else {
        if (open > close) {
            str[pos] = '}';
            PrintParenthesis(str, pos + 1, n, open, close + 1);
        }
        if (open < n) {
            str[pos] = '{';
            PrintParenthesis(str, pos + 1, n, open + 1, close);
        }
    }
}