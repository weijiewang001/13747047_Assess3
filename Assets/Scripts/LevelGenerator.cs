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
                    
                    r = newrow + 1;
                    c = newcolumn;

                    while (levelMap[r, c] == 2)
                    {
                        d = r + c;
                        Topleft[d].transform.rotation = Quaternion.Euler(0f, 0f, 90.0f);
                    }

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
                //for (int newrow = 0; newrow < Row; newrow++)
                //{
                //    for (int newcolumn = 0; newcolumn < Column; newcolumn++)
                //    {
                //        foreach (Transform child in transform)
                //        {
                //            if Topleft[i].GetComponent<MapGo>
                //            if (child.name == "MapTopLeft1")
                //            {

                //                child.transform.rotation = Quaternion.Euler(0f, 0f, 90.0f);
                //            }
                //        }

                //    }
                //}


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

    //}
    //private void LowerLeft()
    //{
    //    i = 1;
    //    x = -14;
    //    y = -13;
    //    for (int row = 0; row < Row - 1; row++)
    //    {
    //        for (int column = 0; column < Column; column++)
    //        {
    //            lowerLeft[i] = Instantiate(MapGameObjects[levelMap[row, column]], new Vector2(x + column, y + row), Quaternion.identity);
    //            //lowerLeft[i].transform.parent = map.transform;
    //            if (levelMap[row, column] == 5)
    //            {
    //                lowerLeft[i].transform.parent = dot.transform;
    //            }
    //            else if (levelMap[row, column] == 6)
    //            {
    //                //lowerLeft[i].transform.parent = PowerPellet.transform;
    //            }
    //            else
    //            {
    //                lowerLeft[i].transform.parent = map.transform;
    //            }
    //            lowerLeft[i].name = "MapLowerLeft" + i;
    //            if (i < lowerLeft.Length) i++;
    //        }
    //    }
    //    lowerLeft[Tjuc].GetComponent<SpriteRenderer>().flipY = true;
    //    Destroy(lowerLeft[182]);
    //    lowerLeft[182] = Instantiate(MapGameObjects[4], new Vector3(-1, -1), Quaternion.identity);
    //    lowerLeft[182].transform.parent = map.transform;
    //    lowerLeft[182].name = "MapLowerLeft182";
    //    foreach (int i in RotationLine)
    //    {
    //        if (i <= 196) lowerLeft[i].transform.Rotate(0f, 0f, -90.0f);
    //    }

    //    foreach (int i in RotationA)
    //    {
    //        lowerLeft[i].transform.Rotate(0f, 0f, 90.0f);
    //    }

    //    foreach (int i in RotationB)
    //    {
    //        lowerLeft[i].transform.Rotate(0f, 0f, 180.0f);
    //    }

    //    foreach (int i in RotationD)
    //    {
    //        lowerLeft[i].transform.Rotate(0f, 0f, -90f);
    //    }
    //}
    //private void LowerRight()
    //{
    //    i = 1;
    //    x = 13;
    //    y = -13;
    //    for (int row = 0; row < Row - 1; row++)
    //    {
    //        for (int column = 0; column < Column; column++)
    //        {
    //            lowerRight[i] = Instantiate(MapGameObjects[levelMap[row, column]], new Vector2(x - column, y + row), Quaternion.identity);
    //            if (levelMap[row, column] == 5)
    //            {
    //                lowerRight[i].transform.parent = dot.transform;
    //            }
    //            else if (levelMap[row, column] == 6)
    //            {
    //                //lowerRight[i].transform.parent = PowerPellet.transform;
    //            }
    //            else
    //            {
    //                lowerRight[i].transform.parent = map.transform;
    //            }
    //            lowerRight[i].name = "MapLowerRight" + i;
    //            if (i <= 210) i++;
    //        }
    //    }
    //    //Destroy(lowerRight[44]);
    //    lowerRight[Tjuc].GetComponent<SpriteRenderer>().flipX = true;
    //    lowerRight[Tjuc].GetComponent<SpriteRenderer>().flipY = true;
    //    Destroy(lowerRight[182]);
    //    lowerRight[182] = Instantiate(MapGameObjects[4], new Vector3(0, -1), Quaternion.identity);
    //    lowerRight[182].transform.parent = map.transform;
    //    lowerRight[182].name = "MapLowerRight182";
    //    foreach (int i in RotationLine)
    //    {
    //        if (i <= 196) lowerRight[i].transform.Rotate(0f, 0f, -90.0f);
    //    }

    //    foreach (int i in RotationA)
    //    {
    //        lowerRight[i].transform.Rotate(0f, 0f, 180.0f);
    //    }

    //    foreach (int i in RotationC)
    //    {
    //        lowerRight[i].transform.Rotate(0f, 0f, -90.0f);
    //    }
    //    foreach (int i in RotationB)
    //    {
    //        lowerRight[i].transform.Rotate(0f, 0f, 90f);
    //    }
    //}


}