using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColasArray : MonoBehaviour
{
    void Start()
    {
        Stack<int> originalStack = new Stack<int>();
        originalStack.Push(4);
        originalStack.Push(-5);
        originalStack.Push(-10);
        originalStack.Push(88);
        originalStack.Push(2);

        Stack<int> stack1 = new Stack<int>();
        Stack<int> stack2 = new Stack<int>();

        
        while (originalStack.Count > 0)
        {
            stack1.Push(originalStack.Pop());
        }

       
    }
}
