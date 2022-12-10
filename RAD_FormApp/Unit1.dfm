object Form1: TForm1
  Left = 0
  Top = 0
  Align = alClient
  BorderStyle = bsNone
  Caption = 'Form1'
  ClientHeight = 339
  ClientWidth = 695
  Color = clSkyBlue
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 13
  object Image1: TImage
    Left = 32
    Top = 92
    Width = 561
    Height = 165
    AutoSize = True
  end
  object Button1: TButton
    Left = 288
    Top = 45
    Width = 145
    Height = 25
    Caption = #1047#1072#1075#1088#1091#1079#1080#1090#1100' '#1080#1079#1086#1073#1088#1072#1078#1077#1085#1080#1077
    TabOrder = 0
    OnClick = Button1Click
  end
  object TextBox_FilePath: TEdit
    Left = 208
    Top = 18
    Width = 449
    Height = 21
    TabOrder = 1
    Text = 'E:\SystemProgramming\Files\test.tsv'
  end
  object TextBox_Width: TEdit
    Left = 32
    Top = 18
    Width = 57
    Height = 21
    TabOrder = 2
    Text = '500'
    TextHint = #1064#1080#1088#1080#1085#1072
  end
  object TextBox_Height: TEdit
    Left = 112
    Top = 18
    Width = 57
    Height = 21
    TabOrder = 3
    Text = '500'
    TextHint = #1042#1099#1089#1086#1090#1072
  end
  object Memo1: TMemo
    Left = 824
    Top = 92
    Width = 649
    Height = 81
    Lines.Strings = (
      'Memo1')
    TabOrder = 4
  end
end
