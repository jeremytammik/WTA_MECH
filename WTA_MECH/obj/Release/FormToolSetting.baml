   M S B A M L   `   `   `  ���� C  ?WTA_MECH, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WTA_MECHWTA_MECH      WTA_MECH.FormToolSetting   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:WTA_MECH     -     � Title$  Tool Setting�� � WindowStyle$
 None=�
������  � AllowsTransparency . $��0q� � SizeToContent$ Height=�$	��431�� � 
ResizeMode$ NoResize=� � 	Resources  �� 
TargetType �� Property �� Value��%D   '_�       �� " _�.���  � ��
 ���� ��  � ��$ 0q�.���� -   $
��Body��
�������	 �� CornerRadius$	 24��$��3q�
�������._�]� -   $��A1����. .+��� -   
 ��Name$
 	btn_close��$
��Left=�$�� �� �� IsCancel .  J� Opacity$ 0Q�]� -   $��A2��$��Stretch=�$��Stretch=���. .+��� -    ��Name$ MsgLabelTop��$	��Top=�$��Center=� �� TextAlignment$ Center=�$��12(�$��10q�$��Purpose���� -   $ MsgLabelBot��$��Bottom=�$B��<(Press ESC to Dismiss or Click here when finished changing.)��$��Center=�$ Center=�$��11(��� $��5q�.+��� -   $ MsgTextBlockMainMsg��$
��Wrap=�$��Center=�$��Center=�$ Center=�$	��4,4q�$M��GThe main message body is here. What happens when this gets really long?��$��16(�&   System.Windows.Controls.DataGrid  -	   $��SettingsGrid��   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ *    RowHeaderWidth$ 0Q�   CanUserAddRows .     CanUserDeleteRows .     AlternatingRowBackground
 �����   HeadersVisibility$ Column=�   SelectionUnit$
 Cell=�   SelectionMode$ Single=�   CanUserSortColumns .  $�� 0, 0, 0, 6q� � ToolTip �� $	 10��
�������$��3q�
�������._��� $��4q�&$Edit the values as needed. Make sure�� !to click out of the cell before�� pressing ESC to dismiss.�� �� -+Reset will restores to the factory setting.�  � RowDefinitions �� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* � � ColumnDefinitions �� $
��Auto ��� $��* �.+��� $��0��$��0��$��Search Root: ���� -
    ��Name$ RootSearchPath��$��0��$��1�� �� TextWrapping$
 Wrap=�$��Root search path��.�� �� $	 10��
�������$	��310��$��3q�
�������._��� $��10q�$��14(�$ Justify=�$��Stretch=�,*When a family is not already loaded in the�� +)project, this is the starting folder from�� -+which all child folders will be searched to�� find that family to load..���� -    ��Name$ chkTagOtherViews��$��Tag Other View��$��4q�$��Center=� �� $	 10��
�������$	��310��$��3q�
�������._��� $��10q�$��14(�$ Justify=�$��Stretch=�0.The Tag will also be placed in the 'companion'�� .,view to this view. If this view is 'working"�� -+then a Tag is also placed in the 'plotting'�� view, and vice versa.�� -   $
 ResetToDefaults��$��Reset To Defaults��$��0,6,0,0q�