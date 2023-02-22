using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//All comments by Robin
public class WireTask : MonoBehaviour
{
    public List<Color> _wireColors = new List<Color>(); // List of available wire colors
    public List<Wire> _leftWires = new List<Wire>(); // List of wires on the left side of the task
    public List<Wire> _rightWires = new List<Wire>(); // List of wires on the right side of the task
    public Wire CurrentDraggedWire; // Reference to the currently dragged wire
    public Wire CurrentHoveredWire; // Reference to the currently hovered wire
    public bool IsTaskCompleted = false; // Whether or not the task is completed

    private List<Color> _availableColors; // List of colors that are still available for use
    private List<int> _availableLeftWireIndex; // List of indices of wires on the left side that are still available for connection
    private List<int> _availableRightWireIndex; // List of indices of wires on the right side that are still available for connection

    private void Start()
    {
        // Initialize the available color and wire index lists
        _availableColors = new List<Color>(_wireColors);
        _availableLeftWireIndex = new List<int>();
        _availableRightWireIndex = new List<int>();


        // Populate the wire index lists with the indices of the wires
        for (int i = 0; i < _leftWires.Count; i++)
        {
            _availableLeftWireIndex.Add(i);
        }

        for (int i = 0; i < _rightWires.Count; i++)
        {
            _availableRightWireIndex.Add(i);
        }
        // Randomly assign colors to the wires until no colors or wires are left
        while (_availableColors.Count > 0 &&_availableLeftWireIndex.Count > 0 &&_availableRightWireIndex.Count > 0)
        {
            // Pick a random color and wire index for the left and right wires
            Color pickedColor =_availableColors[Random.Range(0, _availableColors.Count)];
            int pickedLeftWireIndex = Random.Range(0,_availableLeftWireIndex.Count);
            int pickedRightWireIndex = Random.Range(0,_availableRightWireIndex.Count);

            // Assign the color to the left and right wires
            _leftWires[_availableLeftWireIndex[pickedLeftWireIndex]].SetColor(pickedColor);
            _rightWires[_availableRightWireIndex[pickedRightWireIndex]].SetColor(pickedColor);

            // Assign the color to the left and right wires
            _availableColors.Remove(pickedColor);
            _availableLeftWireIndex.RemoveAt(pickedLeftWireIndex);
            _availableRightWireIndex.RemoveAt(pickedRightWireIndex);
        }
        // Start checking for task completion
        StartCoroutine(CheckTaskCompletion());
    }

    bool checkTask = true;

    private void Update()
    {
        if (checkTask)
        {
            StartCoroutine(CheckTaskCompletion());
        }
       
    }

    private IEnumerator CheckTaskCompletion()
    {
        checkTask = false;
            int successfulWires = 0;

            // Count the number of successful wires on the right side of the task
            for (int i = 0; i < _rightWires.Count; i++)
            {
                
                if (_rightWires[i].IsSuccess) { successfulWires++; }
                print("wires success:" + successfulWires);
            }
            // If all wires on the right side are successful, the task is completed
            if (successfulWires >= _rightWires.Count)
            {
                Debug.Log("TASK COMPLETED");
                IsTaskCompleted = true;
            }
            else
            {
                Debug.Log("TASK INCOMPLETED");
            }
        checkTask = true;
        yield return null;
    }
}