using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatus : MonoBehaviour
{
    // config params

    [Range(0.1f, 10f)] [SerializeField] float gameSpeed = 1f; // initialized at 1f; Range allows it to be a slider in the inspector in Unity
    [SerializeField] int pointsPerBlockDestroyed = 83;

    // State variables

    [SerializeField] int currentScore = 0;
    
    // Update is called once per frame
    void Update()
    {
        Time.timeScale = gameSpeed;
    }

    public void AddToScore()
    {
        currentScore += pointsPerBlockDestroyed;
    }
}
