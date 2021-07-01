using UnityEngine;
using System;

public class GraphManager : MonoBehaviour
{
    private readonly string[] mathematicalFunctionsList = new string[] {"sin", "cos", "tan", "exponential", "logarithmic", "line", "quadratic" };
    private string currentMathematicalFunction = "sin";

    public void NextMathematicalFunction()
    {
        int currentIndex = Array.FindIndex(mathematicalFunctionsList,
            (mathematicalFunction) => mathematicalFunction == currentMathematicalFunction
        );

        if (currentIndex == mathematicalFunctionsList.Length - 1)
        {
            currentMathematicalFunction = mathematicalFunctionsList[0];
            return;
        }
        currentMathematicalFunction = mathematicalFunctionsList[currentIndex + 1];
    }

    public void PreviousMathematicalFunction()
    {
        int currentIndex = Array.FindIndex(mathematicalFunctionsList,
            (mathematicalFunction) => mathematicalFunction == currentMathematicalFunction
        );

        if (currentIndex == 0)
        {
            currentMathematicalFunction = mathematicalFunctionsList[mathematicalFunctionsList.Length - 1];
            return;
        }
        currentMathematicalFunction = mathematicalFunctionsList[currentIndex - 1];
    }

    public string GetCurrentMathematicalFunction()
    {
        return currentMathematicalFunction;
    }
}
