Public Class Organize
    Public Shared Sub OrganizeShit()
        Form1.LabelInGame.Location = Form1.ComboBoxAPBCompatSection.Location + Form1.ComboBoxAPBCompatSection.Size - New System.Drawing.Point(2, Form1.ComboBoxAPBCompatSection.Height - 4)
        Form1.LabelAPBCompatSection.Location = Form1.LabelInGame.Location + Form1.LabelInGame.Size - New System.Drawing.Point(4, Form1.LabelInGame.Height)
        'Form1.LabelStaticDecalsCurrent1.Location = Form1.CheckBoxStaticDecals.Location + Form1.CheckBoxStaticDecals.Size - New System.Drawing.Point(4, Form1.CheckBoxStaticDecals.Height - 2)
        'Form1.LabelStaticDecalsCurrent2.Location = Form1.LabelStaticDecalsCurrent1.Location + Form1.LabelStaticDecalsCurrent1.Size - New System.Drawing.Point(4, Form1.LabelStaticDecalsCurrent1.Height)
        Form1.LabelDynamicDecalsCurrent1.Location = Form1.CheckBoxDynamicDecals.Location + Form1.CheckBoxDynamicDecals.Size - New System.Drawing.Point(4, Form1.CheckBoxDynamicDecals.Height - 2)
        Form1.LabelDynamicDecalsCurrent2.Location = Form1.LabelDynamicDecalsCurrent1.Location + Form1.LabelDynamicDecalsCurrent1.Size - New System.Drawing.Point(4, Form1.LabelDynamicDecalsCurrent1.Height)
    End Sub
End Class
