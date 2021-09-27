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
    public static int Row = 15;
    public static int Column = 14;
    public static int x;
    public static int y;
    private int i;
    private int map1;
    private bool signal = false;
    private int r;
    private int c;
    private int d;
    private int count;
    [SerializeField]private GameObject[] MapGO = default;
    private GameObject[] Topleft = new GameObject[211];
    //private GameObject[] upperRight = new GameObject[211];
    //private GameObject[] lowerLeft = new GameObject[197];
    //private GameObject[] lowerRight = new GameObject[197];

    private GameObject map;
    private GameObject grid = default;
    

    void Awake()
    {
        map = GameObject.FindWithTag("Map");
        grid = GameObject.FindWithTag("Grid");
        UpperLeft();
        //UpperRight();
        //LowerLeft();
        //LowerRight();

    }

    private void Start()
    {
        grid.SetActive(false);
    }

    private void UpperLeft()
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

        for (int newrow = 0; newrow < Row; newrow++)
        {
            for (int newcolumn = 0; newcolumn < Column; newcolumn++)
            {
                if (levelMap[newrow, newcolumn] == 1)
                {

                    //Topleft[i].transform.rotation = Quaternion.Euler(0f, 0f, 180.0f); 
                    signal = true;
                    while (signal)
                    {
                        r = newrow + 1;
                        c = newcolumn;
                        if (levelMap[r, c] == 2)
                        {
                            d = r + c;
                            Topleft[d].transform.rotation = Quaternion.Euler(0f, 0f, 90.0f);
                            break;
                        }
                        else
                        {
                            signal = false;
                        }
                    }
                    i++;




                    //while (levelMap[r, c] == 2)
                    //{
                    //    d = r + c;
                    //    Topleft[d].transform.rotation = Quaternion.Euler(0f, 0f, 90.0f);
                    //}

                    //if (levelMap[r,c] == 2)
                    //{
                    //    d = r + c;
                    //    Topleft[d].transform.rotation = Quaternion.Euler(0f, 0f, 90.0f);
                    //}

                    //if (levelMap[r, c] == 2)
                    //{
                    //    d = r + c;
                    //    Topleft[d].transform.rotation = Quaternion.Euler(0f, 0f, 90.0f);
                    //}
                }
            }

        }


                


                //i = 1;
                //foreach (Transform child in transform)
                //{

                //    if (child.name == "MapTopLeft1")
                //    {

                //        child.transform.rotation = Quaternion.Euler(0f, 0f, 90.0f);
                //    }
                //}
                ////if (levelMap[newrow, newcolumn] == 2)
                //{
                //    newrow += 1;
                //    if (levelMap[newrow, newcolumn] == 2)
                //    {
                //        Topleft[newrow + newcolumn].transform.rotation = Quaternion.Euler(0f, 0f, 90.0f);
                //        newrow += 1;
                //    }
                //}




                //foreach (int i in NintyDegree)
                //{


                //    upperLeft[i].transform.rotation = Quaternion.Euler(0f, 0f, 90.0f);
                //}
                //foreach (int i in NegativeNintyDegree)
                //{
                //    upperLeft[i].transform.rotation = Quaternion.Euler(0f, 0f, -90.0f);
                //}
                //foreach (int i in HundredEightyDegree)
                //{
                //    upperLeft[i].transform.rotation = Quaternion.Euler(0f, 0f, 180.0f);
                //}
                //foreach (int i in NegativeNintyDegree)
                //{
                //    upperLeft[i].transform.rotation = Quaternion.Euler(0f, 0f, 270.0f);
                //}
            }
    //private void UpperRight()
    //{
    //    i = 1;
    //    x = 13;
    //    y = 15;
    //    for (int row = 0; row < Row; row++)
    //    {
    //        for (int column = 0; column < Column; column++)
    //        {
    //            upperRight[i] = Instantiate(MapGameObjects[levelMap[row, column]], new Vector2(x - column, y - row), Quaternion.identity);
    //            if (levelMap[row, column] == 5)
    //            {
    //                upperRight[i].transform.parent = dot.transform;
    //            }
    //            else if (levelMap[row, column] == 6)
    //            {
    //                //upperRight[i].transform.parent = PowerPellet.transform;
    //            }
    //            else
    //            {
    //                upperRight[i].transform.parent = map.transform;
    //            }
    //            upperRight[i].name = "MapUpperRight" + i;
    //            if (i <= 210) i++;
    //        }
    //    }
    //    foreach (int i in RotationLine)
    //    {
    //        upperRight[i].transform.Rotate(0f, 0f, -90.0f);
    //    }

    //    foreach (int i in RotationA)
    //    {
    //        upperRight[i].transform.Rotate(0f, 0f, -90.0f);
    //    }
    //    foreach (int i in RotationC)
    //    {
    //        upperRight[i].transform.Rotate(0f, 0f, 180.0f);
    //    }
    //    foreach (int i in RotationD)
    //    {
    //        upperRight[i].transform.Rotate(0f, 0f, 90f);
    //    }
    //    upperRight[Tjuc].GetComponent<SpriteRenderer>().flipX = true;



}