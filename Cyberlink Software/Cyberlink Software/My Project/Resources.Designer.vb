
Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo

        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Cyberlink_Software.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property

        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property

        Friend ReadOnly Property about_button() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("about_button", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property

        Friend ReadOnly Property about_down() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("about_down", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property about_enter() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("about_enter", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property

        Friend ReadOnly Property AboutDiag() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("AboutDiag", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property killer_button() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("killer_button", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property killer_down() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("killer_down", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property killer_enter() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("killer_enter", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property

        Friend ReadOnly Property MainDiag() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("MainDiag", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property patch_button() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("patch_button", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property patch_down() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("patch_down", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property patch_enter() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("patch_enter", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property REiS() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("REiS", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
    End Module
End Namespace
