using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFunction : MonoBehaviour
{
    public GameDataSO gameData;

    public GameObject Player;
    public GameObject House;
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
    }

    
}
