using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Quiz_DB : MonoBehaviour
{
     [SerializeField] private List<Question> my_questionList = null;

    private List<Question> my_backup = null;
    private void Awake()
    {
        my_backup = my_questionList.ToList();
    }

    public Question GetRandom(bool remove = true)
    {
        if (my_questionList.Count == 0)
            RestoreBackup();

        int index = Random.Range(0, my_questionList.Count);

        if(!remove)
            return my_questionList[index];

        Question q = my_questionList[(int)index];
        my_questionList.RemoveAt(index);
        return q;
    }
    private void RestoreBackup()
    {
        my_questionList = my_backup.ToList();
    }

}
