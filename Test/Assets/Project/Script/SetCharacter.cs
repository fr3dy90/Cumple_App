using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCharacter : MonoBehaviour {

    public void SetChar(GameObject go)
    {
        GlobalData.m_ref = go.name;
        Scene_Manager.instance.LoadScene();
    }
}
