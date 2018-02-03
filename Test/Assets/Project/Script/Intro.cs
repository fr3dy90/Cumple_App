using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Intro : MonoBehaviour {

    public CanvasGroup fade;
    public float secondsWait;
    bool call;
    public float fadeWait;

    private void Awake()
    {
        fade = FindObjectOfType<CanvasGroup>();
        call = true;
    }

    void Start () {
        fade.alpha = 1;
        StartCoroutine(Global_B.Fade(1, 0, fadeWait, fade));
	}
	
	void Update () {
        if (secondsWait > 0)
        {
            secondsWait -= Time.deltaTime;
        }
        else
        {
            if (call)
            {
                ChangeScene();
            }
        }
    }

    void ChangeScene()
    {
        call = false;
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return StartCoroutine(Global_B.Fade(0, 1, fadeWait, fade));
        Scene_Manager.instance.LoadScene();
    }
}
