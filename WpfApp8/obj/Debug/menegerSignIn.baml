   M S B A M L   `   `   `  ����B  >WpfApp8, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp8WpfApp8  5	   	       WpfApp8.menegerSignIn   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   !localclr-namespace:WpfApp8  5	   	     � Title$  
פרטים��5   	   $	��350��6   $	��250��6$   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��0.3* �6   6.   �� 5      $��* �6   6+   �� 5      $
��0.3* �6   6.    � RowDefinitions 5   
   �� 5      $
��0.1* �6   6,   �� 5      $
��0.8* �6   6,   �� 5      $
��0.1* �6   6,   .+�5   
   �� $��1��6   $��פרטי מנהל��6    $
��Bold"�64   $��16(�6F   $��Italic$�6T   $��RightToLeft=�6g   $��Stretch=�6�   $��Stretch=�6�   $��Center=�6�   $��Bottom=�6�   6  �� 5   
   $��1��6   $��1��6!   ���#D3D3D3$��1q�6D   $��1��6Y   $��1��6m   �� 5   
   -   5         ��Name$ listOfDetales��5      $��1��6,   $��1��69   .+�5      �� -   5         ��Name$ id��5       %  !MaterialDesignFloatingHintTextBox#��[  6"   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ תעודת זהות��6]    �� TextAlignment$ Right=�6�   $��8,5,8,0q�6�   $��RightToLeft=�6�   6�   �� 5      -   5        $ foolName��5      #��[  6(   $ שם מלא��6c   $ Right=�6�   $	��8,5q�6�   $��RightToLeft=�6�   6�   �� 5      -   5        $ email��5      #��[  6%   $ כתובת אמייל��6`   $ Right=�6�   $	��8,5q�6�   $��RightToLeft=�6�   6�   �� 5      -   5        $ password��5      #��[  6(   $ 
סיסמא��6c   $ Right=�6�   $	��8,5q�6�   $��RightToLeft=�6�   6�   �� 5      -   5        $��שמור��5      $��8q�6$   6F   5       5#      5$      