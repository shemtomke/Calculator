using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OperationManager : MonoBehaviour
{
    //top text displays -> cannot input
    //bottom text used to input and add
    public Text bottomText, topText;

    //display value in the bottom value
    public void DisplayValue(string number)
    {
        bottomText.text += number;
    }
    public void DisplayOperator(string op)
    {
        bottomText.text += op;
    }

    public void Clear()
    {
        bottomText.text = "";
        topText.text = "";
    }
    public void Calculate()
    {
        string value = bottomText.text.ToString();

        topText.text = bottomText.text; //operation done to be displayed

        //display answer to the bottom text

    }
}