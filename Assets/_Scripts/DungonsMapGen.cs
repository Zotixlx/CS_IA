using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public static class dungonsMapGen // Code for Procedural Generation of a 2D Dungeon
{
    public static HashSet<Vector2Int> GenerateRandomMapBot(Vector2Int startPostition, int walkAmount) //This generates a random walk path for the bot to make a dungeon map
    {
        HashSet<Vector2Int> path = new HashSet<Vector2Int>();
        path.Add(startPostition);
        var previousPosition = startPostition;
        for (int i = 0; i < walkAmount; i++)
        {
            var newPosition = previousPosition + Direction2D.GetRandomDirection();
            path.Add(newPosition);
            previousPosition = newPosition;
        }
        return path;
    }
}

public static class Direction2D //directions for the bot to walk
{
    public static List<Vector2Int> cardinalDirectionsList = new List<Vector2Int>
    {
        new Vector2Int(0,1), //up
        new Vector2Int(1,0), //right
        new Vector2Int(0,-1), //down
        new Vector2Int(-1,0) //left
    };
    public static Vector2Int GetRandomDirection()
    {
        return cardinalDirectionsList[Random.Range(0, cardinalDirectionsList.Count)];
    }
}