# Working with WPF DockingManager and MVVM Light

This sample demonstrates how to integrate **Syncfusion’s WPF DockingManager** with the **MVVM Light framework** to create a modular, maintainable, and MVVM‑friendly docking application. It shows how docked windows can be managed through view models while keeping UI logic separated from business logic.

## Overview
This example illustrates how to build a docking‑based WPF application using the MVVM pattern. Instead of controlling docked windows directly from code‑behind, the DockingManager is driven through view models using MVVM Light concepts such as commands, messaging, and property notifications.

This approach enables dynamic creation, activation, and management of docked panes while preserving clean separation of concerns and testability.

## What This Sample Demonstrates
- How to use Syncfusion DockingManager in an MVVM‑based WPF application
- How to manage docked windows using ViewModels instead of code‑behind
- How to bind docking states such as visibility and activation to ViewModel properties
- How to use MVVM Light messaging and commands to coordinate docking actions
- A clean architectural pattern for scalable docking applications

## Key Components Used
- **DockingManager**: Provides docking, floating, and layout management for child panes
- **MVVM Light Toolkit**: Enables ViewModel communication, commands, and notifications
- **ViewModel classes**: Control the state and behavior of docked windows
- **UserControls / Content views**: Represent the visual content of docked panes

## How It Works
1. Docked windows are represented by ViewModel instances.
2. Each ViewModel exposes properties that control the docking state and visibility.
3. MVVM Light commands and messaging are used to trigger docking actions.
4. The DockingManager responds to ViewModel changes through data binding.
5. The UI updates automatically without direct code‑behind interaction.

## Benefits
- Maintains strict separation between UI and logic
- Improves maintainability and testability of docking applications
- Supports dynamic and complex docking layouts
- Follows best practices for MVVM‑based WPF development

This approach is ideal for IDE‑style applications, dashboards, and tool‑based interfaces that require both flexible docking and a clean MVVM architecture.

https://help.syncfusion.com/wpf/docking/pattern-and-practices#mvvmlight
