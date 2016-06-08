using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
[RequireComponent(typeof(TextMesh))]
public class CONTENT_Text : MonoBehaviour 
{
    public string sortingLayerName = "Default";
    public int orderInLayer = 0;

    #if UNITY_EDITOR
    public void Update () 
    {
        gameObject.GetComponent<MeshRenderer>().sortingLayerName = sortingLayerName;
        gameObject.GetComponent<MeshRenderer>().sortingOrder = orderInLayer;
	}
    #endif
}
