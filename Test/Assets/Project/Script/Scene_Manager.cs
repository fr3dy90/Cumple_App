using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Manager : MonoBehaviour {

    public static Scene_Manager instance;
    public string sceneName;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

   public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
