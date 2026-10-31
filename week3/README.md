# C# Week 3 – Making Decisions

## Overview

Week 3 focuses on **Making Decisions in C# Windows Forms**.

This chapter explains how a C# program makes decisions based on conditions. It covers decision structures, `if` statements, `if-else` statements, nested decisions, logical operators, Boolean variables, string comparison, input validation, RadioButtons, CheckBoxes, `switch` statements, and ListBox controls.

## Importance

Decision-making is an important part of programming because applications need to:

- Check conditions before performing actions
- Choose between different outcomes
- Compare values and strings
- Validate user input
- Prevent errors caused by invalid data
- Respond to user selections
- Add, select, and remove items from lists
- Display appropriate results based on conditions

## Objectives

After completing this chapter, I should understand:

- Decision structures and the `if` statement
- Relational operators
- The `if-else` statement
- Nested decision structures
- The `if-else-if` statement
- Logical operators (`&&`, `||`, `!`)
- `bool` variables and flags
- Comparing strings
- Preventing data conversion exceptions with `TryParse()`
- Input validation
- RadioButtons and CheckBoxes
- The `switch` statement
- Introduction to ListBox controls
- Adding items to a ListBox
- Selecting and reading ListBox items
- Removing and clearing ListBox items

## Main Concept

The main decision-making process in C# is:

```text
User Input
    ↓
Check Condition
    ↓
Choose a Decision
    ↓
Process Data
    ↓
Validate Input
    ↓
Display Result


```

## Practical Importance

These concepts are used in real applications such as:

- Student Grade Systems
- Student Management Systems
- Login and Registration Forms
- Loan Eligibility Systems
- Billing Applications
- Quiz Applications
- Payment Selection Forms
- Product Selection Systems
- Employee Management Systems
- Inventory Systems

## Screenshots & Code

The screenshots of the practical work are stored in the `screenshoots` folder.

The examples demonstrate how decision structures and selection controls are implemented in a C# Windows Forms application.

The main idea is to understand **what the code does, why it is used, and what result it produces**.

### Decision Structures and the if Statement

The `if` statement executes a block of code only when its Boolean condition is true.

![If Statement](/week3/screenshoots/if.png)

### Relational Operators

Relational operators compare two values.

| Operator | Meaning |
|---|---|
| `>` | Greater than |
| `<` | Less than |
| `>=` | Greater than or equal to |
| `<=` | Less than or equal to |
| `==` | Equal to |
| `!=` | Not equal to |

![Relational Operators](/week3/screenshoots/relationalOp.png)

### The if-else Statement

The `if-else` statement executes one block when a condition is true and another block when it is false.

![If-Else Statement](/week3/screenshoots/ifElse.png)

### Nested Decision Structures

Nested decision structures allow one decision to be placed inside another decision. They are useful when a program needs to check more than one condition.

![Nested Decision Structures](/week3/screenshoots/nestedDecision.png)

### The if-else-if Statement

The `if-else-if` statement checks multiple conditions to determine which action should be performed.

For example, it can be used to calculate student grades based on examination scores.

![If-Else-If Statement](/week3/screenshoots/ifElseIf.png)

### Logical Operators

Logical operators combine or reverse Boolean expressions.

- `&&` — AND: both conditions must be true.
- `||` — OR: at least one condition must be true.
- `!` — NOT: reverses a Boolean condition.

![Logical Operators](/week3/screenshoots/logicalOp.png)

### Bool Variables and Flags

A `bool` variable stores either `true` or `false`.

A flag is a Boolean variable used to indicate whether a particular condition exists.


### Comparing Strings

C# allows strings to be compared using the `==` and `!=` operators. The `String.Compare()` method can also be used to compare strings.

![String Comparison](/week3/screenshoots/stringComparison.png)

### Preventing Data Conversion Exceptions with TryParse()

The `TryParse()` methods help prevent conversion exceptions when users enter invalid numeric data.

Examples include:

- `int.TryParse()`
- `double.TryParse()`
- `decimal.TryParse()`

![TryParse](/week3/screenshoots/tryParse.png)

### Input Validation

Input validation checks whether entered data is valid before the program uses it.

For example, a program can check whether working hours are between 1 and 168 or whether a test score is between 0 and 100.

![Input Validation](/week3/screenshoots/inputValidation.png)

### RadioButtons

RadioButtons allow users to select one option from several choices. When RadioButtons are placed in the same group, selecting one automatically deselects the others.

The `Checked` property determines whether a RadioButton is selected.

![RadioButtons](/week3/screenshoots/radioButton.png)

### CheckBoxes

CheckBoxes allow users to select multiple options.

The `Checked` property determines whether a CheckBox is selected.

![CheckBoxes](/week3/screenshoots/checkBox.png)

### The CheckedChanged Event

The `CheckedChanged` event occurs when the `Checked` property of a RadioButton or CheckBox changes.

This event allows the program to respond when the user selects or deselects a control.

![CheckedChanged Event](/week3/screenshoots/checked.png)

### The switch Statement

The `switch` statement selects a path of execution based on the value of an expression. It can be used as an alternative to an `if-else-if` structure when comparing the same expression against multiple values.

The `default` section handles values that do not match any case.

![Switch Statement](/week3/screenshoots/switch.png)

### Introduction to ListBox

A ListBox displays a list of items and allows users to select an item.

Common ListBox properties include:

- `Text` — the text of the currently selected item.
- `Items` — the collection of items in the ListBox.
- `Items.Count` — the number of items in the ListBox.
- `SelectedItem` — the currently selected item.
- `SelectedIndex` — the zero-based index of the selected item.

![ListBox Control](/week3/screenshoots/listbox.png)

### Adding Items to a ListBox

The `Items.Add()` method adds a new item to a ListBox.

For example:

```csharp
daysListBox.Items.Add("Monday");
daysListBox.Items.Add("Tuesday");
daysListBox.Items.Add("Wednesday");
```

![Adding ListBox Items](/week3/screenshoots/AddingListBoxItem.png)

### Selecting an Item from a ListBox

The `SelectedItem` property gets the currently selected item. The `SelectedIndex` property can be used to check whether an item is selected.

If `SelectedIndex` is `-1`, no item is selected.


### Removing Items from a ListBox

The `Items.Remove()` method removes a specific item from a ListBox.

The `Items.RemoveAt()` method removes an item using its index.

The `Items.Clear()` method removes all items from the ListBox.

![Removing ListBox Items](/week3/screenshoots/removeListItem.png)

## Final Summary

Week 3 teaches how to control the flow of a C# program using decision structures and selection controls.

The chapter explains how to evaluate conditions, compare values, validate user input, respond to user selections, and manage items in a ListBox.

**Input → Check Conditions → Make Decisions → Validate Data → Display Results**

These concepts provide the foundation for building interactive and reliable C# Windows Forms applications.
