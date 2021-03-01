using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
    public static int lives;
    Text health;
    public VictoryConditions otherscript;

    // Declare health as the Text component
    void Start()
    {
        lives = 3;
        health = GetComponent<Text>();
    }

    // Update lives text
    void Update()
    {
        if(lives <= 0)
        {
            lives = 0;
            otherscript.GetComponent<VictoryConditions>().Loss();
        }
        health.text = "Lives: " + lives;
    }
}
