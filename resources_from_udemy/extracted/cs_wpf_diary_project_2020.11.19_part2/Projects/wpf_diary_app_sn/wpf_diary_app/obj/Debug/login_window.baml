   M S B A M L   `   `   `  ����M  Iwpf_diary_app, Version=2020.11.18.1, Culture=neutral, PublicKeyToken=null-clr-namespace:wpf_diary_appwpf_diary_app  5   	        wpf_diary_app.login_window   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:wpf_diary_app     5   	   -   5          �Name$  
login_wind��5   	    � Title$  Login to Diary Application��5   	   $��418.007��6,   $��357.028��6=    � WindowStartupLocation$ CenterScreen=�6M    � 
ResizeMode$ NoResize=�6r    � Icon$" Data/Other_Img/male_user.png��6�   .��5	      � .+�5
   
   �� $��	User Info��6   $
��Left=�6&   $	��285��6A   $��	18,21,0,0q�6N   $	��Top=�6a   $	��308��6y   .��5      �� .+�5      �� 
���   �$��1q�6-   $	��107��6A    �� Left$ 96��6N   
 �� Top$ 20��6_   $	��121��6o    �� CornerRadius$ 2��6{   ._�5      �� -   5         ��Name$ 	image_img��5      5      �� 5      $��
User Name:��6   $ 17��6-   $	 171��6>   $��73��6O   �� 5      $��	Password:��6   $ 19��6,   $	 207��6=   G� 5      -   5        	 G�Name$	 user_pass_tbox��5      $ 96��66   $	 209��6G   $	��121��6X   $��16(�6d   �� 5      -   5        
 ��Name$
 
user_combo��5      $ 96��6/   $	 173��6@   $	��120��6Q    � Cursor$
 Hand��6]   5      5      5      �� 5   
   -   5         ��Name$ 	save_butt��5      $
��Left=�6%   $��
30,330,0,0q�6@   $	��Top=�6T   $	��123��6l   $��31��6x   $
 Hand��6�    �� 	IsDefault . .��5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��Data/Other_Img/ok.png��6   $��20��67   $��24��6C   �� 5      $��Ok��6   5      5      �� 5   
   -   5        $ cancel_butt��5      $
��Left=�6'   $��167,330,0,0q�6B   $	��Top=�6W   $��77��6o   $��31��6z   $
 Hand��6�    �� IsCancel . .��5       �� $ 
Horizontal=�6   .+�5!      �� $��Data/Other_Img/exit.png��6   $��20��69   $��24��6E   �� 5"      $
��Exit��6   5#      5$      5&      5'      