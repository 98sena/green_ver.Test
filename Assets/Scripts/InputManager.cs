using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InputManager : MonoBehaviour
{
    public GameObject golfBall;
    public GameObject camera;
    

    float distance = (-29.49f) + (80.0f);

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
        if (slider.name == "WideLength")
        {
            Debug.Log(slider.value + "랄라");
            golfBall.transform.position = new Vector3(golfBall.transform.position.x, golfBall.transform.position.y, (-80.0f)+slider.value * distance);
            camera.transform.position = new Vector3(camera.transform.position.x, camera.transform.position.y, (-90.0f) + slider.value * distance);

        }

        //Debug.Log(slider.name)

    }

    
}
