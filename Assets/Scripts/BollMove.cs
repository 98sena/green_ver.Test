using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;

public class BollMove : MonoBehaviour
{
    public GetPower gp;
    Rigidbody rb;
    Vector3 target = new Vector3(-0.615f, 2.705f, 29.275f);

    public PracticeMode pm;
    public bool succeed = false;
    Vector3 newPos;

    int cnt = 0;
    float friction = 0.7f;
    // Start is called before the first frame update
    void Start()
    { 
        rb = transform.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (pm.state == Progress.StateLevel.Roll)
        {
            //if (Mathf.Abs(target.x - transform.position.x) < 1.5f && Mathf.Abs(target.z - transform.position.z) < 1.5f)
            //{
            //    succeed = true;
            //    Debug.Log("succceees");
            //    return;
            //}

            if (gp.power <= 1)
            {
                gp.getInput = 3;
                if (Mathf.Abs(target.x - transform.position.x) < 1.5f && Mathf.Abs(target.z - transform.position.z) < 1.5f)
                {
                    succeed = true;
                    Debug.Log("succceees");
                }
                return;
            }
            cnt++;
            //Debug.Log(cnt+"       "+Time.deltaTime);

            //newPos.z = newPos.z + Time.deltaTime * gp.power;
            //transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + Time.deltaTime * gp.power);
            transform.position += new Vector3(0, 0, Time.deltaTime * gp.power);


            gp.power = gp.power - Time.deltaTime * friction * gp.power;
            transform.Rotate(Vector3.right * gp.power);
            //transform.position = newPos;
            //transform.position = Vector3.Lerp(transform.position, new Vector3(23.8f,3.74f,30f), 0.1f * Time.deltaTime);
            //gp.power--;
            //beforePos = newPos;



        }
    }
}
