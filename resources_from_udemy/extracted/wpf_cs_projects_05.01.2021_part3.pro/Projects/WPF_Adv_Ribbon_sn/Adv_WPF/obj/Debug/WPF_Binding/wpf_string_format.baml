   M S B A M L   `   `   `  ����B  >Adv_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Adv_WPF.WPF_BindingAdv_WPF.WPF_Binding  5   	   +    %Adv_WPF.WPF_Binding.wpf_string_format   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Adv_WPF.WPF_Binding     5   	     � Title$  wpf_string_format��5   	   $��379.537��6#   $��548.577��64   .��5	      � .+�5
   
   �� -   5         ��Name$ my_tbox��5
      $
��Left=�6#   $��23��6>   $��
306,41,0,0q�6J    �� TextWrapping$
 Wrap=�5      $	��Top=�6x   $	��215��6�   ��6&   �� *Value+ �� ElementName$ 	my_slider�� �� Mode$ OneWay=� �� StringFormat$ {0:F2}��6�   �� 5   
   -   5         ��Name$ 	my_slider��5      $
��Left=�6$   $��	19,41,0,0q�6?   $	��Top=�6R   $	��271��6j    � Maximum$ 20000Q�6v    �� TickFrequency$	 500Q�6�   	 �� TickPlacement$	 TopLeft=�6�   �� 5   
   -   5        
 ��Name$
 my_lbl��5      $
��Left=�6^   $��
306,78,0,0q�6y   $	��Top=�6�   $	��215��6�    �� ContentStringFormat$ N4��6�   ��6    �� *Value+$ 	my_slider��$ OneWay=�6�   5      5      