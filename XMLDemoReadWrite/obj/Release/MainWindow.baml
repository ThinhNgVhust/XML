   M S B A M L   `   `   `  ���� K  GXMLDemoReadWrite, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:XMLDemoReadWriteXMLDemoReadWrite  !    XMLDemoReadWrite.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     0localclr-namespace:XMLDemoReadWrite     $	��600��$	��400��  � 
ResizeMode$  NoResize=� � Title$ DemoXML - By ThingNgHust��.���  � RowDefinitions �� $��1* ��� $��2* �.+��  �� $��1* ��� $��1* ��� $��1* ��� $��1* � � ColumnDefinitions �� $��1* ��� $��3* �.+��� $��Name:��$��
10,10,0,10q�$��16(��� $
��Age:��$��	10,10,0,0q�$��1��$��16(��� $��Point:��$��	10,10,0,0q�$��2��$��16(��� $��1��$��30��$��0q� �� TextWrapping$
 Wrap=�$	��200��$��16(����� *
NameTemple+�� $��1��$��30��$��
48,10,48,7q�$
 Wrap=�$	��200��$��16(�$��1������ *	AgeTemple+�� $��1��$��30��$��
48,10,48,8q�$
 Wrap=�$	��200��$��16(�$��2������ *PointTemple+� $��1��$��113,10,0,-63q�$��3���� $	��Add��$��1��$��48,10,148,2q�$��3��$	��100��$��16(�$��35��{��� *
IsValidate+���� *
AddStudent+���� *StudentTemplate+� $��1��$��10q�.+��� -    ��Name$ listBox1������ *
Students+���� .R��� $��1q�
��� � �$��2q� �� Padding$ 5q�$	��200�� �� CornerRadius$ 3��._��  �� �� �� .+��� $��0������  �� Path$
 Name��� $��1��$��Italic$����� $	 Age��� $��2��$��Italic$����� $ Point�