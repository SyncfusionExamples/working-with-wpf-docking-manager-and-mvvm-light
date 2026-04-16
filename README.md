# Working with WPF DockingManager and MVVM light

This repository contains a sample that shows the WPF DockingManager in an application that uses MVVM Light. The sample demonstrates how to integrate DockingManager with an MVVM-based architecture so that documents and tool windows can be created, displayed, and managed through view models instead of code-behind.

In this example, the application uses a MainViewModel, pane view models, and document view models to represent docked content. Sample text documents are loaded into document tabs, while additional panes such as an All Documents view and a Properties view are hosted as docked tools. Commands are used to open documents and close the application, and bindings are used to keep the active document and property display synchronized.

This approach helps illustrate how DockingManager can be used in a clean MVVM Light pattern for document-centric WPF applications. It also shows how docking content can remain organized, extensible, and easy to maintain in larger desktop solutions.

https://help.syncfusion.com/wpf/docking/pattern-and-practices#mvvmlight
