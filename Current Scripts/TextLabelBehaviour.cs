using TMPro; // Import the TextMeshPro namespace
using System.Globalization;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(TextMeshProUGUI))] // Change this line to use TextMeshProUGUI
public class TextLabelBehaviour : MonoBehaviour
{
    private TextMeshProUGUI label; // Change the type to TextMeshProUGUI
    public UnityEvent startEvent;

    public void Start()
    {
        label = GetComponent<TextMeshProUGUI>(); // Change this line to use TextMeshProUGUI
        startEvent.Invoke();
    }

    public void UpdateLabel(FloatData obj)
    {
        label.text = obj.value.ToString(CultureInfo.InvariantCulture);
    }

    public void UpdateLabel(IntData obj)
    {
        label.text = obj.value.ToString(CultureInfo.InvariantCulture);
    }
}