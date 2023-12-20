using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerScript : MonoBehaviour
{
    public bool iscorrect=false;
    public void Answer()
    {
        if (iscorrect)
        {
            Debug.Log("correcrAnswer");
        }
        else
        {
            Debug.Log("Wrong Answer");
        }
    }


}
