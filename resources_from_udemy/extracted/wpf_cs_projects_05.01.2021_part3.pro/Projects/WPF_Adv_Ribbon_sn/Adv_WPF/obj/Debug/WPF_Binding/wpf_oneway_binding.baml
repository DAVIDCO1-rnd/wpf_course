   M S B A M L   `   `   `  ����B  >Adv_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Adv_WPF.WPF_BindingAdv_WPF.WPF_Binding  5   	   %    Adv_WPF.WPF_Binding.wpf_binding   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Adv_WPF.WPF_Binding     5   	     � Title$  wpf_oneway_binding��5   	   $��351.698��6$   $��483.961��65    � 	Resources 5	          BooleanToVisibilityConverter��%   &	        �� 5
   
   6'   5      .��5      � .+�5   
   �� -   5         ��Name$ 	my_slider��5      $
��Left=�6$   $��	22,24,0,0q�6?   $	��Top=�6R   $	��211��6j    � Maximum$	 100Q�6v    �� TickPlacement$ TopLeft=�6�    �� TickFrequency$ 5Q�6�    � Value$ 50Q�6�   �� 5   
   -   5         ��Name$ my_tbox��5      $
��Left=�6#   $��23��6>   $��
238,27,0,0q�5       �� TextWrapping$
 Wrap=�6&   $	��Top=�5   M   $��56��6e   ��6   �� *Value+	 �� ElementName$	 	my_slider��
 �� Mode$
 OneWay=�6e   � 5   
   -   5         �Name$ first_prog_bar��5      $
��Left=�6.   $��20��6I   $��	31,90,0,0q�6U   $	��Top=�6h   $	��188��6�    6�   �� *Value+$	 	my_slider��$
 OneWay=�� 5   
   -   5        $ second_prog_bar��5      $
��Left=�6/   $	��120��6J   $��
308,24,0,0q�6W   $	��Top=�6k   $��22��6�    � Orientation$ Vertical=�6�    6�   �� *Text+$	 my_tbox��6�   �� 5   
   -   5         ��Name$ enable_disable_butt��5      $��Enable / Disable Button��60   $
��Left=�6R   $��
83,253,0,0q�5      $	��Top=�6!   $��22��69   $	��154��5       � Cursor$
 Hand��6    d� 	IsChecked$
 TrueY�6'   �� 5   
   -   5         ��Name$ 	test_butt��5      $��Test Button��6$   $
��Left=�6:   $��
83,203,0,0q�5      $	��Top=�6%   $	��134��6=   $��34��6I   $��20(�5      {�6   �� *	IsChecked+$	 enable_disable_butt��$
 OneWay=�y�5      �� *	IsChecked+ �� 	Converter# [  $	 show_hide_butt��$
 OneWay=��� 5   
   -   5        $ show_hide_butt��5      $��Show/Hide Button��6+   $
��Left=�6F   $��
83,280,0,0q�6a   $	��Top=�6u   $
 TrueY�6�   	� 5   
   -   5         	�Name$ 
male_rbutt��5      $
��Left=�6,   $��337,185,0,0q�6G   $	��Top=�6\   $
 Hand��6t   $��82��6�   $
 TrueY�6�   $��26��6�    	� 	GroupName$ Gender��6�   $��Center=�6�   .��5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��22��6   $��18��6#   $6��0/Adv_WPF;component/2nd_ctls/Images/male_user.png��6/   �� 5      $
��Male��6   5!      5"      	� 5#   
   -	   5        $ female_rbutt��5#      $
��Left=�6.   $��337,222,0,0q�6I   $	��Top=�6^   $
 Hand��6v   $ Gender��6�   $��Center=�6�   $
 TrueY�6�   .��5$      �� $ 
Horizontal=�6   .+�5%      �� $��22��6   $��18��6#   $8��2/Adv_WPF;component/2nd_ctls/Images/female_user.png��6/   �� 5&      $��Female��6   5(      5)      � 5*   
   -
   5         �Name$ female_grid��5*      $��297,250,21,33q�6$   y�6;   �� *	IsChecked+# [  $	 female_rbutt��$
 OneWay=�{�6�   �� *	IsChecked+$	 female_rbutt��$
 OneWay=�.+�5+      �� -   5         ��Name$ female_combobox��5+      $
��Left=�60   $��39,4,0,0q�6K   $	��Top=�6]   $��90��6u   .@�5,      �� $
��Girl��6   $
��Left=�6.   $��92��6I   �� 5-      $��Woman��6   $
��Left=�6/   $��92��6J   5.      �� 5/      $��Type:��6   $
��Left=�6$   $	��Top=�6?    J� RenderTransformOrigin$ -0.432,0.462&�6W   50      �� 51   
   $��Gender:��6   $
��Left=�6"   $��264,185,0,0q�6=   $	��Top=�6R   $
��Bold"�6j   53      54      