using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model : MonoBehaviour {

    public List<ClothingItem> MyClothingItems = new List<ClothingItem>();

    // ensure the order the points are place in, line up with the order in the enum list
    public List<Transform> BodyPoints = new List<Transform>();
   

    public void AddClothingToModel(GameObject _piece)
    {
        ClothingItem pieceInfo = _piece.GetComponent<ClothingItem>();
        for(int i = 0; i < BodyPoints.Count; i++)
        {
            if((int) pieceInfo.MyPosition == i)
            {
                _piece.transform.position = BodyPoints[i].position;
            }
        }
    }

    public void GradeModel()
    {

    }
	
}
