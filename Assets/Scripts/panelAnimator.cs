using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panelAnimator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Panel;
    public void OpenPanel()
    {
        if (Panel != null)
        {
            Animator animator = Panel.GetComponent<Animator>();
            if (animator != null)
            {
                bool isOpen = animator.GetBool("open");
                animator.SetBool("open", !isOpen);
            }
        }
    }

}
