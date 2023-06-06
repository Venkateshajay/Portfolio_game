using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public bool isPlayerNearTheTrigger = false;
    [SerializeField] Button enterButton;
    public Canvas currentlyActiveCanvas;
    // Start is called before the first frame update
    public void TurnOnOffCanvas(bool OnorOff)
    {
        if (OnorOff)
        {
            enterButton.gameObject.SetActive(false);
            currentlyActiveCanvas.enabled = true;
        }
        else
        {
            enterButton.gameObject.SetActive(true);
            currentlyActiveCanvas.enabled = false;
        }
        
    }

}
