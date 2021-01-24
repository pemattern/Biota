using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ToggleWater : MonoBehaviour, IPointerClickHandler
{

    public GameObject water;

    private Image toggleWaterImage;

    public Sprite toggleWaterOn;

    public Sprite toggleWaterOff;

    private bool toggle;

    // Start is called before the first frame update
    void Start()
    {
        toggleWaterImage = GetComponent<Image>();

        toggle = true;
     }


    public void OnPointerClick(PointerEventData eventData)
    {
        if (toggle)
        {
            toggleWaterImage.sprite = toggleWaterOff;

            water.GetComponent<SpriteRenderer>().color = new Color(255,255,255,0);

            toggle = false;
        }
        else
        {
            toggleWaterImage.sprite = toggleWaterOn;

            water.GetComponent<SpriteRenderer>().color = new Color(255,255,255,255);

            toggle = true;
        } 
    }
}
