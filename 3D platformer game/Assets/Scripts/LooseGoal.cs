using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LooseGoal : MonoBehaviour
{
    public PlayerStats playerStats;
    public Loose loose;


    private void OnEnable()
    {
       

    }



    private void OnDisable()
    {
        playerStats = null;
        loose = null;

    }
}