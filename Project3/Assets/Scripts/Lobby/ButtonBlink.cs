using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBlink : MonoBehaviour
{
    public Color startColor = Color.green;
    public Color endColor = Color.black;
    [Range(0,10)]
    public float speed = 1;
 
    Renderer ren;
 
    void Awake()
    {
        ren = GetComponent<Renderer>();
    }
 
    void Update()

    {   if(ButtonFixtureInteractable.BlinkNow==true){ 
            if(HolographManController.ButtonPressedOnce ==false){ 
                ren.material.color = Color.Lerp(startColor, endColor, Mathf.PingPong(Time.time * speed, 1));
        } 
    
    }
    }

}
