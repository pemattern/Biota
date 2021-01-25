using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Organism;

public class BoardManager : MonoBehaviour
{

    static int rows = 5; // Amount of rows and columns on the board.
    static int columns = 5;

    public float oxygenLevel; // Public variables for primary resources.
    public float mineralLevel;
    public float energyLevel;

    public int tickCounter = 0; // How many ticks have passed?

    public int trilobozoaAmount = 0; // How many of each type are currently alive?
    public int cloudinaAmount = 0;
    public int charniaAmount = 0;
    public int cyanobacteriaAmount = 0;

    public GameObject cloudinaPrefab; // Reference to the different organism prefab.
    public GameObject trilobozoaPrefab;
    public GameObject charniaPrefab;
    public GameObject cyanobacteriaPrefab;

    public GameObject organismParentObject; // Reference to the parent object for the organisms in the hierarchy (simply for tidyness).

    public GameObject colliderPrefab; // Reference to the collider prefab.
    public GameObject colliderParentObject; // Reference to the parent object for the colliders in the hierarchy (simply for tidyness).

    private GameObject[,] board = new GameObject[rows,columns]; // 2D Array of organism GameObjects.
    private GameObject[,] collidersPrefab = new GameObject[rows,columns]; // 2D Array of collider GameObjects.

    private Organism[,] organisms = new Organism[rows,columns]; // 2D Array for the organism components of the organism GameObjects.

    private float isoX; // Variables used to convert cartesian coordinates into isometric coordinates.
    private float isoY;
    private float conversion = 0.5f; // Factor used to convert (equal to width of tile / height of tile).

    private int frameCounter = 0; // Variable that counts frames.
    private int tickRate = 180; // After how many frames does the game tick?

    void Start()
    {
        for (int i=0; i<rows; i++) // For loop used to instantiate GameObjects in their arrays and at correct positions in isometric coordinates.
        {
            for (int j=0; j<columns; j++)
            {
                isoX = ((float) i+ (float) j); // Setting the corresponding isometric coordinates from cartesian coordinates
                isoY = ((-conversion* (float) i) + (conversion* (float) j));

                collidersPrefab[i,j] = (GameObject) Instantiate(colliderPrefab, new Vector3(isoX - 4f, isoY, 0), Quaternion.identity); // Instantiating the colliders and setting their names and parents (for tidyness).
                collidersPrefab[i,j].name = "OrganismPrefab " + i.ToString() + ", " + j.ToString();
                collidersPrefab[i,j].transform.parent = colliderParentObject.transform;
                collidersPrefab[i,j].GetComponent<ColliderBehavior>().posx = i;
                collidersPrefab[i,j].GetComponent<ColliderBehavior>().posy = j;

                board[i,j] = null; // An empty board.

            }
        }
    }

    void Update()
    {
        if (frameCounter < tickRate)
        {
            frameCounter++;
        }
        else
        {
            Tick();
            tickCounter++;
            frameCounter = 0;
        }
    }

    void Tick()
    {
        Debug.Log("There are " + trilobozoaAmount.ToString() + " Trilobozoas.");
        Debug.Log("There are " + cloudinaAmount.ToString() + " Cloudinas.");
    }

    public void Spawn(OrganismType organismType, int posx, int posy)
    {
        isoX = ((float) posx + (float) posy); // Setting the corresponding isometric coordinates from cartesian coordinates
        isoY = ((-conversion * (float) posx) + (conversion * (float) posy));

        if (board[posx,posy] == null) // check if there is already an organism.
        {
            if (organismType == OrganismType.Trilobozoa) // if-statement for which organism type is active.
            {
                board[posx,posy] = (GameObject) Instantiate(trilobozoaPrefab, new Vector3(isoX - 4f, isoY + 1f, 0), Quaternion.identity); // Instantiating and setting parent.
                board[posx,posy].transform.parent = organismParentObject.transform;
            }

            if (organismType == OrganismType.Cloudina) 
            {
                board[posx,posy] = (GameObject) Instantiate(cloudinaPrefab, new Vector3(isoX - 4f, isoY + 1f, 0), Quaternion.identity);  // Instantiating and setting parent.
                board[posx,posy].transform.parent = organismParentObject.transform;
            }

            if (organismType == OrganismType.Cyanobacteria) 
            {
                board[posx,posy] = (GameObject) Instantiate(cyanobacteriaPrefab, new Vector3(isoX - 4f, isoY + 1f, 0), Quaternion.identity);  // Instantiating and setting parent.
                board[posx,posy].transform.parent = organismParentObject.transform;
            }

            if (organismType == OrganismType.Charnia) 
            {
                board[posx,posy] = (GameObject) Instantiate(charniaPrefab, new Vector3(isoX - 4f, isoY + 1f, 0), Quaternion.identity);  // Instantiating and setting parent.
                board[posx,posy].transform.parent = organismParentObject.transform;
            }
        }
    }
}

