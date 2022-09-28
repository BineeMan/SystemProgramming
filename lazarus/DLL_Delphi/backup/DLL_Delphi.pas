library DLL_Delphi;

function Add2(val1: integer; val2: integer): integer; stdcall;

begin

Result := val1 + val2;

end;

//PWideChar - LPCWSTR
//WideString - BSTR

function GetFileContent_Delphi(filePath: PWideChar ): WideString; stdcall;
         var f: file of char;
         var c: char;
         var content: string ;


exports
GetFileContent_Delphi,
Add2;


begin

end.
