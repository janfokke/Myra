/* Generated by MyraPad at 7/8/2021 2:39:49 PM */
using Myra;
using Myra.Graphics2D;
using Myra.Graphics2D.TextureAtlases;
using Myra.Graphics2D.UI;
using Myra.Graphics2D.Brushes;
using Myra.Graphics2D.UI.Properties;

#if MONOGAME || FNA
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
#elif STRIDE
using Stride.Core.Mathematics;
#else
using System.Drawing;
using System.Numerics;
#endif

namespace Myra.Samples.TextRendering.UI
{
	partial class MainPanel: Panel
	{
		private void BuildUI()
		{
			var horizontalSeparator1 = new HorizontalSeparator();

			var label1 = new Label();
			label1.Text = "Font Size:";

			_spinButtonFontSize = new SpinButton();
			_spinButtonFontSize.Value = 32;
			_spinButtonFontSize.Width = 40;
			_spinButtonFontSize.GridColumn = 1;
			_spinButtonFontSize.Id = "_spinButtonFontSize";

			var label2 = new Label();
			label2.Text = "Scale:";
			label2.GridColumn = 2;

			var label3 = new Label();
			label3.Text = "0.1";
			label3.GridColumn = 3;

			_sliderScale = new HorizontalSlider();
			_sliderScale.Minimum = 0.1f;
			_sliderScale.Maximum = 10;
			_sliderScale.Value = 1;
			_sliderScale.Width = 200;
			_sliderScale.GridColumn = 4;
			_sliderScale.Id = "_sliderScale";

			var label4 = new Label();
			label4.Text = "10";
			label4.GridColumn = 5;

			_buttonReset = new TextButton();
			_buttonReset.Text = "Reset";
			_buttonReset.GridColumn = 6;
			_buttonReset.Id = "_buttonReset";

			_checkBoxSmoothText = new CheckBox();
			_checkBoxSmoothText.Text = "Smooth Text";
			_checkBoxSmoothText.GridColumn = 7;
			_checkBoxSmoothText.Id = "_checkBoxSmoothText";

			_labelScaleValue = new Label();
			_labelScaleValue.Text = "5.4";
			_labelScaleValue.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Center;
			_labelScaleValue.GridColumn = 4;
			_labelScaleValue.GridRow = 1;
			_labelScaleValue.Id = "_labelScaleValue";

			var grid1 = new Grid();
			grid1.ColumnSpacing = 8;
			grid1.RowSpacing = 2;
			grid1.DefaultColumnProportion = new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Auto,
			};
			grid1.DefaultRowProportion = new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Auto,
			};
			grid1.Widgets.Add(label1);
			grid1.Widgets.Add(_spinButtonFontSize);
			grid1.Widgets.Add(label2);
			grid1.Widgets.Add(label3);
			grid1.Widgets.Add(_sliderScale);
			grid1.Widgets.Add(label4);
			grid1.Widgets.Add(_buttonReset);
			grid1.Widgets.Add(_checkBoxSmoothText);
			grid1.Widgets.Add(_labelScaleValue);

			_textBoxText = new TextBox();
			_textBoxText.Text = "The quick brown\\nfox jumps over\\nthe lazy dog";
			_textBoxText.Multiline = true;
			_textBoxText.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			_textBoxText.Id = "_textBoxText";

			var verticalStackPanel1 = new VerticalStackPanel();
			verticalStackPanel1.Proportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Auto,
			});
			verticalStackPanel1.Proportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Auto,
			});
			verticalStackPanel1.Proportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Fill,
			});
			verticalStackPanel1.Widgets.Add(horizontalSeparator1);
			verticalStackPanel1.Widgets.Add(grid1);
			verticalStackPanel1.Widgets.Add(_textBoxText);

			
			Widgets.Add(verticalStackPanel1);
		}

		
		public SpinButton _spinButtonFontSize;
		public HorizontalSlider _sliderScale;
		public TextButton _buttonReset;
		public CheckBox _checkBoxSmoothText;
		public Label _labelScaleValue;
		public TextBox _textBoxText;
	}
}
