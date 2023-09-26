using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loose : MonoBehaviour
{
    public GameObject loosePanel;
    public LooseGoal looseGoalScript;

    private bool gameEnded;

    public void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LooseLevel()
    {
        if (!gameEnded)
        {
            Debug.Log("You Loose!");
            gameEnded = true;
        }

    }
}
