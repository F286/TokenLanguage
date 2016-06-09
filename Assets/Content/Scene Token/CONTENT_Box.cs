using UnityEngine;
using System.Collections;

public class CONTENT_Box : MonoBehaviour 
{
    public Vector2 localSize = new Vector2(5, 5);
    public Vector2 pivot = new Vector2(0, 0);

    public Vector2 size
    {
        get
        {
            return localSize;
//            var p = transform.parent ? transform.parent.GetComponentInParent<CONTENT_Box>() : null;
//            print(p);
//            if (p)
//            {
//                var r = p.size;
//                r.Scale(localSize);
//                return r;
//            }
//            else
//            {
//                return localSize;
//            }
        }
    }
}
