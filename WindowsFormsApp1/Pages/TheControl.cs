using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace BattleShip_DSA_Project.Pages
{
    static class TheControl
    {
        static bool isMax = false, isFull = false;
        static Point old_Loc, default_loc;
        static Size old_size, default_size;

        public static void SetInitials(Window win)
        {
            if (win != null)
            {
                old_size = new Size(win.Width, win.Height);
                old_Loc = new Point(win.Left, win.Top);
                default_size = new Size(win.Width, win.Height);
                default_loc = new Point(win.Top, win.Left);
            }
        }

        public static void DoMaximize(Window win, Button btn)
        {
            if (isMax == false)
            {
                old_size = new Size(win.Width, win.Height);
                old_Loc = new Point(win.Top, win.Left);
                Maximize(win);
                isMax = true;
                isFull = false;
                btn.Content = "2";
            }
            else
            {
                win.Top = old_Loc.Y;
                win.Left = old_Loc.X;
                win.Width = old_size.Width;
                win.Height = old_size.Height;
                isMax = false;
                isFull = false;
                btn.Content = "2";
            }
        }

        public static void DoFullScreen(Window win)
        {
            if (isFull == false)
            {
                old_size = new Size(win.Width, win.Height);
                old_Loc = new Point(win.Top, win.Left);
                Fullscreen(win);
                isMax = false;
                isFull = true;
            }
            else
            {
                win.Top = old_Loc.Y;
                win.Left = old_Loc.X;
                win.Width = old_size.Width;
                win.Height = old_size.Height;
                isMax = false;
                isFull = false;
            }
        }


        static void Fullscreen(Window win)
        {
            if (win.WindowState == WindowState.Normal)
                win.WindowState = WindowState.Maximized;
            else
                win.WindowState = WindowState.Normal;
        }
        static void Maximize (Window win)
        {
            double x = SystemParameters.WorkArea.Width;
            double y = SystemParameters.WorkArea.Height;
            win.WindowState = WindowState.Normal;
            win.Top = 0;
            win.Left = 0;
            win.Width = x;
            win.Height = y;
        }
        public static void Minimize (Window win)
        {
            win.WindowState = WindowState.Minimized;
        }

        public static void Exit()
        {
            Application.Current.Shutdown();
        }
    }
}
