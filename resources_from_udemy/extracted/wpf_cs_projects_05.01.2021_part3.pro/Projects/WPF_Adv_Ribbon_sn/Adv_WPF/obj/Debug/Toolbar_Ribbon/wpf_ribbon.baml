   M S B A M L   `   `   `  ����B  >Adv_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Adv_WPF.Toolbar_RibbonAdv_WPF.Toolbar_Ribbon  5   	   '    !Adv_WPF.Toolbar_Ribbon.wpf_ribbon   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:Adv_WPF.Toolbar_Ribbon     5   	     � Title$  
wpf_ribbon��5   	   $	��257��6   $	��739��6)   .��5	      � .+�5
   
   +  %System.Windows.Controls.Ribbon.Ribbon   �� SelectedIndex$ 0��6      HelpPaneContent 5      1  +System.Windows.Controls.Ribbon.RibbonButton  5         Label$
 Help��6      SmallImageSource$ Ribbon_img/about.png��6,      QuickAccessToolBar 5      =  7System.Windows.Controls.Ribbon.RibbonQuickAccessToolBar  5      .@�5      5  /System.Windows.Controls.Ribbon.RibbonMenuButton   � Cursor$
 Hand��6(      SmallImageSource$ Ribbon_img/floppy-16.png��67   .@�5      3  -System.Windows.Controls.Ribbon.RibbonMenuItem  $
��Save��6)      ImageSource$ Ribbon_img/floppy-16.png��67     5      $��Save As��6)   $ Ribbon_img/file_32.png��6:   5        5      $
 Undo��6#   $
 Hand��60   $ Ribbon_img/Undo-2-16.png��6>     5      $
 Redo��6#   $
 Hand��60   $ Ribbon_img/Redo-2-16.png��6>   5      	   ApplicationMenu	 5      :  4System.Windows.Controls.Ribbon.RibbonApplicationMenu  5      
   Label$

 Main��6(   .@�5      >  8System.Windows.Controls.Ribbon.RibbonApplicationMenuItem  $
 Hand��60   $	��New��6>   $ Ribbon_img/add_memo.png��6K     5      $
 Hand��60   $
��Save��6>   $ Ribbon_img/floppy-16.png��6L     5       $
 Hand��61   $��Save As��6?   $ Ribbon_img/file_32.png��6P     5!      $
 Hand��60   $��Search��6>   $ Ribbon_img/view_32.png��6N     5"      $
 Hand��60   $��Options��6>   $$ Ribbon_img/settings-alt-32.png��6O     5#      -   5          Name$ 	exit_butt��5#   0   $
 Hand��6C   $
��Exit��6Q   $ Ribbon_img/exit.png��6_   6�      FooterPaneContent 5%      �� 5&       �� Orientation$ 
Horizontal=�6%   .+�5'        $
 Hand��6+   $ About��69      LargeImageSource$ Ribbon_img/help_32.png��6G     5(      $
 Hand��6+   $ Users��69   $ Ribbon_img/male_user.png��6G   5)         AuxiliaryPaneContent 5,      �� 5-      $ Vertical=�6%   .+�5.      �� $��Recent Files:��6%   $
��Bold"�6=   4  .System.Windows.Controls.Ribbon.RibbonSeparator  5/      �� 50      $	��300��6&   .@�51   "   �� $
 Hand��6.   $��1.jpg��6<   �� 52   "   $
 Hand��6.   $��10.jpg��6<   �� 53   "   $
 Hand��6.   $��11.jpg��6<   �� 54   "   $
 Hand��6.   $��12.jpg��6<   �� 55   "   $
 Hand��6.   $��100.jpg��6<   �� 56   "   $
 Hand��6.   $��111.jpg��6<   57      58      5;      .@�5?      .	  (System.Windows.Controls.Ribbon.RibbonTab	  $
��Home��6   .@�5A      0
  *System.Windows.Controls.Ribbon.RibbonGroup
  $��	Clipboard��6   $	��124��63   $	��0,1q�6?   .@�5B        -   5          Name$ cut_butt��5B   #   $
 Hand��66   $	 Cut��6E   $ Ribbon_img/cut.png��6Q   6w     5C      -   5        $ 	copy_butt��5C   #   $
 Hand��66   $
 Copy��6E   $, &Ribbon_img/ic_content_copy_48px-16.png��6R   6�     5E      $
 Hand��6'      LargeImageSource$ Ribbon_img/add_memo.png��65   $
 Paste��6`   .@�5F        -   5          Name$ paste_menu_butt��5F   )   $% Ribbon_img/content-paste-16.png��6C   $��Paste��6q    m� IsCheckable . 6�     5G      $��Paste special��6*   $ Ribbon_img/add_memo.png��6A   5H      5I      
  5J      $
��Font��6   $	��153��6-   .@�5K      �� $��70��6   .@�5L      �� $	��50%��6'   �� 5M       �� 
IsSelected . $
��100%��6:   �� 5N      $
��200%��6'   5O      3  -System.Windows.Controls.Ribbon.RibbonComboBox  5P         SelectionBoxWidth$ 50Q�6%   .@�5Q      2  ,System.Windows.Controls.Ribbon.RibbonGallery     MaxColumnCount$ 3��6(      SelectedValuePath$ Content��6;      SelectedValue$ Font 3��6W   .@�5R      :  4System.Windows.Controls.Ribbon.RibbonGalleryCategory  $	��140��64   .@�5S   "   6  0System.Windows.Controls.Ribbon.RibbonGalleryItem  $��Font 1��64     5T   "   $��Font 2��64     5U   "   $��Font 3��64     5V   "   $��Font 4��64     5W   "   $��Font 5��64     5X   "   $��25��64   $��25��6@   $��Y��6K   
��� ������	#FF9C9C9C6l     5Y   "   $��25��64   $��25��6@   $��G��6K   
��� � ����	#FF9C9C9C6j   5Z      5[      5\      �� 5]      $ 
Horizontal=�6!   .+�5^      7  1System.Windows.Controls.Ribbon.RibbonToggleButton  $
 Hand��6-      SmallImageSource$ Ribbon_img/bold.png��6<     5_      $
 Hand��6-   $ Ribbon_img/Italic.png��6;     5`      $
 Hand��6.   $ Ribbon_img/underline.png��6<   5a      5c      
  5e      $��Format��6   $��93��6/   $	��0,1q�6:   .@�5f      �� $ 
Horizontal=�6!   .+�5g      6  0System.Windows.Controls.Ribbon.RibbonRadioButton     SmallImageSource$' !Ribbon_img/text_align_left-16.png��6,     5h      $) #Ribbon_img/text_align_center-16.png��6,     5i      $( "Ribbon_img/text_align_right-16.png��6,   5j      5l      
  5n      $��Search��6   .@�5o      �� $ 
Horizontal=�6!   .+�5q      6  0System.Windows.Controls.Ribbon.RibbonTwoLineText     Text$ Title:��6,   2  ,System.Windows.Controls.Ribbon.RibbonTextBox  5r        5s      $  Ribbon_img/search_memo.png��6'   5t      5v      5w      	  5y      $
��View��6   .@�5{      
  $
��Zoom��6   $	��0,1q�6,   $	��108��69   .@�5|        $
 Hand��6#   $ Zoom +��61   $  Ribbon_img/search_memo.png��6@     5}      $
 Hand��6#   $ Zoom -��62   $ Ribbon_img/view_32.png��6A   5~      
  5�      $��Show | Hide��6   $	��146��65   $	��0,1q�6A   .@�5�      3  -System.Windows.Controls.Ribbon.RibbonCheckBox  $
 Hand��6%      Label$ Ruler��63     5�      $
 Hand��6%   $ 
Status Bar��63   5�      
  5�      $��Settings��6   .@�5�      6  0System.Windows.Controls.Ribbon.RibbonSplitButton  $
 Hand��6(   $
 	Word Wrap��66   $$ Ribbon_img/settings-alt-32.png��6H   .@�5�      8  2System.Windows.Controls.Ribbon.RibbonSplitMenuItem  $��No Wrap��6.    .  m� 	IsChecked . 6R     5�      $��Wrap to Ruler��6.   5�      5�      5�      	  5�      $��Format��6   5�      5�      5�      5�      