library project1;

uses Classes;

function Add2(val1: integer; val2: integer): integer; stdcall;

begin

Result := val1 + val2;

end;

exports

Add2;

begin

end.
