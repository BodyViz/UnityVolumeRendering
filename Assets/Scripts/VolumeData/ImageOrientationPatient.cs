using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageOrientationPatient
{

    private Vector3 _row;
    private Vector3 _column;

    public ImageOrientationPatient()
    {
        _row = new Vector3(1, 0, 0);
        _column = new Vector3(0, 1, 0);
    }

    public ImageOrientationPatient(Vector3 firstRow, Vector3 firstColumn)
    {
        _row = firstRow;
        _column = firstColumn;
    }

    public Vector3 Row()
    {
        return _row;
    }

    public Vector3 Column()
    {
        return _column;
    }

    public void printInfo()
    {
        Debug.Log("ImageOrientationPatient");
        Debug.Log("First Row: " + _row.ToString("F5"));
        Debug.Log("First Column: " + _column.ToString("F5"));
    }
}
