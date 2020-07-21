using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InputManager : MonoBehaviour
{
    public GameObject golfBall;
    public GameObject camera;

    public GameObject reBall;
    public GameObject reCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void scrolling(Slider slider)
    {
        if(slider.name == "Wide Length")
        {
            // golfBall.gameObject.transform.position
        }
        Debug.Log(slider.value);
    }

    
}
