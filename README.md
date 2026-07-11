# PixelClock
A customisable pixel-art desktop widget-like application built with C# & WinForms.

PixelClock is a lightweight Windows desktop widget designed to display the current time and date with a retro pixel artstyle.

## Features
- Borderless transparent desktop widget
- Custom pixel font support
- Draggable clock positioning
- Saves and restores widget position
- Displays current time and date
- Lightweight WinForms implementation

## Adding Your Own Font
PixelClock supports custom .ttf fonts.

To use your own font:
- Add your .ttf font file to:
Clock/Fonts/
- Ensure the file name matches the font being loaded in the application:
- Set the file properties in Visual Studio:
Build Action: Content
Copy to Output Directory: Copy if newer

The font file will then be copied alongside the application when built.
> Note: Ensure any fonts added follow their own license requriements.

## Roadmap
### Customisation
- [ ] Change clock font from the GUI
- [ ] Change clock colours from the GUI
- [ ] Adjustable clock sizing
- [ ] Resizable widget window
- [ ] Theme presets

### Desktop Integration
- [ ] Pin widget to the desktop background
- [ ] Allow the widget to remain behind normal applications
- [ ] Improve desktop widget behaviour

### User Experience
- [ ] Improved system tray controls <!-- In Progress -->
- [ ] Settings menu <!-- In Progress -->
- [ ] Better configuration handling <!-- In Progress -->
- [ ] Additional display options

## Built With
- C#
- .NET WinForms

## Licence

Copyright (c) 2026 Joshua (jsyntha)

The source code for PixelClock is licensed under the MIT License.

The MIT License applies only to the source code unless otherwise stated.

Project assets, including but not limited to icons, logos, artwork, and other visual assets, are not included under the MIT License. These assets remain the property of their respective owners and may not be reused, redistributed, or modified without permission.

Third-party assets, such as fonts, are subject to their own individual licences and terms of use.
