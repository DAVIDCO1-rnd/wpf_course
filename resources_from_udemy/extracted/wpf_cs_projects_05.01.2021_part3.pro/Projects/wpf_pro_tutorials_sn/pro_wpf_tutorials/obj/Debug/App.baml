   M S B A M L   `   `   `  ����L  Hpro_wpf_tutorials, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:pro_wpf_tutorialspro_wpf_tutorials  5          pro_wpf_tutorials.App   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      1localclr-namespace:pro_wpf_tutorials     5        �� 	Resources  5         
small_butt �� 
TargetType �� Property �� Value  AppButt �� Triggers P� Property P� Value  AppDataTrigerButt �� Binding �� ElementName	 �� Path
 �� Value  MyCustomButt �� 
TargetType ��Name �� CornerRadius � Cursor �� Triggers �� 
TargetName��%�  &	        &	 �     &	 �    &	 �    �� 5	   
   " ��6#   .�5
      ��  � ��
 � d �6+   �� 5       � ��
 �����6+   �� 5       �@�Cursor$
 Hand��6'   �� 5       � ��$	 250��6&   5      �� 5   
   " ��6    .�5      ��  � ��
 ��  �6+   �� 5       � ��$ Grid Hi!��6(   �� 5       � ��$	 120��6&    5      P� 5       �@J�IsMouseOver . . �5      ��  � ��$ 18(�62   �� 5       � ��
 �  ��64   �� 5       �@�Cursor$
 Hand��60   �� 5       � ��$ 2q�69   �� 5       � ��$ I'm Button!��60   �� 5       � ��$	 150��6.   5      P� 5       � �� . . �5       ��  � ��$ I'm Pressed!��60   5!      5#      �� 5%   
   " ��6*   .�5&      ��  � {� .  6:   �� 5'       � y�$ Hidden=�6+   6<    5)      �� 5+       6   �� $ is_bold_chbox��$	 	IsChecked�
 True6]   .a�5,      ��  � ��$
 Bold"�63   5-      �� 5/       6   �� $ is_enabled_butt��$	 	IsChecked�
 True6]   .a�50      ��  � {� . 62   51      �� 53       6   �� $ is_visible_butt��$	 	IsChecked�
 True6]   .a�54      ��  � y�$ Visible=�63   55      59      �� 5;   
   " ��6/   .R�5<      � .+�5=      �� $ 	in_border��6   #��z��6,   $ 8��6_   # z 5>      #��z��6B   #��z��6w   �� 5?      $��Center=�6#   $��Center=�6@   5@       5B      P� 5C       �@J�IsMouseOver . . �5D      �� $ 	in_border��64    � ��
 � ���6K   �� 5E      $ 	in_border��60    �@�Cursor$
 Hand��6G   5F      5H      5J      5L      