using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MacguffinScript : MonoBehaviour
{
    public Text interact;
    private bool inArea;
    public VictoryConditions otherscript;

    private void Start()
    {
        interact.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            interact.gameObject.SetActive(true);
            interact.text = "Press 'E' to obtain macguffin.";
            inArea = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            interact.gameObject.SetActive(false);
            inArea = false;
        }
    }

    private void Update()
    {
        if (inArea && Input.GetKeyDown(KeyCode.E))
        {
            otherscript.GetComponent<VictoryConditions>().Victory();
            Destroy(gameObject);
        }
    }
}
