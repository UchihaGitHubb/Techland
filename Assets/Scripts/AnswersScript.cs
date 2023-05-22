using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswersScript : MonoBehaviour
{
    [SerializeField]
    public bool isCorrect = false;

    public QuizManager quizManager;

    public void Answer()
    {
        if(isCorrect)
        {
            Debug.Log("Correct Answer");
            quizManager.correct();

        }
        else{
            Debug.Log("Wrong Answer");
            quizManager.wrong();
        }
    }
  
}
