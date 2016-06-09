using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class CONTENT_NineBox : MonoBehaviour 
{
//    public Vector2 size = new Vector2(1, 1);
    public Color color = Color.white;
    public int orderInLayer = 0;
    public float outer = 0.5f;
    public float inner = 1f;
    public SpriteRenderer[] sprites;

    public void LateUpdate()
    {
        if (sprites.Length != 9)
        {
            return;
        }
        var box = GetComponentInParent<CONTENT_Box>();

        if (box == null)
        {
            return;
        }
        var size = box.size;
        var offset = -box.pivot;
        offset.Scale(size);
//        print(size);

        var lef = outer;
        var cen = inner;
        var rig = outer;

        var top = outer;
        var mid = inner;
        var bot = outer;

        var cenSize = size.x - lef - rig;
        var midSize = size.y - top - bot;

        sprites[0].transform.localPosition = new Vector2(0,             0) + offset;
        sprites[1].transform.localPosition = new Vector2(lef,           0) + offset;
        sprites[2].transform.localPosition = new Vector2(lef + cenSize, 0) + offset;

        sprites[3].transform.localPosition = new Vector2(0,             top) + offset;
        sprites[4].transform.localPosition = new Vector2(lef,           top) + offset;
        sprites[5].transform.localPosition = new Vector2(lef + cenSize, top) + offset;

        sprites[6].transform.localPosition = new Vector2(0,             top + midSize) + offset;
        sprites[7].transform.localPosition = new Vector2(lef,           top + midSize) + offset;
        sprites[8].transform.localPosition = new Vector2(lef + cenSize, top + midSize) + offset;

        var cenScale = cenSize / cen;
        var midScale = midSize / mid;

        sprites[1].transform.localScale = new Vector3(cenScale, 1,          1);
        sprites[3].transform.localScale = new Vector3(1,        midScale,   1);
        sprites[4].transform.localScale = new Vector3(cenScale, midScale,   1);
        sprites[5].transform.localScale = new Vector3(1,        midScale,   1);
        sprites[7].transform.localScale = new Vector3(cenScale, 1,          1);

        for (int i = 0; i < sprites.Length; i++)
        {
            sprites[i].color = color;
            sprites[i].sortingOrder = orderInLayer;
        }
    }
}
