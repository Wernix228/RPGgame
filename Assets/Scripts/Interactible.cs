using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactible : MonoBehaviour
{
    public bool useEvents;
    [SerializeField]
    public string promtMessage;

    public virtual string OnLook()
    {
        return promtMessage;
    }
    public void BaseInteract()
    {
        if (useEvents)
        {
            GetComponent<InteractionEvent>().OnInteract.Invoke();
        }
        Interact();
    }
    protected virtual void Interact()
    {
        
    }
    
}
