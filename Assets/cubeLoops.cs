using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeLoops : MonoBehaviour
{
    int a;
    public int myVar = 0;
    public GameObject prefab;
    public bool isPressed = false;
    // Start is called before the first frame update
    void Start()
    {
        for (var i = 0; i < 9; i++)
        {
            GameObject go = Instantiate(prefab, new Vector3(i * 5.0f, 0, 0), Quaternion.identity);
            go.GetComponent<Renderer>().material.color = GetRandomColor();
        }
    }

    Color GetRandomColor()
    {
        return new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }
    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse button Pressed.");
            isPressed = true;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                Debug.Log("Hit gameobject : " + hit.transform.gameObject.name);
            }
        }


        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("Mouse button Pressed.");
            isPressed = false;
        }
    }


}



