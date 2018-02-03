using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class StopVuforia : MonoBehaviour {

    public VuforiaBehaviour vuforiaB;

    private void Update()
    {
        if (vuforiaB == null)
        {
            vuforiaB = FindObjectOfType<VuforiaBehaviour>();
            vuforiaB.enabled = false;
        } 
    }
}
