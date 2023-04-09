using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizUI : MonoBehaviour
{
    [SerializeField] private Text my_question = null;
    [SerializeField] private List<OptionButton> my_buttonList = null;
    

    public void Constructor(Question q, Action<OptionButton> callback)
    {
        my_question.text = q.text;
        for (int n = 0; n < my_buttonList.Count ; n++)
        {
            my_buttonList[n].Construtor(q.options[n], callback);
        }
    }

}
