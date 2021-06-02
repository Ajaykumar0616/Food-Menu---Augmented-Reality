using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System.Collections;
public class foodselectionlogic : MonoBehaviour
{
    public GameObject food1;
    public GameObject food2;
    public GameObject food3;
    public GameObject food4;

    public int BallSelected;
    // Start is called before the first frame update
    void Start()
    {
        food1.SetActive(false);
        food2.SetActive(false);
        food3.SetActive(false);
        food4.SetActive(false);
    }

    // Update is called once per frame
    public void LoadFood1()
    {
        food1.SetActive(true);
        food2.SetActive(false);
        food3.SetActive(false);
        food4.SetActive(false);
    }

    public void LoadFood2()
    {
        food1.SetActive(false);
        food2.SetActive(true);
        food3.SetActive(false);
        food4.SetActive(false);
    }

    public void LoadFood3()
    {
        food1.SetActive(false);
        food2.SetActive(false);
        food3.SetActive(true);
        food4.SetActive(false);
    }

    public void LoadFood4()
    {
        food1.SetActive(false);
        food2.SetActive(false);
        food3.SetActive(false);
        food4.SetActive(true);
    }
}
