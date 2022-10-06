using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GroupCircleBehavior : MonoBehaviour
{
    public GameObject circle1;
    public GameObject circle2;
    public GameObject circle3;
    public GameObject circle4;

    public float tempColor1;
    public float tempColor2;
    public float tempColor3;

    int randomCircle;

    public bool wrongCircleSelected = false;
    public bool showingCorrectCircle = false;

    public Sprite tick;
    public Sprite cross;
    public Sprite circle;

    public float changeTimer = 1.5f;

    float changeTimeOrigin = 1.5f;

    public ScoreManager scoreManager;
    public Timer timer;
    // Start is called before the first frame update
    void Start()
    {
        changeGroupColor();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            string currentScene = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentScene);
        }

        if (wrongCircleSelected)
        {
            if (randomCircle == 1)
            {
                circle1.GetComponent<SpriteRenderer>().sprite = tick;
                changeTimer -= Time.deltaTime;

                if (changeTimer <= 0.0f)
                {
                    wrongCircleSelected = false;
                    //circle1.GetComponent<CircleBehavior>().transitToNextCorrect();
                    //circle2.GetComponent<CircleBehavior>().transitToNextWrongAlt();
                    //circle3.GetComponent<CircleBehavior>().transitToNextWrongAlt();
                    //circle4.GetComponent<CircleBehavior>().transitToNextWrongAlt();
                    changeTimer = changeTimeOrigin;
                }
            } else
            if (randomCircle == 2)
            {
                circle2.GetComponent<SpriteRenderer>().sprite = tick;
                changeTimer -= Time.deltaTime;

                if (changeTimer <= 0.0f)
                {
                    wrongCircleSelected = false;
                    //circle1.GetComponent<CircleBehavior>().transitToNextWrongAlt();
                    //circle2.GetComponent<CircleBehavior>().transitToNextCorrect();
                    //circle3.GetComponent<CircleBehavior>().transitToNextWrongAlt();
                    //circle4.GetComponent<CircleBehavior>().transitToNextWrongAlt();
                    changeTimer = changeTimeOrigin;
                }
            }else
            if (randomCircle == 3)
            {
                circle3.GetComponent<SpriteRenderer>().sprite = tick;
                changeTimer -= Time.deltaTime;

                if (changeTimer <= 0.0f)
                {
                    wrongCircleSelected = false;
                    //circle1.GetComponent<CircleBehavior>().transitToNextWrongAlt();
                    //circle2.GetComponent<CircleBehavior>().transitToNextWrongAlt();
                    //circle3.GetComponent<CircleBehavior>().transitToNextCorrect();
                    //circle4.GetComponent<CircleBehavior>().transitToNextWrongAlt();
                    changeTimer = changeTimeOrigin;
                }
            }else
            if (randomCircle == 4)
            {
                circle4.GetComponent<SpriteRenderer>().sprite = tick;
                changeTimer -= Time.deltaTime;

                if (changeTimer <= 0.0f)
                {
                    wrongCircleSelected = false;
                    //circle1.GetComponent<CircleBehavior>().transitToNextWrongAlt();
                    //circle2.GetComponent<CircleBehavior>().transitToNextWrongAlt();
                    //circle3.GetComponent<CircleBehavior>().transitToNextWrongAlt();
                    //circle4.GetComponent<CircleBehavior>().transitToNextCorrect();
                    changeTimer = changeTimeOrigin;
                }
            }

        }
    }

    public void changeGroupColor()
    {
        timer.resetTime();
        timer.Pause = false;
        RandomizeColor();

        if (randomCircle == 1)
        {

            circle1.GetComponent<SpriteRenderer>().color = Color.HSVToRGB(tempColor1 - 0.15f, tempColor2 - 0.15f, tempColor3);
            circle2.GetComponent<SpriteRenderer>().color = Color.HSVToRGB(tempColor1, tempColor2, tempColor3);
            circle3.GetComponent<SpriteRenderer>().color = Color.HSVToRGB(tempColor1, tempColor2, tempColor3);
            circle4.GetComponent<SpriteRenderer>().color = Color.HSVToRGB(tempColor1, tempColor2, tempColor3);
            circle1.GetComponent<CircleBehavior>().isCorrect = true;
            circle2.GetComponent<CircleBehavior>().isCorrect = false;
            circle3.GetComponent<CircleBehavior>().isCorrect = false;
            circle4.GetComponent<CircleBehavior>().isCorrect = false;
        } else if (randomCircle == 2)
        {
            circle1.GetComponent<SpriteRenderer>().color = Color.HSVToRGB(tempColor1, tempColor2, tempColor3);
            circle2.GetComponent<SpriteRenderer>().color = Color.HSVToRGB(tempColor1 - 0.15f, tempColor2 - 0.15f, tempColor3);
            circle3.GetComponent<SpriteRenderer>().color = Color.HSVToRGB(tempColor1, tempColor2, tempColor3);
            circle4.GetComponent<SpriteRenderer>().color = Color.HSVToRGB(tempColor1, tempColor2, tempColor3);
            circle1.GetComponent<CircleBehavior>().isCorrect = false;
            circle2.GetComponent<CircleBehavior>().isCorrect = true;
            circle3.GetComponent<CircleBehavior>().isCorrect = false;
            circle4.GetComponent<CircleBehavior>().isCorrect = false;
        }
        else if (randomCircle == 3)
        {
            circle1.GetComponent<SpriteRenderer>().color = Color.HSVToRGB(tempColor1, tempColor2, tempColor3);
            circle2.GetComponent<SpriteRenderer>().color = Color.HSVToRGB(tempColor1, tempColor2, tempColor3);
            circle3.GetComponent<SpriteRenderer>().color = Color.HSVToRGB(tempColor1 - 0.15f, tempColor2 - 0.15f, tempColor3);
            circle4.GetComponent<SpriteRenderer>().color = Color.HSVToRGB(tempColor1, tempColor2, tempColor3);
            circle1.GetComponent<CircleBehavior>().isCorrect = false;
            circle2.GetComponent<CircleBehavior>().isCorrect = false;
            circle3.GetComponent<CircleBehavior>().isCorrect = true;
            circle4.GetComponent<CircleBehavior>().isCorrect = false;
        } else if (randomCircle == 4)
        {
            circle1.GetComponent<SpriteRenderer>().color = Color.HSVToRGB(tempColor1, tempColor2, tempColor3);
            circle2.GetComponent<SpriteRenderer>().color = Color.HSVToRGB(tempColor1, tempColor2, tempColor3);
            circle3.GetComponent<SpriteRenderer>().color = Color.HSVToRGB(tempColor1, tempColor2, tempColor3);
            circle4.GetComponent<SpriteRenderer>().color = Color.HSVToRGB(tempColor1 - 0.15f, tempColor2 - 0.15f, tempColor3);
            circle1.GetComponent<CircleBehavior>().isCorrect = false;
            circle2.GetComponent<CircleBehavior>().isCorrect = false;
            circle3.GetComponent<CircleBehavior>().isCorrect = false;
            circle4.GetComponent<CircleBehavior>().isCorrect = true;
        }

        /*
       circle1.GetComponent<SpriteRenderer>().color = Color.HSVToRGB(tempColor1, tempColor2, tempColor3);
       circle2.GetComponent<SpriteRenderer>().color = Color.HSVToRGB(tempColor1, tempColor2, tempColor3);
       circle3.GetComponent<SpriteRenderer>().color = Color.HSVToRGB(tempColor1, tempColor2, tempColor3);
       circle4.GetComponent<SpriteRenderer>().color = Color.HSVToRGB(tempColor1, tempColor2, tempColor3);

       //circle1.GetComponent<SpriteRenderer>().color =new Color (Random.Range(0f, 256f), Random.Range(0f, 256f), Random.Range(0f, 256f));
       circle1.GetComponent<SpriteRenderer>().color = Random.ColorHSV();
       circle2.GetComponent<SpriteRenderer>().color = Random.ColorHSV();
       circle3.GetComponent<SpriteRenderer>().color = Random.ColorHSV();
       circle4.GetComponent<SpriteRenderer>().color = Random.ColorHSV();
       circle1.GetComponent<SpriteRenderer>().color = new Color(tempColor1, tempColor2, tempColor3);
       circle2.GetComponent<SpriteRenderer>().color = new Color(tempColor1, tempColor2, tempColor3);
       circle3.GetComponent<SpriteRenderer>().color = new Color(tempColor1, tempColor2, tempColor3);
       circle4.GetComponent<SpriteRenderer>().color = new Color(tempColor1, tempColor2, tempColor3);
       */
    }

    public void RandomizeColor()
    {
         tempColor1 = Random.Range(0f, 1f);
         tempColor2 = Random.Range(0f, 1f);
         tempColor3 = Random.Range(0f, 1f);

         randomCircle = Random.Range(1, 5);

    }
}
