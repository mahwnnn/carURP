using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
     Animator anim;
     public CameraController cameraController;
    public GameObject  freeCamText;
    void Start()
    {
        anim = GetComponent<Animator>();
        FreeCamera();
    }



    public void WheelView()
    {
        //anim.SetBool("interior",false);
        if (anim.GetBool("wheel"))
        {
            anim.SetBool("wheel",false);
        }
        else
        {
            anim.SetBool("wheel",true);
        }
   
     
    }  public void LeatherlView()
    {
       // anim.SetBool("wheel",false);
       // anim.SetBool("interior",false);
        if (anim.GetBool("leather"))
        {
            anim.SetBool("leather",false);
        }
        else
        {
            anim.SetBool("leather",true);
        }
   
     
    }
   
    public void InteriorView()
    {
       // anim.SetBool("wheel",false);
        if (anim.GetBool("interior"))
        {
            anim.SetBool("interior",false);
        }
        else
        {
            anim.SetBool("interior",true);
        }
    } 
    public void DashView()
    {
       // anim.SetBool("wheel",false);
        if (anim.GetBool("Dash"))
        {
            anim.SetBool("Dash",false);
        }
        else
        {
            anim.SetBool("Dash",true);
        }
    }
    public void ShellView()
    {
       // anim.SetBool("wheel",false);
        if (anim.GetBool("shell"))
        {
            anim.SetBool("shell",false);
        }
        else
        {
            anim.SetBool("shell",true);
        }
    }
    public void FreeCamera()
    {
        if (anim.isActiveAndEnabled)
        {
            anim.enabled = false;
            freeCamText.SetActive(true);
            cameraController.enabled = true;
        }
        else
        {
            anim.enabled = true;
            freeCamText.SetActive(false);
            cameraController.enabled = false;
        }
    }
    
}
