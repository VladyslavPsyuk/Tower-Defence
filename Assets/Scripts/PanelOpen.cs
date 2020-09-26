using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpen : MonoBehaviour
{
    public GameObject InformationPanel;
    public GameObject ActivationFramePanel;


    public void OpenPanel ()
    {
        if (InformationPanel != null )
        {
            bool isActive = InformationPanel.activeSelf;
            InformationPanel.SetActive(!isActive); 
        }
        if (ActivationFramePanel != null)
        {
            bool isActive = ActivationFramePanel.activeSelf;
            ActivationFramePanel.SetActive(!isActive);
        }
    }
}
