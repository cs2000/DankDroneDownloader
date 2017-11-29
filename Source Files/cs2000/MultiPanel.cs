using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace cs2000
{
	[ToolboxBitmap(typeof(MultiPanel), "multipanel")]
	[Designer(typeof(Design.MultiPanelDesigner))]
	public class MultiPanel : Panel
	{
		public event EventHandler<EventArgs> SelectedPageChanged;

		private MultiPanelPage _selectedPage;
		public MultiPanelPage SelectedPage
		{
			get { return _selectedPage; }
			set
			{
				if (_selectedPage != value)
				{
					_selectedPage = value;
					if (_selectedPage != null)
					{
						foreach (Control child in Controls)
						{
							child.Visible = object.ReferenceEquals(child, _selectedPage);
						}
					}
					SelectedPageChanged?.Invoke(this, new EventArgs());
				}
			}
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			Graphics g = e.Graphics;
			using (SolidBrush br = new SolidBrush(BackColor))
			{
				g.FillRectangle(br, ClientRectangle);
			}
		}

		protected override ControlCollection CreateControlsInstance()
		{
			return new MultiPanelPagesCollection(this);
		}
	}
	
}
