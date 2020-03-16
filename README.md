# _To Do List_

#### _ASP.NET MVC practice for Epicodus_, _Mar. 16 2020_

#### By _**Michelle Morin, Alyssa Colistro**_

## Description

_This application is a to-list, to keep track of tasks. We completed this project by working through Epicodus online lessons and familiarizing ourselves with MySQL Workbench and SQL commands from the command line._

## Specifications:

| Specification | Example Input | Example Output |
| ------------- |:-------------:| -------------------:|
| Application creates an instance of an Item | Item newItem = new Item() | new Item object created |
| Application returns description of Item (e.g., "walk the dog") | newItem.Description | "walk the dog" |
| Application sets a description for an Item (e.g., "walk the dog") | Item newItem = new Item("walk the dog") | newItem.Description = "walk the dog" |
| Application adds all new instances of Item to a static list | Item newItem = new Item("walk the dog") | newItem is added to static list property of Item class |
| Application returns all items in the static list of items | Item newItem = new Item(description) | List<Item> result = { newItem } | 
| Application creates an instance of a category | Category newCategory = new Category() | new Category item created |
| Application creates list of items associated with each category | new category object | empty list of items assigned to new category | 

## Setup/Installation Requirements

### Install .NET Core

#### on macOS:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download a .NET Core SDK from Microsoft Corp._
* _Open the file (this will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.)_

#### on Windows:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp._
* _Open the .exe file and follow the steps provided by the installer for your OS._

#### Install dotnet script
_Enter the command ``dotnet tool install -g dotnet-script`` in Terminal (macOS) or PowerShell (Windows)._

### Clone this repository

_Enter the following commands in Terminal (macOS) or PowerShell (Windows):_
* ``cd desktop``
* ``git clone https://github.com/michelle-morin/ToDoListSQL``
* ``cd ToDoListSQL``

_Confirm that you have navigated to the ToDoListSQL directory (e.g., by entering the command_ ``pwd`` _in Terminal)._

_Run this application by entering the following command in Terminal (macOS) or PowerShell (Windows):_
* ``cd ToDoList``
* ``dotnet restore``
* ``dotnet build``
* ``dotnet run`` or ``dotnet watch run``

_Test this application by entering the following command in Terminal (macOS) or PowerShell (Windows):_
* ``cd ToDoList.Tests``
* ``dotnet restore``
* ``dotnet test``

_To view/edit the source code of this application, open the contents of this directory in a text editor or IDE of your choice (e.g., to open all contents of the directory in Visual Studio Code on macOS, enter the command_ ``code .`` _in Terminal)._

## Technologies Used
* _Git_
* _C#_
* _.NET Core 2.2_
* _ASP.NET Core MVC_
* _dotnet script_
* _MSTest_
* _MySQL_

### License

*This webpage is licensed under the MIT license.*

Copyright (c) 2020 **_Michelle Morin, Alyssa Colistro_**