# WPF.Services
A collection of common, reusable services for WPF applications.

## Installation (Git Submodule)
Since this library is not yet on NuGet, the recommended way to use it is as a Git submodule. 
This allows you to keep the library updated while keeping it inside your own repository.

1. Add the Submodule
Open your terminal in your main project's root folder and run:

		git submodule add https://github.com/msamula/WPF.Services.git Libs/Wpf.Services

2. Add to your Solution

	2.1. Open your project in Visual Studio.

	2.2. Right-click on your Solution > Add > Existing Project...

	2.3. Navigate to Libs/Wpf.Services and select the .csproj file.

3. Add Project Reference

	3.1. In your Main UI Project, right-click Dependencies (or References).

	3.2. Select Add Project Reference.

	3.3. Check the box for Wpf.Services.


## Updating the Submodule
If you have added this library as a git submodule, run the following command inside the submodule's directory in your terminal:

```
git pull origin master
```


## Available Services

### FileDialog Services

- **OpenFileDialogService**	=>	Service for handling file open dialogs.
- **OpenFolderDialogService**	=>	Service for handling folder open dialogs.
- **SaveFileDialogService**	=>	Service for handling file save dialogs.


## License
MIT License

Copyright (c) 2026 MICHAEL SAMULA

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
