using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Money : MonoBehaviour
{

    private GameController gameController;
    private GameObject gameControllerObject;
    private float money;
    private string bytes = "Bytes: ";

    public Text txtMoney;

    void Start()
    {
        gameControllerObject = GameObject.FindGameObjectWithTag("GameController");
        gameController = gameControllerObject.GetComponent<GameController>();
    }

    void Update()
    {
        money = gameController.GetMoney();
        txtMoney.text = bytes + money;
    }
}
