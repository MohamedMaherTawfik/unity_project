using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
    public List<QuistionsAndAnswer> QnA;
    public GameObject[] options;
    public int currentQuestion;

    public GameObject quizpanel;

    public GameObject retrypanel;

    public Text QuestionTxt;
    public Text ScoreText;

    int TotalQuestions=0;
    public int score;

    private void Start()
    {
        TotalQuestions = QnA.Count;
        generateQuestions();
        quizpanel.SetActive(true);
        retrypanel.SetActive(false);
    }

    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    void GameOver()
    {
        quizpanel.SetActive(false);
        ScoreText.text = score + "/" + TotalQuestions;
    }

    public void correct()
    {
        score += 1;
        QnA.RemoveAt(currentQuestion);
        generateQuestions();
    }

    public void wrong()
    {
        QnA.RemoveAt(currentQuestion);
        generateQuestions();
    }

    private void setAnswers()
    {
        for (int i=0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswerScript>().iscorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];

            if (QnA[currentQuestion].CorrectAnswer == i+1)
            {   
                options[i].GetComponent<AnswerScript>().iscorrect = true;

            }
        }
    }


    void generateQuestions()
    {
        if(QnA.Count > 0)
        {
            currentQuestion = Random.Range(0, QnA.Count);
            QuestionTxt.text = QnA[currentQuestion].Question;
            setAnswers(); 
        }
        else
        {
            Debug.Log("Out of Quetions"); 
            GameOver();
        }
        
    }
}
