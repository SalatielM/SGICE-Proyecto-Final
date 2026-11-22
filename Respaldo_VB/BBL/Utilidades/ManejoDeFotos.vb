Imports System.Drawing
Imports System.IO

Public Class ManejoDeFotos

    Public Shared Function ImagenABytes(img As Image) As Byte()

        If img Is Nothing Then
            Return Nothing
        End If

        Using ms As New MemoryStream()
            img.Save(ms, Imaging.ImageFormat.Png)
            Return ms.ToArray()
        End Using

    End Function

    Public Shared Function BytesAImagen(datos As Byte()) As Image

        If datos Is Nothing OrElse datos.Length = 0 Then
            Return Nothing
        End If

        Using ms As New MemoryStream(datos)

            Using imgTemporal As Image = Image.FromStream(ms)

                Return New Bitmap(imgTemporal)

            End Using

        End Using

    End Function


End Class
