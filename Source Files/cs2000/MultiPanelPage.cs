using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace cs2000
{
	[Designer(typeof(Design.MultiPanelPageDesigner))]
    public class MultiPanelPage : ContainerControl
    {
        public MultiPanelPage()
        {
            base.Dock = DockStyle.Fill;
        }

        /// <summary>
        /// Overridden from <see cref="Panel"/>.
        /// </summary>
        /// <remarks>
        /// Since the <see cref="MultiPanelPage"/> exists only
        /// in the context of a <see cref="MultiPanelControl"/>,
        /// it makes sense to always have it fill the
        /// <see cref="MultiPanelControl"/>. Hence, this property
        /// will always return <see cref="DockStyle.Fill"/>
        /// regardless of how it is set.
        /// </remarks>
        public override DockStyle Dock
        {
            get
            {
                return base.Dock;
            }
            set
            {
                base.Dock = DockStyle.Fill;
            }
        }

        /// <summary>
        /// Only here so that it shows up in the property panel.
        /// </summary>
        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;
            }
        }

        /// <summary>
        /// Overridden from <see cref="Control"/>.
        /// </summary>
        /// <returns>
        /// A <see cref="MultiPanelPage.ControlCollection"/>.
        /// </returns>
        protected override Control.ControlCollection CreateControlsInstance()
        {
            return new MultiPanelPage.ControlCollection(this);
        }

        #region Classes
        public new class ControlCollection : Control.ControlCollection
        {
            /// <summary>
            /// </summary>
            public ControlCollection(Control owner) : base(owner)
            {
				if (owner == null)
				{
					throw new ArgumentNullException("owner", "Tried to create a MultiPanelPage.ControlCollection with a null owner.");
				}
                MultiPanelPage c = owner as MultiPanelPage;
				if (c == null)
				{
					throw new ArgumentException("Tried to create a MultiPanelPage.ControlCollection with a non-MultiPanelPage owner.", "owner");
				}
            }

            /// <summary>
            /// </summary>
            public override void Add(Control value)
            {
				if (value == null)
				{
					throw new ArgumentNullException("value", "Tried to add a null value to the MultiPanelPage.ControlCollection.");
				}
				if (value is MultiPanelPage p)
				{
					throw new ArgumentException("Tried to add a MultiPanelPage control to the MultiPanelPage.ControlCollection.", "value");
				}
				base.Add(value);
            }
        }
        #endregion

    }
}
