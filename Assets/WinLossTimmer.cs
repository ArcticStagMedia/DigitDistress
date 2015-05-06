using UnityEngine;
using System.Collections;

public class WinLossTimmer : MonoBehaviour
{
    public int cycles;
    public float AprRating;
    public GameObject cyclesObject;
    CycleScenario cycleCode;
    public GameObject ApprovalRating;
    ApprovalRatingScript aprScript;


    // Use this for initialization
    void Start()
    {
        cyclesObject = GameObject.FindGameObjectWithTag("CycleManager");
        cycleCode = cyclesObject.GetComponent<CycleScenario>();
        ApprovalRating = GameObject.FindGameObjectWithTag("ApprovalRatting");
        aprScript = ApprovalRating.GetComponent<ApprovalRatingScript>();

    }

    // Update is called once per frame
    void Update()
    {
        cycles = cycleCode.setCycles();
        AprRating = aprScript.FillCurrent;
        WinLoseStatment(cycles, AprRating);
    }

    public void WinLoseStatment(int cyc, float apr)
    {
        if (cyc >= 10)
        {
            if (apr <= 0)
            {
                Application.LoadLevel(2);
            }
            else if (apr > 0)
            {
                Application.LoadLevel(3);
            }
        }
    }
}
