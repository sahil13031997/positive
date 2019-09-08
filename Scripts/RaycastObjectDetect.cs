
//Below program is responsible to detect the visible detectors using raycast method and show the information panel on click




using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastObjectDetect : MonoBehaviour
{
    //Ray which will hit visible detector 
    Ray ray;

    //it will hold the information of visible detector which ray will hit 
    RaycastHit hit;

    //Canvas which contatin the information panel
    Canvas DamagePartCanvas;


    // below code will detect visible detectors  and enable the particular information panel
    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            if(Physics.Raycast(ray,out hit, Mathf.Infinity))
            {
               // Debug.Log(hit.transform.name);
                DamagePartCanvas= hit.transform.gameObject.GetComponentInChildren<Canvas>();
                DamagePartCanvas.enabled = true;
            }
        }

    }
}
