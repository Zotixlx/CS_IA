using UnityEngine;

public abstract class AbstractDungonGen : MonoBehaviour
{
    [SerializeField]
    protected FloorVisual floorVisual = null;
    [SerializeField]
    protected Vector2Int startPosition = Vector2Int.zero;


    public void GenerateDungeon()
    {
        floorVisual.Clear();
        RunProceduralGen();

    }

    protected abstract void RunProceduralGen();
}
