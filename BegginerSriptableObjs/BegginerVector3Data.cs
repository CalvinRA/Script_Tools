using UnityEngine;
using UnityEngine.UI;

public class BegginerVector3Data : ScriptableObject
{
    public Vector3 position;

    public void SetPosition(float x, float y, float z)
    {
        position = new Vector3(x, y, z);
    }

    public void ChangePosition(float x, float y, float z)
    {
        position = position + new Vector3(x, y, z);
    }
    
    public void DisplayPosition(Text txt)
    {
        txt.text = position.ToString();
    }

    public void DisplayX(Text txt)
    {
        txt.text = position.x.ToString();
    }

    public void DisplayY(Text txt)
    {
        txt.text = position.y.ToString();
    }

    public void DisplayZ(Text txt)
    {
        txt.text = position.z.ToString();
    }
}
