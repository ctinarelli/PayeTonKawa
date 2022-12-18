using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject informationTextPanel;
    public GameObject quizzTextPanel;
    public GameObject player;
    public Button menuButton;

    public Sprite menuIcon;
    public Sprite closeIcon;

    private const float playerSpeed = 1.2f;
    private Vector2 movingPlayerTo;
    private bool movePlayer;
    private bool showingAMenu;

    public void ShowQuizz(GameObject quizzLocation)
    {
        if (!this.showingAMenu)
        {
            quizzLocation.GetComponent<SpriteRenderer>().color = Color.white;
            this.openAMenu();
            this.quizzTextPanel.SetActive(true);
        }
    }

    public void ShowInformation(GameObject informationLocation, string text)
    {
        if (!this.showingAMenu)
        {
            informationLocation.GetComponent<SpriteRenderer>().color = Color.red;

            this.informationTextPanel.SetActive(true);
            this.openAMenu();
            
            this.informationTextPanel.GetComponentInChildren<TextMeshProUGUI>().text = text;
        }
    }
    public void MovePlayerTo(Vector2 p)
    {
        if (!this.showingAMenu)
        {
            this.movingPlayerTo = p;
            this.movePlayer = true;
        }
    }

    void Start()
    {
        this.showingAMenu = false;
        this.movePlayer = false;
    }

    void Update()
    {
        if (this.movePlayer)
        {
            var position = Vector2.Lerp(this.player.transform.position, this.movingPlayerTo, Time.deltaTime * playerSpeed);
            this.player.transform.position = new Vector3 { x = position.x, y = position.y, z = this.transform.position.z };
            Camera.main.transform.position = new Vector3 { x = position.x, y = position.y, z = Camera.main.transform.position.z };
        }
    }

    private void openAMenu()
    {
        this.menuButton.GetComponent<Image>().sprite = this.closeIcon;
        this.showingAMenu = true;
        this.movePlayer = false;
    }

    private void closeAMenu()
    {
        this.menuButton.GetComponent<Image>().sprite = this.menuIcon;
        this.movePlayer = true;
        this.showingAMenu = false;
        this.informationTextPanel.SetActive(false);
        this.quizzTextPanel.SetActive(false);
    }

    public void onMenuButtonClick()
    {
        if (this.showingAMenu) this.closeAMenu();
        else this.openAMenu();
    }

    public void clickAnswer()
    {

    }

    public void clickValidate()
    {
        this.closeAMenu();
    }
}
