using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleWater : MonoBehaviour
{

    public GameObject water;

    private SpriteRenderer toggleWaterSpriteRenderer;

    public Sprite toggleWaterOn;

    public Sprite toggleWaterOff;

    private bool toggle;

    // Start is called before the first frame update
    void Start()
    {
        toggleWaterSpriteRenderer = GetComponent<SpriteRenderer>();

        toggle = true;
     }


    void OnMouseUp()
    {
        if (toggle)
        {
            toggleWaterSpriteRenderer.sprite = toggleWaterOff;

            water.GetComponent<SpriteRenderer>().color = new Color(255,255,255,0);

            toggle = false;
        }
        else
        {
            toggleWaterSpriteRenderer.sprite = toggleWaterOn;

            water.GetComponent<SpriteRenderer>().color = new Color(255,255,255,255);

            toggle = true;
        } 
    }
}
