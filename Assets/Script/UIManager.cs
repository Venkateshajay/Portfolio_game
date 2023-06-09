using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public bool isPlayerNearTheTrigger = false;
    [SerializeField] Button enterButton;
    public Canvas currentlyActiveCanvas;
    [SerializeField] Image[] educationPanels;
    [SerializeField] Image[] projectPanels;
    private int educationPanelIndex=0;
    private int projectPanelIndex=0;
    // Start is called before the first frame update
    public void TurnOnOffCanvas(bool OnorOff)
    {
        if (OnorOff)
        {
            enterButton.gameObject.SetActive(false);
            currentlyActiveCanvas.enabled = true;
            if(currentlyActiveCanvas.name == "ProjectsCanvas")
            {
                TurnOnOffPanels(projectPanelIndex, projectPanels);
            }
        }
        else
        {
            enterButton.gameObject.SetActive(true);
            currentlyActiveCanvas.enabled = false;
        }
        
    }

    public void NextPanel(int indexOfPanel)
    {
        if (indexOfPanel == 0)
        {
            educationPanelIndex = IndexHandler(educationPanelIndex,educationPanels.Length,true);
            TurnOnOffPanels(educationPanelIndex, educationPanels);
        }
        else if(indexOfPanel == 1)
        {
            projectPanelIndex = IndexHandler(projectPanelIndex, projectPanels.Length,true);
            TurnOnOffPanels(projectPanelIndex, projectPanels);
        }
    }

    private void TurnOnOffPanels(int index,Image[] array)
    {
        for(int i = 0; i < array.Length; i++)
        {
            array[index].gameObject.SetActive(true);
            if (i == index)
            {
                continue;
            }
            else
            {
                array[i].gameObject.SetActive(false);
            }
        }
    }

    public void PreviousPanel(int indexOfPanel)
    {
        if (indexOfPanel == 0)
        {
            educationPanelIndex = IndexHandler(educationPanelIndex, educationPanels.Length, false);
            TurnOnOffPanels(educationPanelIndex, educationPanels);
        }
        else if (indexOfPanel == 1)
        {
            projectPanelIndex = IndexHandler(projectPanelIndex, projectPanels.Length, false);
            TurnOnOffPanels(projectPanelIndex, projectPanels);
        }

    }

    private int IndexHandler(int index, int length,bool increment)
    {
        if (increment)
        {
            if (index < length)
            {
                index++;
            }
            if (index == length)
            {
                index = 0;
            }
        }
        else
        {
            if (index >= 0)
            {
                index--;
            }
            if(index == -1)
            {
                index = length - 1;
            }
        }
       
        return index;
    }

    public void OpenURL(string link)
    {
        Application.OpenURL(link);
    }

}
