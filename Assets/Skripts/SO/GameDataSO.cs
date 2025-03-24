
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "StateGame/Data/DataGame", fileName = "Data Game")]
public class GameDataSO : ScriptableObject
{
    public GameObject player;
    public GameObject house;
    public List<GameObject> eats = new List<GameObject>();
}
