   M S B A M L   `   `   `  ����L  Hpro_wpf_tutorials, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:pro_wpf_tutorials.Triggerspro_wpf_tutorials.Triggers  5   	   2    ,pro_wpf_tutorials.Triggers.wpf_data_triggers   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:pro_wpf_tutorials.Triggers     5   	   -   5          �Name$  wfp_data_triggers_wind��5   	    � Title$ wpf_data_triggers��5   	   $	��322��6#   $	��524��60    � WindowStartupLocation$ CenterScreen=�6<    � 	Resources 5	         
WindowButt �� 
TargetType �� Property �� Value �� Triggers �� Binding	 �� ElementName
 �� Path �� Value��%  &	        �� 5
   
   " ��6#   .�5      ��  � {� .  6:   �� 5       � y�$ Hidden=�6+   6<    5      �� 5       6   �� $	 is_bold_chbox��$
 	IsChecked� True6]   .a�5      ��  � ��$
 Bold"�63   5      �� 5       6   �� $	 is_enabled_butt��$
 	IsChecked� True6]   .a�5      ��  � {� . 62   5      �� 5       6   �� $	 is_visible_butt��$
 	IsChecked� True6]   .a�5      ��  � y�$ Visible=�63   5      5      5      .��5!      �  5"   
     GridButt��%  &	       �� 5#      " ��6%   .�5$      ��  � {� .  6>   �� 5%       � y�$ Hidden=�6/   6@    5'      �� 5)       6"   �� $	 is_bold_chbox��$
 	IsChecked� True6a   .a�5*      ��  � ��$
 Bold"�67   5+      �� 5-       6"   �� $	 is_enabled_butt��$
 	IsChecked� True6a   .a�5.      ��  � {� . 66   5/      �� 51       6"   �� $	 is_visible_butt��$
 	IsChecked� True6a   .a�52      ��  � y�$ Visible=�67   53      57      58      .+�59   
   �� -   5         ��Name$ Butt_1��59      $��I'm Cute Button!��6!   $
��Left=�6<   $��185,175,0,0q�6W   $	��Top=�6l   $	��125��6�   $��50��6�   #���   6�   �� 5:   
   -   5         ��Name$ is_bold_chbox��5:      $��Font Is Bold��6*   $
��Left=�6A   $��	40,80,0,0q�6\   $	��Top=�6o   $	��115��6�   �� 5;   
   -   5        $ is_enabled_butt��5;      $��Button is Enabled��6,   $
��Left=�6H   $��	40,50,0,0q�6c   $	��Top=�6v   $	��115��6�   �� 5<   
   -   5        $ is_visible_butt��5<      $��Button is Visible��6,   $
��Left=�6H   $��	40,20,0,0q�6c   $	��Top=�6v   $	��155��6�   �� 5=   
   -   5        $��Property Triggers��5=      $
��Left=�6-   $��360,120,0,0q�6H   $	��Top=�6]   $	��120��6u   $��30��6�   6�   5?      5@      