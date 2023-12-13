using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveBetweenScences : MonoBehaviour
{
    public void Game1(string scencesname )
    {
        SceneManager.LoadScene( scencesname );
    }
    
}
