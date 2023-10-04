using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    // Cube location
    public Vector3 position = new Vector3(0.0f, 0.0f, 0.0f);
    // Cube size
    public Vector3 scale = new Vector3(1.0f, 1.0f, 1.0f);
    

    void Start()
    {
        transform.position = position;
        transform.localScale = scale;

        Material material = Renderer.material;

        material.color = new Color(0.5f, 1.0f, 0.3f, 0.4f);
    }

    void Update()
    {
        transform.Rotate(10.0f * Time.deltaTime, 0.0f, 0.0f);
    }
}
