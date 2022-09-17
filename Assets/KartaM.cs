using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KartaM : MonoBehaviour
{
    public GameObject Dialog1;
    private bool open = false;
    public GameObject move;
    public Camera camera;

    //public Animator anim;
    //private float animationInterpolation = 1f;

    //void KA()
    //{
    //    animationInterpolation = Mathf.Lerp(animationInterpolation, 1f, Time.deltaTime * 3);
    //}


    void Start()
    {
        
    }

    void Update()
    {
        
        if (Input.GetKeyDown("m"))
        {
            open = !open;
            if (open)
            {
                move.GetComponent<FirstPersonMovement>().enabled = false;
                camera.GetComponent<FirstPersonLook>().enabled = false;
                Dialog1.SetActive(true);
                //KA();
            }
            else
            {
                move.GetComponent<FirstPersonMovement>().enabled = true;
                camera.GetComponent<FirstPersonLook>().enabled = true;
                Dialog1.SetActive(false);
            }
        }

    }
}

