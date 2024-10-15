using ProjectExcavator.Drawnings;
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
            {
                g.DrawLine(pen, i * _placeSizeWidth, j *
                _placeSizeHeight * 2, i * _placeSizeWidth + _placeSizeWidth / 2, j *
                _placeSizeHeight * 2);
            }
            
            g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, _pictureHeight / _placeSizeHeight * _placeSizeHeight * 2);
        }
    }

    protected override void SetObjectsPosition()
    {
        for (int i = 0; i <= (_collection?.Count ?? 0); ++i)
        {
            if (_collection?.Get(i) == null)
                continue;

            int row = i / (_pictureWidth / _placeSizeWidth);
            int col = (_pictureWidth / _placeSizeWidth) - 1 - (i % (_pictureWidth / _placeSizeWidth));

            _collection.Get(i)?.SetPictureSize(_pictureWidth, _pictureHeight);
            _collection.Get(i)?.SetPosition(col * _placeSizeWidth, (row * _placeSizeHeight * 2)  + 5);
        }
    }
}
