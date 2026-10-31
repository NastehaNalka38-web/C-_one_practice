# C# File Handling

![](/assignments/filesAssignment/img.png)


## Introduction

File Handling in C# allows us to create, read, write, append, and delete files.

It helps applications store information in text files and retrieve that information whenever needed.

In this README, we will learn how to work with text files using the `System.IO` namespace.

### File Path

The following path will be used in all examples:

```csharp
string path = @"C:\Users\Wireless\Documents\C#_practices\C#_one_practice\assignments\files\ca123.txt";
```

### Required Namespace

Add this namespace at the top of your C# file:

```csharp
using System.IO;
```

---

# 1. Create File — `File.CreateText()`

## Description

`File.CreateText()` creates a new text file at the specified location.

It returns a `StreamWriter` object, which can be used to write information into the file.

**Important:** If the file already exists, `File.CreateText()` overwrites its existing contents.

## Example

```csharp
string path = @"C:\Users\Wireless\Documents\C#_practices\C#_one_practice\assignments\files\ca123.txt";

StreamWriter writer = File.CreateText(path);

writer.Close();

MessageBox.Show("File created successfully!");
```

## Explanation

- `string path` — specifies the location and name of the file.
- `File.CreateText(path)` — creates a new text file.
- `StreamWriter writer` — stores the StreamWriter object returned by `CreateText()`.
- `writer.Close()` — closes the writer and releases the file resource.
- `MessageBox.Show()` — displays a confirmation message.

## When to use it

Use `File.CreateText()` when you want to create a new text file.

---

# 2. Read File — `File.ReadAllText()`

## Description

`File.ReadAllText()` reads all the text from a specified file and returns it as a single string.

It allows you to retrieve the entire contents of a file at once.

## Example

```csharp
string path = @"C:\Users\Wireless\Documents\C#_practices\C#_one_practice\assignments\files\ca123.txt";

string content = File.ReadAllText(path);

MessageBox.Show(content);
```

## Explanation

- `string path` — specifies the file location.
- `File.ReadAllText(path)` — reads all the contents of the file.
- `string content` — stores the text returned from the file.
- `MessageBox.Show(content)` — displays the file contents in a message box.

## Example: Display File Content in ListBox

```csharp
string path = @"C:\Users\Wireless\Documents\C#_practices\C#_one_practice\assignments\files\ca123.txt";

string content = File.ReadAllText(path);

listBox1.Items.Clear();
listBox1.Items.Add(content);
```

## Explanation

- `listBox1.Items.Clear()` — removes all existing items from the ListBox.
- `listBox1.Items.Add(content)` — adds the entire file content as one ListBox item.

**Note:** `ReadAllText()` reads the entire file as one string. It does not automatically create separate ListBox items for each line.

## When to use it

Use `File.ReadAllText()` when you want to read all the contents of a text file at once.

---

# 3. Write File — `File.WriteAllText()`

## Description

`File.WriteAllText()` writes text into a specified file.

If the file already exists, it replaces all existing contents with the new text.

If the file does not exist, it creates a new file.

## Example

```csharp
string path = @"C:\Users\Wireless\Documents\C#_practices\C#_one_practice\assignments\files\ca123.txt";

string name = "Nalka";
int age = 20;
string course = "Data Structure";

string info = name + "\n" + age + "\n" + course;

File.WriteAllText(path, info);

MessageBox.Show("Information saved successfully!");
```

## Explanation

- `name` — stores the student's name.
- `age` — stores the student's age.
- `course` — stores the course name.
- `string info` — combines all information into one string.
- `\n` — separates the information into different lines.
- `File.WriteAllText(path, info)` — writes the information into the file.

## Expected File Content

```text
Nalka
20
Data Structure
```

## When to use it

Use `File.WriteAllText()` when you want to write new information into a file and replace its previous contents.

---

# 4. Append File — `File.AppendAllText()`

## Description

`File.AppendAllText()` adds new text to the end of an existing file without removing its previous contents.

If the file does not exist, it creates a new file.

## Example

```csharp
string path = @"C:\Users\Wireless\Documents\C#_practices\C#_one_practice\assignments\files\ca123.txt";

string name = "Ahmed";
int age = 22;
string course = "C# Programming";

string info = name + "\n" + age + "\n" + course + "\n";

File.AppendAllText(path, info);

MessageBox.Show("Information appended successfully!");
```

## Explanation

- `name` — stores the student's name.
- `age` — stores the student's age.
- `course` — stores the course name.
- `string info` — combines the information into one string.
- `File.AppendAllText(path, info)` — adds the new information to the end of the file.

## Expected File Content

If the file previously contained:

```text
Nalka
20
Data Structure
```

After appending the new information:

```text
Nalka
20
Data Structure
Ahmed
22
C# Programming
```

## When to use it

Use `File.AppendAllText()` when you want to add new information without deleting the existing contents.

---

# 5. Delete File Content — `File.WriteAllText(path, "")`

## Description

`File.WriteAllText(path, "")` removes all text from a file while keeping the file itself.

It replaces the existing contents with an empty string.

## Example

```csharp
string path = @"C:\Users\Wireless\Documents\C#_practices\C#_one_practice\assignments\files\ca123.txt";

File.WriteAllText(path, "");

MessageBox.Show("File content deleted successfully!");

listBox1.Items.Clear();
```

## Explanation

- `File.WriteAllText(path, "")` — removes all text from the file, leaving the file empty.
- `MessageBox.Show()` — displays a confirmation message.
- `listBox1.Items.Clear()` — removes all items displayed in the ListBox.

## Important

This operation deletes the file contents but does not delete the file itself.

## When to use it

Use this method when you want to clear all information from a file but keep the file available for future use.

---

# 6. Delete Entire File — `File.Delete()`

## Description

`File.Delete()` deletes the entire file from the specified location.

Unlike clearing file contents, this method removes the file itself.

## Example

```csharp
string path = @"C:\Users\Wireless\Documents\C#_practices\C#_one_practice\assignments\files\ca123.txt";

if (File.Exists(path))
{
    File.Delete(path);

    MessageBox.Show("File deleted successfully!");

    listBox1.Items.Clear();
}
else
{
    MessageBox.Show("File does not exist!");
}
```

## Explanation

- `File.Exists(path)` — checks whether the file exists.
- `File.Delete(path)` — deletes the entire file.
- `MessageBox.Show()` — displays a confirmation message.
- `listBox1.Items.Clear()` — clears the ListBox.

## When to use it

Use `File.Delete()` when you want to permanently remove a file from its location.

---

# 7. Summary Table

| Method | Description |
|---|---|
| `File.CreateText()` | Creates a new text file. |
| `File.ReadAllText()` | Reads all text from a file. |
| `File.WriteAllText()` | Writes text and replaces existing contents. |
| `File.AppendAllText()` | Adds new text to the end of a file. |
| `File.WriteAllText(path, "")` | Clears all contents but keeps the file. |
| `File.Delete()` | Deletes the entire file. |

---

# 8. Important Notes

1. Always include `using System.IO;`.
2. Make sure the file path is correct.
3. `File.CreateText()` overwrites an existing file.
4. `File.ReadAllText()` reads the entire file as one string.
5. `File.WriteAllText()` replaces existing contents.
6. `File.AppendAllText()` preserves existing contents and adds new text.
7. `File.WriteAllText(path, "")` clears the file without deleting it.
8. `File.Delete()` deletes the entire file.
9. Use `File.Exists()` to check whether a file exists before reading or deleting it.
10. Use `StreamWriter.Close()` or a `using` statement when working with `File.CreateText()`.

---

# Conclusion

C# provides several methods for working with text files through the `System.IO` namespace.

The main methods covered in this README are:

- **Create:** `File.CreateText()`
- **Read:** `File.ReadAllText()`
- **Write:** `File.WriteAllText()`
- **Append:** `File.AppendAllText()`
- **Clear File Content:** `File.WriteAllText(path, "")`
- **Delete File:** `File.Delete()`

Understanding these methods is an important step in learning C# File Handling.

They can be used to build beginner Windows Forms projects such as student record systems, note-taking applications, and simple file management applications.