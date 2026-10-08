# C# Windows Forms – Chapter 1

## Overview

This chapter introduces the basics of **C# Windows Forms**, including Forms, Controls, Events, and basic C# code.

---

## 1. Image1 explains Basic Form Code

```csharp
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
}
```

### Explanation

* `Form1` → the name of the form.
* `: Form` → Form1 inherits from the Windows Form.
* `Form1()` → constructor.
* `InitializeComponent()` → initializes the form and its controls.

---

## 2. image2 explains Button Click Event

```csharp
private void button1_Click(object sender, EventArgs e)
{
}
```

### Explanation

This method runs when the button is clicked.

* `private` → accessible inside the class.
* `void` → returns no value.
* `button1_Click` → event handler for the button.
* `object sender` → identifies the object that triggered the event.
* `EventArgs e` → contains event information.

---

## 3. image3 expalins MessageBox

```csharp
MessageBox.Show("Hello World");
```

### Explanation

Displays a popup message to the user.

Example:

```csharp
private void button1_Click(object sender, EventArgs e)
{
    MessageBox.Show("Hello World");
}
```

---

## 4. Changing Label Text

```csharp
answerLabel.Text = "Hello";
```

### Explanation

Changes the text displayed by a Label.

To clear the Label:

```csharp
answerLabel.Text = "";
```

* `answerLabel` → Label name.
* `.Text` → text displayed by the Label.
* `=` → assigns a value.

---

## 5. PictureBox Visibility

### Show PictureBox

```csharp
pictureBox1.Visible = true;
```

### Hide PictureBox

```csharp
pictureBox1.Visible = false;
```

* `true` → visible.
* `false` → hidden.

---

## 6. Show and Hide Images

```csharp
private void showBackButton_Click(object sender, EventArgs e)
{
    cardBackPictureBox.Visible = true;
    cardFacePictureBox.Visible = false;
}
```

### Explanation

When the button is clicked:

* The back image becomes visible.
* The face image becomes hidden.

The order of the statements is important because C# executes statements sequentially.

---

## 7. Comments

### image6 expalians Single-Line Comment

```csharp
// This is a comment
```

### image7 explains Multi-Line Comment

```csharp
/*
   This is a
   multi-line comment
   ....
*/
```

Comments are used to explain code and are not executed by the program.

---

## 8. image8 explains Close the Form

```csharp
this.Close();
```

### Explanation

Closes the current form.

Example:

```csharp
private void exitButton_Click(object sender, EventArgs e)
{
    this.Close();
}
```

---

## 9. image9 explains Exit the Application

```csharp
Application.Exit();
```

### Explanation

Closes the entire application.

### Difference

| Code                  | Purpose                      |
| --------------------- | ---------------------------- |
| `this.Close();`       | Closes the current Form      |
| `Application.Exit();` | Closes the whole application |

---

## 10. Control Naming

Controls need names so they can be accessed in code.

### Examples

```csharp
myButton
studentNameLabel
exitButton
```

### Naming Rules

* Start with a letter or `_`.
* Do not use spaces.
* Use letters, numbers, and `_`.
* `camelCase` is commonly used.

Example:

```csharp
studentNameLabel
```

---

## 11. image10 explains Syntax Errors

Incorrect:

```csharp
MessageBox.sho("Hello");
```

Correct:

```csharp
MessageBox.Show("Hello");
```

Visual Studio can identify syntax errors and usually shows a red underline under the incorrect code.

---

## 12. Important C# Code

These are the main codes to remember:

```csharp
// Initialize Form
InitializeComponent();

// Show message
MessageBox.Show("Hello");

// Change Label text
label1.Text = "Hello";

// Clear Label
label1.Text = "";

// Show control
pictureBox1.Visible = true;

// Hide control
pictureBox1.Visible = false;

// Close current Form
this.Close();

// Exit application
Application.Exit();
```

---

## Summary

The main concepts covered in this chapter are:

* **Form** → the application's window.
* **Control** → UI elements such as Button, Label, and PictureBox.
* **Event** → an action such as a button click.
* **Event Handler** → code that responds to an event.
* **Property** → controls how an object looks or behaves.
* **Method** → performs an action.
* **Comments** → explain code without being executed.
* **Syntax Error** → an error in the structure of the code.

### Most Important Idea

```text
User Action
     ↓
Event
     ↓
Event Handler
     ↓
C# Code
     ↓
Program Response
```
