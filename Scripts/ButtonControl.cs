
//The purpose of below code is to manage all the buttons which will appear in this project



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonControl : MonoBehaviour
{
    //Using SerializeField to see the array in Inspector View
    [SerializeField]
    GameObject[] DamageParts = new GameObject[7];

    // AccidentStatisticsButtonClick is use as a flag for toggling button
    bool AccidentStatisticsButtonClick;

    //It will get the canvas componenet of parent object 
    Canvas DamagePartCanvas;



    // Start is called before the first frame update
    void Start()
    {
        AccidentStatisticsButtonClick = true;

        // Hiding all the visible detector [red blinking cube] of damage parts
        foreach (GameObject parts in DamageParts)
        {
            parts.SetActive(false);
        }
    }

    // It will  reveal and hide all the visible detectors [red bliking cube]
    public void AccidentStatisticsButton()
    {
        if (AccidentStatisticsButtonClick == true)
        {
            AccidentStatisticsButtonClick = false;
            foreach (GameObject parts in DamageParts)
            {
                parts.SetActive(true);
            }

        }
        else
        {
            foreach (GameObject parts in DamageParts)
            {
                parts.SetActive(false);
                
            }
            AccidentStatisticsButtonClick = true;
        }

      

    }

    //this is responsible for the buttons which will appear when we click on visible detectors and get the information panel
    public void DataPanelButton()
    {
        DamagePartCanvas = EventSystem.current.currentSelectedGameObject.GetComponentInParent<Canvas>();
        DamagePartCanvas.enabled = false;
        
    }
}
