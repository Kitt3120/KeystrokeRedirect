# KeystrokeRedirect

## How it works
KeystrokeRedirect will catch KeyDown-Events fired when the window is focused.
It will then loop through the user-selected processes and filter out processes with windows.
Windows native functions are called through the user32.dll to focus the windows and reflect the KeyDown-Event to them.
The KeystrokRedirect windows will be focused afterwards again.
