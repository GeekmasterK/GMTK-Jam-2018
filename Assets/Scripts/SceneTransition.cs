using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour {
    //public Animator sceneAnim;
    public string sceneName;

    Scene currentScene;

	// Use this for initialization
	void Start ()
    {
        currentScene = SceneManager.GetActiveScene();
        if(currentScene.name == "_InitScene")
        {
            SceneManager.LoadScene(sceneName);
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    /*IEnumerator LoadScene()
    {
        sceneAnim.SetTrigger("end");
        yield return new WaitForSeconds(0.15f);
        SceneManager.LoadScene(sceneName);
    }*/
}
