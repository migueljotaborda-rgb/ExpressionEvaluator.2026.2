using System;
namespace Backend;

public static class ExpressionEvaluator
{
    public static string Evalute(string infix)
    {
        double result = EvalutePostfix(ToPostfix(infix));
        return (result % 1 == 0) ? result.ToString("0") : result.ToString();
    }

    private static string ToPostfix(string infix)
    {
        string postfix = string.Empty;
        char[] stack = new char[infix.Length];
        int top = -1;

        for (int i = 0; i < infix.Length; i++)
        {
            char item = infix[i];

            if (IsOperator(item))
            {
                if (item == ')')
                {
                    while (top >= 0 && stack[top] != '(')
                    {
                        postfix += stack[top--] + " ";
                    }
                    if (top >= 0 && stack[top] == '(')
                    {
                        top--;
                    }
                }
                else
                {
                    while (top >= 0 && stack[top] != '(' && PriorityInfix(item) <= PriorityStack(stack[top]))
                    {
                        postfix += stack[top--] + " ";
                    }
                    stack[++top] = item;
                }
                    }
                    else
                    {
                string number = string.Empty;
                while (i < infix.Length && (char.IsDigit(infix[i]) || infix[i] == '.'))
                        {
                    number += infix[i];
                    i++;
                    }
                i--;
                postfix += number + " ";
                }
            }

        while (top >= 0)
            {
            postfix += stack[top--] + " ";
        }

        return postfix.Trim();
    }

    private static int PriorityStack(char op) => op switch
    {
        '^' => 3,
        '*' => 2,
        '/' => 2,
        '+' => 1,
        '-' => 1,
        '(' => 0,
        _ => throw new Exception("Invalid operator."),
    };

    private static int PriorityInfix(char op) => op switch
    {
        '^' => 4,
        '*' => 2,
        '/' => 2,
        '+' => 1,
        '-' => 1,
        '(' => 5,
        _ => throw new Exception("Invalid operator."),
    };

    private static bool IsOperator(char item) =>
        item == '^' || item == '*' || item == '/' || item == '+' || item == '-' || item == '(' || item == ')';

    private static double EvalutePostfix(string postfix)
    {
        string[] tokens = postfix.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        double[] stack = new double[tokens.Length];
        int top = -1;

        foreach (var token in tokens)
        {
            if (token.Length == 1 && IsOperator(token[0]))
            {
                if (top < 1) throw new Exception("Invalid expression structure.");
                var ope2 = stack[top--];
                var ope1 = stack[top--];
                stack[++top] = Calculate(ope1, ope2, token[0]);
            }
            else
            {
                if (double.TryParse(token, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double num))
                {
                    stack[++top] = num;
                }
            }
        }

        return top >= 0 ? stack[top] : 0;
    }

    private static double Calculate(double ope1, double ope2, char item) => item switch
    {
        '*' => ope1 * ope2,
        '/' => ope1 / ope2,
        '+' => ope1 + ope2,
        '-' => ope1 - ope2,
        '^' => Math.Pow(ope1, ope2),
        _ => throw new Exception("Invalid expression."),
    };
}
