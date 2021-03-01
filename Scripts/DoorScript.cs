using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorScript : MonoBehaviour
{
    public Text interact;
    private bool inArea;

    public bool key = false;
    bool open = false;
    public float openSpeed = 0.1f;

    // Update is called once per frame
    void Update()
    {
        if (key && inArea && Input.GetKeyDown(KeyCode.E))
        {
            open = true;
            interact.text = "The door is opening...";
        }

        if (open)
        {
            transform.Translate(-Vector3.up * openSpeed * Time.deltaTime, Space.World);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            interact.gameObject.SetActive(true);
            inArea = true;
            if (open)
            {
                interact.text = "The door is opening...";
            }
            else if (key)
            {
                interact.text = "Press 'E' to unlock door.";
            }
            else
            {
                interact.text = "You need the key to open this door.";
            }
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
}
