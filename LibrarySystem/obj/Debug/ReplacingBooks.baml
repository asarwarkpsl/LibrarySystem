   M S B A M L   `   `   `  ????H  DLibrarySystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:LibrarySystemLibrarySystem  5   	   "    LibrarySystem.ReplacingBooks   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:LibrarySystem     5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5           MaterialDesignBody#???   5	   
   $??Regular"?5
   
   $??13(?5   
   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=?5   
      TextRenderingMode$
 Auto=?5   
     MaterialDesignPaper#???  5   
     MaterialDesignFont#???  5   
    ? WindowStartupLocation$ CenterScreen=?5   
    ? 
ResizeMode$ NoResize=?5   
   $	??685??5   
   $	??858??6    ? Title$ Replace Books??5   	   $	??685??6   $	??858??6,   .??5      ? $??0,2,0,-2q?6   .+?5   
   ?? -   5         ??Name$ lstSortedList??5      $??Right=?6U   $??535,122,78,105q?6l    ?? View 5      ?? 5      .P?5      ?? 5      5      ?? 5   
   -   5        $ lstAvailableBooks??5      $
??Left=?6Y   $??47,122,567,105q?6o    5      ?? 5      .P?5      ?? 5       5"      ?? 5#   
   -   5         ??Name$ 
lblHeading??5#      $??Replace Books??6$   $??Center=?6<   $	??Top=?6Y   $??24(?6q   ???	#DD0E32F1$??Center=?6?   $??Center=?6?   $??0,-8,0,0q?6?   ?? 5%   
   $??WrapWithOverflow=?6   $??20(?64   $??Italic$?6B   $??10,34,10,547q?6U   ??Place the Call numbers from left hand list to the right hand list in Sorting order. Press Try again to practice aslong as you want.5'      ?? 5)   
   -   5         ??Name$ btnRight??5)      $	??►??6#   $
??Auto??67   $??55??6D   $??356,170,356,444q?6P   	 J? RenderTransformOrigin$	 4.439,4.791&?6i   $??36(?6?   $??Normal$?6?   $
??Bold"?6?   $??Center=?6?   $	??Top=?6?   5+      ?? 5,   
   -   5        $ btnLeft??5,      $	??◄??6"   $
??Auto??66   $??55??6C   $??0,233,0,381q?6O   $	 4.439,4.791&?6d   $??Center=?6?   $??36(?6?   5.      ?? 5/   
   -   5        $ btnUp??5/      $	??▲??6    $
??Auto??64   $??55??6A   $??0,295,0,319q?6M   $	 4.439,4.791&?6b   $??Center=?6?   $??36(?6?   $
??Bold"?6?   51      ?? 52   
   -   5        $ btnDown??52      $	??▼??6"   $
??Auto??66   $??55??6C   $??	0,357,0,0q?6O   $	 4.439,4.791&?6b   $??Center=?6?   $??36(?6?   $	??Top=?6?   54      ?? 55   
   -	   5        $ btnClose??55      $??Close??6#   $
??Auto??63   $??55??6@   $??674,582,38,0q?6L   $	 4.439,4.791&?6b   $	??Top=?6?   ?? 56   
   -
   5        $ btnValidate??56      $??Verify Sorting??6&   $
??Auto??6?   $??55??6L   $??499,583,189,0q?6X   $	 4.439,4.791&?6o   $	??Top=?6?   ?? 57   
   -   5        $ btnReset??57      $??	Try Again??6#   $
??Auto??67   $??55??6D   $??39,584,625,0q?6g   $	 0.483,1.443&?6}   $	??Top=?6?   ?? 58   
   $??Unsorted Call Numbers??6   $
??Left=?60   $??101,122,0,0q?6K   $	??Top=?6`   $
??Bold"?6x   ?? 59   
   $??Sorted Call Numbers??6   $
??Left=?6.   $??591,122,0,0q?6I   $	??Top=?6^   $
??Bold"?6v   5;      5<      