using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class LevelGenerator : MonoBehaviour
{
    public static int[,] levelMap = {
                        {1,2,2,2,2,2,2,2,2,2,2,2,2,7},
                        {2,5,5,5,5,5,5,5,5,5,5,5,5,4},
                        {2,5,3,4,4,3,5,3,4,4,4,3,5,4},
                        {2,6,4,0,0,4,5,4,0,0,0,4,5,4},
                        {2,5,3,4,4,3,5,3,4,4,4,3,5,3},
                        {2,5,5,5,5,5,5,5,5,5,5,5,5,5},
                        {2,5,3,4,4,3,5,3,3,5,3,4,4,4},
                        {2,5,3,4,4,3,5,4,4,5,3,4,4,3},
                        {2,5,5,5,5,5,5,4,4,5,5,5,5,4},
                        {1,2,2,2,2,1,5,4,3,4,4,3,0,4},
                        {0,0,0,0,0,2,5,4,3,4,4,3,0,3},
                        {0,0,0,0,0,2,5,4,4,0,0,0,0,0},
                        {0,0,0,0,0,2,5,4,4,0,3,4,4,0},
                        {2,2,2,2,2,1,5,3,3,0,4,0,0,0},
                        {0,0,0,0,0,0,5,0,0,0,4,0,0,0},
                       };
    public int Row = 15;
    public int Column = 14;
    public static int x;
    public static int y;
    private int i;
    private int r;
    private int c;
    private int d;
    private int count;
    [SerializeField] private GameObject[] MapGO = default;
    private GameObject[] Topleft = new GameObject[211];
    private static int[] NintydegreePosition = { 15, 28, 29, 42, 43, 45, 48, 50, 54, 56, 57,59,64,70, 71, 85, 99,101, 106,109, 107, 113, 120, 121, 126,127, 134,135, 140, 146, 148,154, 160, 162, 163, 174, 176, 177,190, 193, 207 };
    private static int[] NegativeNintyPosition = { 34, 40, 90, 93, 112, 132, 138 };
    private static int[] HundredeightyPosition = { 62, 68, 104, 152, 188, 191 };

    private GameObject map;
    private GameObject grid = default;


    void Awake()
    {
        map = GameObject.FindWithTag("Map");
        grid = GameObject.FindWithTag("Grid");
        TopLeft();


    }

    private void Start()
    {
        grid.SetActive(false);
    }

    private void TopLeft()
    {
        i = 1;
        x = -14;
        y = 15;

        for (int newrow = 0; newrow < Row; newrow++)
        {
            for (int newcolumn = 0; newcolumn < Column; newcolumn++)
            {
                Topleft[i] = Instantiate(MapGO[levelMap[newrow, newcolumn]], new Vector2(x + newcolumn, y - newrow), Quaternion.identity);
                Topleft[i].name = "MapTopLeft" + i;
                Topleft[i].transform.parent = gameObject.transform;
                i++;
            }
        }
        foreach (int item in NintydegreePosition)
        {
            Topleft[i].transform.rotation = Quaternion.Euler(0f, 0f, 90.0f);
        }
        foreach (int item in NegativeNintyPosition)
        {
            Topleft[i].transform.rotation = Quaternion.Euler(0f, 0f, -90.0f);
        }
        foreach(int item in HundredeightyPosition)
        {
            Topleft[i].transform.rotation = Quaternion.Euler(0f, 0f, 180.0f);
        }

    }

}



