# https://stackoverflow.com/a/55602125
cmake_minimum_required(VERSION 3.8)

project(approximation LANGUAGES CSharp)

# Include CMake utilities for CSharp, for WinForm and WPF application support.
include(CSharpUtilities)

# Define the executable, including any .cs files. 
# The .resx and other Properties files are optional here, but including them makes them visible in the VS solution for easy editing. 
add_executable(approximation
    App.config
    approximation.cs
    approximation.Designer.cs
    approximation.resx
    Program.cs
    Properties/AssemblyInfo.cs
    Properties/Resources.Designer.cs
    Properties/Resources.resx
    Properties/Settings.Designer.cs
    Properties/Settings.settings
)

# Define resources folder
#source_group(Resources FILES Resources/pic.png)

# Set the .NET Framework version for the executable.
set_property(TARGET approximation PROPERTY VS_DOTNET_TARGET_FRAMEWORK_VERSION "v4.6.1")
# Set the executable to be 32-bit.
set_property(TARGET approximation PROPERTY WIN32_EXECUTABLE TRUE)
# Set the C# language version (defaults to 3.0).
set(CMAKE_CSharp_FLAGS "/langversion:latest")

# Set the source file properties for Windows Forms use.
csharp_set_windows_forms_properties(
    approximation.cs
    approximation.Designer.cs
    approximation.resx
    Program.cs
    Properties/AssemblyInfo.cs
    Properties/Resources.Designer.cs
    Properties/Resources.resx
    Properties/Settings.Designer.cs
    Properties/Settings.settings
)

# Add in the .NET reference libraries.
set_property(TARGET approximation PROPERTY VS_DOTNET_REFERENCES
    "Microsoft.CSharp"
    "System"
    "System.Collections.Generic"
    "System.Linq"
    "System.Threading.Tasks"
    "System.Windows.Forms"
    "System.Collections.Generic"
    "System.ComponentModel"
    "System.Data"
    "System.Drawing"
    "System.Text"
)
set(CMAKE_CONFIGURATION_TYPES "Debug;Release" CACHE STRING "Configs" FORCE)