Imports System.Data.OleDb

Module DBTool
    Public Function connectDB()
        Dim sDbCon As String
        'sDbCon = "Provider=Microsoft.ACE.OLEDB.12.0;" &
        '  "Data Source=../../XXX.accdb"
        sDbCon = "Provider=Microsoft.Jet.OLEDB.4.0;" &
           "Data Source=../../Database.mdb"

        '建立Connection物件
        Dim objCon = New OleDbConnection(sDbCon)

        '開啟資料庫連結
        objCon.Open()

        Return objCon
    End Function

End Module
