using System;
using System.Collections;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;

namespace cs2000.Design
{
	public class MultiPanelPageDesigner : ScrollableControlDesigner
	{
		public MultiPanelPageDesigner()
		{
		}

		/// <summary>
		/// Shadows the <see cref="MultiPanelPage.Text"/> property.
		/// </summary>
		public string Text
		{
			get
			{
				return _page.Text;
			}
			set
			{
				string ot = _page.Text;
				_page.Text = value;
				if (GetService(typeof(IComponentChangeService)) is IComponentChangeService iccs)
				{
					if (_page.Parent is MultiPanel ytc)
					{
						ytc.Refresh();
					}
				}
			}
		}

		/// <summary>
		/// Overridden. Inherited from
		/// <see cref="ControlDesigner.OnPaintAdornments(PaintEventArgs)"/>.
		/// </summary>
		/// <param name="pea">
		/// Some <see cref="PaintEventArgs"/>.
		/// </param>
		protected override void OnPaintAdornments(PaintEventArgs pea)
		{
			base.OnPaintAdornments(pea);
			// My thanks to bschurter (Bruce), CodeProject member #1255339 for this!
			using (Pen p = new Pen(SystemColors.ControlDark, 1))
			{
				p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
				pea.Graphics.DrawRectangle(p, 0, 0, _page.Width - 1, _page.Height - 1);
			}
			using (Brush b = new SolidBrush(Color.LightGray))
			{
				float fh = _font.GetHeight(pea.Graphics);
				RectangleF tleft = new RectangleF(0, 0, _page.Width / 2, fh);
				pea.Graphics.DrawString(_page.Text, _font, b, tleft);
			}
		}

		/// <summary>
		/// Overridden. Inherited from <see cref="ControlDesigner.Initialize( IComponent )"/>.
		/// </summary>
		/// <param name="component">
		/// The <see cref="IComponent"/> hosted by the designer.
		/// </param>
		public override void Initialize(IComponent component)
		{
			_page = component as MultiPanelPage;
			if (_page == null)
			{
				DisplayError(new Exception("You attempted to use a MultiPanelPageDesigner with a class that does not inherit from MultiPanelPage."));
			}
			base.Initialize(component);
		}

		/// <summary>
		/// Overridden. Inherited from <see cref="ControlDesigner.PreFilterProperties(IDictionary)"/>.
		/// </summary>
		/// <param name="properties"></param>
		protected override void PreFilterProperties(IDictionary properties)
		{
			base.PreFilterProperties(properties);
			properties["Text"] = TypeDescriptor.CreateProperty(typeof(MultiPanelPageDesigner), (PropertyDescriptor)properties["Text"], new Attribute[0]);
		}

		#region Constants
		/// <summary>
		/// Id for the WM_LBUTTONDOWN message.
		/// </summary>
		private const int WM_LBUTTONDOWN = 0x0201;

		/// <summary>
		/// Id for the WM_LBUTTONDBLCLICK message.
		/// </summary>
		private const int WM_LBUTTONDBLCLK = 0x0203;
		#endregion

		/// <summary>
		/// </summary>
		private MultiPanelPage _page;
		private Font _font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular);
		private StringFormat _rightfmt = new StringFormat(StringFormatFlags.NoWrap | StringFormatFlags.DirectionRightToLeft);
	}
}
