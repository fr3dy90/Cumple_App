using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCharacter : MonoBehaviour {

	public Character m_char;
    public GameObject model;
    
    private void Awake()
    {
        m_char = Resources.Load("Data/"+GlobalData.m_ref) as Character;
    }

    private void OnEnable()
    {
        model = Instantiate(m_char.model);
    }

    private void OnDisable()
    {
        Destroy(model);
    }
}
