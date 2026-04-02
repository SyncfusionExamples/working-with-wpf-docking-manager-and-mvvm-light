# Working with WPF DockingManager and MVVM light

## MVVM light
This section explains how to create MVVMLight sample with DockingManager. Since DockingManager is not an Items Control, it is not possible to have a traditional ItemsSource binding to a collection of objects in the view model. It can be achieved using DockingAdapter from the above MVVM sample creation section.

The following steps explains how to create sample project with MVVMLight templates.

1. Download MVVMLight toolkit and install it to avail the predefined MVVMLight templates for all platforms MMVMLight extension can be install from Tools and Extension.

2. Create a new WPF project and select MVVMLight WPF template.

3. Template for MVVMLight sample will be created with required assemblies, Simple IOC container and ViewModelLocator.

4. Attach DockingAdapter project to the DockingManagerMVVMLight project from MVVM sample. Create necessary ViewModels and Views with perfect naming conventions. Once the ItemsSource has been set to DockingAdapter children will be populate.

For more detail please refer [DockingManager MVVMLight](https://help.syncfusion.com/wpf/docking/pattern-and-practices#mvvmlight)

