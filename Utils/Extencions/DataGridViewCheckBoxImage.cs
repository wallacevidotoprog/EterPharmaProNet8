﻿using EterPharmaPro.Properties;

namespace EterPharmaPro.Utils.Extencions
{
	public class DataGridViewCheckBoxImageColumn : DataGridViewCheckBoxColumn
	{
		public Image CheckedImage = Resources.verificado;

		public Image UncheckedImage = Resources.botao_x;

		public DataGridViewCheckBoxImageColumn()
		{
			CellTemplate = new DataGridViewCheckBoxImageCell();
		}
	}
	public class DataGridViewCheckBoxImageCell : DataGridViewCheckBoxCell
	{
		protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates elementState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
		{
			base.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, DataGridViewPaintParts.Background | DataGridViewPaintParts.Border);
			bool cellValue = Convert.ToBoolean(formattedValue);
			if (base.OwningColumn is DataGridViewCheckBoxImageColumn column)
			{
				Image image = (cellValue ? column.CheckedImage : column.UncheckedImage);
				if (image != null)
				{
					int imageX = cellBounds.Left + (cellBounds.Width - image.Width) / 2;
					int imageY = cellBounds.Top + (cellBounds.Height - image.Height) / 2;
					graphics.DrawImage(image, new Rectangle(imageX, imageY, image.Width, image.Height));
				}
			}
		}
	}
}
