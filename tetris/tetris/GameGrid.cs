using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.youtube.com/watch?v=jcUctrLC-7M https://www.youtube.com/watch?v=jcUctrLC-7M
namespace tetris
{
    public class GameGrid
    {
        private readonly int[,] grid;    // two dimentional array
        public int Rows { get; }        
        public int Columns { get; }

        public int this [int r, int c]
        {
            get=> grid[r, c];           // get => grid[r, c];: This is the get accessor for the indexer.
                                        // When you use square brackets to access an element of an instance of the GameGrid class, like gameGrid[3, 5], this get accessor is called.
                                        // It retrieves the value of the element at the specified row r and column c in the grid array and returns it.
            set => grid[r, c] = value;  //set => grid[r, c] = value;: This is the set accessor for the indexer.
                                       //When you use square brackets to assign a value to an element of an instance of the GameGrid class, like gameGrid[3, 5] = 42;
                                       //this set accessor is called. It assigns the provided value to the element at the specified row r and column c in the grid array.
        }

        public GameGrid(int rows, int columns) 
        {
            Rows = rows;   
            Columns = columns;
            grid = new int[Rows, Columns];  // Assigns Rows and Columns value to 2 dim array

        }
        public bool IsInside(int r, int c)  // Convenience method, checks if given rows and columns is inside the grid
        {
            return r >= 0 && r<Rows && 0<=c && c<Columns;
        }
        public bool IsEmpty(int r, int c )
        {
            return IsInside(r, c) && grid[r,c]==0; // checks if grid value is 0 and if its no out of the grid
        }
        public bool IsRowFull(int r)
        {
            for(int c = 0; c < Columns; c++)
            {
                if (grid[r,c]==0) return false; // checks if the row is full buy adding c 1
            }
            return true;
        }
        public bool IsRowEmpty(int r)
        {
            for (int c = 0; c < Columns; c++)
            {
                if (grid[r, c] != 0) return false; // checks if the row is empty
            }
            return true; 
        }
        private void ClearRow(int r)
        {
            for (int c = 0; c < Columns; c++)
            {
                grid[r, c] = 0;
            }
        }
        private void MoveRowDown(int r, int numRows)    // num rows indicates how many row have been cleared so far
        {
            for(int c=0; c<Columns; c++)
            {
                grid[r + numRows, c] = grid[r, c]; // moving the rows down
                grid[r, c] = 0;                             // clear the row
            }
        }
        public int ClearFullRows()
        {
            int cleared = 0;

            for(int r = Rows-1;r>=0; r--)
            {
                if(IsRowFull(r))
                {
                    ClearRow(r);
                    cleared++;
                }
                else if (cleared>0)
                {
                    MoveRowDown(r, cleared);
                }
            }
            return cleared;
        }
    }

}
