using UnityEngine;
using UnityEngine.UI;

public class IntData : ScriptableObject
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

    public void SubtrackValue(int number)
    {
        value -= number;
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
