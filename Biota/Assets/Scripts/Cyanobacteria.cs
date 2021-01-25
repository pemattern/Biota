using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Organism;

public class Cyanobacteria : MonoBehaviour
{
    private int lifetime = 8; // How many ticks alive?
    private int startingTickCounter; // How many ticks at the start of its lifetime?

    private OrganismType organismType = OrganismType.Cyanobacteria;

    private BoardManager boardManager;

    void Start()
    {
        boardManager = (BoardManager)FindObjectOfType(typeof(BoardManager));
        startingTickCounter = boardManager.tickCounter;

        boardManager.cyanobacteriaAmount++;
    }

    // Update is called once per frame
    void Update()
    {
        if (startingTickCounter + lifetime == boardManager.tickCounter)
        {
            boardManager.cyanobacteriaAmount--;
            Destroy(gameObject);
        }
    }
}
