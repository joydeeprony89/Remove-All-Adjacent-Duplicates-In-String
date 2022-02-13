using System;
using System.Collections.Generic;
using System.Text;

namespace Remove_All_Adjacent_Duplicates_In_String
{
  class Program
  {
    static void Main(string[] args)
    {
      Program p = new Program();
      string result = p.RemoveDuplicates("azxxzy"); // azxxzy // abbaca
      Console.WriteLine(result);
    }

    public string RemoveDuplicates(string s)
    {
      Stack<char> stk = new Stack<char>();
      int length = s.Length;
      // push the last char into the stack.
      stk.Push(s[length -1]);
      // varibale to track the previous char.
      char prev;
      for (int i = length - 2; i >= 0; i--)
      {
        // if stack has element, peek the element from stack else put a dummy value to tell no previous element.
        prev = stk.Count > 0 ? stk.Peek() : '1';
        // get the current char from inour string.
        char currentChar = s[i];
        // push the current char into the stack.
        stk.Push(currentChar);
        // of previous and current - i.e adjacent chars are same
        // will be popping both the adjacent elements
        if (currentChar == prev)
        {
          stk.Pop();
          stk.Pop();
        }
      }

      // String builder to generate the output
      StringBuilder result = new StringBuilder();
      while(stk.Count > 0)
      {
        result.Append(stk.Pop());
      }

      return result.ToString(); 
    }
  }
}
