using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyScript : MonoBehaviour
{
    public float fallSpeed = 0.01f;
    public Transform lowerMarker;
    float endHeight;
    public DoorScript door;

    public Text interact;
    private bool inArea;

    private void Start()
    {
        endHeight = lowerMarker.position.y;
    }

    // Key falling down
    void Update()
    {
        if (transform.position.y > endHeight)
        {
            transform.Translate(-Vector3.up * fallSpeed * Time.deltaTime, Space.World);
        }

        if (inArea && Input.GetKeyDown(KeyCode.E))
        {
            door.GetComponent<DoorScript>().key = true;
            interact.gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            interact.gameObject.SetActive(true);
            interact.text = "Press 'E' to pick up key.";
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
}
