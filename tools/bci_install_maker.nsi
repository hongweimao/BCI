;Product Info
Name "BCI" ;Define your own software name here
!define PRODUCT "BCI" ;Define your own software name here
!define VERSION "1.0.0" ;Define your own software version here

!include "MUI.nsh"
!include "winmessages.nsh"
!include "EnvVarUpdate.nsh"
!include "LogicLib.nsh"

;--------------------------------
;Configuration

  OutFile "bci_windows_setup.exe"

  !define MUI_ICON "bci.ico"

  ;Folder selection page
  InstallDir "$DOCUMENTS\${PRODUCT}"

  ;Remember install folder
  InstallDirRegKey HKCU "Software\${PRODUCT}" ""

;--------------------------------
;Pages
  !insertmacro MUI_PAGE_WELCOME
  !insertmacro MUI_PAGE_LICENSE "../LICENSE"
  !insertmacro MUI_PAGE_COMPONENTS
  !insertmacro MUI_PAGE_DIRECTORY
  !insertmacro MUI_PAGE_INSTFILES
  !insertmacro MUI_PAGE_FINISH
  !insertmacro MUI_UNPAGE_CONFIRM
  !insertmacro MUI_UNPAGE_INSTFILES

  !define MUI_ABORTWARNING

  !define MUI_HEADERBITMAP "${NSISDIR}\Contrib\Icons\modern-header.bmp"
  !define MUI_SPECIALBITMAP "${NSISDIR}\Contrib\Icons\modern-wizard.bmp"
 ;!define MUI_UI "${NSISDIR}\Contrib\UIs\default.exe" -- Generated by the gui, but causes errors
 
;--------------------------------
  ;Language
 
  !insertmacro MUI_LANGUAGE "English"
;--------------------------------
  ;Language Strings
 
  ;Descriptions
  LangString DESC_Section_Core   ${LANG_English} "BCI files"
  LangString DESC_Section_Shortcuts ${LANG_English} "Shortcuts to BCI in the Start Menu and on the Desktop"
  LangString DESC_Section_Uninstaller ${LANG_English} "BCI Uninstaller"

     
Section "Core" section_Core
  SectionIn RO

  SetOutPath "$INSTDIR"
  FILE "..\README.md"
  FILE "..\LICENSE"
  
  SetOutPath "$INSTDIR\app_configs"
  File /r /x *.bat "..\app_configs\*.*"
  
  ;SetOutPath "$INSTDIR\data"
  CreateDirectory "$INSTDIR\data"
  
  SetOutPath "$INSTDIR\message_definitions"
  FILE /r /x *.pyc "..\message_definitions\*.*"
  
  SetOutPath "$INSTDIR\modules"
  FILE /r /x *.pyc /x *.pdb /x *.ncb /x *.user /x *.suo /x Release /x Debug /x obj "..\modules\*.*"
  
  SetOutPath "$INSTDIR\tools"
  FILE /r /x *.ico /x *.nsi /x *.pyc /x *.exe "..\tools\*.*"
  
    
  !define env_hklm 'HKLM "SYSTEM\CurrentControlSet\Control\Session Manager\Environment"'
  ; set variable
  WriteRegExpandStr ${env_hklm} BCI_ROOT "$INSTDIR"
  WriteRegExpandStr ${env_hklm} BCI_INCLUDE "$INSTDIR\message_definitions"
  WriteRegExpandStr ${env_hklm} BCI_COMMON "$INSTDIR\modules\Common"
  WriteRegExpandStr ${env_hklm} BCI_MODULES "$INSTDIR\modules"
  WriteRegExpandStr ${env_hklm} BCI_CONFIG "$INSTDIR\app_configs"
  WriteRegExpandStr ${env_hklm} BCI_DATA "$INSTDIR\data"

  ReadEnvStr $R0 "PYTHONPATH" 
  ${If} $R0 == ''
      WriteRegExpandStr ${env_hklm} PYTHONPATH "$INSTDIR\message_definitions"
      ; make sure windows knows about the change
      SendMessage ${HWND_BROADCAST} ${WM_WININICHANGE} 0 "STR:Environment" /TIMEOUT=5000
  ${Else}
      ; make sure windows knows about the change
      SendMessage ${HWND_BROADCAST} ${WM_WININICHANGE} 0 "STR:Environment" /TIMEOUT=5000
      ${EnvVarUpdate} $0 "PYTHONPATH" "A" "HKLM" "$INSTDIR\message_definitions"
  ${EndIf}
  ${EnvVarUpdate} $0 "PYTHONPATH" "A" "HKLM" "$INSTDIR\modules\Common\python"

  ReadEnvStr $R0 "EDITOR" 
  ${If} $R0 == ''
      WriteRegExpandStr ${env_hklm} EDITOR "%WINDIR%\System32\notepad.exe"
      ; make sure windows knows about the change
      SendMessage ${HWND_BROADCAST} ${WM_WININICHANGE} 0 "STR:Environment" /TIMEOUT=5000
  ${EndIf}
SectionEnd

Section "Shortcuts" section_Shortcuts
  SetShellVarContext all
  CreateDirectory "$SMPROGRAMS\${PRODUCT}"
  CreateShortCut "$SMPROGRAMS\${PRODUCT}\app_configs.lnk" "$INSTDIR\app_configs"
  CreateShortCut "$SMPROGRAMS\${PRODUCT}\data.lnk" "$INSTDIR\data"
  CreateShortCut "$SMPROGRAMS\${PRODUCT}\message_definitions.lnk" "$INSTDIR\message_definitions"
  CreateShortCut "$SMPROGRAMS\${PRODUCT}\modules.lnk" "$INSTDIR\modules"
  CreateShortCut "$SMPROGRAMS\${PRODUCT}\tools.lnk" "$INSTDIR\tools"
  CreateShortCut "$DESKTOP\BCI.lnk" "$INSTDIR"
SectionEnd

Section "Uninstaller" section_Uninstaller
  SetShellVarContext all

  CreateShortCut "$SMPROGRAMS\${PRODUCT}\Uninstall.lnk" "$INSTDIR\uninst.exe" "" "$INSTDIR\uninst.exe" 0
  
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT}" "DisplayName" "${PRODUCT} ${VERSION}"
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT}" "DisplayVersion" "${VERSION}"
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT}" "URLInfoAbout" ""
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT}" "Publisher" "MotorLab�"
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT}" "UninstallString" "$INSTDIR\Uninst.exe"
  WriteRegStr HKLM "Software\${PRODUCT}" "" $INSTDIR
  
  WriteUninstaller "$INSTDIR\Uninst.exe"
SectionEnd
 
!insertmacro MUI_FUNCTION_DESCRIPTION_BEGIN
  !insertmacro MUI_DESCRIPTION_TEXT ${section_Core} $(DESC_Section_Core)
  !insertmacro MUI_DESCRIPTION_TEXT ${section_Shortcuts} $(DESC_Section_Shortcuts)
  !insertmacro MUI_DESCRIPTION_TEXT ${section_Uninstaller} $(DESC_Section_Uninstaller)
!insertmacro MUI_FUNCTION_DESCRIPTION_END
 
Function un.onUninstSuccess
  HideWindow
  MessageBox MB_ICONINFORMATION|MB_OK "$(^Name) was successfully removed from your computer.."
FunctionEnd
  
Function un.onInit 
  MessageBox MB_ICONQUESTION|MB_YESNO|MB_DEFBUTTON2 "Are you sure you want to completely remove $(^Name) and all of its components?" IDYES +2
  Abort
FunctionEnd
 
Section "Uninstall" 
  SetShellVarContext all
  
  RMDir /r /REBOOTOK "$INSTDIR"
  RMDir /r "$SMPROGRAMS\${PRODUCT}"

  Delete "$DESKTOP\BCI.lnk"
  DeleteRegKey HKEY_LOCAL_MACHINE "SOFTWARE\${PRODUCT}"
  DeleteRegKey HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT}"
  
  ; delete variable
  DeleteRegValue ${env_hklm} BCI_ROOT 
  DeleteRegValue ${env_hklm} BCI_INCLUDE
  DeleteRegValue ${env_hklm} BCI_COMMON 
  DeleteRegValue ${env_hklm} BCI_MODULES
  DeleteRegValue ${env_hklm} BCI_CONFIG 
  DeleteRegValue ${env_hklm} BCI_DATA
  ; make sure windows knows about the change
  SendMessage ${HWND_BROADCAST} ${WM_WININICHANGE} 0 "STR:Environment" /TIMEOUT=2000  

  ; Remove from PYTHONPATH  
  ${un.EnvVarUpdate} $0 "PYTHONPATH" "R" "HKLM" "$INSTDIR\modules\Common\python"
  ${un.EnvVarUpdate} $0 "PYTHONPATH" "R" "HKLM" "$INSTDIR\message_definitions"
SectionEnd
               
;Function .onInstSuccess
;   MessageBox MB_ICONQUESTION|MB_YESNO|MB_DEFBUTTON2 "Would you like to start $(^Name) now?" IDYES true IDNO false
;   true:
;     ExecShell open "$INSTDIR\bin\MessageManager.exe"
;   false:
;FunctionEnd
   
;eof