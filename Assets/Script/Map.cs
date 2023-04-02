using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Map : MonoBehaviour
{
    int typeBlocchi;
    public float offSet, offSetHight;

    [SerializeField] public const int sizeX = 11;
    [SerializeField] public const int sizeZ = 11;

    Vector3[,] grid = new Vector3[sizeX, sizeZ];


    [SerializeField] GameObject IronWall;
    [SerializeField] GameObject BreakWall;
    GameObject Blocco, Blocco2;

    Vector3 spawnpos;

    private void Awake()
    {
        MapStart();
    }

    private void Start()
    {

    }

    private void Update()
    {

    }

    void MapStart()
    {
        for (int x = 0; x < sizeX; x++)
        {
            for (int z = 0; z < sizeZ; z++)
            {
                spawnpos = Vector3.right * z * offSet + Vector3.forward * x * offSet + Vector3.up * offSetHight;
                grid[x, z] = spawnpos;
                Blocco2 = Instantiate(BreakWall, spawnpos, Quaternion.identity, transform);
                //typeBlocchi = Random.Range(0, 3);
                //Blocchi(typeBlocchi);
            }
        }
    }
}
