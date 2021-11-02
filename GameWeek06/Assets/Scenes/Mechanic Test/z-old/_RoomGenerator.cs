using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _RoomGenerator : MonoBehaviour
{
    public class Cell
    {
        public bool visited = false;
        public bool[] status = new bool[4];
    }

    [System.Serializable]
    public class Rule
    {
        public GameObject room;
        public Vector2Int minPosition;
        public Vector2Int maxPosition;

        public bool obligatory;

        public int ProbabilityofSpawning(int x, int y)
        {
            //0 - cannot spaen 1- can spawn 2 - Has to spawn
            if(x >= minPosition.x && x<=maxPosition.x && y >= minPosition.y && y <= maxPosition.y)
            {
                return obligatory ? 2 : 1;
            }

                return 0;
        }
    }



    public Vector2Int size;
    public int startPos = 0;

    public Rule[] rooms;
    public Vector2 offset;

    List<Cell> board;


    void Start()
    {
        MazeGenerator();
    }


    void Update()
    {
        
    }

    void GenerateTomb()
    {
        for(int i = 0; i < size.x; i++)
        {
            for(int j = 0; j < size.y; j++)
            {
                //not square maze
                Cell currentCell = board[(i + j * size.x)];
                if (currentCell.visited)
                {
                    int randomRoom = -1;
                    List<int> avalibaleRooms = new List<int>();
                    for(int k = 0; k < rooms.Length; k++)
                    {
                        int p = rooms[k].ProbabilityofSpawning(i, j);
                        if(p == 2)
                        {
                            randomRoom = k;
                            break;
                        }else if(p == 1)
                        {
                            avalibaleRooms.Add(k);
                        }
                    }

                    if(randomRoom == -1)
                    {
                        if(avalibaleRooms.Count > 0)
                        {
                            randomRoom = avalibaleRooms[Random.Range(0, avalibaleRooms.Count)];
                        }
                        else
                        {
                            randomRoom = 0;
                        }
                    }

                    var newRoom = Instantiate(rooms[randomRoom].room, new Vector3(i * offset.x, 0, -j * offset.y), Quaternion.identity, transform).GetComponent<_K_RoomBehaviour>();
                    newRoom.UpdateRoom(currentCell.status);

                    newRoom.name += " " + i + " - " + j;
                }


                /* square maze
                var newRoom = Instantiate(room, new Vector3(i * offset.x, 0, -j * offset.y), Quaternion.identity, transform).GetComponent<_K_RoomBehaviour>();
                newRoom.UpdateRoom(board[Mathf.FloorToInt(i+j*size.x)].status);

                newRoom.name += " " + i + " - " + j;
                */
            }
        }
    }

    void MazeGenerator()
    {
        board = new List<Cell>();

        for(int i = 0; i<size.x; i++)
        {
            for(int j = 0; j<size.y; j++)
            {
                board.Add(new Cell());
            }
        }

        int currentCell = startPos;

        Stack<int> path = new Stack<int>();
        int k = 0;

        while (k < 1000)
        {
            k++;

            board[currentCell].visited = true;

            //make the maze not square
            if(currentCell == board.Count - 1)
            {
                break;
            }

            //check the cell's neighbors
            List<int> neighbors = CheckNeighbors(currentCell);

            if (neighbors.Count == 0)
            {
                if (path.Count == 0)
                {
                    break;
                }
                else
                {
                    currentCell = path.Pop();
                }
            }
            else
            {
                path.Push(currentCell);

                int newCell = neighbors[Random.Range(0, neighbors.Count)];

                if (newCell > currentCell)
                {
                    //down or right
                    if (newCell - 1 == currentCell)
                    {
                        board[currentCell].status[2] = true;
                        currentCell = newCell;
                        board[currentCell].status[3] = true;
                    }
                    else
                    {
                        board[currentCell].status[1] = true;
                        currentCell = newCell;
                        board[currentCell].status[0] = true;
                    }
                }
                else
                {
                    //up or left
                    if (newCell + 1 == currentCell)
                    {
                        board[currentCell].status[3] = true;
                        currentCell = newCell;
                        board[currentCell].status[2] = true;
                    }
                    else
                    {
                        board[currentCell].status[0] = true;
                        currentCell = newCell;
                        board[currentCell].status[1] = true;
                    }

                }
            }
        }
        GenerateTomb();
    }


    List<int> CheckNeighbors(int cell)
    {
        List<int> neighbors = new List<int>();

        //check up
        if(cell - size.x >= 0 && !board[(cell - size.x)].visited)
        {
            neighbors.Add((cell - size.x));
        }

        //check down
        if (cell + size.x < board.Count && !board[(cell + size.x)].visited)
        {
            neighbors.Add((cell + size.x));
        }

        //check Right
        if ((cell+1) % size.x != 0 && !board[(cell + 1)].visited)
        {
            neighbors.Add((cell + 1));
        }

        //check Left
        if (cell % size.x != 0 && !board[(cell - 1)].visited)
        {
            neighbors.Add((cell -1));
        }


        return neighbors;

    }
}
