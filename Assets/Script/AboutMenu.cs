using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AboutMenu : MonoBehaviour
{
    private UIManager uiManager;
    [SerializeField] Canvas UI;
    [SerializeField] Canvas activeCanvas;
    //private bool isPlayerNeartheTrigger = false;

    private void Start()
    {
        
        uiManager = FindObjectOfType<UIManager>().GetComponent<UIManager>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            uiManager.currentlyActiveCanvas = activeCanvas;
            UI.enabled = true;
            uiManager.isPlayerNearTheTrigger = true;
            //isPlayerNeartheTrigger = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            UI.enabled = false;
            uiManager.isPlayerNearTheTrigger = false;
            //isPlayerNeartheTrigger = false;
        }
    }
}
