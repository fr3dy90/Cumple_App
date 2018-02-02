using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Global_B
{ 
	public static IEnumerator Fade(float from, float to, float speed, CanvasGroup fade)
    {
        fade.alpha = from;
        while(fade.alpha != to)
        {
            yield return null;
            fade.alpha = Mathf.MoveTowards(fade.alpha, to, Time.deltaTime / speed);
        }
    }
}
