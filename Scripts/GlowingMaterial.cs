
//Below code is responsible for blinking the visible detectors of damaged parts



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowingMaterial : MonoBehaviour
{

    //this bool value will help in lerping back and forth
    bool flag=true;

    // Material of the visible detectors 
    Material SelfMaterial;

    //It will work as gradually decreasing and gradually increasing float for interpolated value 
    float t = 0;


    // Start is called before the first frame update
    void Start()
    {
        SelfMaterial = this.GetComponent<MeshRenderer>().material;
    }



    //
    // It updates on every frame
    private void Update()
    {
       
        Color lerpedColor = Color.Lerp(Color.grey, Color.red,t);
        SelfMaterial.color= lerpedColor;


        //it will change value of t (interpolain value) gradually in order to give fade in and fade out effect
        if (flag == true)
        {
            t -= Time.deltaTime /2;
            if (t < 0.01f)
                flag = false;
        }
        else
        {
            t += Time.deltaTime/2;
            if (t > 0.99f)
                flag = true;
        }
    }


}
