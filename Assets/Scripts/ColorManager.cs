using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public Material bodymaterial;
    public Material rimsmaterial;
    public Material brakematerial;
    public Material bodyshell;
    public Material passengerLeather;
    public Material mainCarLeather;


    public void SetColorMainSeat(string message)
    {
        var parameters = JsonUtility.FromJson<HexColor>(message);
   
        var colorCode = parameters.hexcode;
        
        Debug.Log("Color Changed");
        Color color;
        
        if (ColorUtility.TryParseHtmlString(colorCode, out color))
        {
            mainCarLeather.SetColor("_BaseColor", color);
            
        }
    }
    public void SetColorPassengerSeat(string message)
    {
        var parameters = JsonUtility.FromJson<HexColor>(message);
   
        var colorCode = parameters.hexcode;
        
        Debug.Log("Color Changed");
        Color color;
        
        if (ColorUtility.TryParseHtmlString(colorCode, out color))
        {
            passengerLeather.SetColor("_BaseColor", color);
            
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
            rimsmaterial.SetColor("_BaseColor", color);
            
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
