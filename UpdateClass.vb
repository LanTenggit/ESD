Imports FSLib.App.SimpleUpdater
''' <summary>
''' 自动更新
''' </summary>
Public Class UpdateClass

    ''' <summary>
    ''' 实例化升级组件
    ''' </summary>
    Public Updater As Updater = FSLib.App.SimpleUpdater.Updater.Instance

    Public Sub New()
        '空构造
    End Sub

    ''' <summary>
    '''获取当前升级地址URL
    ''' </summary>
    ''' <returns></returns>
    Public Property Get_URL As String

    ''' <summary>
    ''' 检测并执行自动更新
    ''' </summary>
    Public Sub StartUpdate(Optional ByVal Url As String = "http://10.124.149.29/update/ESDKANBAN/update.xml")
        Get_URL = Url
        '加载更新url地址
        Updater.CheckUpdateSimple(Get_URL)
        '检查更新
        Updater.CheckUpdateSimple()

    End Sub

End Class
