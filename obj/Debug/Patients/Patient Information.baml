   M S B A M L   `   `   `  ����T  PPatientConsultationRecord, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:PatientConsultationRecord.Patients"PatientConsultationRecord.Patients  5   	   <    6PatientConsultationRecord.Patients.Patient_Information   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Blocal0clr-namespace:PatientConsultationRecord.Patients     5   	     � Title$  Patient_Information��5   	   $	��450��6%   $	��800��62    � WindowStartupLocation$ CenterScreen=�6>   .��5	      � ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6    � Offset$ 0Q�6-   � 5      $ 	#FF2F3B7A��6   5       � ColumnDefinitions 5   
   �� 5      $
��475* �6   �� 5      $
��319* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgEmployees��5      $
��Left=�6(   $	��124��6C   $��
85,203,0,0q�6P   $	��Top=�6d   $	��704��6|      AutoGenerateColumns .  	   CanUserAddRows	 .  $��2��6�   
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
First Name��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 5   5   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6   �� *	FirstName+65     5      $ 	Last Name��6%   $ * 5   4    6   �� *
LastName+64     5      $ 	Birthdate��6%   $ * 5   E    6   �� *	Birthdate+ �� StringFormat$ d��6E     5      $ 
Birthplace��6%   $ * 5   6    6   �� *
Birthplace+66     5      $	 Sex��6%   $ * 5   /    6   �� *Sex+6/   5"      �� 5#   
   -   5         ��Name$ cboSortOrder��5#      $
��Left=�6)   $��171,160,0,0q�6D   $	��Top=�6Y   $	��120��6q   $��1��6�   �� 5$   
   -   5         ��Name$ lblSortOrder��5$      $��
Sort Order��6&   $
��Left=�6;   $��29��6V   $��103,159,0,0q�6b   $	��Top=�6w   $��87��6�    J� RenderTransformOrigin$ 0.783,0.576&�6�   $��1��6�   �� 5%   
   -   5        $ 	cboSortBy��5%      $
��Left=�6&   $��447,159,0,0q�6A   $	��Top=�6V   $	��120��6n   $��2��6�   �� 5&   
   -   5        $ 	lblSortBy��5&      $��Sort By��6#   $
��Left=�65   $��29��6P   $��382,159,0,0q�6\   $	��Top=�6q   $��60��6�   $ 0.783,0.576&�6�   �� 5'   
   -   5         ��Name$ btnFirst��5'      $��First��6#   $
��Left=�63   $	��Top=�6N   $��75��6f   $��18��6q   $��
85,359,0,0q�6}   6�   �� 5(   
   -   5        $ btnLast��5(      $
��Last��6"   $
��Left=�61   $	��Top=�6L   $��75��6d   $��18��6o   $��325,359,0,0q�6{   6�   �� 5)   
   -   5        $ btnNext��5)      $
��Next��6"   $
��Left=�61   $	��Top=�6L   $��75��6d   $��18��6o   $��245,359,0,0q�6{   $ 0.615,2.311&�6�   6�   �� 5*   
   -	   5        $ btnPrevious��5*      $��Previous��6&   $
��Left=�69   $	��Top=�6T   $��75��6l   $��18��6w   $��165,359,0,0q�6�   6�   �� 5+   
   -
   5         ��Name$ txtPageSize��5+      $��10��6'   $
��Left=�61   $��23��6L    �� TextWrapping$
 Wrap=�6X   $	��Top=�6l   $��75��6�   $��165,382,0,0q�6�   6�   �� 5,   
   -   5        $ 
txtKeyword��5,      $
��Left=�6&   $��23��6A   $��132,165,0,0q�6M   $
 Wrap=�6b   $	��Top=�6v   $	��199��6�   $ 0.541,-0.697&�6�   �� 5-   
   -   5        $ lblPageSize��5-      $��	Page Size��6%   $
��Left=�69   $	��Top=�6T   $��
85,382,0,0q�6l   �� 5.   
   -   5        $ lblSortBy_Copy��5.      $��Search��6(   $
��Left=�69   $��29��6T   $��
85,159,0,0q�6`   $	��Top=�6t   $��87��6�   $ 0.783,0.576&�6�   �� 5/   
   $
��PCRS��6   $
��Left=�6   $��81��6:   $��
279,18,0,0q�6F   $	��Top=�6Z   $	��247��6r   $��Arial Black)�6~   $��72(�6�   #��� ��6�   $��2��6  ��6�   Z� 6  �� 50   
   $�� ��6   $
��Left=�6   $��284,100,0,0q�66   $	��Top=�6K   $��8��6c   $ 0.5,0.5&�6n   $	��405��6�   #��� ��6�   $��2��6�   z�51      V� 52      .~�53      ��  �� ScaleY$ -1Q�6%   �� 54      �� 55      T� 56      57      59      �� 5:   
   $*��$Patient's Consultation Record System��6   $
��Left=�6?   $��282,114,0,0q�6Z   $	��Top=�6o   $	��506��6�   #��� ��6�   $��Arial Black)�6�   $��24(�6�   $ 0.5,0.5&�6  $��2��6<  ��6&  Z� z�5;      V� 5<      .~�5=      �� �� 5>      �� 5?       �� Angle$ 0.009Q�6&   T� 5@      5A      5C      �� 5D   
   $
��Left=�6   $	��158��6+   $��72,1,0,0q�68   $	��Top=�6J   $	��184��6b   $5��//PatientConsultationRecord;component/loogoo.png��6n   �� 5E   
   -   5        $
��Back��5E      $
��Left=�6    $	��Top=�6;   $��75��6S   $��	10,10,0,0q�6^   6q   �� 5F   
   -   5        $��2��5F      $��Add Patient��6%   $
��Left=�6;   $��447,359,0,0q�6V   $	��Top=�6k   $	��158��6�   6�   5G      5H      