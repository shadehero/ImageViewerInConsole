using System;
using System.IO;
using System.Drawing;

namespace ImageViewer
{
	public class CImage
	{
		public int Width;
		public int Height;
		public Bitmap Bmp;

		public CImage(string path)
		{
			if (File.Exists(path))
			{
				Bmp = new Bitmap(path);
				Width = Bmp.Width;
				Height = Bmp.Height;
			}
		}

		public void Draw(int _x, int _y,char c)
		{
			Console.ForegroundColor = ConsoleColor.White;
			for (int y = 0; y < Bmp.Height; y++)
			{
				for (int x = 0; x < Bmp.Width; x++)
				{
					Console.SetCursorPosition(_x + x, _y + y);
					if (Bmp.GetPixel(x, y) == Color.FromArgb(255,255,255))
					{
						Console.Write(c);
					}

				}
			}
			Console.ResetColor();
		}
	}
}
