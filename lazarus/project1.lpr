library project1;

function Add2(val1: integer; val2: integer): integer; stdcall;

begin

Result := val1 + val2;

end;

function GetFileContent(filePath: PWideChar): WideString; stdcall;
         var f: file of char;
         var c: char;
         var content: string ;
         var content_bstr: WideString ;
             begin
                 assign(f, filePath);
                 reset(f);
                 content := '';
                 while not eof(f) do begin
                     read(f, c);
                     content := content + c
                 end;
                 close (f);
                 content_bstr := content;
                 Result := content_bstr;

             end;

exports
GetFileContent,
Add2;


begin

end.
