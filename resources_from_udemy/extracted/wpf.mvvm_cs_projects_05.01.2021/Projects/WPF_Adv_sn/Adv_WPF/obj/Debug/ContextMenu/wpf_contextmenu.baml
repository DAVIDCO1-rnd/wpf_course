   M S B A M L   `   `   `  ����B  >Adv_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Adv_WPF.ContextMenuAdv_WPF.ContextMenu  5   	   )    #Adv_WPF.ContextMenu.wpf_contextmenu   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Adv_WPF.ContextMenu     5   	     � Title$  wpf_contextmenu��5   	   $	��287��6!   $	��469��6.    � 	Resources 5
         CmItemsStyle �� 
TargetType �� Property �� Value 
 com_cm��%?  &	        &	 �     �� 5   
   " m�6%   .�5      ��  � ��
 �����6+   �� 5       �@�Cursor$
 Hand��6'   �� 5       � ��$ Normal"�6+   5      �� 5   
   .@�5      m� $��
com_new_cm��6$   $	��New��6   6$   m� 5      $��com_edit_cm��6%   $
��Edit��6   6%   5      5       � ContextMenu 5      �� 5   
   .@�5      m� -   5        $��wind_exit_cm��5   M   #���   6   $
��Exit��6?   6a   m� 5      -   5        $��wind_about_cm��5   &   $��About��6   6;   5      .��5      � .+�5   
   �� $��Right Click on Me!��6   $
��Left=�6.   $��
155,15,0,0q�6I   $	��Top=�5       $	��120��6)   $��25��65    5"        CmStyle��%P  &	       &	  �     �� 5#      " ��6(   .�5$      ��  � ��
 �����63   �� 5%       �@�Cursor$
 Hand��6/   �� 5&       � ��$
 Bold"�63   5'      �� 5)      " m�6-   .�5*      ��  � ��
 �����63   �� 5+       �@�Cursor$
 Hand��6/   �� 5,       � ��$ Normal"�63   5-      5/       51      �� 52      #���  6   .@�54      m� -   5        $��Exit_app_cm��54   b   #���   6   $��Exit Application��6G    m� Icon 55      �� 56      $��Pics/exit.png��6$   58      �� 59      m� 5;      -   5        $��cut_cm��5;   .   $	��Cut��6!    5<      �� 5=      $��Pics/cut.png��6$   5?      m� 5A      -   5        $��copy_cm��5A   -   $
��Copy��6    5B      �� 5C      $��Pics/copy.png��6$   5E      m� 5G      -   5        $��paste_cm��5G   .   $��Paste��6    5H      �� 5I      $��Pics/paste-16.png��6$   5K      �� 5M      5O      5R      �� 5S   
   $��Button 2��6   $
��Left=�6$   $��
170,50,0,0q�6?   $	��Top=�6S   $��75��6k   # �  6v   �� 5T   
   $��Button 3��6   $
��Left=�6$   $��
170,80,0,0q�6?   $	��Top=�6S   $��75��6k   # �  6v   �� 5U   
   $��Button 4��6   $
��Left=�6$   $��170,115,0,0q�6?   $	��Top=�6T   $��75��6l     
app_com_cm# �  6w   �� 5V   
   -   5         ��Name$ show_cm_butt��5V      $'��!Click me to see the context menu!��6'   $
��Left=�6S   $��110,150,0,0q�6n   $	��Top=�6�   $	��195��6�   6�   5X      5Y      