using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCharacter : MonoBehaviour {

    public static SelectCharacter instance;
	public Character m_char;
    public GameObject model;
    
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        m_char = Resources.Load("Data/"+GlobalData.m_ref) as Character;
    }

    public void OnTrackeableFound()
    {
        model = Instantiate(m_char.model);
    }

    public void OnTrackeableLost()
    {
        Destroy(model);
    }
}
