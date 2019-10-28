using System;

namespace JuegoDeLaSerpiente
{
    public class ClassCell
    {
        // Atributes
        int CellState; // 0 for empty cell, 1 for snake head

        //Methods
        //Constructor
        public ClassCell()
            {
            this.CellState = 0;
            }
        //--------------------------------
        public void SetCellState(int State)
        {
            this.CellState = State;
        }

        public int GetCellState()
        {
            return this.CellState;
        }

    }
}
