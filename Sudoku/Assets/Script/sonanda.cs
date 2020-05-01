using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonanda : MonoBehaviour
{
    int counter;
    // Start is called before the first frame update
    void Start()
    {
        start_sudoku();
    }

    // Update is called once per frame
    public void start_sudoku()
    {
        int[,] grid = {
            { 9, 5, 2, 0, 0, 0, 0, 0, 0 },
	        { 0, 0, 0, 0, 9, 0, 0, 0, 0 },
	        { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
	        { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
	        { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
	        { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
	        { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
	        { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
	        { 0, 0, 0, 0, 0, 0, 0, 0, 0 }
        };

        if (solve(grid,0,0)){
			int x = 0;
            for(int i = 0; i < 81; i++)
            {
				if(((i%9) == 0) && (i != 0)){
					x++;
				}
				
				sGameManager.Get.set_sudoku_element_value(i,grid[x,i%9]);
	
            }
            
            sGameManager.Get.show_sudoku();
        }


       
    }

    public static bool solve(int[,] grid, int row, int col)
    {
	    if (row < 9 && col < 9)
	    {
		    if (grid[row, col] != 0)
		    {
			    if ((col + 1) < 9) return solve(grid, row, col + 1);
			    else if ((row + 1) < 9) return solve(grid, row + 1, 0);
			    else return true;
		    }
		    else
		    {
			    for (int i = 0; i < 9; ++i)
			    {
				    if (check(grid, row, col, i + 1))
				    {
					    grid[row, col] = i + 1;

					    if ((col + 1) < 9)
					    {
						    if (solve(grid, row, col + 1)) return true;
						    else grid[row, col] = 0;
					    }
					    else if ((row + 1) < 9)
					    {
						    if (solve(grid, row + 1, 0)) return true;
						    else grid[row, col] = 0;
				    	}
					    else return true;
				}
			}
		}

		    return false;
	    }
	    else return true;
    }

    private static bool check(int[,] grid, int row, int col, int num)
    {
	    int rowStart = (row / 3) * 3;
	    int colStart = (col / 3) * 3;

	    for (int i = 0; i < 9; ++i)
	{
		    if (grid[row, i] == num) return false;
		    if (grid[i, col] == num) return false;
		    if (grid[rowStart + (i % 3), colStart + (i / 3)] == num) return false;
	}

	    return true;
    }

}
