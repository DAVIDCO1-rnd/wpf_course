   M S B A M L   `   `   `  ����M  Iwpf_diary_app, Version=2020.11.18.1, Culture=neutral, PublicKeyToken=null-clr-namespace:wpf_diary_appwpf_diary_app  5   	       wpf_diary_app.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:wpf_diary_app     5   	   -   5          �Name$  main_window��5   	    � Title$ 
MainWindow��5   	   $��775.306��6   $��898.779��6-    � WindowStartupLocation$ CenterScreen=�6=    � WindowState$ 	Maximized=�6b    � WindowStyle$
 None=�6z   ��5	      �� 5
   
    �� ImageSource$- 'pack://siteoforigin:,,,/Data/Pics/7.jpg��6    j� Stretch$
 Fill=�6K   .��5      � .+�5   
   ]� ��.  .+�5      �� -   5         ��Name$ sidebar_panel��5      $	��177��6,   $��0,1,0,-1q�68   ��5      �� 5       �� Color$ 	#FFE0EAF1��6&   	 �� Opacity$		 0.4Q�68   .+�5      �� ���	#FFFFA21B$��4q�61   $	��145��6E   
 �� Left$
 14��6R   
 �� Top$ 29��6c   $	��151��6s    �� CornerRadius$	 200��6   ���	#FF080000._�5      �� .+�5      �� -   5         ��Name$ time_lbl��5       $��15:29��62   
��� ���$ 38��6V   $��58��6f   $	��147��6r   
���   �$��32(�6�   $��Center=�6�   $��Center=�6�   $
 -2��6�   5      5      �� 5      -   5        $ 	cal_panel��5      $	��166��6,   $
 6��69   $	 220��6I   $	��167��6Z   ��5      �� 5      $! Data/Other_Img/calander.png��6%   .+�5      �� -   5        $ year_lbl��5      $
��2019��6.   $
 10��6=   $ 35��6N   $��32��6^   $��50��6j   $��16(�6u   
�������$
��Bold"�6�   �� 5      -   5        $ 	month_lbl��5      $��November��6/   $
 65��6B   $ 35��6S   $��32��6c   $��92��6o   $��15(�6z   
�������$
��Bold"�6�   �� 5      -   5        $ day_in_month_lbl��5      $��31��66   $
 22��6C   $ 72��6T   $	��122��6d   $��30(�6p   $
��Bold"�6~   $��Center=�6�   $��45��6�   �� 5      -   5        $ day_in_week_lbl��5      $��Sunday��65   $
 10��6F   $	 120��6W   $��32��6h   $	��147��6t   $��18(�6�   ���	#FF13245D$
��Bold"�6�   $��Center=�6�   5       �� 5!      
���   �$��1q�6-   $	��162��6A   $
 10��6N   $	 558��6_   $	��157��6p   $ 5��6|   ._�5"      �� .+�5#      �� -	   5        $ login_user_name_lbl��5#       $	��...��6=   $
 10��6K   $	 126��6\   $	��135��6m   $��Center=�6y   $
��Bold"�6�   $��17(�6�   �� 5$      -
   5         ��Name$ login_user_image��5$       $	��119��6:   $
 10��6G   $ 10��6X   $	��135��6h   $-��'pack://siteoforigin:,,,/Data/Pics/1.jpg��6t   $��UniformToFill=�6�   5%      5&      5'      �� 5(      -   5        $ 	top_panel��5(      $��67��6(   $	��Top=�64   $	��Top=�6L   ��5)      �� 5*      $ 	#FFE7F085��6&   $
	 0.35Q�68   .+�5-      o� -   5         o�Name$ 	memo_butt��5-      $��60��6*   $
 6��66   $	��100��6F   $ 2��6R   
���   �$��1q�6u   .@�5/      m� -   5         m�Name$ add_memo_butt��5/      $��59��67   $	��100��6C    � Cursor$
 Hand��6O   ��51      �� 52      $
��Left=�6)   $��97��6D   $��53��6O   $��
-7,0,-86,0q�6[   .+�53   "   �� $#��Data/main_window/add_memo.png��6(   $��31��6O   �� 54   "   $��Add Memo F2��6(   $��Center=�6>   $
��Bold"�6b   55      57      58      o� 5:      -   5        $ search_memo_butt��5:      $��60��61   $	
 115��6=   $	��108��6O   $ 2��6[   
���   �$��1q�6~   .@�5<      m� -   5        $ search_butt��5<      $��59��65   $	��106��6A   $
 Hand��6M   ��5>      �� 5?      $
��Left=�6)   $��97��6D   $��53��6O   $��
-7,0,-86,0q�6[   .+�5@   "   �� $&�� Data/main_window/search_memo.png��6(   $��31��6R   $��0,0,-5,0q�6^   �� 5A   "   $��Search Memo F3��6(   $��Center=�6A   $
��Bold"�6e   $��0,0,-6,0q�6w   5B      5D      5E      o� 5G      -   5        $ settings_butt��5G      $��60��6.   $	
 230��6:   $	��108��6L   $ 2��6X   
���   �$��1q�6{   .@�5H      m� -   5        $ settings_main_menu��5H      $��59��6=   $	��106��6I   $
 Hand��6U   ��5J      �� 5K      $
��Left=�6)   $��97��6D   $��53��6O   $��
-7,0,-86,0q�6[   .+�5L   "   �� $*��$Data/main_window/settings-alt-32.png��6(   $��31��6V   $��0,0,-5,0q�6b   �� 5M   "   $��Settings F4��6(   $��Center=�6>   $
��Bold"�6b   $��0,0,-6,0q�6t   5N      .@�5P      m� -   5        $ Settings_sub_menu��5P   #   $��Settings��6>   $
��Left=�6P   $��41��6k   $	��138��6w    m� Icon 5Q      �� 5R   "   $*��$Data/main_window/settings-alt-32.png��6(   $��-3,-8,-9,-10q�6V   $��Right=�6l   $��28��6�   5T      5U      5V      o� 5X      -   5        $ 
tools_butt��5X      $��60��6+   $	
 347��67   $	��108��6I   $ 2��6U   
���   �$��1q�6x   .@�5Z      m� -   5        $ tools_main_menu��5Z      $��59��69   $	��106��6E   $
 Hand��6Q   ��5\      �� 5]      $
��Left=�6)   $��97��6D   $��53��6O   $��
-7,0,-86,0q�6[   .+�5^   "   �� $ ��Data/main_window/tools.png��6(   $��31��6L   $��0,0,-5,0q�6X   �� 5_   "   $��Tools F5��6(   $��Center=�6;   $
��Bold"�6_   $��0,0,-6,0q�6q   5`      .@�5b      m� -   5        $��Users��5b   #   $
��Left=�62   $��41��6M   $	��138��6Y    5c      �� 5d   "   $ ��Data/main_window/tools.png��6(   $��-3,-8,-9,-10q�6L   $��Right=�6b   $��28��6~   5f      5g      5h      o� 5j      -   5        $ 
about_butt��5j      $��60��6+   $	
 462��67   $	��108��6I   $ 2��6U   
���   �$��1q�6x   .@�5k      m� -   5        $ about_main_menu��5k      $��59��69   $	��106��6E   $
 Hand��6Q   ��5m      �� 5n      $
��Left=�6)   $��97��6D   $��53��6O   $��
-7,0,-86,0q�6[   .+�5o   "   �� $ ��Data/main_window/about.png��6(   $��31��6L   $��0,0,-5,0q�6X   �� 5p   "   $��About F6��6(   $��Center=�6;   $
��Bold"�6_   $��0,0,-6,0q�6q   5q      .@�5s      m� -   5        $ about_us_butt��5s   #   $��About Us��6:   $
��Left=�6L   $��41��6g   $	��138��6s    5t      �� 5u   "   $ ��Data/main_window/about.png��6(   $��-3,-8,-9,-10q�6L   $��Right=�6b   $��28��6~   5w      m� 5y      $
��Help��6#   $
��Left=�61   $��41��6L   $	��138��6X    5z      �� 5{   "   $ ��Data/main_window/tools.png��6(   $��-3,-8,-9,-10q�6L   $��Right=�6b   $��28��6~   5}      5      5�      �� 5�      -   5         ��Name$ minimize_butt��5�      $	
 659��61   $ 5��6C   $��24��6R   $��24��6]   .��5�      �� $(��"Data/main_window/Minimize_butt.png��6   $
 Hand��6H   5�      �� 5�      -   5        $ 
close_butt��5�      $	
 686��6.   $ 5��6@   $��24��6O   $��24��6Z   .��5�      �� $%��Data/main_window/Close_butt.png��6   $
 Hand��6E   5�      5�      �� 5�      -   5        $ bottom_panel��5�      $��28��6+   $	��Top=�67   $��Bottom=�6O   ��5�      �� 5�      $ 	#FFD1B482��6&   $
	 0.35Q�68   .+�5�      �� $��Background:��6   $ 3��6.   ��5�      �� 5�      $ 	#FFEED3D3��6*   $		 0.4Q�6<   5�      �� 5�      -   5         ��Name$ pic_cbox��5�      $
 75��6-   $ 5��6>   $��88��6M   $
 Hand��6X   .@�5�      �� $��Image 1��6#   $
��Left=�65   $��92��6P   �� 5�      $��Image 2��6#   $
��Left=�65   $��92��6P   �� 5�      $��Image 3��6#   $
��Left=�65   $��92��6P   �� 5�      $��Image 4��6#   $
��Left=�65   $��92��6P   �� 5�      $��Image 5��6#   $
��Left=�65   $��92��6P   �� 5�      $��Image 6��6#   $
��Left=�65   $��92��6P   �� 5�      $��Image 7��6#   $
��Left=�65   $��92��6P   �� 5�      $��Image 8��6#   $
��Left=�65   $��92��6P   5�      5�      5�      5�      5�      