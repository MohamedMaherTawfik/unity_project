using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainImageScript : MonoBehaviour
{
    [SerializeField] private GameObject image_unknown;

    public void OnMouseDown()
    {
        if (image_unknown.activeSelf)
        {
            image_unknown.SetActive(false);
        }
    }
}