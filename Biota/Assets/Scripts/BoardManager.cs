using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{

    public static int rows = 5;
    public static int columns = 5;

    private string[,] board = new string[rows,columns];

    void Start()
    {
        for (int i=0; i<rows; i++)
        {
            for (int j=0; j<columns; j++)
            {
                board[i,j] = "Empty";
            }
        }
    }

    public void PlaceOrganism(int posx, int posy, string type)
    {
        board[posx, posy] = type;

        Debug.Log(board[posx, posy]+" was played at "+posx.ToString()+", "+posy.ToString()+".");
    }

    public bool BoardSpaceEmpty(int posx, int posy)
    {
        if (board[posx,posy] == "Empty")
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}
