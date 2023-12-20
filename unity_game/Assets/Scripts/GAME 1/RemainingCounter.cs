using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RemainingCounter : MonoBehaviour
{
    internal void setremaining(int remaining)
    {
        GetComponent<TMP_Text>().text = "x" + remaining;
    }
}
