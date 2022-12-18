using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InformationLocation : MonoBehaviour
{
    public GameManager gameManager;
    public string text;

    private SpriteRenderer sprite;
    // Start is called before the first frame update
    void Start()
    {
        this.sprite = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        this.sprite.color = Color.Lerp(sprite.color, Color.white, Time.deltaTime);
    }

    private void OnMouseUp()
    {
        this.gameManager.ShowInformation(this.gameObject, this.text);
    }
}
