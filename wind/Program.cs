using System;
using System.Runtime.InteropServices;
using System.Threading;

class Program
{
    [DllImport("user32.dll")]
    private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

    private const byte VK_LWIN = 0x5B; // Sol Windows tuşu
    private const byte VK_D = 0x44; // D tuşu
    private const uint KEYEVENTF_KEYUP = 0x0002;

    static void Main()
    {
        // Windows tuşuna bas
        keybd_event(VK_LWIN, 0, 0, 0);
        Thread.Sleep(50); // Kısa bir bekleme süresi

        // D tuşuna bas
        keybd_event(VK_D, 0, 0, 0);
        Thread.Sleep(50);

        // D tuşunu bırak
        keybd_event(VK_D, 0, KEYEVENTF_KEYUP, 0);
        Thread.Sleep(50);

        // Windows tuşunu bırak
        keybd_event(VK_LWIN, 0, KEYEVENTF_KEYUP, 0);

        Console.WriteLine("Windows + D tuş kombinasyonu gönderildi.");
    }
}