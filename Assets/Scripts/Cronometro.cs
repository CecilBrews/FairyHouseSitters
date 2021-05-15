using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class Cronometro : MonoBehaviour
{
    Image timerBar;
    public float maxTime = 5f;
    float timeLeft;
    public GameObject BadEnding;
    public GameObject GoodEnding;
    public GameObject cronometro;
    
    public Fungus.Flowchart myFlowchart;



    


    // Start is called before the first frame update
    void Start()
    {
        BadEnding.SetActive(false);
        timerBar = GetComponent<Image>();
        timeLeft = maxTime;
        
    }
    

    // Update is called once per frame
    void Update()


    {

        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timerBar.fillAmount = timeLeft / maxTime;
        }
        else
        {
            BadEnding.SetActive(true);
            cronometro.SetActive(false);
        }

        if(myFlowchart.GetBooleanVariable("Task1Done") && 
            myFlowchart.GetBooleanVariable("Task2Done") &&
            myFlowchart.GetBooleanVariable("Task3Done") &&
            myFlowchart.GetBooleanVariable("Task4Done") &&
            myFlowchart.GetBooleanVariable("Task5Done") &&
            myFlowchart.GetBooleanVariable("Task6Done") &&
            myFlowchart.GetBooleanVariable("Task7Done"))

        {
            GoodEnding.SetActive(true);
            cronometro.SetActive(false);

        }
    }
    
}
