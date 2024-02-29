using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class MatchBehaviour : IDContainterBehaviour
{
    
    public UnityEvent matchEvent, noMatchEvent, noMatchDelayedEvent;
    private IEnumerator OnTriggerEnter(Collider other)
    {
        Debug.Log("hit");
        var tempObj = other.GetComponent<IDContainterBehaviour>();
        if (tempObj == null) 
            yield break;
        
        var otherID = tempObj.idObj;
        if (otherID == idObj)
        {
            matchEvent.Invoke();
        }
        else
        {
            noMatchEvent.Invoke();
            yield return new WaitForSeconds(0.5f);
            noMatchDelayedEvent.Invoke();
        }
    }
}
