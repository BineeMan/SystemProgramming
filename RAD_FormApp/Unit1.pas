unit Unit1;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.ExtCtrls, Vcl.StdCtrls,
  Math, StrUtils, ActiveX;

  type PDrawCallback1 =
      function ( const FileName: PWideChar;
       Width: Integer; Height: Integer; out MyBmb: HBITMAP): HResult; stdcall;

type
  TForm1 = class(TForm)
    Button1: TButton;
    TextBox_FilePath: TEdit;
    Image1: TImage;
    TextBox_Width: TEdit;
    TextBox_Height: TEdit;



    procedure Button1Click(Sender: TObject);
  private
    { Private declarations }
  public
    DrawCallback: PDrawCallback1;
    HInWindow: HWND;
    //HOutWindow: HWND;
    //lpReserved: LPVoid;
    { Public declarations }
  end;

  function GetExternalWindow2( DrawCallback1: PDrawCallback1;
  HInWindow: HWND; out HOutWindow: HWND;
    out StatusInfo: WideString; lpReserved: Integer) : HResult; stdcall;

var
  Form1: TForm1;


implementation

{$R *.dfm}

var
  i: HWND;
  filePath: String;

procedure TForm1.Button1Click(Sender: TObject);
var
    Width: Integer;
    Height: Integer;
    filePath: String;
    MyHbitmap: HBITMAP;
    res: HResult;
    bmp: Tbitmap;

begin
  filePath := 'E:\SystemProgramming\Files\test.tsv';
  const test : PWideChar = 'E:\SystemProgramming\Files\test.tsv';

  //filePath := TextBox_FilePath.Text;
  Width := StrToInt(TextBox_Width.Text);
  Height:= StrToInt(TextBox_Height.Text);
  //MessageBox(Form1.Handle, PChar(filePath), PChar('NOT NULL'), MB_OK);

  res := DrawCallback(test, Width, Height, MyHbitmap);

  if ( MyHbitmap = NULL ) then begin
    MessageBox(Form1.Handle, PChar( 'NULL' ), PChar('asd'), MB_OK);
  end
  else begin
    MessageBox(Form1.Handle, PChar(IntToStr(MyHbitmap) + ' '+ IntToStr(res)), PChar('NOT NULL'), MB_OK);
    Image1.Picture.Bitmap.Handle := MyHbitmap;

    bmp := TBitmap.Create;
    //bmp := CreateBitmapFromHBITMAP(MyHbitmap);
    //bmp.Handle :=  MyHbitmap;
    bmp.SaveToFile('E:\SystemProgramming\Files\xdd.bmp');
    bmp.Free;
    Image1.Refresh;
  end;

end;


function GetForm(Out FormHandle: HWND; DrawCallback1: PDrawCallback1;  pAppHwnd: HWND): HResult;
begin
  Form1 := TForm1.Create(nil);
  Form1.Show;
  FormHandle := Form1.Handle;

  Form1.DrawCallback := DrawCallback1;

end;


function GetExternalWindow2( DrawCallback1: PDrawCallback1;
  HInWindow: HWND; out HOutWindow: HWND;
    out StatusInfo: WideString; lpReserved: Integer) : HResult; stdcall;
begin
  try
    begin
      GetForm(HOutWindow, DrawCallback1, HInWindow);

      Result := 1;
    end
  except
    on E: Exception do Result := -1
  end;

end;

end.

