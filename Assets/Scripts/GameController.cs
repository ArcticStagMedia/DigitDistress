using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
    private GameController gameController;
    private GameObject gameControllerObject;

    public float money;        

    // Use this for initialization
    void Start()
    {
        gameControllerObject = this.gameObject;
        gameController = gameControllerObject.GetComponent<GameController>();
        money = 10000;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public float GetMoney()
    {
        return money;
    }

    public void SetMoney(float mny)
    {
        money = money + mny;
    }
}
