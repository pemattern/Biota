using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHighlight : MonoBehaviour
{

    private SpriteRenderer hlSpriteRenderer;

    void Start()
    {
        hlSpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void OnMouseOver()
    {
        hlSpriteRenderer.sortingOrder = 7;
    }

    // Update is called once per frame
    void OnMouseExit()
    {
        hlSpriteRenderer.sortingOrder = 1;
    }
}
