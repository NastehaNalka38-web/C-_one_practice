# C# Week 2 – Processing Data

## Overview

This chapter explains how to **receive, store, process, convert, and display data** in C# Windows Forms.

### Main Flow

```text
Input → Store → Convert → Process → Output
```

## Topics

### 1. TextBox Input

Used to receive data from the user.

```csharp
string name = textBox1.Text;
```

Gets the text entered by the user.

### 2. Variables & Data Types

Variables store data.

```csharp
string name = "Nasteha";
int age = 19;
double price = 25.5;
decimal salary = 1000.5m;
```

Each data type stores a different kind of value.

### 3. String Concatenation

Combines text using `+`.

```csharp
string fullName = firstName + " " + lastName;
```

Combines first name and last name.

### 4. Calculations

C# supports basic arithmetic.

```csharp
int total = price * quantity;
```

Performs a calculation and stores the result.

### 5. Type Conversion

```csharp
int age = int.Parse(ageTextBox.Text);
```

Converts TextBox text into an integer.

```csharp
label1.Text = age.ToString();
```

Converts a number into text for display.

### 6. Number Formatting

```csharp
price.ToString("C");
```

Formats a number as currency.

### 7. Exception Handling

```csharp
try
{
    // Code
}
catch
{
    // Handle error
}
```

Prevents unexpected errors from stopping the program.

### 8. Constants & Fields

```csharp
const double TAX = 0.15;
```

A constant value cannot be changed.

```csharp
private string name = "Cabdirahman suldanka";
```

A field belongs to the class and can be used by its methods.

## tab orders

Name TextBox   → TabIndex = 0
Age TextBox    → TabIndex = 1
Email TextBox  → TabIndex = 2
Button         → TabIndex = 3


### 9. Math Class

```csharp
Math.Sqrt(25);
Math.Pow(2, 3);
Math.Round(5.7);
```

Used for mathematical operations.

### 10. GUI Details

```csharp
nameTextBox.Focus();
```

Moves keyboard focus to a control.

```csharp
label1.BackColor = Color.Black;
label1.ForeColor = Color.White;
```

Changes the control colors.

### 11. Debugging

Debugging helps find errors in the program.

Important tools:

* Breakpoints
* Locals Window
* Watch Window
* Step Into (`F11`)

## Importance

This chapter teaches the basic skills needed to build applications that can **take user input, process data, perform calculations, handle errors, and show results**.

## Final Summary

**Week 2 = Processing Data**

```text
User Input
↓
Variables
↓
Conversion
↓
Processing
↓
Error Handling
↓
Output
```


The screenshots in this folder show the practical examples and code from the chapter.
