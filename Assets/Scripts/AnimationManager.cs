using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class AnimationManager : MonoBehaviour
{
    public GameObject[] wheels;


    Animator anim;
    public CameraController cameraController;
    public GameObject freeCamText;
 

    void Start()
    {
        anim = GetComponent<Animator>();
        FreeCamera();
    }

    public void CinematicView()
    {
        anim.SetTrigger("cineView");
    } 
    public void ChnageWheels(int index)  //start with 0
    {

        for (int i = 0; i < wheels.Length; i++)
        {
            wheels[i].SetActive(false);
        }
        wheels[index].SetActive(true);
    }
    public void LipView()
    {
       
      
        if (anim.GetBool("Lip"))
        {
            anim.SetBool("Lip",false);
        }
        else
        {
            anim.SetBool("Lip",true);
        }
   
     
    } 
    public void MirrorView()
    {
       
      
        if (anim.GetBool("Mirror"))
        {
            anim.SetBool("Mirror",false);
        }
        else
        {
            anim.SetBool("Mirror",true);
        }
   
     
    } 
    public void RoofView()
    {
       
      
        if (anim.GetBool("Roof"))
        {
            anim.SetBool("Roof",false);
        }
        else
        {
            anim.SetBool("Roof",true);
        }
   
     
    } 
    public void HoodView()
    {
       
      
        if (anim.GetBool("Hood"))
        {
            anim.SetBool("Hood",false);
        }
        else
        {
            anim.SetBool("Hood",true);
        }
   
     
    } 
    public void WheelView()
    {
       
      
        if (anim.GetBool("wheel"))
        {
            anim.SetBool("wheel",false);
        }
        else
        {
            anim.SetBool("wheel",true);
        }
   
     
    } 
    public void LeatherlView()
    {
       
       
        if (anim.GetBool("leather"))
        {
            anim.SetBool("leather",false);
        }
        else
        {
            anim.SetBool("leather",true);
        }
   
      
    }
   
 
    public void DashView()
    {
       
     
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
