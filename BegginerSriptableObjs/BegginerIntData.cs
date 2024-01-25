using UnityEngine;
using UnityEngine.UI;

public class BegginerIntData : ScriptableObject
{
    public int value;

    public void SetValue(int number)
    {
        value = number;
    }

    public void AddValue(int number)
    {
        value += number;
    }
    
    public void MultiplyValue(int number)
    {
        value *= number;
    }

    public void DivideValue(int number)
    {
        value /= number;
    }

    public void DisplayNumber(Text txt)
    {
        txt.text = value.ToString();
    }
}
