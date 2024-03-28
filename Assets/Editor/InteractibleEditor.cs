using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Interactible),true)]
public class InteractibleEditor : Editor
{
    public override void OnInspectorGUI()
    {
        Interactible interactible = (Interactible)target;
        if (target.GetType() == typeof(EventOnlyInteractible))
        {
            interactible.promtMessage = EditorGUILayout.TextField("Prompt Message",interactible.promtMessage);
            EditorGUILayout.HelpBox("EventOnlyInteract can ONLY use UnityEvents.",MessageType.Info);
            if (interactible.GetComponent<InteractionEvent>() == null)
            {
                interactible.useEvents = true;
                interactible.gameObject.AddComponent<InteractionEvent>();
            }
        }
        else
        {
            base.OnInspectorGUI();
            if (interactible.useEvents)
            {
                if (interactible.GetComponent<InteractionEvent>() == null)
                {
                    interactible.gameObject.AddComponent<InteractionEvent>();
                }
            }
            else
            {
                if (interactible.GetComponent<InteractionEvent>() != null)
                {
                    DestroyImmediate(interactible.GetComponent<InteractionEvent>());
                }
            }
        }
    }
}
