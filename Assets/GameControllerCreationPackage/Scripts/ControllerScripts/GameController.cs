using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
    #region GameController boolDeclarations
    public bool isPerpetual;
    public bool isFirstPerson;
    public bool isThirdPerson;
    public bool needMoney;
    public bool needRecources;
    public bool needAccess;
    public bool needCamera;
    public bool needPlayerHealth;
    public bool needPlayerMana;
    public bool needEnemies;
    public bool needEnemyHealth;
    public bool needEnemyMana;
    #endregion

    #region GameController IntDeclarations
    public int amountOfDiffrentRecources;
    public int playerHealth;
    public int playerMana;
    public int enemyHealth;
    public int enemyMana;
    #endregion

    public float money;

    public AudioListener gameAudio;
    public AudioSource gameMusic;
    public AudioSource soundEffects;



    void OnLevelWasLoaded(int level)
    {
        if (level == 1)
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            this.transform.parent = player.transform;
        }else if (level == 0)
        {
            this.transform.parent = null;
        }
    }

    void Awake()
    {
        if (isPerpetual)
        {
            DontDestroyOnLoad(transform.gameObject);
        }
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void setPerpetual(bool perpetual)
    {
        isPerpetual = perpetual;
    }

    #region GameController MainMenuStuff
    public Canvas MainMenu;
    public Canvas Instructions;

    public void SelectScene()
    {
        Application.LoadLevel(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ShowInstructions()
    {
        MainMenu.enabled = false;
        Instructions.enabled = true;
    }

    public void ShowMainMenu()
    {
        MainMenu.enabled = true;
        Instructions.enabled = false;
    }
    #endregion

}
