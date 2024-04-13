using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public Material bodymaterial;
    public Material rims1material,rims2material;
    public Material brakematerial;
    public Material bodyshell;
  
    public Material carSeat;
    public Material steeringWheel;
    public Material dashboardMaterial;


    public void SetColorSeats(string message)
    {
        var parameters = JsonUtility.FromJson<HexColor>(message);
   
        var colorCode = parameters.hexcode;
        
        Debug.Log("Color Changed");
        Color color;
        
        if (ColorUtility.TryParseHtmlString(colorCode, out color))
        {
            carSeat.SetColor("_BaseColor", color);
         
            
        }
    } 
    public void SetColorDashboard(string message)
    {
        var parameters = JsonUtility.FromJson<HexColor>(message);
   
        var colorCode = parameters.hexcode;
        
        Debug.Log("Color Changed");
        Color color;
        
        if (ColorUtility.TryParseHtmlString(colorCode, out color))
        {
            dashboardMaterial.SetColor("_BaseColor", color);
         
            
        }
    }  
    public void SetColorSteering(string message)
    {
        var parameters = JsonUtility.FromJson<HexColor>(message);
   
        var colorCode = parameters.hexcode;
        
        Debug.Log("Color Changed");
        Color color;
        
        if (ColorUtility.TryParseHtmlString(colorCode, out color))
        {
            steeringWheel.SetColor("_BaseColor", color);

        }
    }
  
    public void SetColorToShell(string message)
    {
        var parameters = JsonUtility.FromJson<HexColor>(message);
   
        var colorCode = parameters.hexcode;
        
        Debug.Log("Color Changed");
        Color color;
        
        if (ColorUtility.TryParseHtmlString(colorCode, out color))
        {
            bodyshell.SetColor("_BaseColor", color);
            
        }
    }
   public  void SetColorToBody(string message)
    {
      var parameters = JsonUtility.FromJson<HexColor>(message);
   
        var colorCode = parameters.hexcode;
        
        Debug.Log("Color Changed");
        Color color;
        
        if (ColorUtility.TryParseHtmlString(colorCode, out color))
        {
            bodymaterial.SetColor("_BaseColor", color);
            
        }
    } 
   public  void SetColorToRims(string message)
    {
   
       
        var parameters = JsonUtility.FromJson<HexColor>(message);
        var colorCode = parameters.hexcode;
        
        Debug.Log("Color Changed");
        Color color;
        
        if (ColorUtility.TryParseHtmlString(colorCode, out color))
        {
            rims1material.SetColor("_BaseColor", color);
            rims2material.SetColor("_BaseColor", color);
            
        }
    } 
   public  void BrakeColor(string message)
    {
     
        var parameters = JsonUtility.FromJson<HexColor>(message);
        var colorCode = parameters.hexcode;
        
        Debug.Log("Color Changed");
        Color color;
        
        if (ColorUtility.TryParseHtmlString(colorCode, out color))
        {
            brakematerial.SetColor("_BaseColor", color);
            
        }
    }
}
