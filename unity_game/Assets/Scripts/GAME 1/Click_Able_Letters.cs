using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class Click_Able_Letters : MonoBehaviour,IPointerClickHandler
{
    char _random_letter;
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log($"Clicked on letter {_random_letter}");
        if(_random_letter == GameController.Letter)
        {
            GetComponent<TMP_Text>().color = Color.blue;
            enabled = false;
            GameController.HandleCorrectLetterClick();
            
        }
        else if ( _random_letter != GameController.Letter)
        {
            GetComponent<TMP_Text>().color = Color.red;
        }
    }

    private void Update()
    {
        
    }

    internal void Setletters(char letter)
    {
        enabled= true;
        GetComponent<TMP_Text>().color = Color.white;
        _random_letter = letter;
        if (Random.Range(0, 100) > 50)
        {
            GetComponent<TMP_Text>().text = _random_letter.ToString();
        }
        else
        {
            GetComponent<TMP_Text>().text = _random_letter.ToString().ToUpper();
        }
    }

    //private void OnEnable()
    //{

    //    int a = Random.Range(0, 26);
    //    _random_letter = (char)('a' + a);

    //    if (Random.Range(0, 100) > 50)
    //    {
    //        GetComponent<TMP_Text>().text = _random_letter.ToString();
    //    }
    //    else
    //    {
    //        GetComponent<TMP_Text>().text = _random_letter.ToString().ToUpper();
    //    }


    //}
}
