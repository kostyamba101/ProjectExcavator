using ProjectExcavator.Drawnings;
using ProjectExcavator.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectExcavator.CollectionGenericObjects;

public class Garage : AbstractCompany
{
    public Garage(int picWidth, int picHeight, ICollectionGenericObjects<DrawningCar> collection) : base(picWidth, picHeight, collection)
    {
    }

    protected override void DrawBackground(Graphics g)
    {        
        Pen pen = new(Color.Black, 3);
        for (int i = 0; i < _pictureWidth / _placeSizeWidth; i++)
        {
            for (int j = 0; j < _pictureHeight / _placeSizeHeight +
            1; ++j)
            {//линия разметки места
                g.DrawLine(pen, i * _placeSizeWidth, j *
                _placeSizeHeight * 2, i * _placeSizeWidth + _placeSizeWidth / 2, j *
                _placeSizeHeight * 2);
            }            
            g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, _pictureHeight / _placeSizeHeight * _placeSizeHeight * 2);
        }
    }

    protected override void SetObjectsPosition()        
    {
        int width = _pictureWidth / _placeSizeWidth;
        int height = _pictureHeight / _placeSizeHeight;

        int curWidth = width - 1;
        int curHeight = 0;

        for (int i = 0; i < (_collection?.Count ?? 0); i++)
        {
            try
            {
                int r = i / width;
                int s = width - 1 - (i % width);
                _collection?.Get(i)?.SetPictureSize(_pictureWidth, _pictureHeight);
                _collection?.Get(i)?.SetPosition(s * _placeSizeWidth + 5, (r * _placeSizeHeight * 2) + 5);
            }
            catch (ObjectNotFoundException) { }
            catch (PositionOutOfCollectionException e) { }
            if (curWidth > 0)
                curWidth--;
            else
            {
                curWidth = width - 1;
                curHeight++;
            }

            if (curHeight >= height)
            {
                return;
            }
        }
    }
}
