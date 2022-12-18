using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    // Start is called before the first frame update
    public GameManager gameManager;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButton(0))
        {
            var worldMousePosition = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
            this.gameManager.MovePlayerTo(worldMousePosition);
        }
    }
}
