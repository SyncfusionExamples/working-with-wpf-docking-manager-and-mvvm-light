# Working with WPF DockingManager and MVVM Light

This sample demonstrates how to integrate the **Syncfusion WPF DockingManager** with the **MVVM Light framework** to build a fully MVVM‑compliant docking application. It shows how docked and document windows can be created, managed, and synchronized through ViewModels without relying on code‑behind logic.

## Overview
DockingManager is not an ItemsControl, which makes it challenging to use directly in an MVVM architecture. This sample addresses that limitation by introducing a **custom DockingAdapter** that bridges DockingManager with MVVM Light using dependency properties, data binding, and collection change notifications.

The application uses ViewModels to represent documents and docked panes, while the DockingAdapter dynamically creates and manages DockingManager children based on the bound data source.

## What This Sample Demonstrates
- How to integrate Syncfusion DockingManager with MVVM Light
- How to create a custom adapter to support ItemsSource binding
- How to represent docked panes and documents using ViewModels
- How to synchronize the active document between the UI and ViewModel
- How to dynamically add and remove docked windows using collections
- How to maintain a clean separation between UI and application logic

## Key Components Used
- **DockingManager**: Manages docked and document windows
- **DocumentContainer**: Hosts document‑style windows
- **DockingAdapter**: Custom UserControl that enables MVVM binding
- **IDockElement**: Interface for dockable ViewModel items
- **Workspace / Document ViewModels**: Represent docked panes and documents
- **MVVM Light**: Provides ViewModelBase, commands, and IOC support

## How It Works
1. ViewModels implement the `IDockElement` interface to describe dock state and headers.
2. A collection of dockable items is exposed from the MainViewModel.
3. DockingAdapter binds to this collection using `ItemsSource`.
4. DockingAdapter creates and configures DockingManager child controls dynamically.
5. Active document changes are synchronized using a dependency property.
6. Collection change events update the DockingManager layout in real time.

## Benefits
- Enables true MVVM usage with DockingManager
- Eliminates tight coupling between UI and logic
- Supports dynamic document and pane management
- Improves maintainability and testability
- Ideal for IDE‑style and document‑centric applications

This approach is well suited for WPF applications that require advanced docking layouts while adhering to MVVM best practices using MVVM Light.

https://help.syncfusion.com/wpf/docking/pattern-and-practices#mvvmlight
