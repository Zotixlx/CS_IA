using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

public class SimpleGen : AbstractDungonGen // How the bot will act
{

    [SerializeField]  // to view in unity inspector and able to edit from there
    protected Vector2Int startPostion = Vector2Int.zero;

    [SerializeField]  // to view in unity inspector and able to edit from there
    private int iterations = 10; // how many times the bot will walk
    [SerializeField]
    public int walkAmount = 10; // how many steps the bot will take in each iteration
    [SerializeField]
    public bool startRandomlyEachTime = true; // if true, the bot will start at a random position each time


    protected override void RunProceduralGen()
    {
        HashSet<Vector2Int> floorPositions = RunRandomWalk();
        floorVisual.Clear();
        floorVisual.PaintFloor(floorPositions);
    }

    protected HashSet<Vector2Int> RunRandomWalk() //make sure that each path is connected
    {
        var currentPosition = startPostion;
        HashSet<Vector2Int> floorPositions = new HashSet<Vector2Int>();
        for (int i = 0; i < iterations; i++)
        {
            var path = dungonsMapGen.GenerateRandomMapBot(currentPosition, walkAmount);
            floorPositions.UnionWith(path);
            if (startRandomlyEachTime)
                currentPosition = floorPositions.ElementAt(Random.Range(0, floorPositions.Count));
        }
        return floorPositions;
    }
    }
