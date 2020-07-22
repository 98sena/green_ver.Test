using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;

public class BollMove : MonoBehaviour
{
    public GetPower gp;
    Rigidbody rb;
    Vector3 target = new Vector3(23.4f, 6.25f, 29.49f);

    public PracticeMode pm;
    public bool succeed = false;
    Vector3 newPos;
    Vector3 beforePos = new Vector3(23.4f, 6.25f, 29.49f); //

    int cnt = 0;
    float fraction = 0.7f;
    // Start is called before the first frame update
    void Start()
    { 
        rb = transform.gameObject.GetComponent<Rigidbody>();
        newPos = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (pm.state == Progress.StateLevel.Roll)
        {
            if (gp.power <= 1)
            {
                gp.getInput = 3;
                if (Mathf.Abs(target.x-transform.position.x)<2.0f&& Mathf.Abs(target.z - transform.position.z) < 2.0f)
                {
                    succeed = true;
                }
                return;
            }
            cnt++;
            //Debug.Log(cnt+"       "+Time.deltaTime);

            newPos.z = newPos.z + Time.deltaTime * gp.power;
            
            gp.power = gp.power - Time.deltaTime * fraction * gp.power;

            transform.position = Vector3.Lerp(transform.position, newPos, 10f*Time.deltaTime);
            newPos = transform.position;
            transform.Rotate(Vector3.right * 2.0f);
            //transform.position = newPos;
            //transform.position = Vector3.Lerp(transform.position, new Vector3(23.8f,3.74f,30f), 0.1f * Time.deltaTime);
            //gp.power--;
            //beforePos = newPos;



        }
    }
}
