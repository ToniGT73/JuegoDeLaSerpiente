using System;
using System.Collections.Generic;
using System.Text;

namespace JuegoDeLaSerpiente
{
    public class ClassGrid
    {
        //Atributes
        ClassCell[,] Grid;

        //Constructor
        public ClassGrid()
        {
            //Generació de la malla
            this.Grid = new ClassCell[100,100];
            for(int j = 0 ; j<100; j++)
            {
                for(int i = 0; i<100; i++)
                {
                    this.Grid[j, i] = new ClassCell();
                }
            }
            //Generació de les parets


        }

        //Methods

    }
}
