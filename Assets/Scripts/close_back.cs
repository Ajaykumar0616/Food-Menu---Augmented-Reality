using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class close_back : MonoBehaviour
{
    // Start is called before the first frame update
    public void backbtn()
    {
        SceneManager.LoadScene("SampleScene");
    }

    // Update is called once per frame
    public void closebtn()
    {
        Application.Quit();
        Debug.Log("Exit");
    
    }
}
