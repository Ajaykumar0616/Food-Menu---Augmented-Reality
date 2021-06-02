using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    public void menuDescriptor()
    {
        SceneManager.LoadScene("menuDescriptor");
    }

    
    public void livification()
    {
        SceneManager.LoadScene("livification");
    }

    public void exit()
    {
        Application.Quit();
    }
}
