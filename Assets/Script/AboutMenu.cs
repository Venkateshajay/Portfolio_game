using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AboutMenu : MonoBehaviour
{
    [SerializeField] Canvas UI, AboutCanvas;
    private bool isPlayerNeartheTrigger = false;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            isPlayerNeartheTrigger = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            isPlayerNeartheTrigger = false;
        }
    }

    private void Update()
    {
        if(isPlayerNeartheTrigger)
        {
            UI.enabled = true;
        }
        if (Input.GetKey(KeyCode.Return) && isPlayerNeartheTrigger)
        {
            AboutCanvas.enabled = true;
            Time.timeScale = 0;
        }
    }
}
