using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public int totalscore;
    public GameObject panel1, panel2, panel3,panel4,panel5;
    public GameObject q1, q2, q3,q4,q5;
    public TMP_Text sumscore;
    public bool done;
    void Start()
    {
        done = false;
    }

    // Update is called once per frame
    void Update()
    {
        CheckPanelActivation(panel1);
        CheckPanelActivation(panel2);
        CheckPanelActivation(panel3);
        CheckPanelActivation(panel4);
        CheckPanelActivation(panel5);
        CheckQuestionAnswer(q1);
        CheckQuestionAnswer(q2);
        CheckQuestionAnswer(q3);
        CheckQuestionAnswer(q4);
        CheckQuestionAnswer(q5);

        sumscore.text = totalscore.ToString() + " / 5";
    }
    void CheckPanelActivation(GameObject panel)
    {
        if (panel.activeSelf && !done)
        {
            IncreaseScore();
        }
    }
    void CheckQuestionAnswer(GameObject question)
    {
        if (question.activeSelf && done)
        {
            done = false;
        }
    }
    void IncreaseScore()
    {
        totalscore++;
        done = true;
    }
}