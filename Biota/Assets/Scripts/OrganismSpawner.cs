using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrganismSpawner : MonoBehaviour
{
    
    public GameObject boardManagerGameObject;
    public int cartPosX;
    public int cartPosY;

    private BoardManager boardManager;
    private Organism organism;
    private SpriteRenderer spriteRenderer;
    private Animator animator;


    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        boardManager = boardManagerGameObject.GetComponent<BoardManager>();
    }

    public void Spawn(string type)
    {
        if (type == "Trilobozoa")
        {
            organism = Resources.Load<Organism>("Trilobozoa");
            spriteRenderer.sprite = organism.sprite;
            animator.Play("Trilobozoa");

            boardManager.PlaceOrganism(cartPosX, cartPosY, type);
        }
    }
}
