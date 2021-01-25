using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Organism : MonoBehaviour
{

    public enum OrganismType {Empty, Trilobozoa, Cloudina, Cyanobacteria, Charnia};

    public OrganismType organismType;
 
    void Start()
    {
        organismType = OrganismType.Empty;
    }
   
}
