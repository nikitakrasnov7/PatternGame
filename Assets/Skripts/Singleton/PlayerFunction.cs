using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class PlayerFunction : MonoBehaviour
{
    public GameDataSO gameData;

    public GameObject Player;
    public GameObject House;

    private NavMeshAgent agent;

    public List<GameObject> Eats;

    private static PlayerFunction _instance;
    public static PlayerFunction Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindAnyObjectByType<PlayerFunction>();
            }
            return _instance;
        }

    }

    private void Start()
    {
        gameData.player = Player;
        gameData.house = House;
        gameData.eats = Eats;

        agent = Player.GetComponent<NavMeshAgent>();
    }

    public void AgentGoingToHouse()
    {
        if (Player.GetComponent<NavMeshAgent>() != null)
        {
            NavMeshAgent agent = Player.GetComponent<NavMeshAgent>();
            if (House != null)
            {
                agent.destination = House.transform.position;
            }
        }

    }

    public void AgentStarted()
    {
        Player.GetComponent<NavMeshAgent>().isStopped = false;

    }
    public void AgentStopped(GameObject obstacle)
    {
        float destination = Vector3.Distance(Player.transform.position, obstacle.transform.position);
        if (destination < 2)
        {
            Player.GetComponent<NavMeshAgent>().isStopped = true;
        }
    }

    private bool test = true;
    Vector3 pointer;
    public void RandomGoingAgent()
    {
        if (test)
        {
            test = false;

            pointer = new Vector3(Player.transform.position.x + Random.Range(-5, 5), 0, Player.transform.position.z + Random.Range(-5, 5));
        }
        float distation = Vector3.Distance(Player.transform.position, pointer);
        agent.destination = pointer;
        if (distation < 1.5f)
        {
            test = true;
        }



    }



}
