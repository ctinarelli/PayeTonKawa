using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizzLocation : MonoBehaviour
{
    public GameManager gameManager;

    private SpriteRenderer sprite;
    // Start is called before the first frame update
    void Start()
    {
        this.sprite = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        this.sprite.color = Color.Lerp(sprite.color, Color.red, Time.deltaTime);
    }

    private void OnMouseUp()
    {
        this.gameManager.ShowQuizz(this.gameObject);
    }
}
