using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ToggleOrganismType : MonoBehaviour, IPointerClickHandler
{
    
    public GameObject boardManagerGameObject;
    public Sprite toggleOrganismTypeOn;
    public Sprite toggleOrganismTypeOff;

    private BoardManager boardManager;
    private Image toggleOrganismType;
    private string type;



    private bool toggle;

    void Start()
    {
        toggleOrganismType = GetComponent<Image>();
        boardManager = boardManagerGameObject.GetComponent<BoardManager>();

        toggle = true;

        type = "Trilobozoa";
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (toggle)
        {
            toggleOrganismType.sprite = toggleOrganismTypeOff;

            toggle = false;
        }
        else
        {
            toggleOrganismType.sprite = toggleOrganismTypeOn;

            toggle = true;
        } 
    }
}
