   M S B A M L   `   `   `  ����   GaiaDownload    HttpDemo.UMessageBox   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -     �Name$
  main�� � Title$
 Gaia��$	��130��$	��280�� � WindowStyle$
 None=� � 
ResizeMode$ NoResize=� � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=� � Icon$ Pic\dage.ico����Z�  � Triggers :�  :� RoutedEvent$ Window.Loaded��.[��� ���� -   	 g�Name$	 sbOpShow��.��W� 
 �� 
TargetName$

 main�� �� TargetProperty$ Opacity� W� From$ 0X�	 W� To$	 0.8X� g� Duration$ 0:0:0.15D� � 	Resources ��%    .���� ���	#F03A3A3A J� Opacity$ 1Q� �� CornerRadius$ 3��._��� .+��� 
 �� Top$ 0��$��25��$��0,0,0,1q����	#FFEFE2E2����  �� ElementName$
 main�� �� Path$ Width� �� UpdateSourceTrigger$ PropertyChanged=�._��� -    ��Name$ lblTitle��$
��test��$
��Left=����	#FFCBBEBE$��14(�$��Center=�$��5q��� -   $ lblMsg��
�������$��14(�$
��Wrap=�$
��test��$��Center=� �� Left$ 20��$ 50���� -   $��border1�����	#FF60C1C1$	��0.5q�$��22�� �� Bottom$ 10�� �� Right$	 185��$��49�����	#FFC7C7C7$ 2��._��� $	��嗯��$��Center=�$��Center=��� -   $��border2�����	#FF60C1C1$	��0.5q�$��22��$ 10��$ 30��$��49��$ 2�����	#FFC7C7D1._��� $	��是��$��Center=�$��Center=�