using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonlistener : MonoBehaviour {

    public string infiniteLevel;
	
	public void newgame() {

        SceneManager.LoadScene(infiniteLevel);

    }
	
	
}
