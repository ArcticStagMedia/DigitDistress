using UnityEngine;
using UnityEditor;
using System.Collections;

public class GameControllerEditor : EditorWindow
{



    GameObject gameControllerObject;
    GameController gameController;
    Camera mainCamera;



    public bool isPerpetual = false;
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
<<<<<<< HEAD:Assets/GameControllerCreationPackage/Scripts/Editor/EditorScripts/GameControllerEditor.cs
        isFirstPerson = GUILayout.Toggle(isFirstPerson, "First Person Game?");
        if (isFirstPerson)
        {
            GUILayout.Label("Do you need a controller?");
            //GUILayout.
        }
        needMoney = GUILayout.Toggle(needMoney, "Need Money?");
        if (needMoney)
        {
          money = EditorGUILayout.FloatField("Starting Funds", money);
        }
        if (GUILayout.Button("Update GameController"))
        {
            gameController.isPerpetual = this.isPerpetual;
            if (needMoney)
            {
                gameController.money = this.money;
            }


=======
        if (GUILayout.Button("Update GameController"))
        {
            gameController.isPerpetual = this.isPerpetual;
>>>>>>> 336e988e8db6252dc166f02ec2aecb4fb4939293:Assets/GameControllerCreationPackage/Scripts/EditorScripts/GameControllerEditor.cs
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
