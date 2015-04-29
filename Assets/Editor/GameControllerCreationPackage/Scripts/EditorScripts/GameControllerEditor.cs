using UnityEngine;
using UnityEditor;
using System.Collections;

public class GameControllerEditor : EditorWindow
{


    #region GameController boolDeclarations
    public bool isPerpetual = false;
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
    public int amountOfDiffrentRecources = 0;
    public int playerHealth = 0;
    public int playerMana = 0;
    public int enemyHealth = 0;
    public int enemyMana = 0;
    #endregion

    public float money = 0;

    public AudioListener gameAudio;
    public AudioSource gameMusic;
    public AudioSource soundEffects;


    GameObject gameControllerObject;
    GameController gameController;
    Camera mainCamera;



    bool gameControllerPlacedInScene = false;

    // Use this for initialization
    void OnEnable()
    {
        if (!GameObject.FindGameObjectWithTag("GameController"))
        {
            gameControllerObject = Resources.Load<GameObject>("GameController");
        }
        else if (GameObject.FindGameObjectWithTag("GameController"))
        {
            gameControllerPlacedInScene = true;
        }
    }

    void Update()
    {
        if (!GameObject.FindGameObjectWithTag("GameController"))
        {
            gameControllerObject = Resources.Load<GameObject>("GameController");
        }
        else if (GameObject.FindGameObjectWithTag("GameController"))
        {
            gameControllerPlacedInScene = true;
        }

        if (gameControllerPlacedInScene)
        {
            gameControllerObject = GameObject.FindGameObjectWithTag("GameController");
            gameController = gameControllerObject.GetComponent<GameController>();
            mainCamera = Camera.main;
        }
    }

    [MenuItem("Game Controller Package/Editor")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow(typeof(GameControllerEditor), true);
    }

    void OnGUI()
    {
        GUILayout.Label("Controller Settings", EditorStyles.boldLabel);

        if (GUILayout.Button("Add GameController"))
        {
            if (!GameObject.FindGameObjectWithTag("GameController"))
            {

                Instantiate(gameControllerObject, Vector3.zero, Quaternion.identity);
                GameObject objectToRename = GameObject.FindGameObjectWithTag("GameController");
                objectToRename.gameObject.name = "GameController";
                if (mainCamera.GetComponent<AudioListener>())
                {
                    DestroyImmediate(mainCamera.GetComponent<AudioListener>());
                }
                else
                {
                    Debug.Log("No audio listener on main camera");
                }
            }
            else if (GameObject.FindGameObjectWithTag("GameController"))
            {
                AlredyInUsePopup.ShowWindow();
                Debug.LogError("You already have a \"GameController\"");
            }
            else
            {
                Debug.LogError("Something went wrong with tag \"GameController\"");
            }

        }

        isPerpetual = GUILayout.Toggle(isPerpetual, "Perpetual GameController?");
        needMoney = GUILayout.Toggle(needMoney, "Need Money?");
        if (needMoney)
        {
           EditorGUILayout.FloatField("Starting Funds", money);
        }
        if (GUILayout.Button("Update GameController"))
        {
            gameController.isPerpetual = this.isPerpetual;

        }
    }
}

public class AlredyInUsePopup : EditorWindow
{
    public static void ShowWindow()
    {
        var window = new AlredyInUsePopup();
        window.position = new Rect(Screen.width / 2, Screen.height / 2, 250, 75);
        window.ShowPopup();
        //EditorWindow.GetWindow(typeof(AlredyInUsePopup), true);
    }

    void OnGUI()
    {
        GUILayout.Label("There is already a \n\"GameController\" \nin the scene!");
        if (GUILayout.Button("Ok"))
        {
            Close();
        }
    }
}
