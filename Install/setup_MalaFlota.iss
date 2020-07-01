[Setup]
OutputDir=.\
VersionInfoVersion=1.0.0.1
AppVerName=Ma�a Flota Samochodowa 1.0.0.1
VersionInfoTextVersion=Ma�a Flota 1.0.0.1
VersionInfoCompany=Jacek Kalisz
VersionInfoDescription=Jacek Kalisz
ShowLanguageDialog=no
MinVersion=5.0.2195
AppCopyright=Jacek Kalisz Soft
AppName=Ma�a Flota Samochodowa
DefaultDirName={pf}\Jacek Kalisz Soft\Ma�a Flota Samocodowa
DefaultGroupName=Jacek Kalisz Soft
OutputBaseFilename=setup_MalaFlota
UserInfoPage=false
;AlwaysRestart=true
;RestartIfNeededByRun=false
UninstallDisplayIcon={app}\malaFlota.exe
VersionInfoCopyright=Jacek Kalisz Soft
ShowTasksTreeLines=true
DirExistsWarning=no
ChangesEnvironment=yes
Uninstallable=yes
WizardImageFile=.\ISSkin\logo.bmp
WizardSmallImageFile=.\ISSkin\small_logo.bmp
;PrivilegesRequired=admin
            

[Types]
Name: full; Description: Pe�na instalacja
Name: custom; Description: Tylko wybrane; Flags: iscustom

[Components]
Name: m_mf; Description: Ma�a Flota Samochodowa; Types: full 

[Tasks]
;GroupDescription: {cm:AdditionalIcons};
Name: desktopicon; Description: Utw�rz ikony na pulpicie; GroupDescription: "Dodatkowe ikony:"; Flags: unchecked
Name: desktopicon\common; Description: "Dla wszystkich u�ytkownik�w komputera"; GroupDescription: "Dodatkowe ikony:"; Flags: exclusive
Name: desktopicon\user; Description: "Tylko bie��cy u�ytkownik komputera"; GroupDescription: "Dodatkowe ikony:"; Flags: exclusive unchecked
Name: quicklaunchicon; Description: "Utw�rz ikony w pasku narz�dzi szybkiego uruchamiania"; GroupDescription: "Dodatkowe ikony:"; Flags: unchecked

[Files]
; Add the ISSkin DLL used for skinning Inno Setup installations.
Source: .\ISSkin\ISSkin.dll; DestDir: {app}; Flags: dontcopy

; Add the Visual Style resource contains resources used for skinning,
; you can also use Microsoft Visual Styles (*.msstyles) resources.
Source: .\ISSkin\Office2007.cjstyles; DestDir: {tmp}; Flags: dontcopy

          
; Ma�a Flota Samochodowa
Source: ..\malaFlota\bin\Release\malaFlota.exe; DestDir: {app}; Components: m_mf; Flags: ignoreversion
Source: ..\malaFlota\bin\Release\Zasoby.dll; DestDir: {app}; Components: m_mf; Flags: ignoreversion
Source: ..\malaFlota\bin\Release\malaFlota.exe.config; DestDir: {app}; Components: m_mf; Flags: ignoreversion
Source: ..\malaFlota\bin\Release\Formularz.dll; DestDir: {app}; Components: m_mf; Flags: ignoreversion
Source: ..\malaFlota\bin\Release\DB.dll; DestDir: {app}; Components: m_mf; Flags: ignoreversion
Source: ..\malaFlota\bin\Release\CrystalReport.dll; DestDir: {app}; Components: m_mf; Flags: ignoreversion
Source: ..\malaFlota\bin\Release\crListaKierowca.rpt; DestDir: {app}; Components: m_mf; Flags: ignoreversion
Source: ..\malaFlota\bin\Release\crListaPojazd.rpt; DestDir: {app}; Components: m_mf; Flags: ignoreversion
Source: ..\malaFlota\bin\Release\crListaWyjazd.rpt; DestDir: {app}; Components: m_mf; Flags: ignoreversion

[LangOptions]
LanguageName=Polish
LanguageID=$0415

[Languages]
Name: PL; MessagesFile: compiler:Languages\Polish.isl

[Icons]
; Ma�a Flota Samochodowa
Name: "{commonstartmenu}\Ma�a Flota Samochodowa"; Filename: {app}\malaFlota.exe; IconIndex: 0; IconFilename: {app}\malaFlota.exe; WorkingDir: {app}; Components: m_mf
Name: "{group}\Ma�a Flota Samochodowa"; Filename: {app}\malaFlota.exe; IconIndex: 0; IconFilename: {app}\malaFlota.exe; WorkingDir: {app}; Components: m_mf
Name: "{userdesktop}\Ma�a Flota Samochodowa"; Filename: {app}\malaFlota.exe; WorkingDir: {app}; IconFilename: {app}\malaFlota.exe; IconIndex: 0; Components: m_mf; Tasks: desktopicon\user
Name: "{commondesktop}\Ma�a Flota Samochodowa"; Filename: {app}\malaFlota.exe; WorkingDir: {app}; IconFilename: {app}\malaFlota.exe; IconIndex: 0; Components: m_mf; Tasks: desktopicon\common
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\Ma�a Flota Samochodowa"; Filename: {app}\malaFlota.exe; WorkingDir: {app}; IconFilename: {app}\malaFlota.exe; IconIndex: 0; Components: m_mf; MinVersion: 4,4; Tasks: quicklaunchicon

[_ISTool]
UseAbsolutePaths=false

[Code]
// Importing LoadSkin API from ISSkin.DLL
procedure LoadSkin(lpszPath: String; lpszIniFileName: String);
external 'LoadSkin@files:isskin.dll stdcall';

// Importing UnloadSkin API from ISSkin.DLL
procedure UnloadSkin();
external 'UnloadSkin@files:isskin.dll stdcall';

// Importing ShowWindow Windows API from User32.DLL
function ShowWindow(hWnd: Integer; uType: Integer): Integer;
external 'ShowWindow@user32.dll stdcall';

function InitializeSetup(): Boolean;
begin
	ExtractTemporaryFile('Office2007.cjstyles');
	LoadSkin(ExpandConstant('{tmp}\Office2007.cjstyles'), 'NormalBlack.ini');
	Result := True;
end;

procedure DeinitializeSetup();
begin
	// Hide Window before unloading skin so user does not get
	// a glimse of an unskinned window before it is closed.
	ShowWindow(StrToInt(ExpandConstant('{wizardhwnd}')), 0);
	UnloadSkin();
end;

function ModPathDir(): TArrayOfString;
 var Dir:	TArrayOfString;
 begin
	setArrayLength(Dir, 1)
	Dir[0] := ExpandConstant('{app}');
	Result := Dir;
 end;

 #include ".\ISSkin\modpath.iss"



