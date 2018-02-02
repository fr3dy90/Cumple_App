using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class Intro : MonoBehaviour {

    public CanvasGroup fade;
    public VuforiaBehaviour vuforiaB;
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
		if(vuforiaB == null)
        {
            vuforiaB = FindObjectOfType<VuforiaBehaviour>();
            vuforiaB.enabled = false;
        }
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
        print("Change");
    }
}
