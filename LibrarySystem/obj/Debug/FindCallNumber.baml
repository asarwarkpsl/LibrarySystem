   M S B A M L   `   `   `  ????H  DLibrarySystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:LibrarySystemLibrarySystem  5   	   "    LibrarySystem.FindCallNumber   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:LibrarySystem     5   	   $	??898??5   
   $	??672??6     ? WindowStartupLocation$  CenterScreen=?5	   	    ? 
ResizeMode$ NoResize=?5
   	    ? Title$ Challange CallNumber??5   	   $	??672??6&   $	??898??63   .??5      ? $	??644??6   $	??Top=?6    ? ColumnDefinitions 5   
   ?? 5      $
??285* ?6   ?? 5      $
??164* ?6   .+?5   
   ?? $??2??6   .+?5      ?? -   5         ??Name$ lblQuestion??5      $??Label??6)    ?? Left$ 39??69   
 ?? Top$ 32??6J   $??22(?6Z   ?? 5      -   5         ??Name$ 
lstOptions??5      $	??404??6+   $	??896??68   $??Center=?6o   $ 99??6?   $	??Top=?6?    ?? View 5      ?? 5      .P?5      ?? 5      5      ?? 5      -   5        	 ??Name$	 btnNextQuestion??5      $??Next Question??6.   $
??Auto??6F   $??73??6S   
 J? RenderTransformOrigin$
 4.439,4.791&?6_   $??Center=?6?   $	 626??6?   $	 554??6?   $
??Left=?6?   6?   ?? 5      -   5        $	 btnReset??5      $??	Try Again??6'   $
??Auto??6;   $??65??6H   $
 0.483,1.443&?6T   $	??Top=?6x   $ 39??6?   $	 562??6?   6?   ?? 5      -   5        $	 btnVerifyAns??5      $??Verify??6+   $	??115??6<   $??73??6H   $
 4.439,4.791&?6T   $??Center=?6x   $	 758??6?   $	 554??6?   $
??Left=?6?   6?   ?? 5      -   5        $	 btnPreviousQuestion??5      $??Previous Question??62   $
??Auto??6N   $??73??6[   $
 4.439,4.791&?6g   $	 473??6?   $	 554??6?   $
??Left=?6?   $??Center=?6?   ?? 5       -   5        $	 btnPreviousQuestion_Copy??5       $??Previous Question??67   $
??Auto??6S   $??73??6`   $
 4.439,4.791&?6l   $	 473??6?   $	 554??6?   $??Center=?6?   $??Center=?6?   5!      5#      5$      