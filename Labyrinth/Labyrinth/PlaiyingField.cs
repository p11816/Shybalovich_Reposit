using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Labyrinth
{
    class PlaiyingField
    {
        // начальные координаты верхнего левого угла игрового поля
        public Point pointField;
        // размер поля
        public int col;
        public int row;
        // размер ячейки
        public int sizeCell;
        // высота прямоугольной границы
        public int hRect;
        // лист прямоугольных объектов поля
        public List<Rectangle> fieldList;
        public PlaiyingField(int x0 = 0, int y0 = 0, int myCol = 20, int myRow = 10, int mySizeCell = 10, int myHRect = 2)
        {
            pointField.X = x0;
            pointField.Y = y0;
            col = myCol;
            row = myRow;
            sizeCell = mySizeCell;
            hRect = myHRect;
            fieldList = new List<Rectangle>();
            createdField();
        }
        private void createdField()
        {
            // горизонтальные границы
            for (int i = 0; i < 2; ++i)
            {
                for (int j = 0; j < col; ++j)
                {
                    fieldList.Add(new Rectangle(j * sizeCell, i * row * sizeCell, sizeCell, hRect));
                }
            }
            // вертикальные границы
            for (int i = 0; i < 2; ++i)
            {
                for (int j = 0; j < row; ++j)
                {
                    fieldList.Add(new Rectangle(i * col * sizeCell, j * sizeCell, hRect, sizeCell));
                }
            }
        }
        // добавляем преграды
        private void addObstacles()
        {

        }
        // добавляем границу
        private void addBorders()
        {

        }

    }
}
