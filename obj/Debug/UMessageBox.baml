   M S B A M L   `   `   `  ����  GaiaDownload    HttpDemo.UMessageBox   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    6!   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     6c   -   5          �Name$
  main��5
       � Title$
 Gaia��5      $	��130��5      $	��280��5       � WindowStyle$
 None=�5       � 
ResizeMode$ NoResize=�5	       � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�5       � Icon$ Pic\dage.ico��5      ��5      Z�  � Triggers 5      :� 5       :� RoutedEvent$ Window.Loaded��5      .[�5      �� ��5      �� 5      -   5        	 g�Name$	 sbOpShow��5      .��5      W� 
 �� 
TargetName$

 main��5       �� TargetProperty$ Opacity�5       W� From$ 0X�5      	 W� To$	 0.8X�5       g� Duration$ 0:0:0.15D�5      5      5      5       � 	Resources 5       ��%    6   .��5!      �� ���	#F03A3A3A J� Opacity$ 1Q�5#       �� CornerRadius$ 3��5$      ._�5%      �� .+�5&      �� 
 �� Top$ 0��5'      $��25��5(      $��0,0,0,1q�5*      ���	#FFEFE2E2��5)      ��  �� ElementName$
 main�� �� Path$ Width� �� UpdateSourceTrigger$ PropertyChanged=�._�5,      �� -   5         ��Name$ lblTitle��5-      $
��test��5.      $
��Left=�5/      ���	#FFCBBEBE$��14(�51      $��Center=�52      $��5q�53      54      �� 55      -   5        $ lblMsg��56      
�������$��14(�58      $
��Wrap=�59      $
��test��5:      $��Center=�5;       �� Left$ 20��5<      $ 50��5=      �� 5>      -   5        $��border1��5E      ���	#FF60C1C1$	��0.5q�5@      $��22��5A       �� Bottom$ 10��5B       �� Right$	 185��5C      $��49��5F      ���	#FFC7C7C7$ 2��5H      ._�5I      �� $	��嗯��5J      $��Center=�5K      $��Center=�5L      5M      �� 5N      -   5        $��border2��5U      ���	#FF60C1C1$	��0.5q�5P      $��22��5Q      $ 10��5R      $ 30��5S      $��49��5V      $ 2��5W      ���	#FFC7C7D1._�5Y      �� $	��是��5Z      $��Center=�5[      $��Center=�5\      5]      5^      5_      5`      