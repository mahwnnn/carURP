using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public Material carbonMaterial;
    
    public Material bodymaterial;
    public Material rims1material,rims2material;
    public Material brakematerial;
    public Material bodyshell;
  
    public Material carSeat;
    public Material steeringWheel;
    public Material dashboardMaterial;
    
    public Material HoodMaterial;
    public Material lipMaterial;
    public Material mirrorMaterial;
    
    public Material RoofMaterial;


    public void SetColorRoof(string message)
    {
        var parameters = JsonUtility.FromJson<HexColor>(message);
        if (parameters.hexcode.Equals("carbon"))
        {
            RoofMaterial.mainTexture = carbonMaterial.mainTexture;
            RoofMaterial.color=Color.white;
            return;   
        }
        else
        {
            RoofMaterial.mainTexture = null;
        }
        var colorCode = parameters.hexcode;
        
        Debug.Log("Color Changed");
        Color color;
        
        if (ColorUtility.TryParseHtmlString(colorCode, out color))
        {
            RoofMaterial.SetColor("_BaseColor", color);
         
            
        }
    } 
    public void SetColorHood(string message)
    {
        var parameters = JsonUtility.FromJson<HexColor>(message);
        if (parameters.hexcode.Equals("carbon"))
        {
            HoodMaterial.mainTexture = carbonMaterial.mainTexture;
            HoodMaterial.color=Color.white;
         return;   
        }
        else
        {
            HoodMaterial.mainTexture = null;
        }
        var colorCode = parameters.hexcode;
        
        Debug.Log("Color Changed");
        Color color;
        
        if (ColorUtility.TryParseHtmlString(colorCode, out color))
        {
            HoodMaterial.SetColor("_BaseColor", color);
         
            
        }
    } 
    
    public void SetColorLip(string message)
    {
        var parameters = JsonUtility.FromJson<HexColor>(message);
        if (parameters.hexcode.Equals("carbon"))
        {
            lipMaterial.mainTexture = carbonMaterial.mainTexture;
            lipMaterial.color=Color.white;
            return;   
        }
        else
        {
            lipMaterial.mainTexture = null;
        }
        var colorCode = parameters.hexcode;
        
        Debug.Log("Color Changed");
        Color color;
        
        if (ColorUtility.TryParseHtmlString(colorCode, out color))
        {
            lipMaterial.SetColor("_BaseColor", color);
         
            
        }
    } 
    
    public void SetColorMirror(string message)
    {
        var parameters = JsonUtility.FromJson<HexColor>(message);
        if (parameters.hexcode.Equals("carbon"))
        {
            mirrorMaterial.mainTexture = carbonMaterial.mainTexture;
            mirrorMaterial.color=Color.white;
            return;   
        }
        else
        {
            mirrorMaterial.mainTexture = null;
        }
        var colorCode = parameters.hexcode;
        
        Debug.Log("Color Changed");
        Color color;
        
        if (ColorUtility.TryParseHtmlString(colorCode, out color))
        {
            mirrorMaterial.SetColor("_BaseColor", color);
         
            
        }
    } 
    
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
        if (parameters.hexcode.Equals("carbon"))
        {
            bodyshell.mainTexture = carbonMaterial.mainTexture;
            bodyshell.color=Color.white;
            return;   
        }
        else
        {
            bodyshell.mainTexture = null;
        }
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
