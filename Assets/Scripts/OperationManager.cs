using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OperationManager : MonoBehaviour
{
    //top text displays -> cannot input
    //bottom text used to input and add
    public Text bottomText, topText; 


    private string currentOperator;
    private double currentValue = 0;

    //display value in the bottom value
    public void DisplayValue(string number)
    {
        bottomText.text += number;
    }
    public void DisplayOperator(string op)
    {
        currentOperator = op;
        bottomText.text += op;
    }

    public void Clear()
    {
        currentValue = 0;
        currentOperator = null;
        bottomText.text = "";
        topText.text = "";
    }

    public void Calculate()
    {
        //value in the bottom text goes to the top text and bottom text updates the answer
        topText.text = bottomText.text;

        //get the answer
        switch (currentOperator)
        {
            case "+":
                currentValue += double.Parse(bottomText.text);
                bottomText.text = currentValue.ToString();
                break;
            case "-":
                currentValue -= double.Parse(bottomText.text);
                bottomText.text = currentValue.ToString();
                break;
            case "*":
                currentValue *= double.Parse(bottomText.text);
                bottomText.text = currentValue.ToString();
                break;
            case "/":
                currentValue /= double.Parse(bottomText.text);
                bottomText.text = currentValue.ToString();
                break;
        }
        currentOperator = null;

        //if the operation ends with an operator then you cannot perform a calculation
        //perform calucaltion by dividing the operators within the current value
    }
}
