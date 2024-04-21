using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class DynamicDepth : MonoBehaviour
{
    public Volume volume;
    DepthOfField depthOfField;
     Camera camera;
     public float valueOfBukeh;

    void Start()
    {
        camera = GetComponent<Camera>();
        if (volume == null)
        {
            Debug.LogError("Volume is not assigned to DynamicDepth script!");
            return;
        }

        volume.profile.TryGet(out depthOfField);
        if (depthOfField == null)
        {
            Debug.LogError("Depth of Field effect is not found in the assigned Volume!");
            return;
        }
    }

    void Update()
    {
        if (depthOfField != null)
        {
            // Cast a ray from the camera through the center of the screen
            Ray ray = camera.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                // Check if the hit object has a collider
                Collider collider = hit.collider;
                
                if (collider != null)
                {
                  
                    // Set the focus distance based on the hit point distance from the camera
                    float distance = Vector3.Distance(camera.transform.position, hit.point);
              
                    depthOfField.focusDistance.value = distance;
                    depthOfField.aperture.value = valueOfBukeh;

                }
            }
        }
    }
}