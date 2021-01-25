using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using static Organism;

public class ToggleOrganismType : MonoBehaviour, IPointerClickHandler
{
    
    public GameObject boardManagerGameObject;
    public Sprite toggleOrganismTypeOn;
    public Sprite toggleOrganismTypeOff;

    public OrganismType activeOrganismType;

    private BoardManager boardManager;
    private Image toggleOrganismType;

    private int toggle;

    void Start()
    {
        toggleOrganismType = GetComponent<Image>();
        boardManager = boardManagerGameObject.GetComponent<BoardManager>();

        toggle = 0;

        activeOrganismType = OrganismType.Trilobozoa;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        toggle++;
        if (toggle > 3)
        {
            toggle = 0;
        }

        switch (toggle)
        {
            case 0:
                activeOrganismType = OrganismType.Trilobozoa;
                break;

            case 1:
                activeOrganismType = OrganismType.Cloudina;
                break;

            case 2:
                activeOrganismType = OrganismType.Cyanobacteria;
                break;

            case 3:
                activeOrganismType = OrganismType.Charnia;
                break;
            
            default:
                break;
        }
        
    }
}
