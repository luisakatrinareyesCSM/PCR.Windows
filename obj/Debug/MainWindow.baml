   M S B A M L   `   `   `  ����T  PPatientConsultationRecord, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:PatientConsultationRecordPatientConsultationRecord  5   	   *    $PatientConsultationRecord.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:PatientConsultationRecord     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � WindowStartupLocation$ CenterScreen=�65   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��277* �6   �� 5      $
��515* �6   ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6    � Offset$ 0Q�6-   � 5      $ 	#FF2F3B7A��6   5      .+�5   
   �� -   5        $��PATIENT RECORD��5      $
��Left=�6*   $��49��6E   $��143.6,221,0,0q�6Q   $	��Top=�6h   $	��318��6�   $��Arial Black)�6�   $��24(�6�   #��� ��6�   #��� ��6  $��1��6T  ��5      �� 5      5      �� 5   
   $��WELCOME!��6   $
��Left=�6#   $��65��6>   $��
21,250,0,0q�6J   $	��Top=�6^   $	��357��6v   
������ $��Arial Black)�6�   $��48(�6�   #��� ��6�   $��2��6  �� 5   
   $
��PCRS��6   $
��Left=�6   $��81��6:   $��
240,32,0,0q�6F   $	��Top=�6Z   $	��247��6r   $��Arial Black)�6~   $��72(�6�   #��� ��6�   $��2��6  ��6�   Z� 6  �� 5   
   $�� ��6   $
��Left=�6   $��241,114,0,0q�66   $	��Top=�6K   $��6��6c    J� RenderTransformOrigin$ 0.5,0.5&�6n   $	��504��6�   #��� ��6�   $��2��6�   z�5      V� 5      .~�5      ��  �� ScaleY$ -1Q�6%   �� 5      �� 5       T� 5!      5"      5$      �� 5%   
   $*��$Patient's Consultation Record System��6   $
��Left=�6?   $��239,128,0,0q�6Z   $	��Top=�6o   $	��506��6�   #��� ��6�   $��Arial Black)�6�   $��24(�6�   $ 0.5,0.5&�6  $��2��6<  ��6&  Z� z�5&      V� 5'      .~�5(      �� �� 5)      �� 5*      	 �� Angle$	 0.009Q�6&   T� 5+      5,      5.      �� 5/   
   
���   �$��1q�6%   $
��Left=�69   $��0��6T   $��263,320,0,0q�6_   $	��Top=�6t   $	��224��6�   $��2��6�   �� 50   
   -   5        $��PATIENT INFORMATION��50      $
��Left=�6/   $��49��6J   $��141.6,304,0,0q�6V   $	��Top=�6m   $	��322��6�   $��Arial Black)�6�   $��24(�6�   #��� ��6�   #��� ��6  $ 0.5,0.5&�6Z  $��1��6z  z�51      V� 52      .~�53      �� �� 54      
 �� AngleY$
 0.301Q�6$   �� 55      T� 56       T� Y$ 0.795Q�6)   57      ��59      �� 5:      5<      �� 5=   
   $
��Left=�6   $	��158��6+   $��	21,32,0,0q�68   $	��Top=�6K   $	��184��6c   $��
loogoo.png��6o   �� 5>   
   -   5        $��Change passsword?��5>      $
��Left=�6-   $��
12,391,0,0q�6H   $	��Top=�6\   $	��153��6t   ���	#FF2F3B7A#��� ��6�   #��� ��6�   6+  �� 5?   
   -   5        $��Log Out?��5?      $
��Left=�6$   $��
12,371,0,0q�6?   $	��Top=�6S   $	��153��6k   ���	#FF2F3B7A#��� ��6�   #��� ��6�   6"  �� 5@   
   -   5        $��Add User��5@      $
��Left=�6$   $��
12,347,0,0q�6?   $	��Top=�6S   $	��153��6k   ���	#FF2F3B7A#��� ��6�   #��� ��6�   6"  5B      5C      