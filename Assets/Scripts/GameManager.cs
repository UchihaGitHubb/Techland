using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


[RequireComponent(typeof(AudioSource))]
public class GameManager : MonoBehaviour
{
    [SerializeField] private AudioClip my_correctSound = null;
    [SerializeField] private AudioClip my_incorrectSound = null;
    [SerializeField] private Color my_correctColor = Color.black;
    [SerializeField] private Color my_incorrectColor = Color.black;
    [SerializeField] private float my_waitTime = 0.0f;

    private Quiz_DB my_quizDB = null;
    private QuizUI my_quizUI = null;
    private AudioSource my_audioSource = null;

    private void Start()
    {
        my_quizDB = GameObject.FindObjectOfType<Quiz_DB>();
        my_quizUI = GameObject.FindObjectOfType<QuizUI>();
        my_audioSource = GetComponent<AudioSource>();

        NextQuestion();

    }

    private void NextQuestion()
    {
        my_quizUI.Constructor(my_quizDB.GetRandom(), GiveAnswer);

    }
    private void GiveAnswer(OptionButton optionButton)
    {
        StartCoroutine(GiveAnswerRoutine(optionButton));
    }

    private IEnumerator GiveAnswerRoutine(OptionButton optionButton)
    {
        if (my_audioSource.isPlaying)
            my_audioSource.Stop();

        my_audioSource.clip = optionButton.Option.correct ? my_correctSound : my_incorrectSound;
        optionButton.SetColor(optionButton.Option.correct ? my_correctColor : my_incorrectColor);
        my_audioSource.Play();


        yield return new WaitForSeconds(my_waitTime);

        if (optionButton.Option.correct)
            NextQuestion();

        else
            GameOver();
    }

    private void GameOver()
    {

        SceneManager.LoadScene(3);
    }
        
}


