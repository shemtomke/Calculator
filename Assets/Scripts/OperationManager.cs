using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OperationManager : MonoBehaviour
{
    //top text displays -> cannot input
    //bottom text used to input and add
    public Text bottomText, topText;
    string value;

    private void Update()
    {
        value = bottomText.text.ToString();
    }
    //display value in the bottom value
    public void DisplayValue(string number)
    {
        InvalidResult();
        bottomText.text += number;
    }
    public void DisplayOperator(string op)
    {
        InvalidResult();
        bottomText.text += op;
    }
    public void Percentage()
    {
        //change values to a percentage
        
    }
    //this should clear any data from the text when an invalid error occurs
    public void InvalidResult()
    {
        if (value == "INVALID")
        {
            Clear();
        }
    }
    public void Clear()
    {
        bottomText.text = "";
        topText.text = "";
    }
    public void Calculate()
    {
        //.NET inbuilt function -> DataTable Class
        System.Data.DataTable table = new System.Data.DataTable();

        //operation done to be displayed i.e 2+2
        topText.text = bottomText.text;

        //display answer to the bottom text i.e =4
        try
        {
            bottomText.text = "" + table.Compute(value, "");
        }
        catch (System.Exception)
        {
            //throw this error
            bottomText.text = "INVALID";

            //throw; //disable this 
        }
    }
}