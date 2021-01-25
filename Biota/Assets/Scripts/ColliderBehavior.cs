using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Organism;

public class ColliderBehavior : MonoBehaviour
{
    private SpriteRenderer hlSpriteRenderer;

    private BoardManager boardManager;

    private GameObject organismToggleButton;

    public int posx;
    public int posy;

    void Start()
    {
        hlSpriteRenderer = GetComponent<SpriteRenderer>();

        boardManager = (BoardManager)FindObjectOfType(typeof(BoardManager));

        organismToggleButton = GameObject.Find("OrganismToggleButton");
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
        boardManager.Spawn(organismToggleButton.GetComponent<ToggleOrganismType>().activeOrganismType, posx, posy);
    }
}
