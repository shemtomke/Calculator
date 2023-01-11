using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OperationManager : MonoBehaviour
{
    //top text displays -> cannot input
    //bottom text used to input and add
    public Text bottomText, topText;

    private double currentValue = 0;
    private string currentOperator;

    //display value in the bottom value
    public void DisplayValue(string number)
    {
        bottomText.text += number;
        currentValue += double.Parse(number);
    }
    public void DisplayOperator(string op)
    {
        currentOperator = op;
        bottomText.text += op;
    }

    public void Clear()
    {
        currentValue = 0;
        bottomText.text = "";
        topText.text = "";
    }

    public void Calculate()
    {
        //value in the bottom text goes to the top text and bottom text updates the answer
        topText.text = bottomText.text;

        //if the operation ends or starts with an operator then you cannot perform a calculation
        /*if ((bottomText.text.Substring(bottomText.text.Length - 1) == operatorValue) || (bottomText.text.Substring(0) == operatorValue))
        {
            bottomText.text = "ERROR!";
        }*/
        //perform calucaltion by dividing the operators within the current value
        //bottomText.text = "";
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
    }

}