   M S B A M L   `   `   `  ����T  PPatientConsultationRecord, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:PatientConsultationRecord.Patients"PatientConsultationRecord.Patients  5   	   4    .PatientConsultationRecord.Patients.PatientList   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Blocal0clr-namespace:PatientConsultationRecord.Patients     5   	     � Title$  PatientList��5   	   $	��450��6   $	��800��6*    � WindowStartupLocation$ CenterScreen=�66   .��5	      � 4  .System.Windows.Automation.AutomationProperties   IsOffscreenBehavior$ Onscreen=�6   ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6    � Offset$ 0Q�6-   � 5      $ 	#FF2F3B7A��6   5       � ColumnDefinitions 5   
   �� 5      $
��475* �6   �� 5      $
��319* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgEmployees��5      $
��Left=�6(   $	��119��6C   $��
75,209,0,0q�6P   $	��Top=�6d   $	��704��6|   	   AutoGenerateColumns	 .  
   CanUserAddRows
 .  $��2��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
First Name��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 5   5   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6   �� *	FirstName+65     5      $ 	Last Name��6%   $ * 5   4    6   �� *
LastName+64   4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate 5      �� 5      .R�5      ��  ��Name$ btnShow��6%   -   5        .��5   L   Show6R   5      5         5!       5"      �� 5#      .R�5$      �� $ btnAdd��6%   -   5        .��5$   J   Add6O   5%      5'      5)      �� 5*   
   -   5         ��Name$ cboSortOrder��5*      $
��Left=�6)   $��161,166,0,0q�6D   $	��Top=�6Y   $	��120��6q   $��1��6�   �� 5+   
   -   5         ��Name$ lblSortOrder��5+      $��
Sort Order��6&   $
��Left=�6;   $��29��6V   $��
93,165,0,0q�6b   $	��Top=�6v   $��87��6�    J� RenderTransformOrigin$ 0.783,0.576&�6�   $��1��6�   �� 5,   
   -   5        $ 	cboSortBy��5,      $
��Left=�6&   $��437,165,0,0q�6A   $	��Top=�6V   $	��120��6n   $��2��6�   �� 5-   
   -   5        $ 	lblSortBy��5-      $��Sort By��6#   $
��Left=�65   $��29��6P   $��372,165,0,0q�6\   $	��Top=�6q   $��60��6�   $ 0.783,0.576&�6�   �� 5.   
   -   5        $ btnFirst��5.      $��First��6#   $
��Left=�63   $	��Top=�6N   $��75��6f   $��18��6q   $��
75,365,0,0q�6}   6�   �� 5/   
   -	   5        $ btnLast��5/      $
��Last��6"   $
��Left=�61   $	��Top=�6L   $��75��6d   $��18��6o   $��315,365,0,0q�6{   6�   �� 50   
   -
   5        $ btnNext��50      $
��Next��6"   $
��Left=�61   $	��Top=�6L   $��75��6d   $��18��6o   $��235,365,0,0q�6{   $ 0.615,2.311&�6�   6�   �� 51   
   -   5        $ btnPrevious��51      $��Previous��6&   $
��Left=�69   $	��Top=�6T   $��75��6l   $��18��6w   $��155,365,0,0q�6�   6�   �� 52   
   -   5         ��Name$ txtPageSize��52      $��10��6'   $
��Left=�61   $��23��6L    �� TextWrapping$
 Wrap=�6X   $	��Top=�6l   $��75��6�   $��113,388,0,0q�6�   6�   �� 53   
   -   5        $ 
txtKeyword��53      $
��Left=�6&   $��23��6A   $��122,171,0,0q�6M   $
 Wrap=�6b   $	��Top=�6v   $	��199��6�   $ 0.541,-0.697&�6�   �� 54   
   -   5        $ lblPageSize��54      $��	Page Size��6%   $
��Left=�69   $	��Top=�6T   $��
33,388,0,0q�6l   �� 55   
   -   5        $ lblSortBy_Copy��55      $��Search��6(   $
��Left=�69   $��29��6T   $��
75,165,0,0q�6`   $	��Top=�6t   $��87��6�   $ 0.783,0.576&�6�   �� 56   
   $
��PCRS��6   $
��Left=�6   $��81��6:   $��
273,24,0,0q�6F   $	��Top=�6Z   $	��247��6r   $��Arial Black)�6~   $��72(�6�   #��� ��6�   $��2��6  ��6�   Z� 6  �� 57   
   $�� ��6   $
��Left=�6   $��274,106,0,0q�66   $	��Top=�6K   $��9��6c   $ 0.5,0.5&�6n   $	��495��6�   #��� ��6�   $��2��6�   z�58      V� 59      .~�5:      ��  �� ScaleY$ -1Q�6%   �� 5;      �� 5<      T� 5=      5>      5@      �� 5A   
   $*��$Patient's Consultation Record System��6   $
��Left=�6?   $��272,120,0,0q�6Z   $	��Top=�6o   $	��506��6�   #��� ��6�   $��Arial Black)�6�   $��24(�6�   $ 0.5,0.5&�6  $��2��6<  ��6&  Z� z�5B      V� 5C      .~�5D      �� �� 5E      �� 5F       �� Angle$ 0.009Q�6&   T� 5G      5H      5J      �� 5K   
   $
��Left=�6   $	��158��6+   $��63,6,0,0q�68   $	��Top=�6J   $	��184��6b   $5��//PatientConsultationRecord;component/loogoo.png��6n   �� 5L   
   -   5        $
��Back��5L      $
��Left=�6    $��6,10,0,0q�6;   $	��Top=�6M   $��75��6e   6p   5M      5N      