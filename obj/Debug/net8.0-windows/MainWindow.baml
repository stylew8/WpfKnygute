   M S B A M L   `   `   `  ����E  AWpfKnygute, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WpfKnygute
WpfKnygute  5   	       WpfKnygute.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WpfKnygute     5   	     � Title$  Contacts��5   	   $	��450��6   $	��389��6'    � WindowStartupLocation$ CenterScreen=�5	   	    � 
ResizeMode$ NoResize=�5
   	   .��5      �  � RowDefinitions 5   
   �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DtgContacts��5      $��0,0,98,0q�6(      AutoGenerateColumns$ False��6:      CanUserResizeColumns$ False��5         CanUserAddRows$ False��60      CanUserResizeRows$ False��6G   	   CanUserDeleteRows$	 False��5      
   CanUserReorderColumns$
 False��6-    J� RenderTransformOrigin$ 0.544,0.774&�6K      
IsReadOnly$
 True��5      
�������
���   �   ColumnHeaderStyle 5      �� 5       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5      ��  �� Property � �� �� Value
 �����63   �� 5       � ��
 �   �63   5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Full Name��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 1.3* 6U   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *
FullName+6U     5      $ Number��6%   $
 1.5* 6P    65   �� *Number+6P     5      $ Date of Birth��6%   $ * 6{    6<   �� *DateOfBirth+ �� StringFormat$ {0:yyyy-MM-dd}��6{   5      �� 5!   
   -   5         ��Name$ BtnAdd��5!      $	��Add��6!   $��Right=�5"      $��0,74,7,0q�5#      $	��Top=�5$      $��35��5%      $��86��6    � Cursor$
 Hand��5'      ���	#FF81D082���	#FF73DA5E
���������5(      �� 5)      " ��6   .�5*      ��  � �� 5+      �� 5,       �� 
TargetType" ��6.   .R�5-   "   ��  �� CornerRadius$ 10��6)   #��z��6;   ._�5.   &   �� $��Center=�67   $��Center=�6T   5/   #   50      52      53      55      �� 57   
   -   5        $ BtnEdit��57      $
��Edit��6"   $��Right=�58      $��	0,127,7,0q�59      $	��Top=�5:      $��35��5;      $��86��6   $
 Hand��5=      
����������	#FF5565EC���	#FFD6DA86��5>      �� 5?      " ��6   .�5@      ��  � �� 5A      �� 5B      " ��6.   .R�5C   "   �� $ 10��6)   #��z��6;   ._�5D   &   �� $��Center=�67   $��Center=�6T   5E   #   5F      5H      5I      5K      �� 5M   
   -   5        $ 	btnDelete��5M      $��Delete��6$   $��Right=�5N      $��0,0,7,10q�5O      $��86��6#   $��35��5P   )   $��Bottom=�5Q      ���	#FFDE5454
�������$
 Hand��5T      ��5U      �� 5V      " ��6   .�5W      ��  � �� 5X      �� 5Y      " ��6.   .R�5Z   "   �� $ 10��6)   #��z��6;   ._�5[   &   �� $��Center=�67   $��Center=�6T   5\   #   5]      5_      5`      5b      5d      5e      