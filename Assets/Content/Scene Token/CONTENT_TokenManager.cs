using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CONTENT_TokenManager : MonoBehaviour 
{
//    public List<CONTENT_Token> token;

    public void Update () 
    {
        if (Input.GetMouseButton(0))
        {
            var tokens = GameObject.FindGameObjectsWithTag("token");

            if (Input.GetMouseButtonDown(0))
            {
            }
        }
	}
}
