   M S B A M L   `   `   `  ����B  >WpfApp8, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp8WpfApp8  5   	       PLGui.ReportScreen   5   	   U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp8     5   	     � Title$  ReportScreen��5	   	   $	��450��6   $	��800��6+    � 	Resources 5
         soldier � RowDefinitions $  MaterialDesignSubtitle2TextBlock �� Path)  #MaterialDesignThemes.Wpf.HintAssist   Hint��%�  &	        7  7  7  7  7  �� 5   
   template��.R�5      �  5      �� 5      $��* �6$   61   �� 5      $��* �6$   61   �� 5      $��* �6$   61   .+�5      �� $��1��6   $��1��6)   ���#D3D3D3$��1q�6L   $��1��6a   $��1��6u   � 5      $��0��6   $��1��6$   .+�5      ]� .+�5      �� .+�5      �� 8��  $
��11,0q�6d   מספר אישי6}   �� 5      $��id��6$   $��Center=�6J   $��Center=�6g   ��6.   �� $ Id�6�   5      �� 5      .+�5      �� 8�� $
��11,0q�6d   שם פרטי6{   �� 5      $��	firstName��6$   $��Center=�6X   $��Center=�6u   ��65   �� $ 	firstName�6�   5      �� 5      .+�5      �� 8�� $
��11,0q�6d   שם משפחה6|   �� 5      $��lastName��6$   $��Center=�6V   $��Center=�6s   ��64   �� $ lastName�6�   5       �� 5!      .+�5"      �� 8�� $
��11,0q�6d   
צוות6x   �� 5#      $��Staff��6$   $��Center=�6P   $��Center=�6m   ��61   �� $ Staff�6�   5$      �� 5%      .+�5&      �� 8�� $
��11,0q�6d   
סטטוס6y   �� 5'      $ בחר סטטוס��6'   .@�5(   "   �� .��6/   
חופש65   �� 5)   "   .��6/   
בסיס65   �� 5*   "   .��6/   
תפקיד66   �� 5+   "   .��6/   לימודים68   �� 5,   "   .��6/   
גימל65   5-      5.      5/      50      51      52      53      .��58      �  � ColumnDefinitions 59   
   �� 5:      $
��0.3* �6   �� 5;      $��* �6   �� 5<      $
��0.3* �6    5>   
   �� 5?      $	��79* �6   �� 5@      $
��286* �6   �� 5A      $	��56* �6   .+�5C   
   �� $��0��6   $��1��6   $��	 דוח 1��6-   $��Center=�6>   $��206.333,10,206.667,9.667q�6[   $��30(�6}   $��83��6�   6�   �� 5E   
   -   5         ��Name$ soldier��5E   �   $
��Auto=�6   $
��Auto=�6B   $��1��6t   $��1��6�   $��RightToLeft=�6�   #��[  6�   6�   '  !MaterialDesignThemes.Wpf.Snackbar  5F   
   -   5          Name$ 
MySnackbar��5F   3      IsActive .  $��1��6G   $��2��6W   	   MessageQueue	 6d   4  .MaterialDesignThemes.Wpf.MessageQueueExtension  
   Message.
 5G      .  (MaterialDesignThemes.Wpf.SnackbarMessage  -   5        $��snackbarMassage��5G   -   $��RightToLeft=�6D   5H      �� 5J   
   $��1��6   $��0��6"   .+�5K      �� -   5        $��שמור��5K      $
��8,10q�6$   6I   �� 5L      -   5        $��שלח במייל��5L      $
��8,10q�6)   6P   5M      5O      5P      