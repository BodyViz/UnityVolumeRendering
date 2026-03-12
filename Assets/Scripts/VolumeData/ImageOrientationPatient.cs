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

    public Vector3 Normal()
    {
        return Vector3.Cross(_row, _column).normalized;
    }

    public Quaternion Rotation()
    {
        var left_dir = new Vector3(1.0f, 0.0f, 0.0f);
        var left_quat = Quaternion.FromToRotation(Row(), left_dir);
        var anterior_dir = new Vector3(0.0f, 1.0f, 0.0f);
        var anterior_quat = Quaternion.FromToRotation(anterior_dir, Column());
        return anterior_quat * left_quat;
    }

    public void printInfo()
    {
        Debug.Log("ImageOrientationPatient");
        Debug.Log("First Row: " + _row.ToString("F5"));
        Debug.Log("First Column: " + _column.ToString("F5"));
    }
}
