   M S B A M L   `   `   `  ����B  >WpfApp8, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp8WpfApp8  5	   	       PLGui.formSoldier   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   !localclr-namespace:WpfApp8  5	   	     � Title$  
פרטים��5   	   $	��500��6   $	��300��6$   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��0.3* �6   6.   �� 5      $��* �6   6+   �� 5      $
��0.3* �6   6.    � RowDefinitions 5   
   �� 5      $
��0.1* �6   6,   �� 5      $
��0.8* �6   6,   �� 5      $
��0.1* �6   6,   .+�5   
   �� $��1��6   $��פרטי החייל��6    $
��Bold"�65   $��16(�6G   $��Italic$�6U   $��RightToLeft=�6h   $��Stretch=�6�   $��Stretch=�6�   $��Center=�6�   $��Bottom=�6�   6  �� 5   
   $��1��6   $��1��6!   ���#D3D3D3$��1q�6D   $��1��6Y   $��1��6m   �� 5   
   -   5         ��Name$ listOfDetales��5      $��1��6,   $��1��69   .+�5      �� -   5         ��Name$ id��5       %  !MaterialDesignFloatingHintTextBox#��[  6"   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ מספר אישי��6]    �� TextAlignment$ Right=�6�   $	��8,0q�6�   $��RightToLeft=�6�   6�   �� 5      -   5        $ 	firstName��5      #��[  6)   $ שם פרטי��6d   $ Right=�6�   $	��8,0q�6�   $��RightToLeft=�6�   6�   �� 5      -   5        $ lastName��5      #��[  6(   $ שם משפחה��6c   $ Right=�6�   $	��8,0q�6�   $��RightToLeft=�6�   6�   �� 5      -   5        $
 rank��5      #��[  6$   $ דרגה��6_   $ Right=�6�   $	��8,0q�6�   $��RightToLeft=�6�   6�   �� 5      -   5        $ Staff��5      #��[  6%   $ צוות��6`   $ Right=�6�   $	��8,0q�6�   $��RightToLeft=�6�   6�   �� 5      -   5        $ phone��5      #��[  6%   $ פלאפון��6`   $ Right=�6�   $	��8,0q�6�   $��RightToLeft=�6�   6�   �� 5       -   5        $ addres��5       #��[  6&   $ 
כתובת��6a   $ Right=�6�   $	��8,0q�6�   $��RightToLeft=�6�   6�   �� 5!      -	   5        $ remarks��5!      #��[  6'   $ 
הערות��6b   $ Right=�6�   $	��8,0q�6�   $��RightToLeft=�6�   6�   �� 5"      -
   5         ��Name$ DynamicButton��5"      $��10q�6,   6O   5#      5&      5'      