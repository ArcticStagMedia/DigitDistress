using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour
{
    #region GameController boolDeclarations
    public bool isPerpetual;
    public bool isFirstPerson;
    public bool isThirdPerson;
    public bool needMoney;
    public bool needRecources = true;
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

    public List<GameObject> m_lAllowedBuildings;
    public List<string> RecourceNames;


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
        }
        else if (level == 0)
        {

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
        if (BuildingManager.m_lBuildingPrefabs.Capacity == 0)
        {
            BuildingManager.setAllowedBuildings(m_lAllowedBuildings);
        }

        if (Application.loadedLevel == 1)
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            this.transform.parent = player.transform;
        }
        else if (Application.loadedLevel == 0)
        {
            this.transform.parent = null;
        }
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
