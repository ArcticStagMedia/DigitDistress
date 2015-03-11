using UnityEngine;
using System.Collections;

public class AgentResources:Agent {

   

    public int agentMoney { get; private set; }

	public void SetMoney(int money)
    {
        agentMoney = money;
    }
}
