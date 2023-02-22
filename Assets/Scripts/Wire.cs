using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
// All comments by Robin
public class Wire : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    public bool IsLeftWire; // Indicates if this wire is on the left or right side of the puzzle
    public Color CustomColor; // The color of the wire

    private Image _image; // The image component of the wire game object
    private LineRenderer _lineRenderer; // The line renderer component of the wire game object

    private Canvas _canvas; // The canvas that the wire game object is on
    private bool _isDragStarted = false; // Indicates if the wire is currently being dragged
    private WireTask _wireTask; // The WireTask script that manages the puzzle
    public bool IsSuccess = false; // Indicates if the wire has been successfully connected to another wire
    private void Awake()
    {
        _image = GetComponent<Image>();
        _lineRenderer = GetComponent<LineRenderer>();
        _canvas = GetComponentInParent<Canvas>();
        _wireTask = GetComponentInParent<WireTask>();
    }

    private void Update()
    {
        if (_isDragStarted)
        {
            // If the wire is being dragged, draw a line from its starting point to the current mouse position
            Vector2 movePos;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(_canvas.transform as RectTransform,Input.mousePosition,_canvas.worldCamera,
                        out movePos);
            _lineRenderer.SetPosition(0, transform.position);
            _lineRenderer.SetPosition(1,_canvas.transform.TransformPoint(movePos));
        }
        else
        {
            // Hide the line if not dragging.
            // We will not hide it when it connects, later on.
            if (!IsSuccess)
            {
                _lineRenderer.SetPosition(0, Vector3.zero);
                _lineRenderer.SetPosition(1, Vector3.zero);
            }
        }
        bool isHovered =
          RectTransformUtility.RectangleContainsScreenPoint(
              transform as RectTransform, Input.mousePosition, _canvas.worldCamera);
        if (isHovered)
        {
            // If the mouse is hovering over this wire, set it as the currently hovered wire in the WireTask script
            _wireTask.CurrentHoveredWire = this;
        }
    }

    public void SetColor(Color color)
    {
        // Set the color of the wire and its line renderer
        _image.color = color;
        _lineRenderer.startColor = color;
        _lineRenderer.endColor = color;
        CustomColor = color;
    }
    public void OnDrag(PointerEventData eventData)
    {
        // needed for drag but not used
    }
   

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (IsLeftWire) { return; } // If this is a left wire, it can't be dragged
        if (IsSuccess) { return; } // If this wire is already connected to another wire, it can't be dragged
        _isDragStarted = true; // Indicate that the wire is being dragged
        _wireTask.CurrentDraggedWire = this; // Set this wire as the currently dragged wire in the WireTask script
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (_wireTask.CurrentHoveredWire != null)
        {
            // If another wire is being hovered over, check if they can be connected
            if (_wireTask.CurrentHoveredWire.CustomColor == CustomColor && _wireTask.CurrentHoveredWire.IsLeftWire)
            {
                IsSuccess = true;
                _wireTask.CurrentHoveredWire.IsSuccess = true;
            }
        }
        _isDragStarted = false;
        _wireTask.CurrentDraggedWire = null;
    }
}