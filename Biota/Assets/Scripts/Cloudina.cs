using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Organism;

public class Cloudina : MonoBehaviour
{
    private int lifetime = 3; // How many ticks alive?
    private int startingTickCounter; // How many ticks at the start of its lifetime?

    private OrganismType organismType = OrganismType.Cloudina;

    private BoardManager boardManager;

    void Start()
    {
        boardManager = (BoardManager)FindObjectOfType(typeof(BoardManager));
        startingTickCounter = boardManager.tickCounter;

        boardManager.cloudinaAmount++;
    }

    // Update is called once per frame
    void Update()
    {
        if (startingTickCounter + lifetime == boardManager.tickCounter)
        {
            boardManager.cloudinaAmount--;
            Destroy(gameObject);
        }
    }
}
