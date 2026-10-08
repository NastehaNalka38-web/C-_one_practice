# C# Programming I - Week 1

## Chapter 1: Introduction to Visual C#

Week 1 focuses on the basics of C# programming, Visual Studio, Windows Forms, GUI controls, and writing simple event-driven C# code.

---

## 1. Objects

An **object** is a program component that contains data and performs operations.

Objects have:

- **Properties** – describe the object.
- **Methods** – actions the object can perform.

Example: A Button has properties such as `Text` and `Name`, and can respond to a `Click` event.

---

## 2. Controls

Controls are GUI objects used to build Windows Forms applications.

Common controls:

- Button
- Label
- TextBox
- PictureBox
- CheckBox
- ComboBox

Controls make applications interactive.

---

## 3. Visual Studio

**Visual Studio** is an IDE (Integrated Development Environment) used to create, run, and debug C# applications.

Important parts:

- Toolbox – contains controls.
- Designer – used to design the form.
- Solution Explorer – manages projects and files.
- Properties Window – changes control properties.
- Code Editor – used to write C# code.

---

## 4. Project and Solution

A **Project** is an application.

A **Solution** is a container that can contain one or more projects.

Example:

```text
Solution
└── Project
    ├── Program.cs
    └── Form1.cs
```

---

## 5. Windows Forms

Windows Forms is used to create desktop GUI applications.

A Form is the main window where controls are placed.

Example:

```text
Form
├── Label
├── TextBox
└── Button
```

---

## 6. Properties

Properties control the appearance and behavior of objects and controls.

Example:

```csharp
button1.Text = "Click Me";
```

The `Text` property changes the text displayed on the button.

---

## 7. C# Code Structure

C# code is organized using:

- Namespace
- Class
- Method

Example:

```csharp
namespace MyApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
}
```

`namespace` organizes code, `class` defines an object type, and `method` contains instructions.

---

## 8. Event-Driven Programming

Windows Forms applications are **event-driven**.

The program waits for an action from the user, such as clicking a button, and then executes code.

Example:

```csharp
private void button1_Click(object sender, EventArgs e)
{
    MessageBox.Show("Hello World");
}
```

### Flow

```text
User clicks Button
        ↓
Click Event
        ↓
Event Handler
        ↓
Code Executes
        ↓
Message appears
```

---

## 9. MessageBox

`MessageBox.Show()` displays a message to the user.

```csharp
MessageBox.Show("Hello World");
```

Example inside a button:

```csharp
private void button1_Click(object sender, EventArgs e)
{
    MessageBox.Show("Hello World");
}
```

---

## 10. Label Control

A Label displays text on a form.

Example:

```csharp
answerLabel.Text = "Welcome to C#";
```

To clear the Label:

```csharp
answerLabel.Text = "";
```

The `=` symbol is the assignment operator.

---

## 11. PictureBox

A PictureBox is used to display images.

Important properties:

- `Image`
- `SizeMode`
- `Visible`

Example:

```csharp
pictureBox1.Visible = true;
```

---

## 12. IntelliSense

**IntelliSense** provides automatic code suggestions while writing C# code.

It helps find:

- Methods
- Classes
- Properties
- Variables
- Keywords

It makes coding faster and easier.

---

## 13. Comments

Comments explain code and are ignored by the compiler.

### Single-line comment

```csharp
// Display welcome message
```

### Multi-line comment

```csharp
/*
   This is a
   multi-line comment.
*/
```

---

## 14. Indentation

Indentation makes code easier to read and understand.

```csharp
private void button1_Click(object sender, EventArgs e)
{
    MessageBox.Show("Hello World");
}
```

Good indentation helps show the structure of the code.

---

## 15. Closing a Form

To close the current form:

```csharp
this.Close();
```

Example:

```csharp
private void exitButton_Click(object sender, EventArgs e)
{
    this.Close();
}
```

To exit the whole application:

```csharp
Application.Exit();
```

---

## 16. Syntax Errors

A syntax error occurs when C# code does not follow the correct syntax.

Incorrect:

```csharp
MessageBox.sho("Hello World");
```

Correct:

```csharp
MessageBox.Show("Hello World");
```

Visual Studio usually indicates syntax errors with a red underline.

---

# Practical Example

A simple Windows Forms application:

```csharp
private void helloButton_Click(object sender, EventArgs e)
{
    MessageBox.Show("Hello World");
}

private void showButton_Click(object sender, EventArgs e)
{
    answerLabel.Text = "Welcome to C#";
}

private void exitButton_Click(object sender, EventArgs e)
{
    this.Close();
}
```

### What this code does

| Code | Purpose |
|---|---|
| `MessageBox.Show()` | Displays a message |
| `answerLabel.Text` | Displays text in a Label |
| `this.Close()` | Closes the current Form |

---

# Week 1 Key Points

- C# is used with .NET to create applications.
- Visual Studio is an IDE for developing C# applications.
- Windows Forms is used to create desktop GUI applications.
- Controls are used to build the user interface.
- Properties control the appearance and behavior of controls.
- Events allow the application to respond to user actions.
- Event handlers contain the code executed when an event occurs.
- `MessageBox.Show()` displays messages.
- `Label.Text` displays text.
- `this.Close()` closes the current Form.
- IntelliSense helps with code completion.
- Comments and indentation make code easier to understand.
- Syntax errors must be corrected before the program can run properly.

---

# Screenshots

Screenshots of the practical work are stored in the `screenshots` folder.

### Visual Studio

![Visual Studio](screenshots/01-visual-studio.png)

### Windows Forms

![Windows Forms](screenshots/02-windows-forms.png)

### C# Code

![C# Code](screenshots/03-csharp-code.png)

### Hello World

![Hello World](screenshots/04-hello-world.png)

### MessageBox

![MessageBox](screenshots/05-messagebox.png)

### Label

![Label](screenshots/06-label.png)

### PictureBox

![PictureBox](screenshots/07-picturebox.png)

### IntelliSense

![IntelliSense](screenshots/08-intellisense.png)

### Syntax Error

![Syntax Error](screenshots/09-syntax-error.png)

---

# Conclusion

Week 1 introduced the basic C# Windows Forms development environment and the fundamental concepts needed to create simple desktop applications.

The practical work focused on creating forms, using controls, handling events, writing basic C# code, displaying messages, and working with GUI components.