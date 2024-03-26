using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class PlayerUI : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI promptText;

    internal void UpdateText(string promptMessage)
    {
        promptText.text = promptMessage;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }
 
}
