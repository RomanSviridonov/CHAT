   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.Personal   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   -   5          � Title$  Personal��5   	   $	��450��6   $	��800��6'   .��5	      � ��5
   
   �� 5      .+�5   
   �� $��-3,-20,-0.4,-38q�6   $��img/Frame1.png��6)   $
��Fill=�6A    J� RenderTransformOrigin$ 0.5,0.5&�6P    J� OpacityMask �	#CC000000z�5      V� 5      .~�5      ��  �� ScaleX$ -1Q�6%   �� 5      �� 5      T� 5      5      5      �� 5   
   -   5         ��Name$ 	LabelName��5      $��Label��6#   $
��Left=�63   $��	59,37,0,0q�6N   $	��Top=�6a   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ Friends��5      $
��Left=�6$   $	��300��6?   $��
242,73,0,0q�6L   $	��Top=�6`   $	��314��6x   ���	#FFFCBCFF   
IsReadOnly . ���	#FFEB77FF$��16(�6�    �� IsTextSearchEnabled .    	CellStyle 5      �� 5      	 �� 
TargetType*  $System.Windows.Controls.DataGridCell"	  6   
 �� Triggers
 5      P� 5       P� Property �@ 
IsSelected P� Value . . �5      ��  �� Property � �� �� Value
 ���� 6;   �� 5        � ��
 �   �6;   �� 5!       � ��$ 0q�6@   5"      5$      5&      �� 5'   
   -   5        $ 
FriendName��5'      $��ЛАаа��6$   $
��Left=�63   $��33��6N   $��
361,45,0,0q�6Z   $	��Top=�6n   $��75��6�   5(      5)      