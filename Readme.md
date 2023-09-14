<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128620284/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3371)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms Radio Group - Custom draw radio items

This example creates a custom radio group control that allows you to manually paint radio items:

![](https://raw.githubusercontent.com/DevExpress-Examples/how-to-custom-draw-radiogroupitem-e3371/13.1.4%2B/media/winforms-custom-radio-group.png)

```csharp
void OnCustomDrawItem(object sender, CustomDrawEventArgs e) {
    if (e.ItemInfo.CheckState == CheckState.Checked) {
        e.ItemInfo.Appearance.Font = new Font(e.ItemInfo.Appearance.Font, FontStyle.Bold | FontStyle.Underline);
    }
    if (e.ItemInfo.State == DevExpress.Utils.Drawing.ObjectState.Hot) {
        LinearGradientBrush brush = new LinearGradientBrush(e.ItemInfo.Bounds, Color.LightBlue, Color.Cyan, LinearGradientMode.ForwardDiagonal);
        e.Cache.FillRectangle(brush, e.ItemInfo.Bounds);
        e.CheckPainter.DrawObject(e.ItemInfo);

        e.Handled = true;
    }
}
```

> **Note**
>
> You can also use the following pre-designed and ready-to-use group controls shipped as part of [DevExpress WinForms UI Templates](https://docs.devexpress.com/WindowsForms/404061/ui-templates):
>
> * [Chip Group](https://docs.devexpress.com/WindowsForms/404075/ui-templates/groups/chip-group)
> * [Multi-Select Chip Group](https://docs.devexpress.com/WindowsForms/404074/ui-templates/groups/multi-select-chip-group)
> * [Radio Button Group](https://docs.devexpress.com/WindowsForms/404073/ui-templates/groups/radio-button-group)
> * [Toggle Button Group](https://docs.devexpress.com/WindowsForms/404072/ui-templates/groups/toggle-button-group)
>
>  DevExpress WinForms UI Templates﻿ include predesigned and ready-to-use UI components and forms (C# and Visual Studio 2022 only).


## Files to Review

* [CustomDrawEventArgs.cs](./CS/WindowsApplication3/CustomDrawEventArgs.cs) (VB: [CustomDrawEventArgs.vb](./VB/WindowsApplication3/CustomDrawEventArgs.vb))
* [CustomRadioGroup.cs](./CS/WindowsApplication3/CustomRadioGroup.cs) (VB: [CustomRadioGroup.vb](./VB/WindowsApplication3/CustomRadioGroup.vb))
* [CustomRadioGroupPainter.cs](./CS/WindowsApplication3/CustomRadioGroupPainter.cs) (VB: [CustomRadioGroupPainter.vb](./VB/WindowsApplication3/CustomRadioGroupPainter.vb))
* [Main.cs](./CS/WindowsApplication3/Main.cs) (VB: [Main.vb](./VB/WindowsApplication3/Main.vb))
* [Program.cs](./CS/WindowsApplication3/Program.cs) (VB: [Program.vb](./VB/WindowsApplication3/Program.vb))
* [RepositoryItemCustomRadioGroup.cs](./CS/WindowsApplication3/RepositoryItemCustomRadioGroup.cs) (VB: [RepositoryItemCustomRadioGroup.vb](./VB/WindowsApplication3/RepositoryItemCustomRadioGroup.vb))


## Documentation

* [Custom Editors](https://docs.devexpress.com/WindowsForms/4716/controls-and-libraries/editors-and-simple-controls/common-editor-features-and-concepts/custom-editors)
