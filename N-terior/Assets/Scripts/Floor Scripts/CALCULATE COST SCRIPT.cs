using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculateButton : MonoBehaviour
{
    public InputField widthInputField; // Reference to the input field for width
    public InputField lengthInputField; // Reference to the input field for length
    public InputField costPerUnitInputField; // Reference to the input field for cost per unit
    public Text resultText; // Reference to the text component to display the result

    public void CalculateTotalCost()
    {
        // Parse input from input fields
        float width = float.Parse(widthInputField.text);
        float length = float.Parse(lengthInputField.text);
        float costPerUnit = float.Parse(costPerUnitInputField.text);

        // Calculate the area of the floor
        float area = width * length;

        // Calculate the total cost
        float totalCost = area * costPerUnit;

        // Display the result
        resultText.text = "Total Cost: $" + totalCost.ToString("0.00");
    }
}
