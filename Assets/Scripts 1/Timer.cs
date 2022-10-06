using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] public Image uiFill;
    [SerializeField] public Text uiText;

    public CircleBehavior circleBehavior;
    public int Duration;
    private int remainingDuration;

    public bool Pause;
    public bool infiniteTime = false;
    void Start()
    {
        Being(Duration);
    }

    // Update is called once per frame
    void Update()
    {
        if (infiniteTime)
        {
            remainingDuration = Duration;
        }
    }

    private void Being(int Second)
    {
        remainingDuration = Second;
        StartCoroutine(UpdateTimer());
    }

    private IEnumerator UpdateTimer()
    {
        while(remainingDuration >= 0)
        {
            if (!Pause)
            {
                uiText.text = $"{ remainingDuration % 11}";
                uiFill.fillAmount = Mathf.InverseLerp(0, Duration, remainingDuration);
                remainingDuration--;
                yield return new WaitForSeconds(1f);
            }
            yield return null;
        }
        OnEnd();
    }

    private void OnEnd()
    {
        //remainingDuration = Duration;
        StartCoroutine(UpdateTimer());
        circleBehavior.timeOut();
        Pause = true;

    }

    public void resetTime()
    {
        remainingDuration = Duration;
    }


}
