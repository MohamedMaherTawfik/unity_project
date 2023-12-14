using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayLetters : MonoBehaviour
{
    [SerializeField] bool _upperCase;

    internal void Setletter(char letter)
    {
        if (_upperCase)
        {
            GetComponent<TMP_Text>().text = letter.ToString().ToUpper();
        }
        else
        {
            GetComponent<TMP_Text>().text = letter.ToString().ToLower();
        }
        
    }
}
