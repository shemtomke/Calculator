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
        System.Data.DataTable table = new System.Data.DataTable();

        string value = bottomText.text.ToString();

        //operation done to be displayed i.e 2+2
        topText.text = bottomText.text;

        //display answer to the bottom text i.e =4
        try
        {
            bottomText.text = "" + table.Compute(value, "");
        }
        catch (System.Exception)
        {
            bottomText.text = "INVALID";
            throw;
        }
    }
}