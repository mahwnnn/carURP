using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; // Object to rotate around
    public float rotateSpeed = 5.0f;

    private Vector3 offset;
    private bool rotating = false;
    private Vector2 lastInputPos;

    void Start()
    {
        offset = transform.position - target.position;
    }

    void LateUpdate()
    {
        
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                lastInputPos = touch.position;
                rotating = true;
            }
            else if (touch.phase == TouchPhase.Moved && rotating)
            {
                Vector2 delta = touch.position - lastInputPos;
                transform.RotateAround(target.position, Vector3.up, delta.x * rotateSpeed * Time.deltaTime);
                lastInputPos = touch.position;
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                rotating = false;
            }
        }
        else if (Input.GetMouseButtonDown(0))
        {
            lastInputPos = Input.mousePosition;
            rotating = true;
        }
        else if (Input.GetMouseButton(0) && rotating)
        {
            Vector2 delta = (Vector2)Input.mousePosition - lastInputPos;
            transform.RotateAround(target.position, Vector3.up, delta.x * rotateSpeed * Time.deltaTime);
            lastInputPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            rotating = false;
        }
    }
    
}
