using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(MeshRenderer))]
public class BoxController : MonoBehaviour
{
    MeshRenderer meshRenderer;
    [Range(-10,10)]public float speed = 2;
    public bool shouldFlash = true;

    public GameObject ground;

    void Start()
    {
        //MeshRenderer meshRenderer = (MeshRenderer)GetComponent("MeshRenderer"); // String interpretation @ runtime is very expensive
        //MeshRenderer meshRenderer = (MeshRenderer)GetComponent(typeof(MeshRenderer)); // We should avoid casts if we can

        meshRenderer = GetComponent<MeshRenderer>(); //The "correct" way to get a reference to another component

    }


    void Update()
    {
        
        if (meshRenderer != null && shouldFlash)
        {
            float r = Random.Range(0, 1f);
            float g = Random.Range(0, 1f);
            float b = Random.Range(0, 1f);
            meshRenderer.material.color = new Color(r, g, b);
        }

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        speed += Input.GetAxis("Mouse ScrollWheel") * 10;


        transform.position += new Vector3(h, v, 0) * Time.deltaTime * speed;
    }

    void OnDestroy()
    {

    }
}
