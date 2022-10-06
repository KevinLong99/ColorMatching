using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CircleBehavior : MonoBehaviour
{

    [SerializeField]public bool isCorrect = false;

    public Sprite tick;
    public Sprite cross;
    public Sprite circle;

    public GroupCircleBehavior groupScript;

    public float changeTimer = 1.5f;

    float changeTimeOrigin = 1.5f;

    bool inCorrectAnimation = false;
    bool inWrongAnimation = false;

    bool showingCorrect = false;

    public Timer timer;

    public ScoreManager scoreManager;


    void OnMouseDown()
    {
        {
            if (isCorrect)
            {
                GetComponent<SpriteRenderer>().color = Color.HSVToRGB(0, 0, 1);
                GetComponent<SpriteRenderer>().sprite = tick;
                inCorrectAnimation = true;
                timer.Pause = true;
            }
            else if(!isCorrect)
            {
                GetComponent<SpriteRenderer>().color = Color.HSVToRGB(0, 0, 1);
                GetComponent<SpriteRenderer>().sprite = cross;
                inWrongAnimation = true;
                timer.Pause = true;
            }
        }
    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (inCorrectAnimation)
        {
            changeTimer -= Time.deltaTime;

            if(changeTimer <= 0.0f)
            {
                transitToNextCorrect();
            }
        }

        if (inWrongAnimation)
        {
            changeTimer -= Time.deltaTime;

            if (changeTimer <= 0.0f)
            {
                inWrongAnimation = false;
                groupScript.GetComponent<GroupCircleBehavior>().wrongCircleSelected = true;
            }
        }
    }

    public void transitToNextCorrect()
    {
        GetComponent<SpriteRenderer>().sprite = circle;
        inCorrectAnimation = false;
        changeTimer = changeTimeOrigin;
        groupScript.changeGroupColor();
        scoreManager.IncrementScore();
    }


    public void transitToNextWrong()
    {
            GetComponent<SpriteRenderer>().sprite = circle;
            inWrongAnimation = false;
            changeTimer = changeTimeOrigin;
            groupScript.changeGroupColor();
            scoreManager.ResetScore();
    }


    public void transitToNextWrongAlt()
    {
        GetComponent<SpriteRenderer>().sprite = circle;
        inWrongAnimation = false;
        changeTimer = changeTimeOrigin;
        scoreManager.ResetScore();
    }

     public void transitToNextWrongButton()
    {
        GetComponent<SpriteRenderer>().sprite = circle;
        inWrongAnimation = false;
        changeTimer = changeTimeOrigin;
        scoreManager.ResetScore();
    }

    public void timeOut()
    {
        groupScript.GetComponent<GroupCircleBehavior>().wrongCircleSelected = true;
    }
}
