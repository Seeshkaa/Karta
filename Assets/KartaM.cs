using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KartaM : MonoBehaviour
{
    public GameObject Dialog1;
    private bool open = false;
    public FirstPersonMovement move;
    public FirstPersonLook camera;

    public Animation armAnim;

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
        if(!armAnim.IsPlaying("animRuk"))
            armAnim.Play("animIdle");

        if (Input.GetKeyDown("m"))
        {
            armAnim.Stop();
            armAnim.Play("animRuk");
            open = !open;
            if (open && !armAnim.IsPlaying("animRuk"))
            {  
                move.enabled = false;
                camera.enabled = false;
                Dialog1.SetActive(true);
                //KA();
            }
            else
            {
                move.enabled = true;
                camera.enabled = true;
                Dialog1.SetActive(false);
            }
        }

    }

}