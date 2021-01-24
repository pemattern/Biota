using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderBehavior : MonoBehaviour
{
    public GameObject organismHolder;
    private SpriteRenderer hlSpriteRenderer;
    private OrganismSpawner organismSpawner;

    void Start()
    {
        hlSpriteRenderer = GetComponent<SpriteRenderer>();
        organismSpawner = organismHolder.GetComponent<OrganismSpawner>();
    }

    void OnMouseOver()
    {
        hlSpriteRenderer.sortingOrder = 7;
    }

    void OnMouseExit()
    {
        hlSpriteRenderer.sortingOrder = 1;
    }

    void OnMouseUp()
    {
        organismSpawner.Spawn("Trilobozoa");
    }
}
