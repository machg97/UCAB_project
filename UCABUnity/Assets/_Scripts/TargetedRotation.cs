using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetedRotation : MonoBehaviour
{
    
    public Transform target;

    public float rotationSpeed;
    public ForwardSide forwardSide;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vectorToTarget = target.position - transform.position;

        float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg - AngleOffset();

        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);

        transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * rotationSpeed);
    }

    private float AngleOffset()
    {
        float AngularOffset = 0f;

        switch (forwardSide)
        {
            case ForwardSide.Top:
                AngularOffset = 90f;
                break;

            case ForwardSide.Right:
                AngularOffset = 0f;
                break;

            case ForwardSide.Buttom:
                AngularOffset = 270f;
                break;

            case ForwardSide.Left:
                AngularOffset = 180f;
                break;

        }

        return AngularOffset;
    }



    public enum ForwardSide
    {
        Top,
        Right,
        Buttom,
        Left
    }
}
