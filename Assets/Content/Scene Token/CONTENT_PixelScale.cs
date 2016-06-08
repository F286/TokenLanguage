using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class CONTENT_PixelScale : MonoBehaviour 
{
    public void Update()
    {
        var s = (Camera.main.orthographicSize * 100f) / Screen.height;
        transform.localScale = new Vector3(s, s, 1);
    }
}
