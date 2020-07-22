using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PracticeMode : Progress
{
    public GameObject selectButtons;
    public GameObject startButtons;
    public GameObject readyButtons;
    public GetPower gp;
    
    public BollMove bm;

    public GameObject endButtons;
    public GameObject againUI;

    public int hitCount = 0;
    int practiceCount;

    public Text hitCntObj;
    public Text practiceCntObj;

    public GameObject ball;
    public GameObject startPos;
    public GameObject cameraPos;
    public GameObject startCameraPos;


    // Start is called before the first frame update
    void Start()
    {
        state = 0;
        practiceCount = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        hitCntObj.text = "" + hitCount;
        practiceCntObj.text = "" + (practiceCount + 1);
        run(state);
    }

    public override void startState()
    {
        if (!startButtons.activeSelf)
        {
            startButtons.SetActive(true);
        }
        if (againUI.activeSelf)
        {
            StartCoroutine(WaitForNotice());
        }
        if (endButtons.activeSelf)
        {
            endButtons.SetActive(false);
        }
        Debug.Log("START STATE");
    }
    public void gotoReady()
    {
        if (selectButtons.activeSelf)
        {
            selectButtons.SetActive(false);
        }
        nextState();
    }
   
    IEnumerator WaitForNotice()
    {
        yield return new WaitForSeconds(1.0f);
        againUI.SetActive(false);
    }
    public override void readyState()
    {
        
        
        if (!readyButtons.activeSelf)
        {
            Debug.Log("Hi Start");
            readyButtons.SetActive(true);
        }
        if (startButtons.activeSelf)
        {
            Debug.Log("bye Start");
            startButtons.SetActive(false);
        }
        
        Debug.Log("ready");
        if (gp.getInput == 2)
        {
            nextState();
        }
    }
    //각도 조절
    public void leftbutton()
    {
        
    }
    private void rightbutton()
    {

    }
    public override void rollState()
    {
        if (gp.getInput == 3)
        {
          
            Debug.Log("BYE ROLL");
            gp.getInput = 0;
            nextState();
            if (readyButtons.activeSelf)
            {
                readyButtons.SetActive(false);
            }
        }
    }
    public override void endState()
    {
        Debug.Log("END STATE");
        if (bm.succeed)
        {
            
            endButtons.SetActive(true);
        }
        else
        {
            if (!endButtons.activeSelf)
            {
                againUI.SetActive(true);
            }
            nextState();
        }
    }

    public void oneMore()
    {
        practiceCount++;
        hitCount = 0;
        nextState();
        if (!selectButtons.activeSelf)
        {
            selectButtons.SetActive(true);
        }
        ball.transform.position = startPos.transform.position;
        cameraPos.transform.position = startCameraPos.transform.position;
        bm.succeed = false;
    }
}
