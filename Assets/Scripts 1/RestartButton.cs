using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class RestartButton : MonoBehaviour
{
    // Start is called before the first frame update

    public CircleBehavior circle;

    public Button restartButton;

    public ScoreManager scoreManager;

    public GameObject level;

    private bool inLevel = false;

    public Text generalText;

    public Timer timer;
    public GameObject theTimer;

    public GroupCircleBehavior groupCircle;

    public GameObject Score;
    public GameObject Record;

    public void restartLevel()
    {
        circle.transitToNextWrongButton();
        string currentScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentScene);
    }

    public void resetRecord()
    {
        scoreManager.ResetRecord();
        string currentScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentScene);
    }


    public void generalButton()
    {
        if (!inLevel)//menu screen to gameplay
        {
            //timer.Pause = false;
            Score.SetActive(true);
            Record.SetActive(true);
            theTimer.SetActive(true);
            timer.infiniteTime = false;
            level.SetActive(true);
            //timer.resetTime();
            inLevel = true;
            generalText.text = "Restart";
        }
        else //gameplay screen to menu
        {
            Score.SetActive(false);
            Record.SetActive(false);
            //timer.Pause = true;
            theTimer.SetActive(false);
            circle.transitToNextWrongButton();
            string currentScene = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentScene);

            timer.infiniteTime = true;
            level.SetActive(false);
            timer.resetTime();
            circle.transitToNextWrong();
            inLevel = false;
            generalText.text = "Play";

        }
    }

    public void startGame()
    {
        level.SetActive(true);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
