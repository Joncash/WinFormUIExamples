using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WinApp_UI_Examples
{
	/*覆寫 OnPaint(object, e)*/
	public class CircularButton : Button
	{
		protected override void OnPaint(PaintEventArgs pevent)
		{
			//使用 GraphicPath
			GraphicsPath g = new GraphicsPath();
			var upperLeft_pos_x = 0;
			var upperLeft_pos_y = 0;
			var width = ClientSize.Width; //控制項的寬度
			var height = ClientSize.Height; //控制項的高度
			g.AddEllipse(upperLeft_pos_x, upperLeft_pos_y, width, height);

			//Region 重新繪制
			this.Region = new System.Drawing.Region(g);

			base.OnPaint(pevent);
		}
	}
}
