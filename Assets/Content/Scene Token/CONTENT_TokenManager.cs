using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CONTENT_TokenManager : MonoBehaviour 
{
    static Vector2 worldPosition
    {
        get
        {
            return Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
    }
//    public List<CONTENT_Token> token;
    public Rigidbody2D pickup;
    public float pickupTime;
    public float pressTime;
    public bool longPress = false;
    public Vector2 initialPosition;
    public bool hasMoved;

    public void Update () 
    {
        if (Input.GetMouseButton(0))
        {
//            var tokens = GameObject.FindGameObjectsWithTag("token");

            if (Input.GetMouseButtonDown(0))
            {
                longPress = false;
                pressTime = Time.time;
                initialPosition = Input.mousePosition;
                hasMoved = false;
            }
            if (!hasMoved && (initialPosition - (Vector2)Input.mousePosition).sqrMagnitude > 4f * 4f)
            {
                hasMoved = true;

                if (Time.time - pressTime < 0.3f)
                {

                    var overlap = Physics2D.OverlapCircle(worldPosition, 0.5f);
                    if (overlap && overlap.attachedRigidbody)
                    {
                        pickup = overlap.attachedRigidbody;
                        pickupTime = Time.time;
                    }
                }
                else
                {
                    
                }
            }
//
//            if (!hasMoved && (initialPosition - (Vector2)Input.mousePosition).sqrMagnitude > 5f * 5f)
//            {
//                hasMoved = true;
//            }
//            if (!hasMoved && !longPress && Time.time - pressTime > 0.3f)
//            {
//                longPress = true;
//                LongPress();
//            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            pickup = null;
        } 
        if (pickup)
        {
            pickup.transform.position = Vector2.Lerp(pickup.transform.position, worldPosition, (Time.time - pickupTime) / 0.1f);
        }
	}

//    void LongPress()
//    {
//        var overlap = Physics2D.OverlapCircle(worldPosition, 0.5f);
//        if (overlap && overlap.attachedRigidbody)
//        {
//            pickup = overlap.attachedRigidbody;
//            pickupTime = Time.time;
//        }
//    }
}
