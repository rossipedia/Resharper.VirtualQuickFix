@echo off
call "%VS110COMNTOOLS%vsvars32.bat"
msbuild Resharper.VirtualQuickFix.sln /p:Configuration=Debug /p:Platform="Any CPU"
