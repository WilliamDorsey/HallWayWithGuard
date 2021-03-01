using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VictoryConditions : MonoBehaviour
{
    Text outcome;
    // Start is called before the first frame update
    void Start()
    {
        outcome = GetComponent<Text>();
        outcome.text = "";
    }

    // Update is called once per frame
    public void Victory()
    {
        outcome.color = Color.yellow;
        outcome.text = "YOU WIN";
        SceneManager.LoadScene("Win Screen");
    }

    public void Loss()
    {
        outcome.text = "YOU LOSE";
        SceneManager.LoadScene("Lose Screen");
    }
}
