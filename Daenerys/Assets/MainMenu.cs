using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void DarkSide()
    {
        SceneManager.LoadScene("Level2");
    }
    public void BrightSide()
    {
        SceneManager.LoadScene("Level1");
    }
    


}
