   M S B A M L   `   `   `  ����B  >Adv_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Adv_WPF.WPF_BindingAdv_WPF.WPF_Binding  5   	   -    'Adv_WPF.WPF_Binding.wpf_binding_project   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Adv_WPF.WPF_Binding     5   	     � Title$  wpf_binding_project��5   	   $��339.398��6%   $��454.096��66   .��5	      � .+�5
   
   �� -   5         ��Name$ width_slider��5
      $��
33,24,25,0q�6'   $	��Top=�6;    � Minimum$ 50Q�6S    � Maximum$
 1000Q�6`    �� TickPlacement$ TopLeft=�6o    �� TickFrequency$ 20Q�6�    � Value$	 100Q�6�   �� 5   
   -   5        $ height_slider��5      $
��Left=�6(   $��
16,64,0,21q�6C   $��27��6W    �� Orientation$ Vertical=�6b   $ TopLeft=�6y   $ 10Q�6�   $ 50Q�6�   $	 800Q�6�   $ 80Q�6�   �� 5   
   -   5         ��Name$ my_image��5      $
��Left=�6"   $��	65,53,0,0q�6~   $	��Top=�6�   $��Images/koala_resized.jpg��6�   $
��Fill=�6
  ��6=   �� *Value+	 �� ElementName$	 height_slider��
 �� Mode$
 OneWay=���6�   �� *Value+$	 width_slider��$
 OneWay=�6
  5      5      