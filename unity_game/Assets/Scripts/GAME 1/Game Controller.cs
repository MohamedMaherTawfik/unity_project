using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static char Letter='a';

    static int Correct_Answers = 5;
    static int _CorrectClicks;
    private void OnEnable()
    {
        GenerateBoard();
        updateDisplayLetters();
    }

    private static void GenerateBoard()
    {
        var Clickables = FindObjectsOfType<Click_Able_Letters>();

        List<char> Charslist = new List<char>();

        for (int i = 0; i < Correct_Answers; i++)
            Charslist.Add(Letter);
        
        for (int i = Correct_Answers; i < Clickables.Length; i++)
        {
           var Chossenletter = ChosseInvalidRandomLetter();
           Charslist.Add(Chossenletter);
        }

        Charslist = Charslist.OrderBy(t => UnityEngine.Random.Range(0, 10000)).ToList();

        for (int i = 0; i < Clickables.Length; i++)
        {
            Clickables[i].Setletters(Charslist[i]);
        }
        FindObjectOfType<RemainingCounter>().setremaining(Correct_Answers - _CorrectClicks);
    }

    private static char ChosseInvalidRandomLetter()
    {
        int a = UnityEngine.Random.Range(0, 26);
        var random_letter = (char)('a' + a);
        while(random_letter==Letter )
        {
            a = UnityEngine.Random.Range(0, 26);
            random_letter = (char)('a' + a);
        }

        return random_letter;   
    }

    internal static void HandleCorrectLetterClick()
    {
        _CorrectClicks++;
        FindObjectOfType<RemainingCounter>().setremaining(Correct_Answers - _CorrectClicks);
        if (_CorrectClicks >= Correct_Answers)
        {
            Letter++;
            updateDisplayLetters();
            _CorrectClicks = 0;
            GenerateBoard();
        }

    }

    private static void updateDisplayLetters()
    {
        foreach (var displayletter in FindObjectsOfType<DisplayLetters>())
        {
            displayletter.Setletter(Letter);
        }
    }
}
