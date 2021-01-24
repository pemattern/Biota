using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="Organism", menuName="Organism")]
public class Organism : ScriptableObject
{

    public enum OrganismType {Empty, Trilobozoa, Cloudina};

    public OrganismType organismType;

    public Sprite sprite;

    public AnimationClip animationClip;
    
}
