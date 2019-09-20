using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorApplicator : MonoBehaviour
{
    public Color Tint;
    Renderer r;

    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Renderer>() ?? GetComponentInChildren<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        r.material.SetColor("_Tint", Tint);
    }
}
