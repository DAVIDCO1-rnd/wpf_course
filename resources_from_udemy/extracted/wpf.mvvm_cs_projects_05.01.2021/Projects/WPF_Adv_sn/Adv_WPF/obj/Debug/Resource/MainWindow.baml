   M S B A M L   `   `   `  ����B  >Adv_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:Adv_WPFAdv_WPF  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	       Adv_WPF.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Adv_WPF     5   	   9System&clr-namespace:System;assembly=mscorlib     5   	   -   5          �Name$  main_window��5   ?    � Title$ WPF Resource��5   	   $��323.306��6   $��682.868��6/    � WindowStartupLocation$ CenterScreen=�6?    � 	Resources 5	         butt_height  
butt_width  butt_back_color �� Color  butt_cursor  window_read_butt_width��%�   &	        &	      &	 5     &	 X     &	 t     X�5
   
   30Q�60   X�5   
   100Q�60   �� 5   
   $ 	#FFF5EFEF��62   ��5   
   Hand��6+   X�5   
   132Q�6<   5      .��5      � -   5         �Name$ 	main_grid��5      .+�5   
   � -   5        $ first_sub_grid��5      $
��Left=�6'   $	��213��6B   $��	20,33,0,0q�6O   $	��Top=�6b   $	��142��6z   ���	#FFF0F0F0 5        grid_butt_width  grid_butt_height��%I   &	       &	      X�5      100Q�6=   X�5      25Q�6=   5      .+�5      �� -   5         ��Name$ 	save_butt��5      $
��Save��6(   $
��Left=�67   $��	27,44,0,0q�6R   $	��Top=�6e   #���  6}   #���  6�   #���  6�    � Cursor# �  6  �� 5      $	��New��6   $
��Left=�6#   $��	27,84,0,0q�6>   $	��Top=�6Q   #���  6i   #���  6�   #���  6�   # �  6�   �� 5      $
��Edit��6   $
��Left=�6$   $��
27,123,0,0q�6?   $	��Top=�6S   #���  6k   # �  6�   #���  6�   #���  6�   5      �� 5   
     exit_butt_text#���  6   $
��Left=�6<   $��
303,10,0,0q�6W   $	��Top=�6k     exit_butt_width#���  6�    	 exit_butt_height#��� 	 6�    
 exit_butt_back_color#��� 
 6�     exit_butt_cursor# �  6  � 5    
   -   5        $ second_sub_grid��5       $
��Left=�6(   $	��213��6C   $��
180,33,0,0q�6P   $	��Top=�6d   $	��109��6|   ���	#FFF7F1F1 5!        grid2_butt_width  grid2_butt_height��%I   &	       &	      X�5$      75Q�6=   X�5%      NaNQ�6?   5'      .+�5(      �� $
��Save��6   $
��Left=�6$   $��	24,72,0,0q�6?   $	��Top=�6R   #���  6j   #���  6�   �� 5)      $	��New��6   $
��Left=�6#   $��
24,107,0,0q�6>   $	��Top=�6R   $��75��6j   5*      � 5+   
   -   5        $ grid_res_loader��5+      $
��Left=�6(   $	��118��6C   $��
402,33,0,0q�6P   $	��Top=�6d   $	��261��6|   ���	#FFDBEADD 5,        grid_res_load_butt_width��%%   &	       X�5.      132Q�6F   5/      .+�50      �� -   5        $ window_res_butt��50      $��Load Window Resource��6.   $
��Left=�6M   $��	10,25,0,0q�6h   $	��Top=�6{   #���  6�   6�   �� 51      -   5         ��Name$ window_res_lbl��51      $��Label��6,   $
��Left=�6<   $��
158,21,0,0q�6W   $	��Top=�6k   $��94��6�   �� 52      -	   5        $ app_res_butt��52      $��Load App Resource��6+   $
��Left=�6G   $��	10,56,0,0q�6b   $	��Top=�6u     load_butt_app_res_butt#���  6�   6�   �� 53      -
   5        $ app_res_lbl��53      $��Label��6)   $
��Left=�69   $��
158,53,0,0q�6T   $	��Top=�6h   $��94��6�   �� 54      -   5        $ grid_res_butt��54      $��Load Grid Resource��6,   $
��Left=�6I   $��	10,87,0,0q�6d   $	��Top=�6w   #���  6�   6�   �� 55      -   5        $ grid_res_lbl��55      $��Label��6*   $
��Left=�6:   $��
158,84,0,0q�6U   $	��Top=�6i   $��94��6�   56      � 57   
   $
��Left=�6   $	��118��6*   $��401,163,0,0q�67   $	��Top=�6L   $	��262��6d   ���	#FFEEF0F1.+�58      �� -   5        $ save_window_res_butt��58      $��Save to Window Resource��63   $
��Left=�6U   $��8,25,0,0q�6p   $	��Top=�6�   $	��147��6�   6�   �� 59      -   5        $ save_app_res_butt��59      $��Save to App Resource��60   $
��Left=�6O   $��8,56,0,0q�6j   $	��Top=�6|   $	��147��6�   6�   �� 5:      -   5        $ save_grid_res_butt��5:      $��Save to Grid Resource��61   $
��Left=�6Q   $��8,87,0,0q�6l   $	��Top=�6~   $	��147��6�   6�   �� 5;      -   5        	 ��Name$	 save_window_res_lbl��5;      $
��Left=�63   $��23��6N   $��
179,23,0,0q�6Z   
 �� TextWrapping$

 Wrap=�6n   $��TextBox��6�   $	��Top=�6�   $��73��6�   �� 5<      -   5        $	 save_app_res_lbl��5<      $
��Left=�60   $��23��6K   $��
179,53,0,0q�6W   $

 Wrap=�6k   $��TextBox��6   $	��Top=�6�   $��73��6�   �� 5=      -   5        $	 save_grid_res_lbl��5=      $
��Left=�61   $��23��6L   $��
179,84,0,0q�6X   $

 Wrap=�6l   $��TextBox��6�   $	��Top=�6�   $��73��6�   5>      5?      5@      