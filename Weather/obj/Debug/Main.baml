   M S B A M L   `   `   `  ����B  >Weather, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WeatherWeather  5   	       Weather.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Weather     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.0.1244, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5   	     MaterialDesignPaper#���  5	   	     � Title$  Weather��5   	    � WindowStartupLocation$ CenterScreen=�6    � WindowStyle$
 None=�6>    � 
ResizeMode$ NoResize=�6Q   $	��500��6g   $	��350��6t   ��5
   	   :  4MaterialDesignThemes.Wpf.MaterialDesignFontExtension  .��5      �  � RowDefinitions 5   
   �� 5      $��22 �6   6*   �� 5      6   .+�5   
   �� -   5         ��Name$ backgroundTime��5      $��2��6(   $��UniformToFill=�69   ��6Q   �� 6f   � 5   
   -   5         �Name$ gridTopPanel��5   _   
������ $��0��6u   .+�5      �� $��Right=�6    �� Orientation$ 
Horizontal=�65   $��90��6N   .+�5      �� -   5         ��Name$ minimize��5   _   
���   �
������ 
������ $��45��6q   $
��Auto��6�   .��5      '  !MaterialDesignThemes.Wpf.PackIcon  	   Kind$	 WindowMinimize=�6.   6F   5      �� 5      -   5        $ close��5   L   
������ 
������ $��45��6[   $
��Auto��6�   .��5        $	 WindowClose=�6.   6C   5      5      5      � 5   
   -   5        $ gridMain��5      $��1��6    5      �� 5      6"   �� 5       $��50 �6    6.   .+�5"      � -   5        $ currentWeather��5"      $��0��6+   .+�5#      �� $��25q�6   .+�5$      �� -   5        
 ��Name$
 tbCity��5$       
�������$��Center=�6C   $��20(�6`    J� Effect 5%      3  -System.Windows.Media.Effects.DropShadowEffect  5&         ShadowDepth$ 1Q�6/      
BlurRadius$
 0.01Q�6?      Color$ Black��6Q   5(      �� 5)      -   5        $
 	dayOfWeek��5)       
�������$��Center=�6F   $��20(�6c    5*        5+      $ 1Q�6/   $
 0.01Q�6?   $ Black��6Q   5-      �� 5.      -	   5        $
 currentTemp��5.       
�������$��Center=�6H   $��72(�6e    5/        50      $ 1Q�6/   $ 1Q�6?   $ Black��6N   52      �� 53      -
   5        $
 
feels_like��53       
�������$��Center=�6G   $��20(�6d    54        55      $ 1Q�6/   $ 1Q�6?   $ Black��6N   57      �� 58      -   5        $
 description��58   K    �� TextAlignment$ Center=�6    $
��Wrap=�67   
�������$��Center=�6s   $��20(�6�    59        5:      $ 1Q�6/   $ 1Q�6?   $ Black��6N   5<      �� 5=      -   5        $
 pressure��5=       
�������$��Center=�6E   $��20(�6b    5>        5?      $ 1Q�6/   $ 1Q�6?   $ Black��6N   5A      �� 5B      -   5        $
 speed��5B       
�������$��Center=�6B   $��20(�6_    5C        5D      $ 1Q�6/   $ 1Q�6?   $ Black��6N   5F      �� 5G      -   5        $
 humidity��5G       
�������$��Center=�6E   $��20(�6b    5H        5I      $ 1Q�6/   $ 1Q�6?   $ Black��6N   5K      5L      5M      � 5N      -   5        $ nextWeather��5N      $��1��6(   $��50��65   .+�5O      �� 
������� J� Opacity$	 0.5Q�6)   69   �� 5P      -   5         ��Name$ cmCity��5R      $��5q�5S      $��2��5T      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Город��5U      .  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton .  �� 
IsEditable .  & "MaterialDesignFloatingHintComboBox#��[ 5X      $��43��6Q    �� SelectedValue 5Y      �� *SelectedValueOne+��5Z      �� 5[      .R�5\      $� 5]      5_      5`      5a      5b      5c      