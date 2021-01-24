using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="Organism", menuName="Organism")]
public class Organism : ScriptableObject
{

    public string type;
    public Sprite sprite;
    public AnimationClip animationClip;
    
}
